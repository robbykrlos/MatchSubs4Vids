namespace MatchSubs4Vids
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.bASD = new System.Windows.Forms.Button();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.lvFilesLeft = new System.Windows.Forms.ListView();
            this.lHelp = new System.Windows.Forms.Label();
            this.lvFilesRight = new System.Windows.Forms.ListView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.pbProgress = new System.Windows.Forms.ToolStripProgressBar();
            this.cbRegexes = new System.Windows.Forms.ComboBox();
            this.cbSpeed = new System.Windows.Forms.CheckBox();
            this.bClearMatching = new System.Windows.Forms.Button();
            this.cbUseComplexRegex = new System.Windows.Forms.CheckBox();
            this.bAutoDetect = new System.Windows.Forms.Button();
            this.bRenameFromRight = new System.Windows.Forms.Button();
            this.bRenameFromLeft = new System.Windows.Forms.Button();
            this.bMatch = new System.Windows.Forms.Button();
            this.bFilterRight = new System.Windows.Forms.Button();
            this.bFilterLeft = new System.Windows.Forms.Button();
            this.tbSearchPatternRight = new System.Windows.Forms.TextBox();
            this.tbSearchPatternLeft = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.bgWorker = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.bASD);
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            this.splitContainer1.Panel1.Controls.Add(this.menuStrip1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.splitContainer1.Panel2.Controls.Add(this.statusStrip1);
            this.splitContainer1.Panel2.Controls.Add(this.cbRegexes);
            this.splitContainer1.Panel2.Controls.Add(this.cbSpeed);
            this.splitContainer1.Panel2.Controls.Add(this.bClearMatching);
            this.splitContainer1.Panel2.Controls.Add(this.cbUseComplexRegex);
            this.splitContainer1.Panel2.Controls.Add(this.bAutoDetect);
            this.splitContainer1.Panel2.Controls.Add(this.bRenameFromRight);
            this.splitContainer1.Panel2.Controls.Add(this.bRenameFromLeft);
            this.splitContainer1.Panel2.Controls.Add(this.bMatch);
            this.splitContainer1.Panel2.Controls.Add(this.bFilterRight);
            this.splitContainer1.Panel2.Controls.Add(this.bFilterLeft);
            this.splitContainer1.Panel2.Controls.Add(this.tbSearchPatternRight);
            this.splitContainer1.Panel2.Controls.Add(this.tbSearchPatternLeft);
            this.splitContainer1.Size = new System.Drawing.Size(1316, 700);
            this.splitContainer1.SplitterDistance = 600;
            this.splitContainer1.TabIndex = 0;
            this.splitContainer1.TabStop = false;
            // 
            // bASD
            // 
            this.bASD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bASD.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bASD.ForeColor = System.Drawing.Color.OrangeRed;
            this.bASD.Location = new System.Drawing.Point(1129, 0);
            this.bASD.Name = "bASD";
            this.bASD.Size = new System.Drawing.Size(187, 23);
            this.bASD.TabIndex = 13;
            this.bASD.TabStop = false;
            this.bASD.Text = "AutoDownloadSubtitles (F12)";
            this.bASD.UseVisualStyleBackColor = true;
            this.bASD.Click += new System.EventHandler(this.bASD_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 24);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.lvFilesLeft);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.lHelp);
            this.splitContainer2.Panel2.Controls.Add(this.lvFilesRight);
            this.splitContainer2.Size = new System.Drawing.Size(1316, 576);
            this.splitContainer2.SplitterDistance = 655;
            this.splitContainer2.TabIndex = 0;
            this.splitContainer2.TabStop = false;
            // 
            // lvFilesLeft
            // 
            this.lvFilesLeft.AllowDrop = true;
            this.lvFilesLeft.CheckBoxes = true;
            this.lvFilesLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvFilesLeft.HideSelection = false;
            this.lvFilesLeft.Location = new System.Drawing.Point(0, 0);
            this.lvFilesLeft.MultiSelect = false;
            this.lvFilesLeft.Name = "lvFilesLeft";
            this.lvFilesLeft.Size = new System.Drawing.Size(655, 576);
            this.lvFilesLeft.TabIndex = 2;
            this.lvFilesLeft.UseCompatibleStateImageBehavior = false;
            this.lvFilesLeft.View = System.Windows.Forms.View.Details;
            this.lvFilesLeft.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.lvFilesLeft_ItemChecked);
            this.lvFilesLeft.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainForm_DragDrop);
            this.lvFilesLeft.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainForm_DragEnter);
            // 
            // lHelp
            // 
            this.lHelp.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lHelp.AutoSize = true;
            this.lHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lHelp.Location = new System.Drawing.Point(15, 315);
            this.lHelp.Name = "lHelp";
            this.lHelp.Size = new System.Drawing.Size(538, 240);
            this.lHelp.TabIndex = 4;
            this.lHelp.Text = resources.GetString("lHelp.Text");
            this.lHelp.Click += new System.EventHandler(this.lHelp_Click);
            // 
            // lvFilesRight
            // 
            this.lvFilesRight.AllowDrop = true;
            this.lvFilesRight.CheckBoxes = true;
            this.lvFilesRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvFilesRight.HideSelection = false;
            this.lvFilesRight.Location = new System.Drawing.Point(0, 0);
            this.lvFilesRight.MultiSelect = false;
            this.lvFilesRight.Name = "lvFilesRight";
            this.lvFilesRight.Size = new System.Drawing.Size(657, 576);
            this.lvFilesRight.TabIndex = 3;
            this.lvFilesRight.UseCompatibleStateImageBehavior = false;
            this.lvFilesRight.View = System.Windows.Forms.View.Details;
            this.lvFilesRight.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.lvFilesRight_ItemChecked);
            this.lvFilesRight.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainForm_DragDrop);
            this.lvFilesRight.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainForm_DragEnter);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(1316, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.openToolStripMenuItem.Text = "&Open (F4)";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lStatus,
            this.pbProgress});
            this.statusStrip1.Location = new System.Drawing.Point(0, 74);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip1.Size = new System.Drawing.Size(1316, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 12;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lStatus
            // 
            this.lStatus.Name = "lStatus";
            this.lStatus.RightToLeftAutoMirrorImage = true;
            this.lStatus.Size = new System.Drawing.Size(1168, 17);
            this.lStatus.Spring = true;
            this.lStatus.Text = "Drag&&Drop below the folder you want to target, OR have the path copied in clipbo" +
    "ard (copy/paste) OR used F4 to select it.";
            this.lStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pbProgress
            // 
            this.pbProgress.Name = "pbProgress";
            this.pbProgress.Size = new System.Drawing.Size(100, 16);
            this.pbProgress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            // 
            // cbRegexes
            // 
            this.cbRegexes.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cbRegexes.FormattingEnabled = true;
            this.cbRegexes.Location = new System.Drawing.Point(501, 40);
            this.cbRegexes.Name = "cbRegexes";
            this.cbRegexes.Size = new System.Drawing.Size(326, 21);
            this.cbRegexes.TabIndex = 11;
            this.cbRegexes.TabStop = false;
            // 
            // cbSpeed
            // 
            this.cbSpeed.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cbSpeed.AutoSize = true;
            this.cbSpeed.Checked = true;
            this.cbSpeed.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbSpeed.Location = new System.Drawing.Point(441, 11);
            this.cbSpeed.Name = "cbSpeed";
            this.cbSpeed.Size = new System.Drawing.Size(46, 17);
            this.cbSpeed.TabIndex = 10;
            this.cbSpeed.TabStop = false;
            this.cbSpeed.Text = "Fast";
            this.cbSpeed.UseVisualStyleBackColor = true;
            // 
            // bClearMatching
            // 
            this.bClearMatching.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bClearMatching.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bClearMatching.ForeColor = System.Drawing.Color.DarkRed;
            this.bClearMatching.Location = new System.Drawing.Point(493, 7);
            this.bClearMatching.Name = "bClearMatching";
            this.bClearMatching.Size = new System.Drawing.Size(110, 23);
            this.bClearMatching.TabIndex = 9;
            this.bClearMatching.TabStop = false;
            this.bClearMatching.Text = "Clear mathcing (F8)";
            this.bClearMatching.UseVisualStyleBackColor = true;
            this.bClearMatching.Click += new System.EventHandler(this.bClearMatching_Click);
            // 
            // cbUseComplexRegex
            // 
            this.cbUseComplexRegex.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cbUseComplexRegex.AutoSize = true;
            this.cbUseComplexRegex.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbUseComplexRegex.Checked = true;
            this.cbUseComplexRegex.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbUseComplexRegex.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbUseComplexRegex.Location = new System.Drawing.Point(441, 41);
            this.cbUseComplexRegex.Name = "cbUseComplexRegex";
            this.cbUseComplexRegex.Size = new System.Drawing.Size(54, 17);
            this.cbUseComplexRegex.TabIndex = 7;
            this.cbUseComplexRegex.TabStop = false;
            this.cbUseComplexRegex.Text = "Regex";
            this.cbUseComplexRegex.UseVisualStyleBackColor = true;
            this.cbUseComplexRegex.CheckedChanged += new System.EventHandler(this.cbUseComplexRegex_CheckedChanged);
            // 
            // bAutoDetect
            // 
            this.bAutoDetect.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bAutoDetect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bAutoDetect.ForeColor = System.Drawing.Color.DarkGreen;
            this.bAutoDetect.Location = new System.Drawing.Point(712, 7);
            this.bAutoDetect.Name = "bAutoDetect";
            this.bAutoDetect.Size = new System.Drawing.Size(115, 23);
            this.bAutoDetect.TabIndex = 1;
            this.bAutoDetect.TabStop = false;
            this.bAutoDetect.Text = "Auto Detect (F1)";
            this.bAutoDetect.UseVisualStyleBackColor = true;
            this.bAutoDetect.Click += new System.EventHandler(this.bAutoDetect_Click);
            // 
            // bRenameFromRight
            // 
            this.bRenameFromRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bRenameFromRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bRenameFromRight.Location = new System.Drawing.Point(1084, 7);
            this.bRenameFromRight.Name = "bRenameFromRight";
            this.bRenameFromRight.Size = new System.Drawing.Size(220, 23);
            this.bRenameFromRight.TabIndex = 6;
            this.bRenameFromRight.TabStop = false;
            this.bRenameFromRight.Text = "<- Rename (CTRL + SHIFT + <-)";
            this.bRenameFromRight.UseVisualStyleBackColor = true;
            this.bRenameFromRight.Click += new System.EventHandler(this.bRenameFromRight_Click);
            // 
            // bRenameFromLeft
            // 
            this.bRenameFromLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bRenameFromLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bRenameFromLeft.Location = new System.Drawing.Point(12, 7);
            this.bRenameFromLeft.Name = "bRenameFromLeft";
            this.bRenameFromLeft.Size = new System.Drawing.Size(220, 23);
            this.bRenameFromLeft.TabIndex = 5;
            this.bRenameFromLeft.TabStop = false;
            this.bRenameFromLeft.Text = "Rename -> (CTRL + SHIFT + ->)";
            this.bRenameFromLeft.UseVisualStyleBackColor = true;
            this.bRenameFromLeft.Click += new System.EventHandler(this.bRenameFromLeft_Click);
            // 
            // bMatch
            // 
            this.bMatch.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bMatch.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.bMatch.Location = new System.Drawing.Point(609, 7);
            this.bMatch.Name = "bMatch";
            this.bMatch.Size = new System.Drawing.Size(97, 23);
            this.bMatch.TabIndex = 4;
            this.bMatch.TabStop = false;
            this.bMatch.Text = "&Match (ENTER)";
            this.bMatch.UseVisualStyleBackColor = true;
            this.bMatch.Click += new System.EventHandler(this.bMatch_Click);
            // 
            // bFilterRight
            // 
            this.bFilterRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bFilterRight.Location = new System.Drawing.Point(991, 38);
            this.bFilterRight.Name = "bFilterRight";
            this.bFilterRight.Size = new System.Drawing.Size(75, 23);
            this.bFilterRight.TabIndex = 3;
            this.bFilterRight.TabStop = false;
            this.bFilterRight.Text = "Filter right";
            this.bFilterRight.UseVisualStyleBackColor = true;
            this.bFilterRight.Click += new System.EventHandler(this.bFilterRight_Click);
            // 
            // bFilterLeft
            // 
            this.bFilterLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bFilterLeft.Location = new System.Drawing.Point(247, 38);
            this.bFilterLeft.Name = "bFilterLeft";
            this.bFilterLeft.Size = new System.Drawing.Size(75, 23);
            this.bFilterLeft.TabIndex = 2;
            this.bFilterLeft.TabStop = false;
            this.bFilterLeft.Text = "Filter left";
            this.bFilterLeft.UseVisualStyleBackColor = true;
            this.bFilterLeft.Click += new System.EventHandler(this.bFilterLeft_Click);
            // 
            // tbSearchPatternRight
            // 
            this.tbSearchPatternRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSearchPatternRight.Location = new System.Drawing.Point(1072, 40);
            this.tbSearchPatternRight.Name = "tbSearchPatternRight";
            this.tbSearchPatternRight.Size = new System.Drawing.Size(232, 20);
            this.tbSearchPatternRight.TabIndex = 1;
            this.tbSearchPatternRight.TabStop = false;
            this.tbSearchPatternRight.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbSearchPatternRight_KeyUp);
            // 
            // tbSearchPatternLeft
            // 
            this.tbSearchPatternLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbSearchPatternLeft.Location = new System.Drawing.Point(12, 40);
            this.tbSearchPatternLeft.Name = "tbSearchPatternLeft";
            this.tbSearchPatternLeft.Size = new System.Drawing.Size(229, 20);
            this.tbSearchPatternLeft.TabIndex = 0;
            this.tbSearchPatternLeft.TabStop = false;
            this.tbSearchPatternLeft.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbSearchPatternLeft_KeyUp);
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.RootFolder = System.Environment.SpecialFolder.MyComputer;
            this.folderBrowserDialog1.ShowNewFolderButton = false;
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(1316, 675);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(1316, 700);
            this.toolStripContainer1.TabIndex = 1;
            this.toolStripContainer1.TabStop = false;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // bgWorker
            // 
            this.bgWorker.WorkerReportsProgress = true;
            this.bgWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgWorker_DoWork);
            this.bgWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgWorker_ProgressChanged);
            this.bgWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgWorker_RunWorkerCompleted);
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1316, 700);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStripContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MatchSubs4Vids";
            this.Activated += new System.EventHandler(this.MainForm_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Click += new System.EventHandler(this.MainForm_Click);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainForm_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainForm_DragEnter);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ListView lvFilesLeft;
        private System.Windows.Forms.ListView lvFilesRight;
        private System.Windows.Forms.TextBox tbSearchPatternRight;
        private System.Windows.Forms.TextBox tbSearchPatternLeft;
        private System.Windows.Forms.Button bFilterRight;
        private System.Windows.Forms.Button bFilterLeft;
        private System.Windows.Forms.Button bMatch;
        private System.Windows.Forms.Button bRenameFromRight;
        private System.Windows.Forms.Button bRenameFromLeft;
        private System.Windows.Forms.Button bAutoDetect;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.CheckBox cbUseComplexRegex;
        private System.Windows.Forms.Button bClearMatching;
        private System.Windows.Forms.CheckBox cbSpeed;
        private System.Windows.Forms.Label lHelp;
        private System.Windows.Forms.ComboBox cbRegexes;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lStatus;
        private System.Windows.Forms.Button bASD;
        protected System.ComponentModel.BackgroundWorker bgWorker;
        public System.Windows.Forms.ToolStripProgressBar pbProgress;
    }
}

