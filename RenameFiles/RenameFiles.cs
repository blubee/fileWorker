using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using FileHandlerLib;

namespace RenameFiles
{
    public partial class RenameFiles : Form
    {
        private static string orderCriteria_CreationDate = "Erstellungsdatum";
        private static string orderCriteria_ChangeDate = "Änderungsdatum";
        private static string orderCriteria_Name = "Name";

        public RenameFiles()
        {
            InitializeComponent();

            fileOrderCriteriaDdl.Items.Add(orderCriteria_CreationDate);
            fileOrderCriteriaDdl.Items.Add(orderCriteria_ChangeDate);
            fileOrderCriteriaDdl.Items.Add(orderCriteria_Name);
        }

        private void startRenameProcessBtn_Click(object sender, EventArgs e)
        {

            var aOrderCriteriaSelectedItem = fileOrderCriteriaDdl.SelectedItem;

            if (!String.IsNullOrEmpty(folderPathTbx.Text) && !String.IsNullOrEmpty(targetMainFileNameTbx.Text) &&
                !String.IsNullOrEmpty(targetFileCounterBeginTbx.Text))
            {
                
                //var FileOrderCriteria = 

                DirectoryInfo aFiles = new DirectoryInfo(folderPathTbx.Text);
                var files = aFiles.GetFiles().OrderBy(p => p.CreationTime);

                if(aOrderCriteriaSelectedItem.ToString() == orderCriteria_ChangeDate)
                {
                    files = aFiles.GetFiles().OrderBy(p => p.LastWriteTime);
                }

                if (aOrderCriteriaSelectedItem.ToString() == orderCriteria_Name)
                {
                    files = aFiles.GetFiles().OrderBy(p => p.Name);
                }

                var abb = "bp";

                
                var aFileCounter = Convert.ToInt32(targetFileCounterBeginTbx.Text);

                foreach (var item in files)
                {
                    
                    var aFileNameWithExtension = FileStringHelper.GetFileNameWithExtensionFromCompleteFilePath(item.FullName);
                   
                    var aFileExtension = FileStringHelper.GetExtensionFromFileName(aFileNameWithExtension);

                    var aFileCounterStr = aFileCounter.ToString();

                    if(aFileCounter < 10)
                    {
                        aFileCounterStr = "00" + aFileCounterStr;
                    }
                    if(aFileCounter > 9 && aFileCounter < 100)
                    {
                        aFileCounterStr = "0" + aFileCounterStr;
                    }

                    var aNewCompleteFileName = targetMainFileNameTbx.Text + fileNameCounterSeperatorTbx.Text + aFileCounterStr + "." + aFileExtension;

                    var aPath = FileStringHelper.GetFilePathWithoutFileName(item.FullName);
                    var aNewFilePathWithName = aPath + "\\" + aNewCompleteFileName;

                    //TODO: Now MoveFile sofern nicht bereits existiert 
                    
                    File.Move(item.FullName, aNewFilePathWithName);

                    aFileCounter++;
                }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
