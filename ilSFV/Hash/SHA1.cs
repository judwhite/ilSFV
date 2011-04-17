using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace ilSFV.Hash
{
	/// <summary>
	/// Calculates an SHA1 digest.
	/// </summary>
	public static class SHA1
	{
		private static readonly SHA1CryptoServiceProvider _SHA1 = new SHA1CryptoServiceProvider();

		/// <summary>
		/// Returns the SHA1 digest of a specified file as a string.
		/// </summary>
		/// <param name="file">The file.</param>
		/// <returns>SHA1 digest as a string.</returns>
		public static string Calculate(FileInfo file)
		{
			if (file == null)
				throw new ArgumentNullException("file");

			return DigestToString(CalculateDigest(file));
		}

		/// <summary>
		/// Returns the SHA1 digest of an input stream as a string.
		/// </summary>
		/// <param name="stream">Input stream.</param>
		/// <returns>SHA1 digest as a string.</returns>
		public static string Calculate(Stream stream)
		{
			if (stream == null)
				throw new ArgumentNullException("stream");

			return DigestToString(CalculateDigest(stream));
		}

		/// <summary>
		/// Returns the SHA1 digest of a byte array as a string.
		/// </summary>
		/// <param name="data">The byte array.</param>
		/// <returns>SHA1 digest as a string.</returns>
		public static string Calculate(byte[] data)
		{
			if (data == null)
				throw new ArgumentNullException("data");

			return DigestToString(CalculateDigest(data));
		}

		/// <summary>
		/// Returns the SHA1 digest of a specified file as a byte array.
		/// </summary>
		/// <param name="file">The file.</param>
		/// <returns>SHA1 digest as a byte array.</returns>
		public static byte[] CalculateDigest(FileInfo file)
		{
			if (file == null)
				throw new ArgumentNullException("file");

			using (FileStream fileStream = file.Open(FileMode.Open, FileAccess.Read, FileShare.Read))
			{
				return CalculateDigest(fileStream);
			}
		}

		/// <summary>
		/// Returns the SHA1 digest of an input stream as a byte array.
		/// </summary>
		/// <param name="stream">The stream.</param>
		/// <returns>SHA1 digest as a byte array.</returns>
		public static byte[] CalculateDigest(Stream stream)
		{
			if (stream == null)
				throw new ArgumentNullException("stream");

			stream.Position = 0;
			return _SHA1.ComputeHash(stream);
		}

		/// <summary>
		/// Returns the SHA1 digest of a byte array as a byte array.
		/// </summary>
		/// <param name="data">The byte array.</param>
		/// <returns>SHA1 digest as a byte array.</returns>
		public static byte[] CalculateDigest(byte[] data)
		{
			if (data == null)
				throw new ArgumentNullException("data");

			using (MemoryStream memoryStream = new MemoryStream(data))
			{
				return CalculateDigest(memoryStream);
			}
		}

		private static string DigestToString(IEnumerable<byte> digest)
		{
			StringBuilder str = new StringBuilder();
			foreach (byte item in digest)
			{
				str.AppendFormat("{0:x2}", item);
			}
			return str.ToString();
		}
	}
}
