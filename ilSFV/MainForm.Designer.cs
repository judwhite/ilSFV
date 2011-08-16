namespace ilSFV
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.miNewSFV = new System.Windows.Forms.ToolStripMenuItem();
            this.miNewMD5 = new System.Windows.Forms.ToolStripMenuItem();
            this.miNewSHA1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.miOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.miPreferences = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.miCheckForUpdates = new System.Windows.Forms.ToolStripMenuItem();
            this.miDocumentSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.miDocument1 = new System.Windows.Forms.ToolStripMenuItem();
            this.miDocument2 = new System.Windows.Forms.ToolStripMenuItem();
            this.miDocument3 = new System.Windows.Forms.ToolStripMenuItem();
            this.miDocument4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.miExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLegend = new System.Windows.Forms.ToolStripMenuItem();
            this.miFileOK = new System.Windows.Forms.ToolStripMenuItem();
            this.miFileBad = new System.Windows.Forms.ToolStripMenuItem();
            this.miFileNotFound = new System.Windows.Forms.ToolStripMenuItem();
            this.miFileUntested = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTools = new System.Windows.Forms.ToolStripMenuItem();
            this.miFindRenamedFiles = new System.Windows.Forms.ToolStripMenuItem();
            this.miUseCachedResults = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.miFindDuplicateFiles = new System.Windows.Forms.ToolStripMenuItem();
            this.miTruncateFileNames = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.miRegisterFileTypes = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuView = new System.Windows.Forms.ToolStripMenuItem();
            this.miHideGood = new System.Windows.Forms.ToolStripMenuItem();
            this.miCommentResultPane = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.miAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblSets = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblParts = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblGood = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblBad = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblMissing = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.miCopyFileNames = new System.Windows.Forms.ToolStripMenuItem();
            this.CopyPathAndFileNames = new System.Windows.Forms.ToolStripMenuItem();
            this.miContextMenuSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.miCopyCurrentChecksum = new System.Windows.Forms.ToolStripMenuItem();
            this.miCopyOriginalChecksum = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGo = new System.Windows.Forms.Button();
            this.btnRightPane = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.chkHideGood = new System.Windows.Forms.CheckBox();
            this.btnHide = new System.Windows.Forms.Button();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpComments = new System.Windows.Forms.TabPage();
            this.txtComments = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.lvwFiles = new ilSFV.FastListView();
            this.colFilename = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tpComments.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuLegend,
            this.mnuTools,
            this.mnuView,
            this.mnuHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1184, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miNewSFV,
            this.miNewMD5,
            this.miNewSHA1,
            this.toolStripSeparator5,
            this.miOpen,
            this.toolStripSeparator3,
            this.miPreferences,
            this.toolStripSeparator1,
            this.miCheckForUpdates,
            this.miDocumentSeparator,
            this.miDocument1,
            this.miDocument2,
            this.miDocument3,
            this.miDocument4,
            this.toolStripSeparator2,
            this.miExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(39, 20);
            this.mnuFile.Text = "&File";
            this.mnuFile.DropDownOpening += new System.EventHandler(this.mnuFile_DropDownOpening);
            // 
            // miNewSFV
            // 
            this.miNewSFV.Name = "miNewSFV";
            this.miNewSFV.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.miNewSFV.Size = new System.Drawing.Size(210, 22);
            this.miNewSFV.Text = "New &SFV File...";
            this.miNewSFV.Click += new System.EventHandler(this.miNewSFV_Click);
            // 
            // miNewMD5
            // 
            this.miNewMD5.Name = "miNewMD5";
            this.miNewMD5.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.miNewMD5.Size = new System.Drawing.Size(210, 22);
            this.miNewMD5.Text = "New &MD5 File...";
            this.miNewMD5.Click += new System.EventHandler(this.miNewMD5_Click);
            // 
            // miNewSHA1
            // 
            this.miNewSHA1.Name = "miNewSHA1";
            this.miNewSHA1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.miNewSHA1.Size = new System.Drawing.Size(210, 22);
            this.miNewSHA1.Text = "New SH&A-1 File...";
            this.miNewSHA1.Click += new System.EventHandler(this.miNewSHA1_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(207, 6);
            // 
            // miOpen
            // 
            this.miOpen.Name = "miOpen";
            this.miOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.miOpen.Size = new System.Drawing.Size(210, 22);
            this.miOpen.Text = "&Open...";
            this.miOpen.Click += new System.EventHandler(this.miOpen_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(207, 6);
            // 
            // miPreferences
            // 
            this.miPreferences.Name = "miPreferences";
            this.miPreferences.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.miPreferences.Size = new System.Drawing.Size(210, 22);
            this.miPreferences.Text = "&Preferences...";
            this.miPreferences.Click += new System.EventHandler(this.miPreferences_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(207, 6);
            // 
            // miCheckForUpdates
            // 
            this.miCheckForUpdates.Name = "miCheckForUpdates";
            this.miCheckForUpdates.Size = new System.Drawing.Size(210, 22);
            this.miCheckForUpdates.Text = "Check For &Updates";
            this.miCheckForUpdates.Click += new System.EventHandler(this.miCheckForUpdates_Click);
            // 
            // miDocumentSeparator
            // 
            this.miDocumentSeparator.Name = "miDocumentSeparator";
            this.miDocumentSeparator.Size = new System.Drawing.Size(207, 6);
            this.miDocumentSeparator.Visible = false;
            // 
            // miDocument1
            // 
            this.miDocument1.Name = "miDocument1";
            this.miDocument1.Size = new System.Drawing.Size(210, 22);
            this.miDocument1.Text = "document1";
            this.miDocument1.Visible = false;
            this.miDocument1.Click += new System.EventHandler(this.miDocument1_Click);
            // 
            // miDocument2
            // 
            this.miDocument2.Name = "miDocument2";
            this.miDocument2.Size = new System.Drawing.Size(210, 22);
            this.miDocument2.Text = "document2";
            this.miDocument2.Visible = false;
            this.miDocument2.Click += new System.EventHandler(this.miDocument1_Click);
            // 
            // miDocument3
            // 
            this.miDocument3.Name = "miDocument3";
            this.miDocument3.Size = new System.Drawing.Size(210, 22);
            this.miDocument3.Text = "document3";
            this.miDocument3.Visible = false;
            this.miDocument3.Click += new System.EventHandler(this.miDocument1_Click);
            // 
            // miDocument4
            // 
            this.miDocument4.Name = "miDocument4";
            this.miDocument4.Size = new System.Drawing.Size(210, 22);
            this.miDocument4.Text = "document4";
            this.miDocument4.Visible = false;
            this.miDocument4.Click += new System.EventHandler(this.miDocument1_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(207, 6);
            // 
            // miExit
            // 
            this.miExit.Name = "miExit";
            this.miExit.Size = new System.Drawing.Size(210, 22);
            this.miExit.Text = "E&xit";
            this.miExit.Click += new System.EventHandler(this.miExit_Click);
            // 
            // mnuLegend
            // 
            this.mnuLegend.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miFileOK,
            this.miFileBad,
            this.miFileNotFound,
            this.miFileUntested});
            this.mnuLegend.Name = "mnuLegend";
            this.mnuLegend.Size = new System.Drawing.Size(61, 20);
            this.mnuLegend.Text = "&Legend";
            // 
            // miFileOK
            // 
            this.miFileOK.Image = global::ilSFV.Properties.Resources.Bullet_10;
            this.miFileOK.Name = "miFileOK";
            this.miFileOK.Size = new System.Drawing.Size(179, 22);
            this.miFileOK.Text = "File OK";
            // 
            // miFileBad
            // 
            this.miFileBad.Image = global::ilSFV.Properties.Resources.Bullet_9;
            this.miFileBad.Name = "miFileBad";
            this.miFileBad.Size = new System.Drawing.Size(179, 22);
            this.miFileBad.Text = "File Bad";
            // 
            // miFileNotFound
            // 
            this.miFileNotFound.Image = global::ilSFV.Properties.Resources.Bullet_8;
            this.miFileNotFound.Name = "miFileNotFound";
            this.miFileNotFound.Size = new System.Drawing.Size(179, 22);
            this.miFileNotFound.Text = "File Not Found";
            // 
            // miFileUntested
            // 
            this.miFileUntested.Image = global::ilSFV.Properties.Resources.Bullet_6;
            this.miFileUntested.Name = "miFileUntested";
            this.miFileUntested.Size = new System.Drawing.Size(179, 22);
            this.miFileUntested.Text = "Untested-Unknown";
            // 
            // mnuTools
            // 
            this.mnuTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miFindRenamedFiles,
            this.miUseCachedResults,
            this.toolStripSeparator4,
            this.miFindDuplicateFiles,
            this.miTruncateFileNames,
            this.toolStripSeparator6,
            this.miRegisterFileTypes});
            this.mnuTools.Name = "mnuTools";
            this.mnuTools.Size = new System.Drawing.Size(49, 20);
            this.mnuTools.Text = "&Tools";
            // 
            // miFindRenamedFiles
            // 
            this.miFindRenamedFiles.Name = "miFindRenamedFiles";
            this.miFindRenamedFiles.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.miFindRenamedFiles.Size = new System.Drawing.Size(326, 22);
            this.miFindRenamedFiles.Text = "Find &Renamed Files";
            this.miFindRenamedFiles.Click += new System.EventHandler(this.miFindRenamedFiles_Click);
            // 
            // miUseCachedResults
            // 
            this.miUseCachedResults.Name = "miUseCachedResults";
            this.miUseCachedResults.Size = new System.Drawing.Size(326, 22);
            this.miUseCachedResults.Text = "Use &Cached Results";
            this.miUseCachedResults.Click += new System.EventHandler(this.miUseCachedResults_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(323, 6);
            // 
            // miFindDuplicateFiles
            // 
            this.miFindDuplicateFiles.Name = "miFindDuplicateFiles";
            this.miFindDuplicateFiles.Size = new System.Drawing.Size(326, 22);
            this.miFindDuplicateFiles.Text = "Find/Delete Duplicate Files Using Checksum...";
            this.miFindDuplicateFiles.Click += new System.EventHandler(this.miFindDuplicateFiles_Click);
            // 
            // miTruncateFileNames
            // 
            this.miTruncateFileNames.Name = "miTruncateFileNames";
            this.miTruncateFileNames.Size = new System.Drawing.Size(326, 22);
            this.miTruncateFileNames.Text = "&Truncate File Names...";
            this.miTruncateFileNames.Click += new System.EventHandler(this.miTruncateFileNames_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(323, 6);
            // 
            // miRegisterFileTypes
            // 
            this.miRegisterFileTypes.Name = "miRegisterFileTypes";
            this.miRegisterFileTypes.Size = new System.Drawing.Size(326, 22);
            this.miRegisterFileTypes.Text = "Register File &Types";
            this.miRegisterFileTypes.Click += new System.EventHandler(this.miRegisterFileTypes_Click);
            // 
            // mnuView
            // 
            this.mnuView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miHideGood,
            this.miCommentResultPane});
            this.mnuView.Name = "mnuView";
            this.mnuView.Size = new System.Drawing.Size(45, 20);
            this.mnuView.Text = "&View";
            // 
            // miHideGood
            // 
            this.miHideGood.Name = "miHideGood";
            this.miHideGood.Size = new System.Drawing.Size(198, 22);
            this.miHideGood.Text = "&Hide Good";
            this.miHideGood.Click += new System.EventHandler(this.miHideGood_Click);
            // 
            // miCommentResultPane
            // 
            this.miCommentResultPane.Name = "miCommentResultPane";
            this.miCommentResultPane.Size = new System.Drawing.Size(198, 22);
            this.miCommentResultPane.Text = "&Comment/Result Pane";
            this.miCommentResultPane.Click += new System.EventHandler(this.miCommentResultPane_Click);
            // 
            // mnuHelp
            // 
            this.mnuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miAbout});
            this.mnuHelp.Name = "mnuHelp";
            this.mnuHelp.Size = new System.Drawing.Size(45, 20);
            this.mnuHelp.Text = "&Help";
            // 
            // miAbout
            // 
            this.miAbout.Name = "miAbout";
            this.miAbout.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.miAbout.Size = new System.Drawing.Size(126, 22);
            this.miAbout.Text = "&About";
            this.miAbout.Click += new System.EventHandler(this.miAbout_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus,
            this.lblSets,
            this.lblParts,
            this.lblGood,
            this.lblBad,
            this.lblMissing});
            this.statusStrip1.Location = new System.Drawing.Point(0, 584);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1184, 24);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = false;
            this.lblStatus.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(43, 19);
            this.lblStatus.Text = "Ready";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSets
            // 
            this.lblSets.AutoSize = false;
            this.lblSets.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.lblSets.Name = "lblSets";
            this.lblSets.Size = new System.Drawing.Size(31, 19);
            this.lblSets.Text = "Sets:";
            this.lblSets.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblParts
            // 
            this.lblParts.AutoSize = false;
            this.lblParts.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.lblParts.Name = "lblParts";
            this.lblParts.Size = new System.Drawing.Size(40, 19);
            this.lblParts.Text = "Parts:";
            this.lblParts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblGood
            // 
            this.lblGood.AutoSize = false;
            this.lblGood.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.lblGood.Name = "lblGood";
            this.lblGood.Size = new System.Drawing.Size(43, 19);
            this.lblGood.Text = "Good:";
            this.lblGood.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblBad
            // 
            this.lblBad.AutoSize = false;
            this.lblBad.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.lblBad.Name = "lblBad";
            this.lblBad.Size = new System.Drawing.Size(34, 19);
            this.lblBad.Text = "Bad:";
            this.lblBad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMissing
            // 
            this.lblMissing.AutoSize = false;
            this.lblMissing.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.lblMissing.Name = "lblMissing";
            this.lblMissing.Size = new System.Drawing.Size(55, 19);
            this.lblMissing.Text = "Missing:";
            this.lblMissing.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lvwFiles);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Size = new System.Drawing.Size(1184, 560);
            this.splitContainer1.SplitterDistance = 590;
            this.splitContainer1.TabIndex = 2;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miCopyFileNames,
            this.CopyPathAndFileNames,
            this.miContextMenuSeparator,
            this.miCopyCurrentChecksum,
            this.miCopyOriginalChecksum});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(232, 98);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // miCopyFileNames
            // 
            this.miCopyFileNames.Name = "miCopyFileNames";
            this.miCopyFileNames.Size = new System.Drawing.Size(231, 22);
            this.miCopyFileNames.Text = "Copy File Name(s)";
            this.miCopyFileNames.Click += new System.EventHandler(this.miCopyFileNames_Click);
            // 
            // CopyPathAndFileNames
            // 
            this.CopyPathAndFileNames.Name = "CopyPathAndFileNames";
            this.CopyPathAndFileNames.Size = new System.Drawing.Size(231, 22);
            this.CopyPathAndFileNames.Text = "Copy Path + File Name(s)";
            this.CopyPathAndFileNames.Click += new System.EventHandler(this.miCopyPathAndFileNames_Click);
            // 
            // miContextMenuSeparator
            // 
            this.miContextMenuSeparator.Name = "miContextMenuSeparator";
            this.miContextMenuSeparator.Size = new System.Drawing.Size(228, 6);
            // 
            // miCopyCurrentChecksum
            // 
            this.miCopyCurrentChecksum.Name = "miCopyCurrentChecksum";
            this.miCopyCurrentChecksum.Size = new System.Drawing.Size(231, 22);
            this.miCopyCurrentChecksum.Text = "Copy Current Checksum (##)";
            this.miCopyCurrentChecksum.Click += new System.EventHandler(this.miCopyCurrentChecksum_Click);
            // 
            // miCopyOriginalChecksum
            // 
            this.miCopyOriginalChecksum.Name = "miCopyOriginalChecksum";
            this.miCopyOriginalChecksum.Size = new System.Drawing.Size(231, 22);
            this.miCopyOriginalChecksum.Text = "Copy Original Checksum (##)";
            this.miCopyOriginalChecksum.Click += new System.EventHandler(this.miCopyOriginalChecksum_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Bullet 6.png");
            this.imageList1.Images.SetKeyName(1, "Bullet 10.png");
            this.imageList1.Images.SetKeyName(2, "Bullet 9.png");
            this.imageList1.Images.SetKeyName(3, "Bullet 8.png");
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnGo);
            this.panel1.Controls.Add(this.btnRightPane);
            this.panel1.Controls.Add(this.btnPause);
            this.panel1.Controls.Add(this.chkHideGood);
            this.panel1.Controls.Add(this.btnHide);
            this.panel1.Controls.Add(this.progressBar2);
            this.panel1.Controls.Add(this.progressBar1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 498);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(590, 62);
            this.panel1.TabIndex = 0;
            // 
            // btnGo
            // 
            this.btnGo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGo.Location = new System.Drawing.Point(512, 32);
            this.btnGo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(74, 20);
            this.btnGo.TabIndex = 25;
            this.btnGo.Text = "&Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // btnRightPane
            // 
            this.btnRightPane.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRightPane.Location = new System.Drawing.Point(555, 6);
            this.btnRightPane.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnRightPane.Name = "btnRightPane";
            this.btnRightPane.Size = new System.Drawing.Size(31, 20);
            this.btnRightPane.TabIndex = 20;
            this.btnRightPane.Text = "<<";
            this.btnRightPane.UseVisualStyleBackColor = true;
            this.btnRightPane.Click += new System.EventHandler(this.btnRightPane_Click);
            // 
            // btnPause
            // 
            this.btnPause.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPause.Enabled = false;
            this.btnPause.Location = new System.Drawing.Point(399, 6);
            this.btnPause.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(74, 20);
            this.btnPause.TabIndex = 10;
            this.btnPause.Text = "&Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // chkHideGood
            // 
            this.chkHideGood.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkHideGood.AutoSize = true;
            this.chkHideGood.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkHideGood.Location = new System.Drawing.Point(318, 9);
            this.chkHideGood.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.chkHideGood.Name = "chkHideGood";
            this.chkHideGood.Size = new System.Drawing.Size(77, 17);
            this.chkHideGood.TabIndex = 5;
            this.chkHideGood.Text = "Hide Good";
            this.chkHideGood.UseVisualStyleBackColor = true;
            this.chkHideGood.CheckedChanged += new System.EventHandler(this.chkHideGood_CheckedChanged);
            // 
            // btnHide
            // 
            this.btnHide.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHide.Enabled = false;
            this.btnHide.Location = new System.Drawing.Point(477, 6);
            this.btnHide.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(74, 20);
            this.btnHide.TabIndex = 15;
            this.btnHide.Text = "Hide";
            this.btnHide.UseVisualStyleBackColor = true;
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // progressBar2
            // 
            this.progressBar2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar2.Location = new System.Drawing.Point(8, 32);
            this.progressBar2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(500, 20);
            this.progressBar2.TabIndex = 1;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(8, 6);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(306, 20);
            this.progressBar1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpComments);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(590, 560);
            this.tabControl1.TabIndex = 30;
            // 
            // tpComments
            // 
            this.tpComments.Controls.Add(this.txtComments);
            this.tpComments.Location = new System.Drawing.Point(4, 25);
            this.tpComments.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tpComments.Name = "tpComments";
            this.tpComments.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tpComments.Size = new System.Drawing.Size(582, 531);
            this.tpComments.TabIndex = 0;
            this.tpComments.Text = "Comments";
            this.tpComments.UseVisualStyleBackColor = true;
            // 
            // txtComments
            // 
            this.txtComments.BackColor = System.Drawing.SystemColors.Window;
            this.txtComments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtComments.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComments.Location = new System.Drawing.Point(2, 3);
            this.txtComments.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtComments.Multiline = true;
            this.txtComments.Name = "txtComments";
            this.txtComments.ReadOnly = true;
            this.txtComments.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtComments.Size = new System.Drawing.Size(578, 525);
            this.txtComments.TabIndex = 0;
            this.txtComments.WordWrap = false;
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.Description = "Select a Folder";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.RestoreDirectory = true;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // lvwFiles
            // 
            this.lvwFiles.AllowDrop = true;
            this.lvwFiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colFilename});
            this.lvwFiles.ContextMenuStrip = this.contextMenuStrip1;
            this.lvwFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwFiles.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwFiles.FullRowSelect = true;
            this.lvwFiles.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvwFiles.HideSelection = false;
            this.lvwFiles.Location = new System.Drawing.Point(0, 0);
            this.lvwFiles.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.lvwFiles.Name = "lvwFiles";
            this.lvwFiles.Size = new System.Drawing.Size(590, 498);
            this.lvwFiles.StateImageList = this.imageList1;
            this.lvwFiles.TabIndex = 0;
            this.lvwFiles.UseCompatibleStateImageBehavior = false;
            this.lvwFiles.View = System.Windows.Forms.View.Details;
            this.lvwFiles.SelectedIndexChanged += new System.EventHandler(this.lvwFiles_SelectedIndexChanged);
            this.lvwFiles.DragDrop += new System.Windows.Forms.DragEventHandler(this.lvwFiles_DragDrop);
            this.lvwFiles.DragOver += new System.Windows.Forms.DragEventHandler(this.lvwFiles_DragOver);
            // 
            // colFilename
            // 
            this.colFilename.Text = "File name";
            this.colFilename.Width = 409;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 608);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ilSFV";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Move += new System.EventHandler(this.MainForm_Move);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tpComments.ResumeLayout(false);
            this.tpComments.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuLegend;
        private System.Windows.Forms.ToolStripMenuItem mnuTools;
        private System.Windows.Forms.ToolStripMenuItem mnuView;
		private System.Windows.Forms.ToolStripMenuItem mnuHelp;
        private System.Windows.Forms.ToolStripMenuItem miOpen;
        private System.Windows.Forms.ToolStripMenuItem miPreferences;
        private System.Windows.Forms.ToolStripMenuItem miExit;
        private System.Windows.Forms.ToolStripMenuItem miFileOK;
        private System.Windows.Forms.ToolStripMenuItem miFileBad;
        private System.Windows.Forms.ToolStripMenuItem miFileNotFound;
        private System.Windows.Forms.ToolStripMenuItem miFileUntested;
        private System.Windows.Forms.ToolStripMenuItem miHideGood;
        private System.Windows.Forms.ToolStripMenuItem miCommentResultPane;
        private System.Windows.Forms.ToolStripMenuItem miAbout;
        private System.Windows.Forms.ToolStripMenuItem miFindRenamedFiles;
        private System.Windows.Forms.ToolStripMenuItem miUseCachedResults;
        private System.Windows.Forms.ToolStripSeparator miDocumentSeparator;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.ToolStripStatusLabel lblParts;
        private System.Windows.Forms.ToolStripStatusLabel lblGood;
        private System.Windows.Forms.ToolStripStatusLabel lblBad;
        private System.Windows.Forms.ToolStripStatusLabel lblMissing;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpComments;
        private System.Windows.Forms.TextBox txtComments;
        private System.Windows.Forms.CheckBox chkHideGood;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Button btnRightPane;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnHide;
        private FastListView lvwFiles;
        private System.Windows.Forms.ColumnHeader colFilename;
        private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
		private System.Windows.Forms.ToolStripMenuItem miDocument1;
		private System.Windows.Forms.ToolStripMenuItem miDocument2;
		private System.Windows.Forms.ToolStripMenuItem miDocument3;
		private System.Windows.Forms.ToolStripMenuItem miDocument4;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem miCheckForUpdates;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
		private System.Windows.Forms.ToolStripMenuItem miRegisterFileTypes;
		private System.Windows.Forms.ToolStripMenuItem miNewSHA1;
		private System.Windows.Forms.ToolStripMenuItem miNewMD5;
		private System.Windows.Forms.ToolStripMenuItem miNewSFV;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem miCopyFileNames;
		private System.Windows.Forms.ToolStripMenuItem CopyPathAndFileNames;
		private System.Windows.Forms.ToolStripSeparator miContextMenuSeparator;
		private System.Windows.Forms.ToolStripMenuItem miCopyCurrentChecksum;
		private System.Windows.Forms.ToolStripMenuItem miCopyOriginalChecksum;
		private System.Windows.Forms.ToolStripStatusLabel lblSets;
		private System.Windows.Forms.ToolStripMenuItem miFindDuplicateFiles;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
		private System.Windows.Forms.ToolStripMenuItem miTruncateFileNames;
    }
}

