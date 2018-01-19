using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RenameFiles
{
    public partial class FileShortener : Form
    {
        public FileShortener()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var aErrorHelper = "";
            try
            {
                statusTb.Text = "Start";

                var aSourcePath = sourceFilePathTb.Text;
                var aSuffix = fileExtensionTb.Text;
                var aFolderFilter = aSuffix;
                if (aSuffix.Contains("*."))
                {
                    aSuffix = aSuffix.Substring(1);
                }

                var aRemoveFromPosition = Convert.ToInt32(removeFromPositionTb.Text) - 1;
                var aRemoveToPosition = Convert.ToInt32(removeToPositionTb.Text);

                var aFiles = Directory.GetFiles(aSourcePath, aFolderFilter,
                                    SearchOption.TopDirectoryOnly).Where(x => x.ToLower().EndsWith(aSuffix)).ToList();

                foreach (var item in aFiles)
                {
                    var aFolderPathEndIndex = item.LastIndexOf("\\");
                    // +2 because of \\ from above
                    var aFileName = item.Substring(aFolderPathEndIndex + 1);

                    var aFileSuffixPos = aFileName.LastIndexOf(".");
                    var aFileSuffix = aFileName.Substring(aFileSuffixPos);


                    var aSourceFile = aSourcePath + "\\" + aFileName;
                    if (aFileName.Length > Convert.ToInt32(removeFromPositionTb.Text) &&
                        aFileName.Length > Convert.ToInt32(removeToPositionTb.Text))
                    {
                        var aLength = aRemoveToPosition - aRemoveFromPosition;
                        aFileName = aFileName.Substring(aRemoveFromPosition, aLength);

                        
                        try
                        {
                            var aTargetFile = aSourcePath + "\\" + aFileName + aFileSuffix;
                            aErrorHelper = "Versuche Move von \r\n " + aSourceFile + " zu \r\n " + aTargetFile;
                            File.Move(aSourceFile, aTargetFile);
                        }
                        catch (Exception ex)
                        {
                            var aTargetFile = aSourcePath + "\\" + aFileName + "_" + Guid.NewGuid() + aFileSuffix;
                            // wenn datei bereits exisitert, erstelle eine weitere mit Guid am Ende
                            aErrorHelper = "Versuche Move(catch) von \r\n" + aSourceFile + " zu \r\n " + aTargetFile;
                            File.Move(aSourceFile, aSourcePath + "\\" + aFileName + "_" + Guid.NewGuid() + aFileSuffix);
                        }

                        //File.Move(aSourceFile, aTargetFile);
                    }
                }

                statusTb.Text = "Abgeschlossen";
            }
            catch(Exception exception)
            {
                errorTb.Text = exception.Message + "\r\n\r\n";
                errorTb.Text = errorTb.Text + aErrorHelper + "\r\n\r\n"; ;

                if (exception.InnerException != null)
                {
                    errorTb.Text = errorTb.Text + "\n\rINNEREXCEPTION: " + exception.InnerException.Message;
                }
                if (!String.IsNullOrEmpty(exception.StackTrace))
                {
                    errorTb.Text = errorTb.Text + exception.StackTrace;
                    errorTb.Text = errorTb.Text + exception.StackTrace;
                }
            }
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void sourceFilePathTb_TextChanged(object sender, EventArgs e)
        {
            statusTb.Text = "";
        }
    }
}
