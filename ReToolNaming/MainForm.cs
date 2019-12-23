using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Collections;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Management;
using System.Globalization;
using System.IO;
using ReToolNaming.Classes;

namespace ReToolNaming
{
    public partial class MainForm : Form
    {
        private RenameUtils renameUtils;
        private bool pathViaAppParams = false;
        
        public MainForm(string path)
        {
            InitializeComponent();
            renameUtils = new RenameUtils();
            renameUtils.InitializeUtils() ;
            tbSearchPatternLeft.Text = "*.avi|*.mkv|*.mp4|*.m2ts";
            tbSearchPatternRight.Text = "*.srt|*.sub|*.str";
            lvFilesLeft.AllowDrop = true;
            lvFilesRight.AllowDrop = true;
            if (path.Length > 0 && Directory.Exists(path))
            {
                DisplayStatus("Directory from startup parameter /path exists - " + path + " - preloading data", false);
                this.pathViaAppParams = true;
                folderBrowserDialog1.SelectedPath = path;
                LoadTargetDirectory();
            }
        }

        private void LoadTargetDirectory()
        {
            RenameUtils.PopulateFiles(lvFilesLeft, tbSearchPatternLeft.Text, folderBrowserDialog1);
            RenameUtils.PopulateFiles(lvFilesRight, tbSearchPatternRight.Text, folderBrowserDialog1);
            log.addLogTextLine("Populating form with content from path: " + RenameUtils.getFullPath(folderBrowserDialog1).ToString());
            AutoDetectAutoMatchListViews();
        }

        private void DisplayStatus(string message, bool append)
        {
            lStatus.Text = append ? (!lStatus.Text.Contains(message) ? lStatus.Text + message : lStatus.Text) : message;
        }
      
        private void Form1_Load(object sender, EventArgs e)
        {
            log.addLogTextLine("Application opened.");
            LoadTargetDirectory();
        }

        private void bFilterLeft_Click(object sender, EventArgs e)
        {
            RenameUtils.PopulateFiles(lvFilesLeft, tbSearchPatternLeft.Text, folderBrowserDialog1);
        }

        private void bFilterRight_Click(object sender, EventArgs e)
        {
            RenameUtils.PopulateFiles(lvFilesRight, tbSearchPatternRight.Text, folderBrowserDialog1);
        }

        private void bMatch_Click(object sender, EventArgs e)
        {
            Match();
        }

        private void Match()
        {
            renameUtils.MatchLeftRight(lvFilesLeft, lvFilesRight);
            log.addLogTextLine("Manually matched files");
        }

        private void bRenameFromLeft_Click(object sender, EventArgs e)
        {
            renameUtils.Rename(RenameUtils.DIRECTION_LEFT, lvFilesLeft, lvFilesRight, folderBrowserDialog1, tbSearchPatternLeft.Text, tbSearchPatternRight.Text);
        }

        private void bRenameFromRight_Click(object sender, EventArgs e)
        {
            renameUtils.Rename(RenameUtils.DIRECTION_RIGHT, lvFilesLeft, lvFilesRight, folderBrowserDialog1, tbSearchPatternLeft.Text, tbSearchPatternRight.Text);
        }

        private void bAutoDetect_Click(object sender, EventArgs e)
        {
            AutoDetectAutoMatchListViews();
        }

        private void AutoDetectAutoMatchListViews()
        {
            renameUtils.AutoMatchListViews(lvFilesLeft, lvFilesRight, pbProgres, cbUseComplexRegex.Checked, tbRegex.Text.ToString(), cbSpeed.Checked);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            LoadTargetDirectory();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 aboutBox = new AboutBox1();
            aboutBox.ShowDialog();
            aboutBox.Dispose();
        }

        private void cbUseComplexRegex_CheckedChanged(object sender, EventArgs e)
        {
            tbRegex.Enabled = cbUseComplexRegex.Checked;
        }

        private void button1_Click(object sender, EventArgs e)//Clear matches.
        {
            RenameUtils.ClearMathingLeftRight(lvFilesLeft, lvFilesRight);
        }

        private void lvFilesLeft_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            RenameUtils.BehaveLikeRadioCheckBox(lvFilesLeft, e.Item, lvFilesLeft_ItemChecked);
        }

        private void lvFilesRight_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            RenameUtils.BehaveLikeRadioCheckBox(lvFilesRight, e.Item, lvFilesRight_ItemChecked);
        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

            foreach (string file in files)
            {
                bool flagPass = false;
                if (Directory.Exists(file.ToString()))
                {
                    folderBrowserDialog1.SelectedPath = file.ToString();
                    flagPass = true;
                }
                if (File.Exists(file.ToString()))
                {
                    FileInfo ddFile = new FileInfo(file.ToString());
                    folderBrowserDialog1.SelectedPath = ddFile.Directory.FullName.ToString();
                    flagPass = true;
                }
                if (flagPass)
                {
                    RenameUtils.PopulateFiles(lvFilesLeft, tbSearchPatternLeft.Text, folderBrowserDialog1);
                    RenameUtils.PopulateFiles(lvFilesRight, tbSearchPatternRight.Text, folderBrowserDialog1);
                    log.addLogTextLine("Populating form with content from path: " + RenameUtils.getFullPath(folderBrowserDialog1).ToString());
                    break;
                }
            }
            
        }

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false) == true)
            {
                e.Effect = DragDropEffects.All;
            }  
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            log.addLogTextLine("Application closed.");
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F4)
            {
                folderBrowserDialog1.ShowDialog();
                LoadTargetDirectory();
            }

            if (e.KeyCode == Keys.F1)
            {
                AutoDetectAutoMatchListViews();
            }

            if (e.KeyCode == Keys.F2)
            {
                AutoDetectAutoMatchListViews();
            }

            if (e.KeyCode == Keys.F8)
            {
                RenameUtils.ClearMathingLeftRight(lvFilesLeft, lvFilesRight);
            }

            if (e.KeyCode == Keys.Enter)
            {
                    Match();
            }
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            if (this.pathViaAppParams)
            {
                this.pathViaAppParams = false;
                return;
            }

            string clipboardText = Clipboard.GetText();

            if (Directory.Exists(clipboardText))
            {
                if (folderBrowserDialog1.SelectedPath != clipboardText)
                {
                    DisplayStatus("Directory from clipboard exists - " + clipboardText + " - preloading data", false);
                    folderBrowserDialog1.SelectedPath = clipboardText;
                    LoadTargetDirectory();
                }
            }
            else
            {
                DisplayStatus("  Clipboard text is not a path.", true);
            }
        }

        private void lHelp_Click(object sender, EventArgs e)
        {
            lHelp.Text = "";
        }

        private void tbSearchPatternLeft_KeyUp(object sender, KeyEventArgs e)
        {
            bFilterLeft.PerformClick();
        }

        private void tbSearchPatternRight_KeyUp(object sender, KeyEventArgs e)
        {
            bFilterRight.PerformClick();
        }

        
    }
}
