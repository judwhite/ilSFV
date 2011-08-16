using System;
using System.Diagnostics;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using ilSFV.Localization;
using ilSFV.Model.Settings;

namespace ilSFV
{
	public sealed partial class PreferencesForm : Form
	{
		public PreferencesForm(bool showAbout)
		{
			InitializeComponent();

            SetLanguage();

			if (showAbout)
				tabControl1.SelectedTab = tpAbout;

			Program.Settings.Statistics.Load();

			if (Program.Settings.General.AlwaysOnTop) // make sure pref form is above mainform
				TopMost = true;

			// General
            cboLanguage.Items.Clear();
            cboLanguage.Items.AddRange(Language.GetLanguages());
            cboLanguage.SelectedIndexChanged += cboLanguage_SelectedIndexChanged;
			cboLanguage.SelectedIndex = cboLanguage.Items.IndexOf(Program.Settings.General.Language);
			if (cboLanguage.SelectedIndex == -1)
				cboLanguage.SelectedIndex = 0;
			trkCacheSize.Value = Program.Settings.General.CacheSize;
			chkAlwaysOnTop.Checked = Program.Settings.General.AlwaysOnTop;
			chkRememberWindowPlacement.Checked = Program.Settings.General.RememberWindowPlacement;
			chkReuseWindow.Checked = Program.Settings.General.ReuseWindow;
			chkCheckForUpdates.Checked = Program.Settings.General.CheckForUpdates;
			txtCheckForUpdatesDays.Text = Program.Settings.General.UpdateCheckFrequency.ToString();
			chkFlashWindowWhenDone.Checked = Program.Settings.General.FlashWindowWhenDone;
			chkAutoScrollFileList.Checked = Program.Settings.General.AutoScrollFileList;
			chkRecursive.Checked = Program.Settings.General.Recursive;
			chkUseLowPriorityOnHide.Checked = Program.Settings.General.UseLowPriorityOnHide;
            chkIsRecentFilesSaved.Checked = Program.Settings.General.IsRecentFilesSaved;

			// Checking
			chkAutoFindRenames.Checked = Program.Settings.Check.AutoFindRenames;
			chkUseRecycleBin.Checked = Program.Settings.Check.UseRecyleBin;
			chkRenameBadFiles.Checked = Program.Settings.Check.RenameBadFiles;
			chkCreateMissingMarkers.Checked = Program.Settings.Check.CreateMissingMarkers;
			chkCleanupBadMissing.Checked = Program.Settings.Check.CleanupBadMissing;
			chkDeleteFailedFiles.Checked = Program.Settings.Check.DeleteFailedFiles;
			chkAutoCloseWhenDoneChecking.Checked = Program.Settings.Check.AutoCloseWhenDoneChecking;
			chkAutoCloseWhenDoneCheckingOnlyAllOK.Checked = Program.Settings.Check.AutoCloseWhenDoneCheckingOnlyIfAllOK;
			chkAutomaticallyVerify.Checked = Program.Settings.Check.AutoVerify;
			chkPlaySoundOnAllOK.Checked = Program.Settings.Check.PlaySoundOK;
			chkPlaySoundOnAllOK_OnlyIfInactive.Checked = Program.Settings.Check.PlaySoundOK_OnlyIfInactive;
			chkPlaySoundOnError.Checked = Program.Settings.Check.PlaySoundError;

			switch (Program.Settings.Check.Renaming)
			{
				case CheckRenaming.Lowercase:
					rbRenameToLowercase.Checked = true;
					break;

				case CheckRenaming.MatchSet:
					rbRenameToMatchSet.Checked = true;
					break;

				default:
					rbRenameNone.Checked = true;
					break;
			}

			// Creating
			txtExcludeFilesOfType.Text = Program.Settings.Create.ExcludeFilesOfType;
			chkSortFiles.Checked = Program.Settings.Create.SortFiles;
			chkSFV32Compatibility.Checked = Program.Settings.Create.SFV32Compatibility;
			chkMD5SumCompatibility.Checked = Program.Settings.Create.MD5SumCompatibility;
			chkCreateForEachSubDir.Checked = Program.Settings.Create.CreateForEachSubDir;
			chkPromptForFileName.Checked = Program.Settings.Create.PromptForFileName;
			chkAutoCloseWhenDoneCreating.Checked = Program.Settings.Create.AutoCloseWhenDoneCreating;

			// Comments
			chkWriteComments.Checked = Program.Settings.Comments.WriteComments;
			txtCommentsHeader.Text = Program.Settings.Comments.Header;
			txtCommentsFileList.Text = Program.Settings.Comments.Content;
			txtCommentsFooter.Text = Program.Settings.Comments.Footer;

			// Stats
			UpdateStatisticsLabels();

			UpdateCacheSizeLabels();
			UpdateChkAutoCloseWhenDoneCheckingOnlyAllOK();
			UpdateChkPlaySoundOnAllOK_OnlyIfInactive();
			UpdateCheckForUpdatesTextBoxEnabled();
			UpdateChkCreateForEachSubDirEnabled();
			UpdateCommentsTextBoxesEnabled();
		}

