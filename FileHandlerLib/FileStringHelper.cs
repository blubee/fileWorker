using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandlerLib
{
    public static class FileStringHelper
    {
        /// <summary>
        /// For Example:
        /// C:\folder\subfolder\text.txt 
        /// returns
        /// text.txt
        /// </summary>
        /// <param name="inFilePath"></param>
        /// <returns></returns>
        public static string GetFileNameWithExtensionFromCompleteFilePath(string inFilePath)
        {
            var aFolderPathEndIndex = inFilePath.LastIndexOf("\\");
            // +2 because of \\ from above
            var aFileName = inFilePath.Substring(aFolderPathEndIndex + 1);

            return aFileName;
        }

        /// <summary>
        /// For Example:
        /// C:\folder\subfolder\text.txt 
        /// returns
        /// text
        /// </summary>
        /// <param name="inFilePath"></param>
        /// <returns></returns>
        public static string GetFileNameWithoutExtensionFromCompleteFilePath(string inFilePath)
        {
            var aFileNameWithExtension = GetFileNameWithExtensionFromCompleteFilePath(inFilePath);

            var aSepIndex = aFileNameWithExtension.LastIndexOf(".");

            var aFileName = aFileNameWithExtension.Substring(0, aSepIndex +1);

            return aFileName;
        }

        /// <summary>
        /// For Example:
        /// test.txt
        /// returns
        /// test
        /// </summary>
        /// <param name="inFileName"></param>
        /// <returns></returns>
        public static string GetFileNameWithoutExtensionFromFile(string inFileName)
        {
            var aSepIndex = inFileName.LastIndexOf(".");

            var aFileName = inFileName.Substring(0, aSepIndex);

            return aFileName;
        }


        /// <summary>
        /// For Example:
        /// test.txt
        /// returns
        /// txt
        /// </summary>
        /// <param name="inFileName"></param>
        /// <returns></returns>
        public static string GetExtensionFromFileName(string inFileName)
        {
            var aSepIndex = inFileName.LastIndexOf(".");

            var aFileName = inFileName.Substring(aSepIndex + 1);

            return aFileName;
        }

        /// <summary>
        /// For Example:
        /// C:\folder\subfolder\test.txt
        /// returns
        /// C:\folder\subfolder
        /// </summary>
        /// <param name="inFilePath"></param>
        /// <returns></returns>
        public static string GetFilePathWithoutFileName(string inFilePath)
        {
            var aSepIndex = inFilePath.LastIndexOf("\\");
            var aPath = inFilePath.Substring(0, aSepIndex);
            return aPath;
        }
    }
}
