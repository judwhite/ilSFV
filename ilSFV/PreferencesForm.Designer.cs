namespace ilSFV
{
    partial class PreferencesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PreferencesForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpGeneral = new System.Windows.Forms.TabPage();
            this.chkIsRecentFilesSaved = new System.Windows.Forms.CheckBox();
            this.chkUseLowPriorityOnHide = new System.Windows.Forms.CheckBox();
            this.txtCheckForUpdatesDays = new System.Windows.Forms.TextBox();
            this.lblDays = new System.Windows.Forms.Label();
            this.btnClearCache = new System.Windows.Forms.Button();
            this.chkCheckForUpdates = new System.Windows.Forms.CheckBox();
            this.chkRecursive = new System.Windows.Forms.CheckBox();
            this.chkAutoScrollFileList = new System.Windows.Forms.CheckBox();
            this.chkFlashWindowWhenDone = new System.Windows.Forms.CheckBox();
            this.chkReuseWindow = new System.Windows.Forms.CheckBox();
            this.chkRememberWindowPlacement = new System.Windows.Forms.CheckBox();
            this.chkAlwaysOnTop = new System.Windows.Forms.CheckBox();
            this.trkCacheSize = new System.Windows.Forms.TrackBar();
            this.lblRecords = new System.Windows.Forms.Label();
            this.lblCacheSizeLabel = new System.Windows.Forms.Label();
            this.cboLanguage = new System.Windows.Forms.ComboBox();
            this.lblLanguage = new System.Windows.Forms.Label();
            this.lblCacheRecords = new System.Windows.Forms.Label();
            this.tpChecking = new System.Windows.Forms.TabPage();
            this.chkPlaySoundOnError = new System.Windows.Forms.CheckBox();
            this.chkAutomaticallyVerify = new System.Windows.Forms.CheckBox();
            this.grpRenaming = new System.Windows.Forms.GroupBox();
            this.rbRenamePreserveCapitalization = new System.Windows.Forms.RadioButton();
            this.rbRenameNone = new System.Windows.Forms.RadioButton();
            this.rbRenameToLowercase = new System.Windows.Forms.RadioButton();
            this.rbRenameToMatchSet = new System.Windows.Forms.RadioButton();
            this.chkPlaySoundOnAllOK = new System.Windows.Forms.CheckBox();
            this.chkPlaySoundOnAllOK_OnlyIfInactive = new System.Windows.Forms.CheckBox();
            this.chkAutoCloseWhenDoneCheckingOnlyAllOK = new System.Windows.Forms.CheckBox();
            this.chkAutoCloseWhenDoneChecking = new System.Windows.Forms.CheckBox();
            this.chkDeleteFailedFiles = new System.Windows.Forms.CheckBox();
            this.chkCleanupBadMissing = new System.Windows.Forms.CheckBox();
            this.chkCreateMissingMarkers = new System.Windows.Forms.CheckBox();
            this.chkRenameBadFiles = new System.Windows.Forms.CheckBox();
            this.chkUseRecycleBin = new System.Windows.Forms.CheckBox();
            this.chkAutoFindRenames = new System.Windows.Forms.CheckBox();
            this.tpCreating = new System.Windows.Forms.TabPage();
            this.chkCreateForEachSubDir = new System.Windows.Forms.CheckBox();
            this.txtExcludeFilesOfType = new System.Windows.Forms.TextBox();
            this.lblExcludeFilesofType = new System.Windows.Forms.Label();
            this.chkAutoCloseWhenDoneCreating = new System.Windows.Forms.CheckBox();
            this.chkPromptForFileName = new System.Windows.Forms.CheckBox();
            this.chkMD5SumCompatibility = new System.Windows.Forms.CheckBox();
            this.chkSFV32Compatibility = new System.Windows.Forms.CheckBox();
            this.chkSortFiles = new System.Windows.Forms.CheckBox();
            this.tpComments = new System.Windows.Forms.TabPage();
            this.btnCommentShowVariables = new System.Windows.Forms.Button();
            this.txtCommentsFooter = new System.Windows.Forms.TextBox();
            this.txtCommentsFileList = new System.Windows.Forms.TextBox();
            this.txtCommentsHeader = new System.Windows.Forms.TextBox();
            this.lblCommentsFooter = new System.Windows.Forms.Label();
            this.lblCommentsFileList = new System.Windows.Forms.Label();
            this.lblCommentsHeader = new System.Windows.Forms.Label();
            this.chkWriteComments = new System.Windows.Forms.CheckBox();
            this.tpAbout = new System.Windows.Forms.TabPage();
            this.btnReleaseNotes = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnWeb = new System.Windows.Forms.Button();
            this.lblMadeInTributeTohkSFV = new System.Windows.Forms.Label();
            this.lblilSFV = new System.Windows.Forms.Label();
            this.lblReleaseDate = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.grpUsageStatistics = new System.Windows.Forms.GroupBox();
            this.btnResetUsageStats = new System.Windows.Forms.Button();
            this.txtTimeSpent = new System.Windows.Forms.TextBox();
            this.txtGoodFiles = new System.Windows.Forms.TextBox();
            this.lblTimeSpent = new System.Windows.Forms.Label();
            this.lblGoodFiles = new System.Windows.Forms.Label();
            this.txtMBChecked = new System.Windows.Forms.TextBox();
            this.txtSetsChecked = new System.Windows.Forms.TextBox();
            this.txtFilesChecked = new System.Windows.Forms.TextBox();
            this.lblMBChecked = new System.Windows.Forms.Label();
            this.lblSetsChecked = new System.Windows.Forms.Label();
            this.lblFilesChecked = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tabControl1.SuspendLayout();
            this.tpGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkCacheSize)).BeginInit();
            this.tpChecking.SuspendLayout();
            this.grpRenaming.SuspendLayout();
            this.tpCreating.SuspendLayout();
            this.tpComments.SuspendLayout();
            this.tpAbout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpUsageStatistics.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            resources.ApplyResources(this.tabControl1, "tabControl1");
            this.tabControl1.Controls.Add(this.tpGeneral);
            this.tabControl1.Controls.Add(this.tpChecking);
            this.tabControl1.Controls.Add(this.tpCreating);
            this.tabControl1.Controls.Add(this.tpComments);
            this.tabControl1.Controls.Add(this.tpAbout);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            // 
            // tpGeneral
            // 
            this.tpGeneral.Controls.Add(this.chkIsRecentFilesSaved);
            this.tpGeneral.Controls.Add(this.chkUseLowPriorityOnHide);
            this.tpGeneral.Controls.Add(this.txtCheckForUpdatesDays);
            this.tpGeneral.Controls.Add(this.lblDays);
            this.tpGeneral.Controls.Add(this.btnClearCache);
            this.tpGeneral.Controls.Add(this.chkCheckForUpdates);
            this.tpGeneral.Controls.Add(this.chkRecursive);
            this.tpGeneral.Controls.Add(this.chkAutoScrollFileList);
            this.tpGeneral.Controls.Add(this.chkFlashWindowWhenDone);
            this.tpGeneral.Controls.Add(this.chkReuseWindow);
            this.tpGeneral.Controls.Add(this.chkRememberWindowPlacement);
            this.tpGeneral.Controls.Add(this.chkAlwaysOnTop);
            this.tpGeneral.Controls.Add(this.trkCacheSize);
            this.tpGeneral.Controls.Add(this.lblRecords);
            this.tpGeneral.Controls.Add(this.lblCacheSizeLabel);
            this.tpGeneral.Controls.Add(this.cboLanguage);
            this.tpGeneral.Controls.Add(this.lblLanguage);
            this.tpGeneral.Controls.Add(this.lblCacheRecords);
            resources.ApplyResources(this.tpGeneral, "tpGeneral");
            this.tpGeneral.Name = "tpGeneral";
            this.tpGeneral.UseVisualStyleBackColor = true;
            // 
            // chkIsRecentFilesSaved
            // 
            resources.ApplyResources(this.chkIsRecentFilesSaved, "chkIsRecentFilesSaved");
            this.chkIsRecentFilesSaved.Name = "chkIsRecentFilesSaved";
            this.chkIsRecentFilesSaved.UseVisualStyleBackColor = true;
            // 
            // chkUseLowPriorityOnHide
            // 
            resources.ApplyResources(this.chkUseLowPriorityOnHide, "chkUseLowPriorityOnHide");
            this.chkUseLowPriorityOnHide.Name = "chkUseLowPriorityOnHide";
            this.chkUseLowPriorityOnHide.UseVisualStyleBackColor = true;
            // 
            // txtCheckForUpdatesDays
            // 
            resources.ApplyResources(this.txtCheckForUpdatesDays, "txtCheckForUpdatesDays");
            this.txtCheckForUpdatesDays.Name = "txtCheckForUpdatesDays";
            // 
            // lblDays
            // 
            resources.ApplyResources(this.lblDays, "lblDays");
            this.lblDays.Name = "lblDays";
            // 
            // btnClearCache
            // 
            resources.ApplyResources(this.btnClearCache, "btnClearCache");
            this.btnClearCache.Name = "btnClearCache";
            this.btnClearCache.UseVisualStyleBackColor = true;
            this.btnClearCache.Click += new System.EventHandler(this.btnClearCache_Click);
            // 
            // chkCheckForUpdates
            // 
            resources.ApplyResources(this.chkCheckForUpdates, "chkCheckForUpdates");
            this.chkCheckForUpdates.Name = "chkCheckForUpdates";
            this.chkCheckForUpdates.UseVisualStyleBackColor = true;
            this.chkCheckForUpdates.CheckedChanged += new System.EventHandler(this.chkCheckForUpdates_CheckedChanged);
            // 
            // chkRecursive
            // 
            resources.ApplyResources(this.chkRecursive, "chkRecursive");
            this.chkRecursive.Name = "chkRecursive";
            this.chkRecursive.UseVisualStyleBackColor = true;
            this.chkRecursive.CheckedChanged += new System.EventHandler(this.chkRecursive_CheckedChanged);
            // 
            // chkAutoScrollFileList
            // 
            resources.ApplyResources(this.chkAutoScrollFileList, "chkAutoScrollFileList");
            this.chkAutoScrollFileList.Name = "chkAutoScrollFileList";
            this.chkAutoScrollFileList.UseVisualStyleBackColor = true;
            // 
            // chkFlashWindowWhenDone
            // 
            resources.ApplyResources(this.chkFlashWindowWhenDone, "chkFlashWindowWhenDone");
            this.chkFlashWindowWhenDone.Name = "chkFlashWindowWhenDone";
            this.chkFlashWindowWhenDone.UseVisualStyleBackColor = true;
            // 
            // chkReuseWindow
            // 
            resources.ApplyResources(this.chkReuseWindow, "chkReuseWindow");
            this.chkReuseWindow.Name = "chkReuseWindow";
            this.chkReuseWindow.UseVisualStyleBackColor = true;
            // 
            // chkRememberWindowPlacement
            // 
            resources.ApplyResources(this.chkRememberWindowPlacement, "chkRememberWindowPlacement");
            this.chkRememberWindowPlacement.Name = "chkRememberWindowPlacement";
            this.chkRememberWindowPlacement.UseVisualStyleBackColor = true;
            // 
            // chkAlwaysOnTop
            // 
            resources.ApplyResources(this.chkAlwaysOnTop, "chkAlwaysOnTop");
            this.chkAlwaysOnTop.Name = "chkAlwaysOnTop";
            this.chkAlwaysOnTop.UseVisualStyleBackColor = true;
            // 
            // trkCacheSize
            // 
            resources.ApplyResources(this.trkCacheSize, "trkCacheSize");
            this.trkCacheSize.BackColor = System.Drawing.SystemColors.Window;
            this.trkCacheSize.LargeChange = 1000;
            this.trkCacheSize.Maximum = 35000;
            this.trkCacheSize.Name = "trkCacheSize";
            this.trkCacheSize.SmallChange = 100;
            this.trkCacheSize.TickFrequency = 100;
            this.trkCacheSize.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trkCacheSize.Scroll += new System.EventHandler(this.trkCacheSize_Scroll);
            // 
            // lblRecords
            // 
            resources.ApplyResources(this.lblRecords, "lblRecords");
            this.lblRecords.Name = "lblRecords";
            // 
            // lblCacheSizeLabel
            // 
            resources.ApplyResources(this.lblCacheSizeLabel, "lblCacheSizeLabel");
            this.lblCacheSizeLabel.Name = "lblCacheSizeLabel";
            // 
            // cboLanguage
            // 
            resources.ApplyResources(this.cboLanguage, "cboLanguage");
            this.cboLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLanguage.FormattingEnabled = true;
            this.cboLanguage.Name = "cboLanguage";
            // 
            // lblLanguage
            // 
            resources.ApplyResources(this.lblLanguage, "lblLanguage");
            this.lblLanguage.Name = "lblLanguage";
            // 
            // lblCacheRecords
            // 
            resources.ApplyResources(this.lblCacheRecords, "lblCacheRecords");
            this.lblCacheRecords.Name = "lblCacheRecords";
            // 
            // tpChecking
            // 
            this.tpChecking.Controls.Add(this.chkPlaySoundOnError);
            this.tpChecking.Controls.Add(this.chkAutomaticallyVerify);
            this.tpChecking.Controls.Add(this.grpRenaming);
            this.tpChecking.Controls.Add(this.chkPlaySoundOnAllOK);
            this.tpChecking.Controls.Add(this.chkPlaySoundOnAllOK_OnlyIfInactive);
            this.tpChecking.Controls.Add(this.chkAutoCloseWhenDoneCheckingOnlyAllOK);
            this.tpChecking.Controls.Add(this.chkAutoCloseWhenDoneChecking);
            this.tpChecking.Controls.Add(this.chkDeleteFailedFiles);
            this.tpChecking.Controls.Add(this.chkCleanupBadMissing);
            this.tpChecking.Controls.Add(this.chkCreateMissingMarkers);
            this.tpChecking.Controls.Add(this.chkRenameBadFiles);
            this.tpChecking.Controls.Add(this.chkUseRecycleBin);
            this.tpChecking.Controls.Add(this.chkAutoFindRenames);
            resources.ApplyResources(this.tpChecking, "tpChecking");
            this.tpChecking.Name = "tpChecking";
            this.tpChecking.UseVisualStyleBackColor = true;
            // 
            // chkPlaySoundOnError
            // 
            resources.ApplyResources(this.chkPlaySoundOnError, "chkPlaySoundOnError");
            this.chkPlaySoundOnError.Name = "chkPlaySoundOnError";
            this.chkPlaySoundOnError.UseVisualStyleBackColor = true;
            // 
            // chkAutomaticallyVerify
            // 
            resources.ApplyResources(this.chkAutomaticallyVerify, "chkAutomaticallyVerify");
            this.chkAutomaticallyVerify.Name = "chkAutomaticallyVerify";
            this.chkAutomaticallyVerify.UseVisualStyleBackColor = true;
            // 
            // grpRenaming
            // 
            this.grpRenaming.Controls.Add(this.rbRenamePreserveCapitalization);
            this.grpRenaming.Controls.Add(this.rbRenameNone);
            this.grpRenaming.Controls.Add(this.rbRenameToLowercase);
            this.grpRenaming.Controls.Add(this.rbRenameToMatchSet);
            resources.ApplyResources(this.grpRenaming, "grpRenaming");
            this.grpRenaming.Name = "grpRenaming";
            this.grpRenaming.TabStop = false;
            // 
            // rbRenamePreserveCapitalization
            // 
            resources.ApplyResources(this.rbRenamePreserveCapitalization, "rbRenamePreserveCapitalization");
            this.rbRenamePreserveCapitalization.Name = "rbRenamePreserveCapitalization";
            this.rbRenamePreserveCapitalization.TabStop = true;
            this.rbRenamePreserveCapitalization.UseVisualStyleBackColor = true;
            // 
            // rbRenameNone
            // 
            resources.ApplyResources(this.rbRenameNone, "rbRenameNone");
            this.rbRenameNone.Name = "rbRenameNone";
            this.rbRenameNone.TabStop = true;
            this.rbRenameNone.UseVisualStyleBackColor = true;
            // 
            // rbRenameToLowercase
            // 
            resources.ApplyResources(this.rbRenameToLowercase, "rbRenameToLowercase");
            this.rbRenameToLowercase.Name = "rbRenameToLowercase";
            this.rbRenameToLowercase.TabStop = true;
            this.rbRenameToLowercase.UseVisualStyleBackColor = true;
            // 
            // rbRenameToMatchSet
            // 
            resources.ApplyResources(this.rbRenameToMatchSet, "rbRenameToMatchSet");
            this.rbRenameToMatchSet.Name = "rbRenameToMatchSet";
            this.rbRenameToMatchSet.TabStop = true;
            this.rbRenameToMatchSet.UseVisualStyleBackColor = true;
            // 
            // chkPlaySoundOnAllOK
            // 
            resources.ApplyResources(this.chkPlaySoundOnAllOK, "chkPlaySoundOnAllOK");
            this.chkPlaySoundOnAllOK.Name = "chkPlaySoundOnAllOK";
            this.chkPlaySoundOnAllOK.UseVisualStyleBackColor = true;
            this.chkPlaySoundOnAllOK.CheckedChanged += new System.EventHandler(this.chkPlaySoundOnAllOK_CheckedChanged);
            // 
            // chkPlaySoundOnAllOK_OnlyIfInactive
            // 
            resources.ApplyResources(this.chkPlaySoundOnAllOK_OnlyIfInactive, "chkPlaySoundOnAllOK_OnlyIfInactive");
            this.chkPlaySoundOnAllOK_OnlyIfInactive.Name = "chkPlaySoundOnAllOK_OnlyIfInactive";
            this.chkPlaySoundOnAllOK_OnlyIfInactive.UseVisualStyleBackColor = true;
            // 
            // chkAutoCloseWhenDoneCheckingOnlyAllOK
            // 
            resources.ApplyResources(this.chkAutoCloseWhenDoneCheckingOnlyAllOK, "chkAutoCloseWhenDoneCheckingOnlyAllOK");
            this.chkAutoCloseWhenDoneCheckingOnlyAllOK.Name = "chkAutoCloseWhenDoneCheckingOnlyAllOK";
            this.chkAutoCloseWhenDoneCheckingOnlyAllOK.UseVisualStyleBackColor = true;
            // 
            // chkAutoCloseWhenDoneChecking
            // 
            resources.ApplyResources(this.chkAutoCloseWhenDoneChecking, "chkAutoCloseWhenDoneChecking");
            this.chkAutoCloseWhenDoneChecking.Name = "chkAutoCloseWhenDoneChecking";
            this.chkAutoCloseWhenDoneChecking.UseVisualStyleBackColor = true;
            this.chkAutoCloseWhenDoneChecking.CheckedChanged += new System.EventHandler(this.chkAutoCloseWhenDoneChecking_CheckedChanged);
            // 
            // chkDeleteFailedFiles
            // 
            resources.ApplyResources(this.chkDeleteFailedFiles, "chkDeleteFailedFiles");
            this.chkDeleteFailedFiles.Name = "chkDeleteFailedFiles";
            this.chkDeleteFailedFiles.UseVisualStyleBackColor = true;
            // 
            // chkCleanupBadMissing
            // 
            resources.ApplyResources(this.chkCleanupBadMissing, "chkCleanupBadMissing");
            this.chkCleanupBadMissing.Name = "chkCleanupBadMissing";
            this.chkCleanupBadMissing.UseVisualStyleBackColor = true;
            // 
            // chkCreateMissingMarkers
            // 
            resources.ApplyResources(this.chkCreateMissingMarkers, "chkCreateMissingMarkers");
            this.chkCreateMissingMarkers.Name = "chkCreateMissingMarkers";
            this.chkCreateMissingMarkers.UseVisualStyleBackColor = true;
            // 
            // chkRenameBadFiles
            // 
            resources.ApplyResources(this.chkRenameBadFiles, "chkRenameBadFiles");
            this.chkRenameBadFiles.Name = "chkRenameBadFiles";
            this.chkRenameBadFiles.UseVisualStyleBackColor = true;
            // 
            // chkUseRecycleBin
            // 
            resources.ApplyResources(this.chkUseRecycleBin, "chkUseRecycleBin");
            this.chkUseRecycleBin.Name = "chkUseRecycleBin";
            this.chkUseRecycleBin.UseVisualStyleBackColor = true;
            // 
            // chkAutoFindRenames
            // 
            resources.ApplyResources(this.chkAutoFindRenames, "chkAutoFindRenames");
            this.chkAutoFindRenames.Name = "chkAutoFindRenames";
            this.chkAutoFindRenames.UseVisualStyleBackColor = true;
            // 
            // tpCreating
            // 
            this.tpCreating.Controls.Add(this.chkCreateForEachSubDir);
            this.tpCreating.Controls.Add(this.txtExcludeFilesOfType);
            this.tpCreating.Controls.Add(this.lblExcludeFilesofType);
            this.tpCreating.Controls.Add(this.chkAutoCloseWhenDoneCreating);
            this.tpCreating.Controls.Add(this.chkPromptForFileName);
            this.tpCreating.Controls.Add(this.chkMD5SumCompatibility);
            this.tpCreating.Controls.Add(this.chkSFV32Compatibility);
            this.tpCreating.Controls.Add(this.chkSortFiles);
            resources.ApplyResources(this.tpCreating, "tpCreating");
            this.tpCreating.Name = "tpCreating";
            this.tpCreating.UseVisualStyleBackColor = true;
            // 
            // chkCreateForEachSubDir
            // 
            resources.ApplyResources(this.chkCreateForEachSubDir, "chkCreateForEachSubDir");
            this.chkCreateForEachSubDir.Name = "chkCreateForEachSubDir";
            this.chkCreateForEachSubDir.UseVisualStyleBackColor = true;
            // 
            // txtExcludeFilesOfType
            // 
            resources.ApplyResources(this.txtExcludeFilesOfType, "txtExcludeFilesOfType");
            this.txtExcludeFilesOfType.Name = "txtExcludeFilesOfType";
            // 
            // lblExcludeFilesofType
            // 
            resources.ApplyResources(this.lblExcludeFilesofType, "lblExcludeFilesofType");
            this.lblExcludeFilesofType.Name = "lblExcludeFilesofType";
            // 
            // chkAutoCloseWhenDoneCreating
            // 
            resources.ApplyResources(this.chkAutoCloseWhenDoneCreating, "chkAutoCloseWhenDoneCreating");
            this.chkAutoCloseWhenDoneCreating.Name = "chkAutoCloseWhenDoneCreating";
            this.chkAutoCloseWhenDoneCreating.UseVisualStyleBackColor = true;
            // 
            // chkPromptForFileName
            // 
            resources.ApplyResources(this.chkPromptForFileName, "chkPromptForFileName");
            this.chkPromptForFileName.Name = "chkPromptForFileName";
            this.chkPromptForFileName.UseVisualStyleBackColor = true;
            // 
            // chkMD5SumCompatibility
            // 
            resources.ApplyResources(this.chkMD5SumCompatibility, "chkMD5SumCompatibility");
            this.chkMD5SumCompatibility.Name = "chkMD5SumCompatibility";
            this.chkMD5SumCompatibility.UseVisualStyleBackColor = true;
            // 
            // chkSFV32Compatibility
            // 
            resources.ApplyResources(this.chkSFV32Compatibility, "chkSFV32Compatibility");
            this.chkSFV32Compatibility.Name = "chkSFV32Compatibility";
            this.chkSFV32Compatibility.UseVisualStyleBackColor = true;
            // 
            // chkSortFiles
            // 
            resources.ApplyResources(this.chkSortFiles, "chkSortFiles");
            this.chkSortFiles.Name = "chkSortFiles";
            this.chkSortFiles.UseVisualStyleBackColor = true;
            // 
            // tpComments
            // 
            this.tpComments.Controls.Add(this.btnCommentShowVariables);
            this.tpComments.Controls.Add(this.txtCommentsFooter);
            this.tpComments.Controls.Add(this.txtCommentsFileList);
            this.tpComments.Controls.Add(this.txtCommentsHeader);
            this.tpComments.Controls.Add(this.lblCommentsFooter);
            this.tpComments.Controls.Add(this.lblCommentsFileList);
            this.tpComments.Controls.Add(this.lblCommentsHeader);
            this.tpComments.Controls.Add(this.chkWriteComments);
            resources.ApplyResources(this.tpComments, "tpComments");
            this.tpComments.Name = "tpComments";
            this.tpComments.UseVisualStyleBackColor = true;
            // 
            // btnCommentShowVariables
            // 
            resources.ApplyResources(this.btnCommentShowVariables, "btnCommentShowVariables");
            this.btnCommentShowVariables.Name = "btnCommentShowVariables";
            this.btnCommentShowVariables.UseVisualStyleBackColor = true;
            this.btnCommentShowVariables.Click += new System.EventHandler(this.btnCommentShowVariables_Click);
            // 
            // txtCommentsFooter
            // 
            resources.ApplyResources(this.txtCommentsFooter, "txtCommentsFooter");
            this.txtCommentsFooter.Name = "txtCommentsFooter";
            // 
            // txtCommentsFileList
            // 
            resources.ApplyResources(this.txtCommentsFileList, "txtCommentsFileList");
            this.txtCommentsFileList.Name = "txtCommentsFileList";
            // 
            // txtCommentsHeader
            // 
            resources.ApplyResources(this.txtCommentsHeader, "txtCommentsHeader");
            this.txtCommentsHeader.Name = "txtCommentsHeader";
            // 
            // lblCommentsFooter
            // 
            resources.ApplyResources(this.lblCommentsFooter, "lblCommentsFooter");
            this.lblCommentsFooter.Name = "lblCommentsFooter";
            // 
            // lblCommentsFileList
            // 
            resources.ApplyResources(this.lblCommentsFileList, "lblCommentsFileList");
            this.lblCommentsFileList.Name = "lblCommentsFileList";
            // 
            // lblCommentsHeader
            // 
            resources.ApplyResources(this.lblCommentsHeader, "lblCommentsHeader");
            this.lblCommentsHeader.Name = "lblCommentsHeader";
            // 
            // chkWriteComments
            // 
            resources.ApplyResources(this.chkWriteComments, "chkWriteComments");
            this.chkWriteComments.Name = "chkWriteComments";
            this.chkWriteComments.UseVisualStyleBackColor = true;
            this.chkWriteComments.CheckedChanged += new System.EventHandler(this.chkWriteComments_CheckedChanged);
            // 
            // tpAbout
            // 
            this.tpAbout.Controls.Add(this.btnReleaseNotes);
            this.tpAbout.Controls.Add(this.pictureBox1);
            this.tpAbout.Controls.Add(this.btnWeb);
            this.tpAbout.Controls.Add(this.lblMadeInTributeTohkSFV);
            this.tpAbout.Controls.Add(this.lblilSFV);
            this.tpAbout.Controls.Add(this.lblReleaseDate);
            this.tpAbout.Controls.Add(this.lblVersion);
            this.tpAbout.Controls.Add(this.grpUsageStatistics);
            resources.ApplyResources(this.tpAbout, "tpAbout");
            this.tpAbout.Name = "tpAbout";
            this.tpAbout.UseVisualStyleBackColor = true;
            // 
            // btnReleaseNotes
            // 
            resources.ApplyResources(this.btnReleaseNotes, "btnReleaseNotes");
            this.btnReleaseNotes.Name = "btnReleaseNotes";
            this.btnReleaseNotes.UseVisualStyleBackColor = true;
            this.btnReleaseNotes.Click += new System.EventHandler(this.btnReleaseNotes_Click);
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // btnWeb
            // 
            resources.ApplyResources(this.btnWeb, "btnWeb");
            this.btnWeb.Name = "btnWeb";
            this.toolTip1.SetToolTip(this.btnWeb, resources.GetString("btnWeb.ToolTip"));
            this.btnWeb.UseVisualStyleBackColor = true;
            this.btnWeb.Click += new System.EventHandler(this.btnWeb_Click);
            // 
            // lblMadeInTributeTohkSFV
            // 
            resources.ApplyResources(this.lblMadeInTributeTohkSFV, "lblMadeInTributeTohkSFV");
            this.lblMadeInTributeTohkSFV.Name = "lblMadeInTributeTohkSFV";
            // 
            // lblilSFV
            // 
            resources.ApplyResources(this.lblilSFV, "lblilSFV");
            this.lblilSFV.Name = "lblilSFV";
            // 
            // lblReleaseDate
            // 
            resources.ApplyResources(this.lblReleaseDate, "lblReleaseDate");
            this.lblReleaseDate.Name = "lblReleaseDate";
            // 
            // lblVersion
            // 
            resources.ApplyResources(this.lblVersion, "lblVersion");
            this.lblVersion.Name = "lblVersion";
            // 
            // grpUsageStatistics
            // 
            resources.ApplyResources(this.grpUsageStatistics, "grpUsageStatistics");
            this.grpUsageStatistics.Controls.Add(this.btnResetUsageStats);
            this.grpUsageStatistics.Controls.Add(this.txtTimeSpent);
            this.grpUsageStatistics.Controls.Add(this.txtGoodFiles);
            this.grpUsageStatistics.Controls.Add(this.lblTimeSpent);
            this.grpUsageStatistics.Controls.Add(this.lblGoodFiles);
            this.grpUsageStatistics.Controls.Add(this.txtMBChecked);
            this.grpUsageStatistics.Controls.Add(this.txtSetsChecked);
            this.grpUsageStatistics.Controls.Add(this.txtFilesChecked);
            this.grpUsageStatistics.Controls.Add(this.lblMBChecked);
            this.grpUsageStatistics.Controls.Add(this.lblSetsChecked);
            this.grpUsageStatistics.Controls.Add(this.lblFilesChecked);
            this.grpUsageStatistics.Name = "grpUsageStatistics";
            this.grpUsageStatistics.TabStop = false;
            // 
            // btnResetUsageStats
            // 
            resources.ApplyResources(this.btnResetUsageStats, "btnResetUsageStats");
            this.btnResetUsageStats.Name = "btnResetUsageStats";
            this.btnResetUsageStats.UseVisualStyleBackColor = true;
            this.btnResetUsageStats.Click += new System.EventHandler(this.btnResetUsageStats_Click);
            // 
            // txtTimeSpent
            // 
            resources.ApplyResources(this.txtTimeSpent, "txtTimeSpent");
            this.txtTimeSpent.BackColor = System.Drawing.SystemColors.Window;
            this.txtTimeSpent.Name = "txtTimeSpent";
            this.txtTimeSpent.ReadOnly = true;
            // 
            // txtGoodFiles
            // 
            resources.ApplyResources(this.txtGoodFiles, "txtGoodFiles");
            this.txtGoodFiles.BackColor = System.Drawing.SystemColors.Window;
            this.txtGoodFiles.Name = "txtGoodFiles";
            this.txtGoodFiles.ReadOnly = true;
            // 
            // lblTimeSpent
            // 
            resources.ApplyResources(this.lblTimeSpent, "lblTimeSpent");
            this.lblTimeSpent.Name = "lblTimeSpent";
            // 
            // lblGoodFiles
            // 
            resources.ApplyResources(this.lblGoodFiles, "lblGoodFiles");
            this.lblGoodFiles.Name = "lblGoodFiles";
            // 
            // txtMBChecked
            // 
            this.txtMBChecked.BackColor = System.Drawing.SystemColors.Window;
            resources.ApplyResources(this.txtMBChecked, "txtMBChecked");
            this.txtMBChecked.Name = "txtMBChecked";
            this.txtMBChecked.ReadOnly = true;
            // 
            // txtSetsChecked
            // 
            this.txtSetsChecked.BackColor = System.Drawing.SystemColors.Window;
            resources.ApplyResources(this.txtSetsChecked, "txtSetsChecked");
            this.txtSetsChecked.Name = "txtSetsChecked";
            this.txtSetsChecked.ReadOnly = true;
            // 
            // txtFilesChecked
            // 
            this.txtFilesChecked.BackColor = System.Drawing.SystemColors.Window;
            resources.ApplyResources(this.txtFilesChecked, "txtFilesChecked");
            this.txtFilesChecked.Name = "txtFilesChecked";
            this.txtFilesChecked.ReadOnly = true;
            // 
            // lblMBChecked
            // 
            resources.ApplyResources(this.lblMBChecked, "lblMBChecked");
            this.lblMBChecked.Name = "lblMBChecked";
            // 
            // lblSetsChecked
            // 
            resources.ApplyResources(this.lblSetsChecked, "lblSetsChecked");
            this.lblSetsChecked.Name = "lblSetsChecked";
            // 
            // lblFilesChecked
            // 
            resources.ApplyResources(this.lblFilesChecked, "lblFilesChecked");
            this.lblFilesChecked.Name = "lblFilesChecked";
            // 
            // btnOK
            // 
            resources.ApplyResources(this.btnOK, "btnOK");
            this.btnOK.Name = "btnOK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Analyze.png");
            // 
            // PreferencesForm
            // 
            this.AcceptButton = this.btnOK;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PreferencesForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.tabControl1.ResumeLayout(false);
            this.tpGeneral.ResumeLayout(false);
            this.tpGeneral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkCacheSize)).EndInit();
            this.tpChecking.ResumeLayout(false);
            this.tpChecking.PerformLayout();
            this.grpRenaming.ResumeLayout(false);
            this.grpRenaming.PerformLayout();
            this.tpCreating.ResumeLayout(false);
            this.tpCreating.PerformLayout();
            this.tpComments.ResumeLayout(false);
            this.tpComments.PerformLayout();
            this.tpAbout.ResumeLayout(false);
            this.tpAbout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpUsageStatistics.ResumeLayout(false);
            this.grpUsageStatistics.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpGeneral;
        private System.Windows.Forms.TabPage tpChecking;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TabPage tpCreating;
        private System.Windows.Forms.TabPage tpAbout;
        private System.Windows.Forms.GroupBox grpUsageStatistics;
        private System.Windows.Forms.ComboBox cboLanguage;
        private System.Windows.Forms.Label lblLanguage;
		private System.Windows.Forms.TrackBar trkCacheSize;
		private System.Windows.Forms.Label lblCacheRecords;
        private System.Windows.Forms.Label lblRecords;
        private System.Windows.Forms.Label lblCacheSizeLabel;
        private System.Windows.Forms.CheckBox chkRecursive;
        private System.Windows.Forms.CheckBox chkAutoScrollFileList;
        private System.Windows.Forms.CheckBox chkFlashWindowWhenDone;
        private System.Windows.Forms.CheckBox chkReuseWindow;
        private System.Windows.Forms.CheckBox chkRememberWindowPlacement;
        private System.Windows.Forms.CheckBox chkAlwaysOnTop;
        private System.Windows.Forms.CheckBox chkDeleteFailedFiles;
        private System.Windows.Forms.CheckBox chkCleanupBadMissing;
        private System.Windows.Forms.CheckBox chkCreateMissingMarkers;
        private System.Windows.Forms.CheckBox chkRenameBadFiles;
        private System.Windows.Forms.CheckBox chkUseRecycleBin;
        private System.Windows.Forms.CheckBox chkAutoFindRenames;
        private System.Windows.Forms.GroupBox grpRenaming;
        private System.Windows.Forms.RadioButton rbRenameNone;
        private System.Windows.Forms.RadioButton rbRenameToLowercase;
        private System.Windows.Forms.RadioButton rbRenameToMatchSet;
        private System.Windows.Forms.CheckBox chkAutoCloseWhenDoneCheckingOnlyAllOK;
        private System.Windows.Forms.CheckBox chkAutoCloseWhenDoneChecking;
        private System.Windows.Forms.CheckBox chkAutoCloseWhenDoneCreating;
        private System.Windows.Forms.CheckBox chkPromptForFileName;
        private System.Windows.Forms.CheckBox chkMD5SumCompatibility;
        private System.Windows.Forms.CheckBox chkSFV32Compatibility;
        private System.Windows.Forms.CheckBox chkSortFiles;
        private System.Windows.Forms.TextBox txtTimeSpent;
        private System.Windows.Forms.TextBox txtGoodFiles;
        private System.Windows.Forms.Label lblTimeSpent;
        private System.Windows.Forms.Label lblGoodFiles;
        private System.Windows.Forms.TextBox txtMBChecked;
        private System.Windows.Forms.TextBox txtSetsChecked;
        private System.Windows.Forms.TextBox txtFilesChecked;
        private System.Windows.Forms.Label lblMBChecked;
        private System.Windows.Forms.Label lblSetsChecked;
        private System.Windows.Forms.Label lblFilesChecked;
        private System.Windows.Forms.Label lblReleaseDate;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.TextBox txtExcludeFilesOfType;
        private System.Windows.Forms.Label lblExcludeFilesofType;
        private System.Windows.Forms.Button btnWeb;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lblMadeInTributeTohkSFV;
        private System.Windows.Forms.Label lblilSFV;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.Button btnResetUsageStats;
		private System.Windows.Forms.CheckBox chkCheckForUpdates;
		private System.Windows.Forms.CheckBox chkAutomaticallyVerify;
		private System.Windows.Forms.Button btnClearCache;
		private System.Windows.Forms.Label lblDays;
		private System.Windows.Forms.TextBox txtCheckForUpdatesDays;
		private System.Windows.Forms.CheckBox chkPlaySoundOnError;
		private System.Windows.Forms.CheckBox chkPlaySoundOnAllOK;
		private System.Windows.Forms.CheckBox chkPlaySoundOnAllOK_OnlyIfInactive;
		private System.Windows.Forms.CheckBox chkCreateForEachSubDir;
		private System.Windows.Forms.TabPage tpComments;
		private System.Windows.Forms.TextBox txtCommentsHeader;
		private System.Windows.Forms.Label lblCommentsFooter;
		private System.Windows.Forms.Label lblCommentsFileList;
		private System.Windows.Forms.Label lblCommentsHeader;
		private System.Windows.Forms.CheckBox chkWriteComments;
		private System.Windows.Forms.TextBox txtCommentsFooter;
		private System.Windows.Forms.TextBox txtCommentsFileList;
		private System.Windows.Forms.Button btnCommentShowVariables;
		private System.Windows.Forms.CheckBox chkUseLowPriorityOnHide;
		private System.Windows.Forms.Button btnReleaseNotes;
        private System.Windows.Forms.CheckBox chkIsRecentFilesSaved;
        private System.Windows.Forms.RadioButton rbRenamePreserveCapitalization;
    }
}