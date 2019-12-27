using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using Classes;

namespace MatchSubs4Vids
{
    public partial class MainForm : Form
    {
        private readonly RenameUtils renameUtils;
        private readonly ConsoleLogForm consoleLogForm;
        
        private bool pathViaAppParams = false;

        public MainForm(string path)
        {
            InitializeComponent();

            consoleLogForm = new ConsoleLogForm(this)
            {
                StartPosition = FormStartPosition.CenterParent
            };
            consoleLogForm.Hide();

            //Handle version title.
            string LongVersion = Assembly.GetExecutingAssembly().GetName().Version.ToString();
            string VersionNumber = LongVersion.Substring(0, LongVersion.Length-2);
            Text = "MatchSubs4Vids (v" + VersionNumber + ")";

            renameUtils = new RenameUtils();
            renameUtils.InitializeUtils() ;
            renameUtils.LoadFilters(tbSearchPatternLeft, tbSearchPatternRight);
            renameUtils.LoadRegexesIntoComboBox(cbRegexes);

            if (path.Length > 0 && Directory.Exists(path))
            {
                DisplayStatus("Directory from startup parameter /path exists - " + path + " - preloading data", false);
                this.pathViaAppParams = true;
                folderBrowserDialog1.SelectedPath = path;
                LoadTargetDirectory(true);
            }
        }

        private void StartAutomaticDownloadSubtitles()
        {
            pbProgress.Value = 0;
            consoleLogForm.lConsoleLog.Text = "Wait. Procesing...";
            consoleLogForm.Show();

            //correction on ConsoleLogForm placement.
            int x = this.DesktopBounds.Left + (this.Width - consoleLogForm.Width) / 2;
            int y = this.DesktopBounds.Top + (this.Height - consoleLogForm.Height) / 2;
            consoleLogForm.SetDesktopLocation(x, y);

            bgWorker.RunWorkerAsync();
        }

        private void bgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            string[] args = new string[4];

            args[0] = folderBrowserDialog1.SelectedPath.ToString();
            args[1] = Properties.Settings.Default.OPEN_SUBTITLES_DOWNLOAD_LANGUAGES;
            args[2] = Properties.Settings.Default.OPEN_SUBTITLES_USERNAME;
            args[3] = Properties.Settings.Default.OPEN_SUBTITLES_PASSWORD;

            e.Result = AutoSubtitleDownloader.ASD.Start(args) + "\r\nPres SPACE / ESC / ENTER to close this message";
        }

        private void bgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            consoleLogForm.lConsoleLog.Text = e.Result.ToString();
            
            consoleLogForm.lConsoleLog.SelectionStart = consoleLogForm.lConsoleLog.TextLength;
            consoleLogForm.lConsoleLog.ScrollToCaret();

