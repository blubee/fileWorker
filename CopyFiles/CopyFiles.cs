using System;
using System.IO;
using System.Collections.Generic;
using System.Windows.Forms;

using FileHandlerLib;

namespace CopyFiles
{
    public partial class CopyFiles : Form
    {
        public CopyFiles()
        {
            InitializeComponent();

            SetStandardPaths();
        }

        /// <summary>
        /// for working environment 
        /// </summary>
        private void SetStandardPaths()
        {
            sourceFilePath1Tb.Text = @"C:\Temp\SugarShipping\LS_1\pdf";
            sourceFilePath2Tb.Text = @"C:\Temp\SugarShipping\LS_2\pdf";
            sourceFilePath3Tb.Text = @"C:\Temp\SugarShipping\LS_3\pdf";

            targetFilePath1Tb.Text = @"C:\Temp\SugarShipping\LS_1";
            targetFilePath2Tb.Text = @"C:\Temp\SugarShipping\LS_2";
            targetFilePath3Tb.Text = @"C:\Temp\SugarShipping\LS_3";

            deleteFolderPath1Tb.Text = @"C:\Temp\SugarShipping\LS_1\completed";
            deleteFolderPath2Tb.Text = @"C:\Temp\SugarShipping\LS_2\completed";
            deleteFolderPath3Tb.Text = @"C:\Temp\SugarShipping\LS_3\completed";
        }

        /// <summary>
        /// Start Copy file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            IDictionary<string, string> aAllFiles = new Dictionary<string, string>();

            if (!String.IsNullOrEmpty(sourceFilePath1Tb.Text))
            {
                var aSourcePath_1 = sourceFilePath1Tb.Text;
                var aFiles_1 = Directory.GetFiles(aSourcePath_1, "*", SearchOption.TopDirectoryOnly);
                foreach (var item in aFiles_1)
                {
                    aAllFiles.Add(item, targetFilePath1Tb.Text);
                }
            }

            if (!String.IsNullOrEmpty(sourceFilePath2Tb.Text))
            {
                var aSourcePath_2 = sourceFilePath2Tb.Text;
                var aFiles_2 = Directory.GetFiles(aSourcePath_2, "*", SearchOption.TopDirectoryOnly);
                foreach (var item in aFiles_2)
                {
                    aAllFiles.Add(item, targetFilePath2Tb.Text);
                }
            }

            if (!String.IsNullOrEmpty(sourceFilePath3Tb.Text))
            {
                var aSourcePath_3 = sourceFilePath3Tb.Text;
                var aFiles_3 = Directory.GetFiles(aSourcePath_3, "*", SearchOption.TopDirectoryOnly);
                foreach (var item in aFiles_3)
                {
                    aAllFiles.Add(item, targetFilePath3Tb.Text);
                }
            }

            foreach(var item in aAllFiles)
            {
                var aFileName = FileStringHelper.GetFileNameWithExtensionFromCompleteFilePath(item.Key);
                File.Copy(item.Key, item.Value + "\\" + aFileName);
            }
        }


        /// <summary>
        /// Delete files from listed folders
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(deleteFolderPath1Tb.Text))
            {
                var aFiles_1 = Directory.GetFiles(deleteFolderPath1Tb.Text, "*", SearchOption.TopDirectoryOnly);
                foreach (var item in aFiles_1)
                {
                    File.Delete(item);
                }
            }
            if (!String.IsNullOrEmpty(deleteFolderPath2Tb.Text))
            {
                var aFiles_2 = Directory.GetFiles(deleteFolderPath2Tb.Text, "*", SearchOption.TopDirectoryOnly);
                foreach (var item in aFiles_2)
                {
                    File.Delete(item);
                }
            }
            if (!String.IsNullOrEmpty(deleteFolderPath3Tb.Text))
            {
                var aFiles_3 = Directory.GetFiles(deleteFolderPath3Tb.Text, "*", SearchOption.TopDirectoryOnly);
                foreach (var item in aFiles_3)
                {
                    File.Delete(item);
                }
            }
        }


        #region ####    Auswahl der Folder via Btn Klick    ####

        private void button3_Click(object sender, EventArgs e)
        {
            var aDialog = folderBrowserDialog1.ShowDialog();
            if (aDialog == DialogResult.OK)
            {
                sourceFilePath1Tb.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void folderSelection2Btn_Click(object sender, EventArgs e)
        {
            var aDialog = folderBrowserDialog1.ShowDialog();
            if (aDialog == DialogResult.OK)
            {
                sourceFilePath2Tb.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void folderSelection3Btn_Click(object sender, EventArgs e)
        {
            var aDialog = folderBrowserDialog1.ShowDialog();
            if (aDialog == DialogResult.OK)
            {
                sourceFilePath3Tb.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        
        private void folderDelSelection11Btn_Click(object sender, EventArgs e)
        {
            var aDialog = folderBrowserDialog1.ShowDialog();
            if (aDialog == DialogResult.OK)
            {
                targetFilePath1Tb.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void folderDelSelection21Btn_Click(object sender, EventArgs e)
        {
            var aDialog = folderBrowserDialog1.ShowDialog();
            if (aDialog == DialogResult.OK)
            {
                targetFilePath2Tb.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void folderDelSelection31Btn_Click(object sender, EventArgs e)
        {
            var aDialog = folderBrowserDialog1.ShowDialog();
            if (aDialog == DialogResult.OK)
            {
                targetFilePath3Tb.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void delFolder1Btn_Click(object sender, EventArgs e)
        {
            var aDialog = folderBrowserDialog1.ShowDialog();
            if (aDialog == DialogResult.OK)
            {
                deleteFolderPath1Tb.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void delFolder2Btn_Click(object sender, EventArgs e)
        {
            var aDialog = folderBrowserDialog1.ShowDialog();
            if (aDialog == DialogResult.OK)
            {
                deleteFolderPath2Tb.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void delFolder3Btn_Click(object sender, EventArgs e)
        {
            var aDialog = folderBrowserDialog1.ShowDialog();
            if (aDialog == DialogResult.OK)
            {
                deleteFolderPath3Tb.Text = folderBrowserDialog1.SelectedPath;
            }
        }


        #endregion ####    Auswahl der Folder via Btn Klick    ####


        private void deleteFilesFromRootBtn_Click(object sender, EventArgs e)
        {
            var aDeleteFodler1 = @"C:\Temp\SugarShipping\LS_1";
            var aFiles_1 = Directory.GetFiles(aDeleteFodler1, "*", SearchOption.TopDirectoryOnly);
            foreach (var item in aFiles_1)
            {
                File.Delete(item);
            }

            var aDeleteFodler2 = @"C:\Temp\SugarShipping\LS_2";
            var aFiles_2 = Directory.GetFiles(aDeleteFodler2, "*", SearchOption.TopDirectoryOnly);
            foreach (var item in aFiles_2)
            {
                File.Delete(item);
            }

            var aDeleteFodler3 = @"C:\Temp\SugarShipping\LS_3";
            var aFiles_3 = Directory.GetFiles(aDeleteFodler3, "*", SearchOption.TopDirectoryOnly);
            foreach (var item in aFiles_3)
            {
                File.Delete(item);
            }
        }
    }
}