        private void cboLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            Language.Load(cboLanguage.Text);

            SetLanguage();
        }

        private void SetLanguage()
        {
            var p = Language.PreferencesForm;

            // Title
            Text = p.Title;

            // General
            tpGeneral.Text = p.General;
            lblLanguage.Text = p.Language;
            lblCacheSizeLabel.Text = p.CacheSize;
            lblRecords.Text = p.Records;
            btnClearCache.Text = p.ClearCacheButton;
            chkAlwaysOnTop.Text = p.AlwaysOnTop;
            chkRememberWindowPlacement.Text = p.RememberWindowPlacement;
            chkReuseWindow.Text = p.ReuseWindowSingleInstance;
            chkCheckForUpdates.Text = p.CheckForUpdateEvery;
            lblDays.Text = p.Days;
            chkIsRecentFilesSaved.Text = p.ShowRecentFilesInFileMenu;
            chkFlashWindowWhenDone.Text = p.FlashWindowWhenDone;
            chkAutoScrollFileList.Text = p.AutoScrollFileList;
            chkRecursive.Text = p.RecursiveCreationChecking;
            chkUseLowPriorityOnHide.Text = p.UseLowPriorityOnHide;

            // Checking
            tpChecking.Text = p.Checking;
            chkAutoFindRenames.Text = p.AutoFindRenamesWhenSetComplete;
            chkUseRecycleBin.Text = p.UseRecycleBin;
            chkRenameBadFiles.Text = p.RenameBadFiles;
            chkCreateMissingMarkers.Text = p.CreateMissingFileMarkers;
            chkCleanupBadMissing.Text = p.CleanupBadMissing;
            chkDeleteFailedFiles.Text = p.DeleteFailedFiles;
            chkAutoCloseWhenDoneChecking.Text = p.AutoCloseWhenDone_Checking;
            chkAutoCloseWhenDoneCheckingOnlyAllOK.Text = p.OnlyWhenAllOK;
            chkAutomaticallyVerify.Text = p.AutoVerify;
            chkPlaySoundOnAllOK.Text = p.PlaySoundWhenAllOK;
            chkPlaySoundOnAllOK_OnlyIfInactive.Text = p.OnlyWhenNotInForeground;
            chkPlaySoundOnError.Text = p.PlaySoundWhenBadMissing;
            grpRenaming.Text = p.Renaming;
            rbRenameToMatchSet.Text = p.ToMatchNamesInSetFile;
            rbRenameToLowercase.Text = p.ToLowercase;
            rbRenameNone.Text = p.None;

            // Creating
            tpCreating.Text = p.Creating;
            lblExcludeFilesofType.Text = p.ExcludeFilesOfType;
            chkSortFiles.Text = p.SortFiles;
            chkSFV32Compatibility.Text = p.SFV32Compatibility;
            chkMD5SumCompatibility.Text = p.MD5SumCompatibility;
            chkCreateForEachSubDir.Text = p.CreateFileForEachSubdir;
            chkPromptForFileName.Text = p.PromptForFileName;
            chkAutoCloseWhenDoneCreating.Text = p.AutoCloseWhenDone_Creating;

            // Comments
            tpComments.Text = p.Comments;
            chkWriteComments.Text = p.WriteCommentsCheckBox;
            lblCommentsHeader.Text = p.Header;
            lblCommentsFileList.Text = p.FileList;
            lblCommentsFooter.Text = p.Footer;
            btnCommentShowVariables.Text = p.ShowVariablesButton;
            
            // About
            tpAbout.Text = p.About;
            lblMadeInTributeTohkSFV.Text = p.MadeInTributeTohkSFV;
            btnWeb.Text = p.WebButton;

            Version version = Assembly.GetExecutingAssembly().GetName().Version;
            int major = version.Major;
            int minor = version.Minor;
            int build = version.Build;
            DateTime releaseDate = new DateTime(2000, 1, 1).AddDays(build);

            lblVersion.Text = string.Format("{0} {1}.{2}.{3}", p.Version, major, minor, build);
            lblReleaseDate.Text = string.Format("{0} {1:yyyy-MM-dd}", p.Released, releaseDate);

            grpUsageStatistics.Text = p.UsageStatistics;
            lblFilesChecked.Text = p.FilesChecked;
            lblSetsChecked.Text = p.SetsChecked;
            lblMBChecked.Text = p.MBChecked;
            lblGoodFiles.Text = p.GoodFiles;
            lblTimeSpent.Text = p.TimeSpent;
            btnResetUsageStats.Text = p.ResetButton;
            btnReleaseNotes.Text = p.ReleaseNotesButton;

            // OK/Cancel buttons
            btnOK.Text = Language.General.OKButton;
            btnCancel.Text = Language.General.CancelButton;
        }

