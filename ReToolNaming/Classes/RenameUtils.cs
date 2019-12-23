using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Globalization;
using System.Drawing;
using System.Collections;

namespace ReToolNaming.Classes
{
    public class RenameUtils
    {
        public const string DIRECTION_LEFT = "left";
        public const string DIRECTION_RIGHT = "right";

        private List<string> ListColors;
        private int indexMatch;

        public void setIndexMatch(int indexMatch)
        {
            this.indexMatch = indexMatch;
        }

        public int getIndexMatch()
        {
            return this.indexMatch;
        }

        protected void setListColors(List<string> ListColors)
        {
            this.ListColors = ListColors;
        }

        protected List<string> getListColors()
        {
            return this.ListColors;
        }

        public void InitializeUtils()
        {
            this.ListColors = GetColors();
            this.indexMatch = 1;
        }

        public static void InitListView(ListView lvFiles)
        {
            //init ListView control
            lvFiles.Clear();		//clear control
            //create column header for ListView
            lvFiles.Columns.Add(ReToolNaming.Properties.Resources.TextUI_Name, 400);
            lvFiles.Columns.Add(ReToolNaming.Properties.Resources.TextUI_Size, 100);
            lvFiles.Columns.Add(ReToolNaming.Properties.Resources.TextUI_Modified, 100);
            lvFiles.Columns.Add(ReToolNaming.Properties.Resources.TextUI_Matching, 50);

        } 

        private static string formatDate(DateTime dtDate)
        {
            //Get date and time in short format
            string stringDate = "";

            stringDate = dtDate.ToShortDateString().ToString() + " " + dtDate.ToShortTimeString().ToString();

            return stringDate;
        }

