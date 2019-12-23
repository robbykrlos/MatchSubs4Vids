namespace ReToolNaming
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
            this.lStatus = new System.Windows.Forms.Label();
            this.pbProgres = new System.Windows.Forms.ProgressBar();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.lHelp = new System.Windows.Forms.Label();
            this.lvFilesLeft = new System.Windows.Forms.ListView();
            this.lvFilesRight = new System.Windows.Forms.ListView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbSpeed = new System.Windows.Forms.CheckBox();
            this.bClearMatching = new System.Windows.Forms.Button();
            this.tbRegex = new System.Windows.Forms.TextBox();
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
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lStatus);
            this.splitContainer1.Panel1.Controls.Add(this.pbProgres);
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            this.splitContainer1.Panel1.Controls.Add(this.menuStrip1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.cbSpeed);
            this.splitContainer1.Panel2.Controls.Add(this.bClearMatching);
            this.splitContainer1.Panel2.Controls.Add(this.tbRegex);
            this.splitContainer1.Panel2.Controls.Add(this.cbUseComplexRegex);
            this.splitContainer1.Panel2.Controls.Add(this.bAutoDetect);
            this.splitContainer1.Panel2.Controls.Add(this.bRenameFromRight);
            this.splitContainer1.Panel2.Controls.Add(this.bRenameFromLeft);
            this.splitContainer1.Panel2.Controls.Add(this.bMatch);
            this.splitContainer1.Panel2.Controls.Add(this.bFilterRight);
            this.splitContainer1.Panel2.Controls.Add(this.bFilterLeft);
            this.splitContainer1.Panel2.Controls.Add(this.tbSearchPatternRight);
            this.splitContainer1.Panel2.Controls.Add(this.tbSearchPatternLeft);
            this.splitContainer1.Size = new System.Drawing.Size(1316, 653);
            this.splitContainer1.SplitterDistance = 620;
            this.splitContainer1.TabIndex = 0;
            this.splitContainer1.TabStop = false;
            // 
            // lStatus
            // 
            this.lStatus.AutoSize = true;
            this.lStatus.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lStatus.ForeColor = System.Drawing.Color.DarkRed;
            this.lStatus.Location = new System.Drawing.Point(134, 3);
            this.lStatus.Name = "lStatus";
            this.lStatus.Size = new System.Drawing.Size(661, 15);
            this.lStatus.TabIndex = 5;
            this.lStatus.Text = "Drag&&Drop below the folder you want to target, OR have the path copied in clipbo" +
                "ard (copy/paste) OR used F4 to select it.";
            // 
            // pbProgres
            // 
            this.pbProgres.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pbProgres.Location = new System.Drawing.Point(137, 3);
            this.pbProgres.Name = "pbProgres";
            this.pbProgres.Size = new System.Drawing.Size(1167, 15);
            this.pbProgres.TabIndex = 4;
            this.pbProgres.Visible = false;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 24);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.lHelp);
            this.splitContainer2.Panel1.Controls.Add(this.lvFilesLeft);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.lvFilesRight);
            this.splitContainer2.Size = new System.Drawing.Size(1316, 596);
            this.splitContainer2.SplitterDistance = 655;
            this.splitContainer2.TabIndex = 0;
            this.splitContainer2.TabStop = false;
            // 
            // lHelp
            // 
            this.lHelp.AutoSize = true;
            this.lHelp.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lHelp.Location = new System.Drawing.Point(0, 356);
            this.lHelp.Name = "lHelp";
            this.lHelp.Size = new System.Drawing.Size(650, 240);
            this.lHelp.TabIndex = 4;
            this.lHelp.Text = resources.GetString("lHelp.Text");
            this.lHelp.Click += new System.EventHandler(this.lHelp_Click);
            // 
            // lvFilesLeft
            // 
            this.lvFilesLeft.AllowDrop = true;
            this.lvFilesLeft.CheckBoxes = true;
            this.lvFilesLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvFilesLeft.Location = new System.Drawing.Point(0, 0);
            this.lvFilesLeft.MultiSelect = false;
            this.lvFilesLeft.Name = "lvFilesLeft";
            this.lvFilesLeft.Size = new System.Drawing.Size(655, 596);
            this.lvFilesLeft.TabIndex = 2;
            this.lvFilesLeft.UseCompatibleStateImageBehavior = false;
            this.lvFilesLeft.View = System.Windows.Forms.View.Details;
            this.lvFilesLeft.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.lvFilesLeft_ItemChecked);
            this.lvFilesLeft.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.lvFilesLeft.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            // 
            // lvFilesRight
            // 
            this.lvFilesRight.AllowDrop = true;
            this.lvFilesRight.CheckBoxes = true;
            this.lvFilesRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvFilesRight.Location = new System.Drawing.Point(0, 0);
            this.lvFilesRight.MultiSelect = false;
            this.lvFilesRight.Name = "lvFilesRight";
            this.lvFilesRight.Size = new System.Drawing.Size(657, 596);
            this.lvFilesRight.TabIndex = 3;
            this.lvFilesRight.UseCompatibleStateImageBehavior = false;
            this.lvFilesRight.View = System.Windows.Forms.View.Details;
            this.lvFilesRight.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.lvFilesRight_ItemChecked);
            this.lvFilesRight.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.lvFilesRight.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.aboutToolStripMenuItem});
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
            // cbSpeed
            // 
            this.cbSpeed.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cbSpeed.AutoSize = true;
            this.cbSpeed.Checked = true;
            this.cbSpeed.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbSpeed.Location = new System.Drawing.Point(362, 8);
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
            this.bClearMatching.Location = new System.Drawing.Point(413, 4);
            this.bClearMatching.Name = "bClearMatching";
            this.bClearMatching.Size = new System.Drawing.Size(110, 23);
            this.bClearMatching.TabIndex = 9;
            this.bClearMatching.TabStop = false;
            this.bClearMatching.Text = "Clear mathcing (F8)";
            this.bClearMatching.UseVisualStyleBackColor = true;
            this.bClearMatching.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbRegex
            // 
            this.tbRegex.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tbRegex.Location = new System.Drawing.Point(804, 5);
            this.tbRegex.Name = "tbRegex";
            this.tbRegex.Size = new System.Drawing.Size(239, 20);
            this.tbRegex.TabIndex = 8;
            this.tbRegex.TabStop = false;
            this.tbRegex.Text = "S\\d+.E\\d+";
            // 
            // cbUseComplexRegex
            // 
            this.cbUseComplexRegex.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cbUseComplexRegex.AutoSize = true;
            this.cbUseComplexRegex.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbUseComplexRegex.Checked = true;
            this.cbUseComplexRegex.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbUseComplexRegex.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbUseComplexRegex.Location = new System.Drawing.Point(749, 7);
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
            this.bAutoDetect.Location = new System.Drawing.Point(632, 4);
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
            this.bRenameFromRight.Location = new System.Drawing.Point(1049, 4);
            this.bRenameFromRight.Name = "bRenameFromRight";
            this.bRenameFromRight.Size = new System.Drawing.Size(128, 23);
            this.bRenameFromRight.TabIndex = 6;
            this.bRenameFromRight.TabStop = false;
            this.bRenameFromRight.Text = "C + S + <- Rename";
            this.bRenameFromRight.UseVisualStyleBackColor = true;
            this.bRenameFromRight.Click += new System.EventHandler(this.bRenameFromRight_Click);
            // 
            // bRenameFromLeft
            // 
            this.bRenameFromLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bRenameFromLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bRenameFromLeft.Location = new System.Drawing.Point(137, 4);
            this.bRenameFromLeft.Name = "bRenameFromLeft";
            this.bRenameFromLeft.Size = new System.Drawing.Size(219, 23);
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
            this.bMatch.Location = new System.Drawing.Point(529, 4);
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
            this.bFilterRight.Location = new System.Drawing.Point(1183, 6);
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
            this.bFilterLeft.Location = new System.Drawing.Point(56, 4);
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
            this.tbSearchPatternRight.Location = new System.Drawing.Point(1262, 6);
            this.tbSearchPatternRight.Name = "tbSearchPatternRight";
            this.tbSearchPatternRight.Size = new System.Drawing.Size(54, 20);
            this.tbSearchPatternRight.TabIndex = 1;
            this.tbSearchPatternRight.TabStop = false;
            this.tbSearchPatternRight.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbSearchPatternRight_KeyUp);
            // 
            // tbSearchPatternLeft
            // 
            this.tbSearchPatternLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbSearchPatternLeft.Location = new System.Drawing.Point(3, 6);
            this.tbSearchPatternLeft.Name = "tbSearchPatternLeft";
            this.tbSearchPatternLeft.Size = new System.Drawing.Size(50, 20);
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
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(1316, 628);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(1316, 653);
            this.toolStripContainer1.TabIndex = 1;
            this.toolStripContainer1.TabStop = false;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1316, 653);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStripContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "ReToolNaming";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        public System.Windows.Forms.TextBox tbRegex;
        private System.Windows.Forms.Button bClearMatching;
        private System.Windows.Forms.ProgressBar pbProgres;
        private System.Windows.Forms.Label lStatus;
        private System.Windows.Forms.CheckBox cbSpeed;
        private System.Windows.Forms.Label lHelp;
    }
}