		private void UpdateCommentsTextBoxesEnabled()
		{
			bool enabled = chkWriteComments.Checked;
			txtCommentsHeader.Enabled = enabled;
			txtCommentsFileList.Enabled = enabled;
			txtCommentsFooter.Enabled = enabled;
		}

		private void UpdateChkCreateForEachSubDirEnabled()
		{
			chkCreateForEachSubDir.Enabled = chkRecursive.Checked;
		}

		private void UpdateStatisticsLabels()
		{
			txtFilesChecked.Text = string.Format("{0:#,0}", Program.Settings.Statistics.FilesChecked);
			txtSetsChecked.Text = string.Format("{0:#,0}", Program.Settings.Statistics.SetsChecked);
			txtMBChecked.Text = string.Format("{0:#,0}", Program.Settings.Statistics.MBChecked);
			txtGoodFiles.Text = string.Format("{0:#,0}", Program.Settings.Statistics.GoodFiles);

			TimeSpan timeSpent = Program.Settings.Statistics.TimeSpent;
			txtTimeSpent.Text = string.Format("{0}:{1:00}:{2:00}", timeSpent.Hours, timeSpent.Minutes, timeSpent.Seconds);
		}

		private void btnWeb_Click(object sender, EventArgs e)
		{
			Process.Start("http://cdtag.com/ilsfv");
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			Cursor.Current = Cursors.WaitCursor;

			bool saveNow = (Program.Settings.General.ReuseWindow != chkReuseWindow.Checked);

			// General
			Program.Settings.General.Language = cboLanguage.Text;
			Program.Settings.General.CacheSize = trkCacheSize.Value;
			Program.Settings.General.AlwaysOnTop = chkAlwaysOnTop.Checked;
			Program.Settings.General.RememberWindowPlacement = chkRememberWindowPlacement.Checked;
			Program.Settings.General.ReuseWindow = chkReuseWindow.Checked;
			Program.Settings.General.CheckForUpdates = chkCheckForUpdates.Checked;
			Program.Settings.General.FlashWindowWhenDone = chkFlashWindowWhenDone.Checked;
			Program.Settings.General.AutoScrollFileList = chkAutoScrollFileList.Checked;
			Program.Settings.General.Recursive = chkRecursive.Checked;
			Program.Settings.General.UseLowPriorityOnHide = chkUseLowPriorityOnHide.Checked;
            Program.Settings.General.IsRecentFilesSaved = chkIsRecentFilesSaved.Checked;

			int days;
			if (int.TryParse(txtCheckForUpdatesDays.Text, out days) && days > 0)
				Program.Settings.General.UpdateCheckFrequency = days;

			// Checking
			Program.Settings.Check.AutoFindRenames = chkAutoFindRenames.Checked;
			Program.Settings.Check.UseRecyleBin = chkUseRecycleBin.Checked;
			Program.Settings.Check.RenameBadFiles = chkRenameBadFiles.Checked;
			Program.Settings.Check.CreateMissingMarkers = chkCreateMissingMarkers.Checked;
			Program.Settings.Check.CleanupBadMissing = chkCleanupBadMissing.Checked;
			Program.Settings.Check.DeleteFailedFiles = chkDeleteFailedFiles.Checked;
			Program.Settings.Check.AutoCloseWhenDoneChecking = chkAutoCloseWhenDoneChecking.Checked;
			Program.Settings.Check.AutoCloseWhenDoneCheckingOnlyIfAllOK = chkAutoCloseWhenDoneCheckingOnlyAllOK.Checked;
			Program.Settings.Check.AutoVerify = chkAutomaticallyVerify.Checked;
			Program.Settings.Check.PlaySoundOK = chkPlaySoundOnAllOK.Checked;
			Program.Settings.Check.PlaySoundOK_OnlyIfInactive = chkPlaySoundOnAllOK_OnlyIfInactive.Checked;
			Program.Settings.Check.PlaySoundError = chkPlaySoundOnError.Checked;

			if (rbRenameToLowercase.Checked)
				Program.Settings.Check.Renaming = CheckRenaming.Lowercase;
			else if (rbRenameToMatchSet.Checked)
				Program.Settings.Check.Renaming = CheckRenaming.MatchSet;
			else
				Program.Settings.Check.Renaming = CheckRenaming.None;

			// Creating
			Program.Settings.Create.ExcludeFilesOfType = txtExcludeFilesOfType.Text;
			Program.Settings.Create.SortFiles = chkSortFiles.Checked;
			Program.Settings.Create.SFV32Compatibility = chkSFV32Compatibility.Checked;
			Program.Settings.Create.MD5SumCompatibility = chkMD5SumCompatibility.Checked;
			Program.Settings.Create.CreateForEachSubDir = chkCreateForEachSubDir.Checked;
			Program.Settings.Create.PromptForFileName = chkPromptForFileName.Checked;
			Program.Settings.Create.AutoCloseWhenDoneCreating = chkAutoCloseWhenDoneCreating.Checked;

			// Comments
			Program.Settings.Comments.WriteComments = chkWriteComments.Checked;
			Program.Settings.Comments.Header = txtCommentsHeader.Text;
			Program.Settings.Comments.Content = txtCommentsFileList.Text;
			Program.Settings.Comments.Footer = txtCommentsFooter.Text;

			// Save
			if (saveNow)
			{
				Program.Settings.General.Save();
				Program.Settings.Check.Save();
				Program.Settings.Create.Save();
				Program.Settings.Comments.Save();
			}

			Cursor.Current = Cursors.Default;

			Close();
		}

