namespace ilSFV
{
	partial class RemoveDuplicatesForm
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
            this.lvwGroupings = new System.Windows.Forms.ListView();
            this.colGroupingsDuplicates = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colGroupingsCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lvwDuplicateFiles = new System.Windows.Forms.ListView();
            this.colFileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblSelectFileToKeep = new System.Windows.Forms.Label();
            this.lvwBadDirectories = new System.Windows.Forms.ListView();
            this.colBadDirsDirectory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colBadDirsCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblOptionalSelectDirectories = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRemoveDuplicates = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvwGroupings
            // 
            this.lvwGroupings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.lvwGroupings.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colGroupingsDuplicates,
            this.colGroupingsCount});
            this.lvwGroupings.FullRowSelect = true;
            this.lvwGroupings.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvwGroupings.HideSelection = false;
            this.lvwGroupings.Location = new System.Drawing.Point(12, 12);
            this.lvwGroupings.MultiSelect = false;
            this.lvwGroupings.Name = "lvwGroupings";
            this.lvwGroupings.Size = new System.Drawing.Size(183, 465);
            this.lvwGroupings.TabIndex = 0;
            this.lvwGroupings.UseCompatibleStateImageBehavior = false;
            this.lvwGroupings.View = System.Windows.Forms.View.Details;
            this.lvwGroupings.SelectedIndexChanged += new System.EventHandler(this.lvwGroupings_SelectedIndexChanged);
            // 
            // colGroupingsDuplicates
            // 
            this.colGroupingsDuplicates.Text = "Duplicates";
            this.colGroupingsDuplicates.Width = 90;
            // 
            // colGroupingsCount
            // 
            this.colGroupingsCount.Text = "Count";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.splitContainer1);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Location = new System.Drawing.Point(201, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(683, 473);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(3, 16);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lvwDuplicateFiles);
            this.splitContainer1.Panel1.Controls.Add(this.lblSelectFileToKeep);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lvwBadDirectories);
            this.splitContainer1.Panel2.Controls.Add(this.lblOptionalSelectDirectories);
            this.splitContainer1.Size = new System.Drawing.Size(677, 424);
            this.splitContainer1.SplitterDistance = 212;
            this.splitContainer1.TabIndex = 4;
            // 
            // lvwDuplicateFiles
            // 
            this.lvwDuplicateFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwDuplicateFiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colFileName});
            this.lvwDuplicateFiles.FullRowSelect = true;
            this.lvwDuplicateFiles.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvwDuplicateFiles.HideSelection = false;
            this.lvwDuplicateFiles.Location = new System.Drawing.Point(3, 16);
            this.lvwDuplicateFiles.MultiSelect = false;
            this.lvwDuplicateFiles.Name = "lvwDuplicateFiles";
            this.lvwDuplicateFiles.Size = new System.Drawing.Size(671, 193);
            this.lvwDuplicateFiles.TabIndex = 0;
            this.lvwDuplicateFiles.UseCompatibleStateImageBehavior = false;
            this.lvwDuplicateFiles.View = System.Windows.Forms.View.Details;
            this.lvwDuplicateFiles.SelectedIndexChanged += new System.EventHandler(this.lvwDuplicateFiles_SelectedIndexChanged);
            // 
            // colFileName
            // 
            this.colFileName.Text = "File name";
            this.colFileName.Width = 120;
            // 
            // lblSelectFileToKeep
            // 
            this.lblSelectFileToKeep.AutoSize = true;
            this.lblSelectFileToKeep.Location = new System.Drawing.Point(0, 0);
            this.lblSelectFileToKeep.Name = "lblSelectFileToKeep";
            this.lblSelectFileToKeep.Size = new System.Drawing.Size(92, 13);
            this.lblSelectFileToKeep.TabIndex = 2;
            this.lblSelectFileToKeep.Text = "Select file to keep";
            // 
            // lvwBadDirectories
            // 
            this.lvwBadDirectories.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwBadDirectories.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colBadDirsDirectory,
            this.colBadDirsCount});
            this.lvwBadDirectories.FullRowSelect = true;
            this.lvwBadDirectories.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvwBadDirectories.HideSelection = false;
            this.lvwBadDirectories.Location = new System.Drawing.Point(3, 16);
            this.lvwBadDirectories.Name = "lvwBadDirectories";
            this.lvwBadDirectories.Size = new System.Drawing.Size(671, 189);
            this.lvwBadDirectories.TabIndex = 3;
            this.lvwBadDirectories.UseCompatibleStateImageBehavior = false;
            this.lvwBadDirectories.View = System.Windows.Forms.View.Details;
            // 
            // colBadDirsDirectory
            // 
            this.colBadDirsDirectory.Text = "Directory";
            this.colBadDirsDirectory.Width = 120;
            // 
            // colBadDirsCount
            // 
            this.colBadDirsCount.Text = "Count";
            // 
            // lblOptionalSelectDirectories
            // 
            this.lblOptionalSelectDirectories.AutoSize = true;
            this.lblOptionalSelectDirectories.Location = new System.Drawing.Point(0, 0);
            this.lblOptionalSelectDirectories.Name = "lblOptionalSelectDirectories";
            this.lblOptionalSelectDirectories.Size = new System.Drawing.Size(264, 13);
            this.lblOptionalSelectDirectories.TabIndex = 4;
            this.lblOptionalSelectDirectories.Text = "Optional: Select directories to delete all duplicates from";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnRemoveDuplicates);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 440);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(677, 30);
            this.panel1.TabIndex = 5;
            // 
            // btnRemoveDuplicates
            // 
            this.btnRemoveDuplicates.Enabled = false;
            this.btnRemoveDuplicates.Location = new System.Drawing.Point(3, 3);
            this.btnRemoveDuplicates.Name = "btnRemoveDuplicates";
            this.btnRemoveDuplicates.Size = new System.Drawing.Size(120, 23);
            this.btnRemoveDuplicates.TabIndex = 1;
            this.btnRemoveDuplicates.Text = "&Delete Duplicates";
            this.btnRemoveDuplicates.UseVisualStyleBackColor = true;
            this.btnRemoveDuplicates.Click += new System.EventHandler(this.btnRemoveDuplicates_Click);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(809, 485);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "&Close";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // RemoveDuplicatesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 520);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lvwGroupings);
            this.Name = "RemoveDuplicatesForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Find and Delete Duplicate Files";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RemoveDuplicatesForm_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListView lvwGroupings;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label lblSelectFileToKeep;
		private System.Windows.Forms.Button btnRemoveDuplicates;
		private System.Windows.Forms.ListView lvwDuplicateFiles;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.ListView lvwBadDirectories;
		private System.Windows.Forms.Label lblOptionalSelectDirectories;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.ColumnHeader colBadDirsDirectory;
		private System.Windows.Forms.ColumnHeader colGroupingsDuplicates;
		private System.Windows.Forms.ColumnHeader colGroupingsCount;
		private System.Windows.Forms.ColumnHeader colFileName;
		private System.Windows.Forms.ColumnHeader colBadDirsCount;
	}
}