using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ilSFV.Model.Workset;

namespace ilSFV
{
	public partial class RemoveDuplicatesForm : Form
	{
		private readonly ChecksumSet _set;
		private IEnumerable<IGrouping<string, ChecksumFile>> _dupeSet;

		//private readonly string[] _ignoreExtensions = new[] { ".jpg", ".log", ".cue", ".m3u", ".exe", ".cfg", ".lst", ".mov", ".nfo" };
		private readonly string[] _ignoreExtensions = new string[] { };

		public RemoveDuplicatesForm(ChecksumSet set)
		{
			InitializeComponent();

			_set = set;

			InitializeFormVariables();
		}

		private void InitializeFormVariables()
		{
			_dupeSet = GetDuplicates();

			string dir = _set.Directory;
			foreach (IGrouping<string, ChecksumFile> group in _dupeSet)
			{
				foreach (ChecksumFile file in group.Where(p => p.IsDeleted == false))
				{
					if (!File.Exists(Path.Combine(dir, file.FileName)))
						file.IsDeleted = true;
				}
			}

			_dupeSet = GetDuplicates();

			RebuildGroupings();
		}

		private void RebuildGroupings()
		{
			lvwGroupings.BeginUpdate();
			try
			{
				lvwGroupings.Items.Clear();
				int totalCount = _dupeSet.Count();
				int currentFile = 1;
				foreach (IGrouping<string, ChecksumFile> group in _dupeSet)
				{
					int groupCount = group.Where(p => p.IsDeleted == false).Count();
					if (groupCount > 1)
					{
						ListViewItem item = new ListViewItem();
						item.Text = string.Format("{0:#,0} / {1:#,0}", currentFile, totalCount);
						item.SubItems.Add(groupCount.ToString());
						item.Tag = group;
						lvwGroupings.Items.Add(item);
					}

					currentFile++;
				}

				if (lvwGroupings.Items.Count > 0)
					lvwGroupings.SelectedIndices.Add(0);
			}
			finally
			{
				lvwGroupings.EndUpdate();
			}
		}

		private IEnumerable<IGrouping<string, ChecksumFile>> GetDuplicates()
		{
			return _set.Files
				.GroupBy(p => p.OriginalChecksum)
				.Where(p => p
					.Where(q => q.IsDeleted == false && !_ignoreExtensions.Contains(Path.GetExtension(q.FileName).ToLower()))
					.Count() > 1
				);
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void lvwGroupings_SelectedIndexChanged(object sender, EventArgs e)
		{
			lvwDuplicateFiles.Items.Clear();
			lvwBadDirectories.Items.Clear();
			btnRemoveDuplicates.Enabled = false;

			if (lvwGroupings.SelectedItems.Count == 1)
			{
				IGrouping<string, ChecksumFile> group = (IGrouping<string, ChecksumFile>)lvwGroupings.SelectedItems[0].Tag;
				foreach (ChecksumFile file in group.Where(p => p.IsDeleted == false))
				{
					ListViewItem item = new ListViewItem();
					item.Text = file.FileName;
					item.Tag = file;
					lvwDuplicateFiles.Items.Add(item);
				}
			}

			if (lvwDuplicateFiles.Items.Count > 0)
				lvwDuplicateFiles.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.ColumnContent);
		}