		private void trkCacheSize_Scroll(object sender, EventArgs e)
		{
			UpdateCacheSizeLabels();
		}

		private void UpdateCacheSizeLabels()
		{
			lblCacheRecords.Text = string.Format("{0:#,0}", trkCacheSize.Value);
		}

		private void btnResetUsageStats_Click(object sender, EventArgs e)
		{
			Program.Settings.Statistics.Clear();
			UpdateStatisticsLabels();
		}

		private void chkAutoCloseWhenDoneChecking_CheckedChanged(object sender, EventArgs e)
		{
			UpdateChkAutoCloseWhenDoneCheckingOnlyAllOK();
		}

		private void UpdateChkAutoCloseWhenDoneCheckingOnlyAllOK()
		{
			chkAutoCloseWhenDoneCheckingOnlyAllOK.Enabled = chkAutoCloseWhenDoneChecking.Checked;
		}

		private void btnClearCache_Click(object sender, EventArgs e)
		{
			Cursor.Current = Cursors.WaitCursor;
			Cache.Clear();
			Cursor.Current = Cursors.Default;

			MessageBox.Show(Language.PreferencesForm.CacheCleared_Message, Language.PreferencesForm.CacheCleared_Title, MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void chkCheckForUpdates_CheckedChanged(object sender, EventArgs e)
		{
			UpdateCheckForUpdatesTextBoxEnabled();
		}

		private void UpdateCheckForUpdatesTextBoxEnabled()
		{
			txtCheckForUpdatesDays.Enabled = chkCheckForUpdates.Checked;
		}

		private void UpdateChkPlaySoundOnAllOK_OnlyIfInactive()
		{
			chkPlaySoundOnAllOK_OnlyIfInactive.Enabled = chkPlaySoundOnAllOK.Checked;
		}

		private void chkPlaySoundOnAllOK_CheckedChanged(object sender, EventArgs e)
		{
			UpdateChkPlaySoundOnAllOK_OnlyIfInactive();
		}

		private void chkRecursive_CheckedChanged(object sender, EventArgs e)
		{
			UpdateChkCreateForEachSubDirEnabled();
		}

		private void btnCommentShowVariables_Click(object sender, EventArgs e)
		{
			/*StringBuilder sb = new StringBuilder();
			sb.AppendLine("Header/Footer:");
			sb.AppendLine("{0} : Checksum file create date/time");
			sb.AppendLine();
			sb.AppendLine("File list:");
			sb.AppendLine("{0} : File size in bytes");
			sb.AppendLine("{1} : File last write time");
			sb.AppendLine("{2} : File name (relative path)");*/

			MessageBox.Show(Language.PreferencesForm.ShowVariables_Message, Language.PreferencesForm.ShowVariables_Title, MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void chkWriteComments_CheckedChanged(object sender, EventArgs e)
		{
			UpdateCommentsTextBoxesEnabled();
		}

		private void btnReleaseNotes_Click(object sender, EventArgs e)
		{
			Cursor.Current = Cursors.WaitCursor;
			using (ReleaseNotesForm form = new ReleaseNotesForm())
			{
				Cursor.Current = Cursors.Default;
				form.ShowDialog();
			}
		}
	}
}
