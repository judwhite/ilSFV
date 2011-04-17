using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace ilSFV
{
	/// <summary>
	/// Contains information about a file from drag &amp; drop.
	/// </summary>
	public class FileDrop
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="FileDrop"/> class.
		/// </summary>
		/// <param name="path">The path.</param>
		public FileDrop(string path)
		{
			Path = path;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="FileDrop"/> class. Implicitly sets <see cref="IsInMemory"/> to true.
		/// </summary>
		/// <param name="path">The path.</param>
		/// <param name="contents">The file contents.</param>
		public FileDrop(string path, byte[] contents)
		{
			Path = path;
			Contents = contents;
			IsInMemory = true;
		}

		/// <summary>
		/// Gets the full path of the file. If the file <see cref="IsInMemory"/>, Path will be a file name without a directory.
		/// </summary>
		/// <value>The full path of the file. If the file <see cref="IsInMemory"/>, Path will be a file name without a directory.</value>
		public string Path { get; internal set; }

		/// <summary>
		/// Gets the contents of the file if the file <see cref="IsInMemory"/>.
		/// </summary>
		/// <value>The contents of the file if the file <see cref="IsInMemory"/>.</value>
		public byte[] Contents { get; internal set; }

		/// <summary>
		/// Gets a value indicating whether the contents of the file are in memory.
		/// </summary>
		/// <value><c>true</c> if the contents of the file are in memory; otherwise, <c>false</c>.</value>
		public bool IsInMemory { get; internal set; }

		/// <summary>
		/// Gets the list of <see cref="FileDrop"/> from the specified <see cref="IDataObject"/>. Includes objects dragged from Explorer and Outlook.
		/// </summary>
		/// <param name="data">The <see cref="IDataObject"/>.</param>
		/// <returns>The list of <see cref="FileDrop"/> from the specified <see cref="IDataObject"/>.</returns>
		public static List<FileDrop> GetList(IDataObject data)
		{
			List<FileDrop> list = new List<FileDrop>();

			if (data != null)
			{
				if (data.GetDataPresent("FileDrop"))
				{
					string[] fileNames = data.GetData("FileDrop") as string[];

					if (fileNames != null && fileNames.Length > 0)
					{
						foreach (string fileName in fileNames)
						{
							list.Add(new FileDrop(fileName));
						}
					}
				}
				else if (data.GetDataPresent("FileGroupDescriptor"))
				{
					Stream stream = (Stream)data.GetData("FileGroupDescriptor");
					byte[] fileGroupDescriptor = new byte[512];
					stream.Read(fileGroupDescriptor, 0, 512);

					// build the filename from the FileGroupDescriptor block
					StringBuilder fileName = new StringBuilder();
					for (int i = 76; fileGroupDescriptor[i] != 0; i++)
					{
						fileName.Append(Convert.ToChar(fileGroupDescriptor[i]));
					}
					stream.Close();

					MemoryStream ms = (MemoryStream)data.GetData("FileContents", true);
					byte[] fileBytes = new byte[ms.Length];
					ms.Position = 0;
					ms.Read(fileBytes, 0, (int)ms.Length);

					list.Add(new FileDrop(fileName.ToString(), fileBytes));
				}
			}

			return list;
		}

		/// <summary>
		/// Gets the list of <see cref="FileDrop"/> from the specified <see cref="IDataObject"/>. Includes objects dragged from Explorer and Outlook.
		/// </summary>
		/// <param name="data">The <see cref="IDataObject"/>.</param>
		/// <param name="allowedExtension">The allowed extension in the format ".ext".</param>
		/// <returns>The list of <see cref="FileDrop"/> from the specified <see cref="IDataObject"/>.</returns>
		public static List<FileDrop> GetList(IDataObject data, string allowedExtension)
		{
			return GetList(data, new[] { allowedExtension }, false);
		}

		/// <summary>
		/// Gets the list of <see cref="FileDrop"/> from the specified <see cref="IDataObject"/>. Includes objects dragged from Explorer and Outlook.
		/// </summary>
		/// <param name="data">The <see cref="IDataObject"/>.</param>
		/// <param name="allowedExtensions">The allowed extensions in the format ".ext".</param>
		/// <param name="plusDirectories">if set to <c>true</c>, all directories will also be included.</param>
		/// <returns>
		/// The list of <see cref="FileDrop"/> from the specified <see cref="IDataObject"/>.
		/// </returns>
		public static List<FileDrop> GetList(IDataObject data, string[] allowedExtensions, bool plusDirectories)
		{
			List<FileDrop> list = GetList(data);
			foreach (FileDrop file in new List<FileDrop>(list))
			{
				bool isOK = false;

				if (plusDirectories && Directory.Exists(file.Path))
				{
					isOK = true;
				}
				else
				{
					string fileExt = System.IO.Path.GetExtension(file.Path);

					foreach (string ext in allowedExtensions)
					{
						if (string.Compare(fileExt, ext, true) == 0)
						{
							isOK = true;
							break;
						}
					}
				}

				if (!isOK)
					list.Remove(file);
			}

			return list;
		}
	}
}