		private void lvwDuplicateFiles_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (lvwDuplicateFiles.SelectedItems.Count == 1)
			{
				btnRemoveDuplicates.Enabled = true;
				ListViewItem selectedItem = lvwDuplicateFiles.SelectedItems[0];

				lvwBadDirectories.Items.Clear();
				foreach (ListViewItem item in lvwDuplicateFiles.Items)
				{
					if (item == selectedItem)
						continue;

					ChecksumFile file = (ChecksumFile)item.Tag;

					ListViewGroup group = new ListViewGroup(file.FileName);

					string dir = Path.GetDirectoryName(file.FileName);
					while (!string.IsNullOrEmpty(dir))
					{
						ListViewItem badDirItem = new ListViewItem();
						string dirWithSlash = dir + @"\";
						badDirItem.Text = dirWithSlash;
						badDirItem.Group = group;

						if (selectedItem.Text.StartsWith(dirWithSlash))
							break;

						int dirRemoveCount = 0;
						foreach (IGrouping<string, ChecksumFile> checkGroup in _dupeSet)
						{
							int checkGroupCount = checkGroup.Where(p => p.IsDeleted == false).Count();
							if (checkGroupCount > 1)
							{
								int startsWithCount = 0;
								foreach (ChecksumFile checkFile in checkGroup.Where(p => p.IsDeleted == false))
								{
									// see if any files start with dir
									if (checkFile.FileName.StartsWith(dirWithSlash))
										startsWithCount++;
								}

								// if all files start with 'dir' we can't proceed
								if (startsWithCount != checkGroupCount)
								{
									dirRemoveCount += startsWithCount;
								}
								else
								{
								}
							}
						}
						badDirItem.SubItems.Add(string.Format("{0:#,0}", dirRemoveCount));

						lvwBadDirectories.Items.Add(badDirItem);

						dir = Path.GetDirectoryName(dir);
					}

					if (lvwBadDirectories.Items.Count > 0)
					{
						int colWidth = lvwBadDirectories.Columns[0].Width;
						lvwBadDirectories.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.ColumnContent);
						if (lvwBadDirectories.Columns[0].Width < colWidth)
							lvwBadDirectories.Columns[0].Width = colWidth;
					}
				}
			}
			else
			{
				btnRemoveDuplicates.Enabled = false;
			}
		}

		private void btnRemoveDuplicates_Click(object sender, EventArgs e)
		{
			if (lvwDuplicateFiles.SelectedItems.Count != 1)
				return;

			ListViewItem selectedItem = lvwDuplicateFiles.SelectedItems[0];
			ChecksumFile file = (ChecksumFile)selectedItem.Tag;

			string sourceFullPath = Path.Combine(file.Set.Directory, file.FileName);
			if (!File.Exists(sourceFullPath))
			{
				MessageBox.Show(string.Format("'{0}' does not exist!", sourceFullPath), "File not found", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}

			string confirmMessage = string.Format("Are you sure you want to use '{0}' as the source file?", file.FileName);
			DialogResult res = MessageBox.Show(confirmMessage, "Remove duplicates", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (res != DialogResult.Yes)
				return;

			Cursor.Current = Cursors.WaitCursor;
			IGrouping<string, ChecksumFile> group = (IGrouping<string, ChecksumFile>)lvwGroupings.SelectedItems[0].Tag;
			List<ChecksumFile> groupList = new List<ChecksumFile>(group);
			for (int i = 0; i < groupList.Count; i++)
			{
				ChecksumFile removeFile = groupList[i];
				if (string.Compare(removeFile.FileName, file.FileName, true) == 0)
					continue;

				string fullPath = Path.Combine(file.Set.Directory, removeFile.FileName);
				if (File.Exists(fullPath))
					Program.SafeDelete(fullPath);
				removeFile.IsDeleted = true;
			}
			Cursor.Current = Cursors.Default;

			foreach (ListViewItem badDirItem in lvwBadDirectories.SelectedItems)
			{
				Cursor.Current = Cursors.WaitCursor;
				string dir = badDirItem.Text;

				List<ChecksumFile> deleteFiles = new List<ChecksumFile>();
				foreach (IGrouping<string, ChecksumFile> checkGroup in _dupeSet)
				{
					int checkGroupCount = checkGroup.Where(p => p.IsDeleted == false).Count();
					if (checkGroupCount > 1)
					{
						int startsWithCount = 0;
						foreach (ChecksumFile checkFile in checkGroup.Where(p => p.IsDeleted == false))
						{
							// see if any files start with dir
							if (checkFile.FileName.StartsWith(dir))
								startsWithCount++;
						}

						// if all files start with 'dir' we can't proceed
						if (startsWithCount != checkGroupCount)
						{
							foreach (ChecksumFile checkFile in checkGroup.Where(p => p.IsDeleted == false))
							{
								// see if any files start with dir
								if (checkFile.FileName.StartsWith(dir))
									deleteFiles.Add(checkFile);
							}
						}
					}
				}

				if (deleteFiles.Count > 0)
				{
					StringBuilder sb = new StringBuilder();
					sb.AppendLine(string.Format("Are you sure want to delete all {0} duplicate(s) in '{1}'?", deleteFiles.Count, dir));
					if (deleteFiles.Count <= 50)
					{
						sb.AppendLine();
						sb.AppendLine("The following items will be deleted:");
						sb.AppendLine();
						foreach (ChecksumFile deleteFile in deleteFiles)
							sb.AppendLine(deleteFile.FileName);
					}

					Cursor.Current = Cursors.Default;
					DialogResult res2 = MessageBox.Show(sb.ToString(), "Remove duplicates", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
					if (res2 == DialogResult.Yes)
					{
						Cursor.Current = Cursors.WaitCursor;
						foreach (ChecksumFile removeFile in deleteFiles)
						{
							string fullPath = Path.Combine(file.Set.Directory, removeFile.FileName);
							if (File.Exists(fullPath))
								Program.SafeDelete(fullPath);
							removeFile.IsDeleted = true;
						}
						Cursor.Current = Cursors.Default;
					}
				}
			}

			Cursor.Current = Cursors.WaitCursor;
			RebuildGroupings();
			Cursor.Current = Cursors.Default;
		}

		private void RemoveDuplicatesForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (e.CloseReason == CloseReason.UserClosing)
			{
				Cursor.Current = Cursors.WaitCursor;
				int deleteCount = 0;
				foreach (ChecksumFile file in _set.Files)
				{
					if (file.IsDeleted)
						deleteCount++;
				}
				Cursor.Current = Cursors.Default;

				if (deleteCount > 0)
				{
					string msg = string.Format("Would you like to rewrite the checksum file without the {0:#,0} deleted files?{1}{1}Note: Comments will be removed.", deleteCount, Environment.NewLine);
					DialogResult res = MessageBox.Show(msg, "Rewrite Checksum File", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

					if (res == DialogResult.Cancel)
					{
						e.Cancel = true;
						return;
					}

					if (res == DialogResult.Yes)
					{
						Cursor.Current = Cursors.WaitCursor;
						StringBuilder shabang = new StringBuilder();

						if (_set.Type == ChecksumType.SFV && Program.Settings.Create.SFV32Compatibility)
						{
							shabang.AppendLine("; Generated by WIN-SFV32 v1 [added for sfv32 compatibility]");
						}

						/*string[] comments = _set.Comments.Split(new[] { Environment.NewLine }, StringSplitOptions.None);

						foreach (string line in comments)
						{
							shabang.AppendLine(";" + line);
						}*/

						foreach (ChecksumFile file in _set.Files)
						{
							if (file.IsDeleted)
								continue;

							if (_set.Type == ChecksumType.MD5 || _set.Type == ChecksumType.SHA1)
							{
								if (Program.Settings.Create.MD5SumCompatibility)
									shabang.AppendLine(string.Format("{0} *{1}", file.OriginalChecksum, file.FileName));
								else
									shabang.AppendLine(string.Format("{0} {1}", file.OriginalChecksum, file.FileName));
							}
							else if (_set.Type == ChecksumType.SFV)
							{
								shabang.AppendLine(string.Format("{0} {1}", file.FileName, file.OriginalChecksum));
							}
							else
							{
								throw new Exception(string.Format("{0} not implemented", _set.Type));
							}
						}

						string strShaBang = shabang.ToString();

						File.WriteAllText(_set.VerificationFileName, strShaBang, Encoding.GetEncoding(MainForm.CODE_PAGE));
						Cursor.Current = Cursors.Default;
					}
				}
			}
		}
	}
}