        private static string formatSize(Int64 lSize)
        {
            //Format number to KB
            string stringSize = "";
            NumberFormatInfo myNfi = new NumberFormatInfo();

            Int64 lKBSize = 0;

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
                lKBSize = lSize / 1024;
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

        public static string getFullPath(FolderBrowserDialog folderBrowserDialog)
        {
            if (folderBrowserDialog.SelectedPath.ToString() == "")
                return Directory.GetCurrentDirectory();
            else return folderBrowserDialog.SelectedPath.ToString();
        }

        
        public static string[] getFiles(string SourceFolder, string Filter, SearchOption searchOption)
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
            if (Directory.Exists((string)getFullPath(folderBrowserDialog)) == false)
            {
                MessageBox.Show(ReToolNaming.Properties.Resources.TextUI_DirectoryDoesNotExist);
            }
            else
            {
                try
                {
                    string[] stringFiles = getFiles(getFullPath(folderBrowserDialog), searchPattern, SearchOption.TopDirectoryOnly);
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
                        lvData[1] = RenameUtils.formatSize(lFileSize);

                        //check if file is in local current day light saving time
                        if (TimeZone.CurrentTimeZone.IsDaylightSavingTime(dtModifyDate) == false)
                        {
                            //not in day light saving time adjust time
                            lvData[2] = RenameUtils.formatDate(dtModifyDate.AddHours(1));
                        }
                        else
                        {
                            //not in day light saving time adjust time
                            lvData[2] = RenameUtils.formatDate(dtModifyDate);
                        }

                        //Create actual list item
                        ListViewItem lvItem = new ListViewItem(lvData, 0);
                        lvFiles.Items.Add(lvItem);


                    }
                }
                catch (IOException e)
                {
                    MessageBox.Show(ReToolNaming.Properties.Resources.TextUI_Error_DriveNotReady);
                }
                catch (UnauthorizedAccessException e)
                {
                    MessageBox.Show(ReToolNaming.Properties.Resources.TextUI_Error_DriveAccessDenied);
                }
                catch (Exception e)
                {
                    MessageBox.Show(ReToolNaming.Properties.Resources.TextUI_Error + e);
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
            log.addLogTextLine("Matching cleared.");
        }

        public static void BehaveLikeRadioCheckBox(ListView lvFiles, ListViewItem checkedListVieeItem, ItemCheckedEventHandler lvFiles_ItemChecked)
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
            if (String.Empty == strComplexRegex)
                return string.Join(null, System.Text.RegularExpressions.Regex.Split(expr, "[^\\d$]"));
            else
                return System.Text.RegularExpressions.Regex.Match(expr, strComplexRegex).Value.ToString();
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
                    if (colorName != Color.Black.Name && colorName != Color.White.Name) colors.Add(colorName);
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
                    lvItem.BackColor = Color.FromName(this.ListColors[(this.indexMatch)%(this.ListColors.Count())]);
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

        public void AutoMatchListViews(ListView lvFilesLeft, ListView lvFilesRight, ProgressBar pbProgres, bool flagUseComplexRegex, string strRegex, bool flagUseFastRendering)
        {
            RenameUtils.ClearMathingLeftRight(lvFilesLeft, lvFilesRight);
            log.addLogTextLine("Auto matching operation " + (flagUseComplexRegex ? "with " : "without ") + "regex support " + (flagUseFastRendering ? "using " : "not using ") + "fast rendering.");
            pbProgres.Show();
            pbProgres.Value = 0;
            foreach (ListViewItem lvItem in lvFilesLeft.Items)
            {
                if (lvItem.SubItems[3].Text != string.Empty) continue;
                
                string strLeftFileName = lvItem.Text;
                string strKeyNumberLeft = RenameUtils.ExtractNumbers(strLeftFileName, flagUseComplexRegex ? strRegex : String.Empty);

                foreach (ListViewItem lvRightItem in lvFilesRight.Items)
                {
                    if (lvRightItem.SubItems[3].Text != string.Empty) continue;

                    string strRightFileName = lvRightItem.Text;
                    string strKeyNumberRight = RenameUtils.ExtractNumbers(strRightFileName, flagUseComplexRegex ? strRegex : String.Empty);

                    if (flagUseComplexRegex)
                    {
                        strKeyNumberLeft = RenameUtils.ExtractNumbers(strKeyNumberLeft, string.Empty);
                        strKeyNumberRight = RenameUtils.ExtractNumbers(strKeyNumberRight, string.Empty);
                    }

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
                pbProgres.Value = (int)((decimal)(lvItem.Index+1.00) * (decimal)(100.00 / lvFilesLeft.Items.Count));
            }
            pbProgres.Hide();
        }

        public void Rename(string strDirection, ListView lvFilesLeft, ListView lvFilesRight, FolderBrowserDialog folderBrowserDialog, string strSearchPatternLeft, string strSearchPatternRight)
        {
            if (MessageBox.Show(ReToolNaming.Properties.Resources.TextUI_RenameOperationWarning, ReToolNaming.Properties.Resources.TextUI_Warning, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                foreach (ListViewItem lvItemLeft in lvFilesLeft.Items)
                {
                    foreach (ListViewItem lvItemRight in lvFilesRight.Items)
                    {
                        if (lvItemLeft.SubItems[3].Text == lvItemRight.SubItems[3].Text && lvItemLeft.SubItems[3].Text.Length > 0)
                        {
                            FileInfo fileInfoLeft = new FileInfo(RenameUtils.getFullPath(folderBrowserDialog) + "\\" + lvItemLeft.Text);
                            string strLeftFileNameOnly = fileInfoLeft.Name;
                            strLeftFileNameOnly = strLeftFileNameOnly.Replace(fileInfoLeft.Extension.ToString(), "");

                            FileInfo fileInfoRight = new FileInfo(RenameUtils.getFullPath(folderBrowserDialog) + "\\" + lvItemRight.Text);
                            string strRightFileNameOnly = fileInfoRight.Name;
                            strRightFileNameOnly = strRightFileNameOnly.Replace(fileInfoRight.Extension.ToString(), "");

                            if (strDirection == DIRECTION_LEFT)
                            {
                                File.Move(fileInfoRight.FullName, fileInfoRight.Directory.FullName + "\\" + strLeftFileNameOnly + fileInfoRight.Extension);
                                log.addLogTextLine("Renamed " + fileInfoRight.FullName + " to " + fileInfoRight.Directory.FullName + "\\" + strLeftFileNameOnly + fileInfoRight.Extension);
                                lvItemLeft.SubItems[3].Text = "";
                                lvItemRight.SubItems[3].Text = "";
                            }
                            else
                            {
                                File.Move(fileInfoLeft.FullName, fileInfoLeft.Directory.FullName + "\\" + strRightFileNameOnly + fileInfoLeft.Extension);
                                log.addLogTextLine("Renamed " + fileInfoLeft.FullName + " to " + fileInfoLeft.Directory.FullName + "\\" + strRightFileNameOnly + fileInfoLeft.Extension);
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
