using MatchSubs4Vids.Properties;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Classes
{
    public class RenameUtils
    {
        public const string DIRECTION_LEFT = "left";
        public const string DIRECTION_RIGHT = "right";

        private List<string> ListColors;
        private int indexMatch;

        public void SetIndexMatch(int indexMatch)
        {
            this.indexMatch = indexMatch;
        }

        public int GetIndexMatch()
        {
            return this.indexMatch;
        }

        protected void SetListColors(List<string> ListColors)
        {
            this.ListColors = ListColors;
        }

        protected List<string> GetListColors()
        {
            return this.ListColors;
        }

        internal void LoadRegexesIntoComboBox(ComboBox cbRegexes)
        { 
            cbRegexes.DisplayMember = "Text";
            cbRegexes.ValueMember = "Value";

            var items = new[] {
                new { Text =  "Used for S12E34 or s1e34 formats. ([sS]\\d{1,2}.[eE]\\d{1,2})", Value ="[sS]\\d{1,2}.[eE]\\d{1,2}"},
                new { Text = "Used for .1234. or .123. formats. (\\.\\d{3,4}\\.)", Value = "\\.\\d{3,4}\\." },
                new { Text = "Used for 12x34 or 1x23 formats. (\\d{1,2}[xX]\\d{1,2})", Value = "\\d{1,2}[xX]\\d{1,2}" }
            };


            cbRegexes.DataSource = items;
            cbRegexes.SelectedIndex = 0;
        }

        internal void LoadFilters(TextBox tbLeft, TextBox tbRight)
        {
            tbLeft.Text = "*.avi|*.mkv|*.mp4|*.m2ts";
            tbRight.Text = "*.srt|*.sub|*.str";
        }

        public void InitializeUtils()
        {
            this.ListColors = GetColors();
            this.indexMatch = 1;
        }

        public static void InitListView(ListView lvFiles)
        {
            //init ListView control
            lvFiles.Clear(); //clear control

            //create column header for ListView
            lvFiles.Columns.Add(Resources.TextUI_Name, 400);
            lvFiles.Columns.Add(Resources.TextUI_Size, 100);
            lvFiles.Columns.Add(Resources.TextUI_Modified, 100);
            lvFiles.Columns.Add(Resources.TextUI_Matching, 50);
        }

        private static string FormatDate(DateTime dtDate)
        {
            //Get date and time in short format
            string stringDate = dtDate.ToShortDateString().ToString() + " " + dtDate.ToShortTimeString().ToString();
            return stringDate;
        }

        private static string FormatSize(Int64 lSize)
        {
            NumberFormatInfo myNfi = new NumberFormatInfo();

            //Format number to KB
            string stringSize;
            if (lSize < 1024)
            {
                if (lSize == 0)
                {
                    //zero byte
                    stringSize = "0";
                }
                else
                {
                    //less than 1K but not zero byte
                    stringSize = "1";
                }
            }
            else
            {
                //convert to KB
                long lKBSize = lSize / 1024;
                //format number with default format
                stringSize = lKBSize.ToString("n", myNfi);
                //remove decimal
                stringSize = stringSize.Replace(".00", "");
            }
            return stringSize + " KB";
        }

        public static string GetPathName(string stringPath)
        {
            //Get Name of folder
            string[] stringSplit = stringPath.Split('\\');
            int _maxIndex = stringSplit.Length;
            return stringSplit[_maxIndex - 1];
        }

        public static string GetFullPath(FolderBrowserDialog folderBrowserDialog)
        {
            if (folderBrowserDialog.SelectedPath.ToString() == "")
                return Directory.GetCurrentDirectory();
            else return folderBrowserDialog.SelectedPath.ToString();
        }


        public static string[] GetFiles(string SourceFolder, string Filter, SearchOption searchOption)
        {
            // ArrayList will hold all file names
            ArrayList alFiles = new ArrayList();

            // Create an array of filter string
            string[] MultipleFilters = Filter.Split('|');

            // for each filter find mathing file names
            foreach (string FileFilter in MultipleFilters)
            {
                // add found file names to array list
                alFiles.AddRange(Directory.GetFiles(SourceFolder, FileFilter, searchOption));
            }

            // returns string array of relevant file names
            return (string[])alFiles.ToArray(typeof(string));
        }

        public static void PopulateFiles(ListView lvFiles, string searchPattern, FolderBrowserDialog folderBrowserDialog)
        {
            //Populate listview with files
            string[] lvData = new string[4];

            //clear list
            InitListView(lvFiles);

            //check path
            if (Directory.Exists((string)GetFullPath(folderBrowserDialog)) == false)
            {
                MessageBox.Show(Resources.TextUI_DirectoryDoesNotExist);
            }
            else
            {
                try
                {
                    string[] stringFiles = GetFiles(GetFullPath(folderBrowserDialog), searchPattern, SearchOption.TopDirectoryOnly);
                    string stringFileName = "";
                    DateTime dtModifyDate;
                    Int64 lFileSize = 0;

                    //loop throught all files
                    foreach (string stringFile in stringFiles)
                    {
                        stringFileName = stringFile;
                        FileInfo objFileSize = new FileInfo(stringFileName);
                        lFileSize = objFileSize.Length;
                        dtModifyDate = objFileSize.LastWriteTime; //GetLastWriteTime(stringFileName);

                        //create listview data
                        lvData[0] = RenameUtils.GetPathName(stringFileName);
                        lvData[1] = RenameUtils.FormatSize(lFileSize);

                        //check if file is in local current day light saving time
                        if (TimeZone.CurrentTimeZone.IsDaylightSavingTime(dtModifyDate) == false)
                        {
                            //not in day light saving time adjust time
                            lvData[2] = RenameUtils.FormatDate(dtModifyDate.AddHours(1));
                        }
                        else
                        {
                            //not in day light saving time adjust time
                            lvData[2] = RenameUtils.FormatDate(dtModifyDate);
                        }

                        //Create actual list item
                        ListViewItem lvItem = new ListViewItem(lvData, 0);
                        lvFiles.Items.Add(lvItem);


                    }
                }
                catch (IOException e)
                {
                    MessageBox.Show(Resources.TextUI_Error_DriveNotReady + e.Message);
                }
                catch (UnauthorizedAccessException e)
                {
                    MessageBox.Show(Resources.TextUI_Error_DriveAccessDenied + e.Message);
                }
                catch (Exception e)
                {
                    MessageBox.Show(Resources.TextUI_Error + e.Message);
                }
            }

        }

        public static void ClearMatchStatus(ListView lvObject)
        {
            foreach (ListViewItem lvItem in lvObject.Items)
            {
                lvItem.SubItems[3].Text = string.Empty;
                lvItem.BackColor = Color.White;
            }
        }

        public static void ClearMathingLeftRight(ListView lvFilesLeft, ListView lvFilesRight)
        {
            RenameUtils.ClearMatchStatus(lvFilesLeft);
            RenameUtils.ClearMatchStatus(lvFilesRight);
            LogUtils.AddLogTextLine("Matching cleared.");
        }

        public static void BehaveLikeRadioCheckBox(ListView lvFiles, ListViewItem checkedListVieeItem)
        {
            if (null == checkedListVieeItem) return; //small fix; sometimes 'e' was null.

            bool checkedState = checkedListVieeItem.Checked;

            if (checkedState)
            {
                if (lvFiles.CheckedItems.Count > 1)
                {
                    foreach (ListViewItem lvItem in lvFiles.CheckedItems)
                    {
                        if (lvItem.Index == checkedListVieeItem.Index) continue;
                        lvItem.Checked = false;
                    }
                }
            }
            checkedListVieeItem.Checked = checkedState;
        }

        public static string ExtractNumbers(string expr, string strComplexRegex)
        {
            try
            {
                if (String.Empty == strComplexRegex)
                {
                    //if there is no Regex set use a default one.
                    //MessageBox.Show(string.Join(null, System.Text.RegularExpressions.Regex.Split(expr, "[^\\d$]")));
                    return string.Join(null, System.Text.RegularExpressions.Regex.Split(expr, "[^\\d$]"));
                }
                else
                {
                    //MessageBox.Show(System.Text.RegularExpressions.Regex.Match(expr, strComplexRegex).Value.ToString());
                    return System.Text.RegularExpressions.Regex.Match(expr, strComplexRegex).Value.ToString();
                }
            } catch (Exception)
            {
                //silence
                return "";
            }
        }

        private static List<string> GetColors()
        {
            //create a generic list of strings
            List<string> colors = new List<string>();
            //get the color names from the Known color enum
            string[] colorNames = Enum.GetNames(typeof(KnownColor));
            //iterate thru each string in the colorNames array
            foreach (string colorName in colorNames)
            {
                //cast the colorName into a KnownColor
                KnownColor knownColor = (KnownColor)Enum.Parse(typeof(KnownColor), colorName);
                //check if the knownColor variable is a System color
                if (knownColor > KnownColor.Transparent)
                {
                    //add it to our list
                    if (colorName != Color.Black.Name && 
                        colorName != Color.White.Name &&
                        colorName != Color.Blue.Name &&
                        colorName != Color.CadetBlue.Name &&
                        colorName != Color.DarkSlateBlue.Name &&
                        colorName != Color.DarkBlue.Name &&
                        colorName != Color.DarkGray.Name &&
                        colorName != Color.Navy.Name && 
                        colorName != Color.DarkMagenta.Name
                        ) colors.Add(colorName);
                }
            }
            //return the color list
            return colors;
        }

        public void MatchRow(ListView lvFiles)
        {
            foreach (ListViewItem lvItem in lvFiles.Items)
            {
                if (lvItem.Checked)
                {
                    lvItem.SubItems[3].Text = this.indexMatch.ToString();
                    lvItem.BackColor = Color.FromName(this.ListColors[(this.indexMatch) % (this.ListColors.Count())]);
                    lvItem.Checked = false;
                    break;
                }
            }
        }

        public void MatchLeftRight(ListView lvFilesLeft, ListView lvFilesRight)
        {
            //MessageBox.Show(lvFilesLeft.SelectedItems.Count.ToString());
            if (lvFilesLeft.CheckedItems.Count > 0 && lvFilesRight.CheckedItems.Count > 0)
            {
                this.MatchRow(lvFilesLeft);
                this.MatchRow(lvFilesRight);
                this.indexMatch++;
            }
            else
            {
                MessageBox.Show("Matching not done. Chech in both sides a file.");
            }
        }

        public void AutoMatchListViews(ListView lvFilesLeft, ListView lvFilesRight, ToolStripProgressBar pbProgres, bool flagUseComplexRegex, string strRegex, bool flagUseFastRendering)
        {
            RenameUtils.ClearMathingLeftRight(lvFilesLeft, lvFilesRight);
            if (!flagUseComplexRegex) strRegex = ".*";
            LogUtils.AddLogTextLine("Auto matching operation " + (flagUseComplexRegex ? "with " : "without ") + "regex support " + (flagUseFastRendering ? "using " : "not using ") + "fast rendering.");
            pbProgres.Value = 0;
            foreach (ListViewItem lvItem in lvFilesLeft.Items)
            {
                if (lvItem.SubItems[3].Text != string.Empty) continue;

                string strLeftFileName = lvItem.Text;
                string strKeyNumberLeft = RenameUtils.ExtractNumbers(strLeftFileName, flagUseComplexRegex ? strRegex : String.Empty);

                if (flagUseFastRendering && strKeyNumberLeft == "") continue;

                foreach (ListViewItem lvRightItem in lvFilesRight.Items)
                {
                    if (lvRightItem.SubItems[3].Text != string.Empty) continue;

                    string strRightFileName = lvRightItem.Text;
                    string strKeyNumberRight = RenameUtils.ExtractNumbers(strRightFileName, flagUseComplexRegex ? strRegex : String.Empty);

                    if (flagUseFastRendering && strKeyNumberRight == "") continue;

                    //if (flagUseComplexRegex)
                    //{
                    //    strKeyNumberLeft = RenameUtils.ExtractNumbers(strKeyNumberLeft, string.Empty);
                    //    strKeyNumberRight = RenameUtils.ExtractNumbers(strKeyNumberRight, string.Empty);
                    //}

                    //MessageBox.Show((strLeftFileName) + " - " + strKeyNumberLeft + " -=- " + strRightFileName + " - " + strKeyNumberRight);

                    if (strKeyNumberLeft.Contains(strKeyNumberRight) || strKeyNumberRight.Contains(strKeyNumberLeft))
                    {
                        lvItem.Checked = true;
                        lvRightItem.Checked = true;
                        this.MatchLeftRight(lvFilesLeft, lvFilesRight);
                        if (!flagUseFastRendering)
                        {
                            lvFilesLeft.Refresh();//for special effect.
                            lvFilesRight.Refresh();
                        }
                        break;
                    }
                }

                pbProgres.Value = (int)((decimal)(lvItem.Index + 1.00) * (decimal)(100.00 / lvFilesLeft.Items.Count));
            }
        }

        public void Rename(string strDirection, ListView lvFilesLeft, ListView lvFilesRight, FolderBrowserDialog folderBrowserDialog, string strSearchPatternLeft, string strSearchPatternRight)
        {
            if (MessageBox.Show(Resources.TextUI_RenameOperationWarning, Resources.TextUI_Warning, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                foreach (ListViewItem lvItemLeft in lvFilesLeft.Items)
                {
                    foreach (ListViewItem lvItemRight in lvFilesRight.Items)
                    {
                        if (lvItemLeft.SubItems[3].Text == lvItemRight.SubItems[3].Text && lvItemLeft.SubItems[3].Text.Length > 0)
                        {
                            FileInfo fileInfoLeft = new FileInfo(RenameUtils.GetFullPath(folderBrowserDialog) + "\\" + lvItemLeft.Text);
                            string strLeftFileNameOnly = fileInfoLeft.Name;
                            strLeftFileNameOnly = strLeftFileNameOnly.Replace(fileInfoLeft.Extension.ToString(), "");

                            FileInfo fileInfoRight = new FileInfo(RenameUtils.GetFullPath(folderBrowserDialog) + "\\" + lvItemRight.Text);
                            string strRightFileNameOnly = fileInfoRight.Name;
                            strRightFileNameOnly = strRightFileNameOnly.Replace(fileInfoRight.Extension.ToString(), "");

                            if (strDirection == DIRECTION_LEFT)
                            {
                                File.Move(fileInfoRight.FullName, fileInfoRight.Directory.FullName + "\\" + strLeftFileNameOnly + fileInfoRight.Extension);
                                LogUtils.AddLogTextLine("Renamed " + fileInfoRight.FullName + " to " + fileInfoRight.Directory.FullName + "\\" + strLeftFileNameOnly + fileInfoRight.Extension);
                                lvItemLeft.SubItems[3].Text = "";
                                lvItemRight.SubItems[3].Text = "";
                            }
                            else
                            {
                                File.Move(fileInfoLeft.FullName, fileInfoLeft.Directory.FullName + "\\" + strRightFileNameOnly + fileInfoLeft.Extension);
                                LogUtils.AddLogTextLine("Renamed " + fileInfoLeft.FullName + " to " + fileInfoLeft.Directory.FullName + "\\" + strRightFileNameOnly + fileInfoLeft.Extension);
                                lvItemLeft.SubItems[3].Text = "";
                                lvItemRight.SubItems[3].Text = "";
                            }
                        }
                    }
                }
                RenameUtils.PopulateFiles(lvFilesLeft, strSearchPatternLeft, folderBrowserDialog);
                RenameUtils.PopulateFiles(lvFilesRight, strSearchPatternRight, folderBrowserDialog);
            }
        }
    }
}