            pbProgress.Value = 100;
            bFilterRight.PerformClick();
        }

        private void bgWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            pbProgress.Value++;
        }

        private void LoadTargetDirectory(bool autoDetetect)
        {
            RenameUtils.PopulateFiles(lvFilesLeft, tbSearchPatternLeft.Text, folderBrowserDialog1);
            RenameUtils.PopulateFiles(lvFilesRight, tbSearchPatternRight.Text, folderBrowserDialog1);
            LogUtils.AddLogTextLine("Populating form with content from path: " + RenameUtils.GetFullPath(folderBrowserDialog1).ToString());
            if(autoDetetect) AutoDetectAutoMatchListViews();
        }

        private void DisplayStatus(string message, bool append)
        {
            lStatus.Text = append ? (!lStatus.Text.Contains(message) ? lStatus.Text + message : lStatus.Text) : message;
        }
      
        private void MainForm_Load(object sender, EventArgs e)
        {
            LogUtils.AddLogTextLine("Application opened.");
            LoadTargetDirectory(false);
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
            LogUtils.AddLogTextLine("Manually matched files");
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

        private void bDeepDetect_Click(object sender, EventArgs e)
        {
            DeepDetectAutoMatchListViews();
        }

        private void AutoDetectAutoMatchListViews()
        {
            string regex = cbRegexes.SelectedValue == null ? cbRegexes.Text : cbRegexes.SelectedValue.ToString();
            int autoMatchResult = renameUtils.AutoMatchListViews(lvFilesLeft, lvFilesRight, pbProgress, cbUseComplexRegex.Checked, regex, cbSpeed.Checked, cbAutoClear.Checked);
            lStatus.Text = "Auto Matched " + autoMatchResult.ToString() + " sub-vid pairs. ";
            if (autoMatchResult == lvFilesLeft.Items.Count || autoMatchResult == lvFilesRight.Items.Count)
            {
                lStatus.Text += "FULL MATCH! ";
            }
            lHelp.Hide();
            //pbProgress.Value = 0;
        }

        private void DeepDetectAutoMatchListViews()
        {
            int deepMatchResult = renameUtils.DeepMatchListViews(lvFilesLeft, lvFilesRight, pbProgress, cbRegexes);
            lStatus.Text = "Deep Matched " + deepMatchResult.ToString() + " sub-vid pairs. ";
            if (deepMatchResult == lvFilesLeft.Items.Count || deepMatchResult == lvFilesRight.Items.Count)
            {
                lStatus.Text += "FULL MATCH! ";
            }
            lHelp.Hide();
            //pbProgress.Value = 0;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            LoadTargetDirectory(true);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About aboutBox = new About();
            aboutBox.ShowDialog();
            aboutBox.Dispose();
        }

        private void cbUseComplexRegex_CheckedChanged(object sender, EventArgs e)
        {
            cbRegexes.Enabled = cbUseComplexRegex.Checked;
        }

        private void bClearMatching_Click(object sender, EventArgs e)//Clear matches.
        {
            RenameUtils.ClearMathingLeftRight(lvFilesLeft, lvFilesRight);
        }

        private void lvFilesLeft_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            RenameUtils.BehaveLikeRadioCheckBox(lvFilesLeft, e.Item);
        }

        private void lvFilesRight_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            RenameUtils.BehaveLikeRadioCheckBox(lvFilesRight, e.Item);
        }

        private void MainForm_DragDrop(object sender, DragEventArgs e)
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
                    LogUtils.AddLogTextLine("Populating form with content from path: " + RenameUtils.GetFullPath(folderBrowserDialog1).ToString());
                    break;
                }
            }
            
        }

        private void MainForm_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false) == true)
            {
                e.Effect = DragDropEffects.All;
            }  
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            LogUtils.AddLogTextLine("Application closed.");
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            //handle global key shortcuts
            if (e.KeyCode == Keys.F1)
            {
                AutoDetectAutoMatchListViews();
            }

            if (e.KeyCode == Keys.F2)
            {
                DeepDetectAutoMatchListViews();
            }

            if (e.KeyCode == Keys.F4)
            {
                folderBrowserDialog1.ShowDialog();
                LoadTargetDirectory(true);
            }

            if (e.KeyCode == Keys.F5)
            {
                bFilterLeft.PerformClick();
                bFilterRight.PerformClick();
            }

            if (e.KeyCode == Keys.F8)
            {
                RenameUtils.ClearMathingLeftRight(lvFilesLeft, lvFilesRight);
            }

            if (e.KeyCode == Keys.F12)
            {
                StartAutomaticDownloadSubtitles();
            }

            if (e.KeyCode == Keys.Enter)
            {
                    Match();
            }

            if (e.KeyCode == Keys.Add)
            {
                cbRegexes.SelectedIndex = cbRegexes.SelectedIndex < cbRegexes.Items.Count - 1 ? cbRegexes.SelectedIndex + 1 : 0;
            }

            if (e.KeyCode == Keys.Subtract)
            {
                cbRegexes.SelectedIndex = cbRegexes.SelectedIndex > 0 ? cbRegexes.SelectedIndex - 1 : cbRegexes.Items.Count - 1;
            }

            if (e.KeyCode == Keys.Multiply)
            {
                cbUseComplexRegex.Checked = !cbUseComplexRegex.Checked;
            }

            if (e.KeyCode == Keys.Divide)
            {
                cbAutoClear.Checked = !cbAutoClear.Checked;
            }
        }

        private void MainForm_Activated(object sender, EventArgs e)
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
                    LoadTargetDirectory(true);
                }
            }
            else
            {
                DisplayStatus("  Clipboard text is not a path.", true);
            }
        }

        private void lHelp_Click(object sender, EventArgs e)
        {
            lHelp.Hide();
        }

        private void tbSearchPatternLeft_KeyUp(object sender, KeyEventArgs e)
        {
            bFilterLeft.PerformClick();
        }

        private void tbSearchPatternRight_KeyUp(object sender, KeyEventArgs e)
        {
            bFilterRight.PerformClick();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lHelp.Show();
        }

        private void bASD_Click(object sender, EventArgs e)
        {
            StartAutomaticDownloadSubtitles();
        }

        private void MainForm_Click(object sender, EventArgs e)
        {
            if (consoleLogForm.Visible) consoleLogForm.Hide();
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            splitContainer1.SplitterDistance = Size.Height - 140;
        }
    }
}
