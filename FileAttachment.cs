using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Municipal_Services_Application_for_South_Africa
{
    //    /// <summary>
    //    /// This defines the structure for file attachments. It requires implementing classes to provide the file name, 
    //    file path, file size, and a method to validate the attachment.

    //    Methods:
    //- ValidateFileAttachment: Ensures that the file attachment meets specific requirements(e.g., file name, path, size).

    // switch statement: Ensure thate the file name, path and size exists by checking it case by case. 
    // whereas if the file name, path and size are there then they pass the 'cases'. 
    //    /// </summary>
    public class FileAttachment : IFileAttachment
    {
        public string FileName { get; set; }
        public string FilePath { get; set; }
        
        public long FileSize { get; set; }
        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        public FileAttachment(string fileName, string filePath, long fileSize)
        {
            FileName = fileName;
            FilePath = filePath;
            FileSize = fileSize;
        }
        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        public bool ValidateFileAttachment()
        {
            bool isValid = true;
            string errorMessage = "";

            switch (true)
            {
                //if there is no file name
                case bool _ when string.IsNullOrEmpty(FileName):
                    errorMessage = "File name is required. Please choose a file from File Explorer. Example: ABS.PDF";
                    isValid = false;
                    break;
                    //if there no path of file
                case bool _ when string.IsNullOrEmpty(FilePath):
                    errorMessage = "File path is missing. Please choose a file from File Explorer. Example: User/Downloads/ABC.PDF";
                    isValid = false;
                    break;
                    //file doesnt have any size
                case bool _ when FileSize <= 0:
                    errorMessage = "We cannot find the file. Please try attaching again and ensure you select an existing file more than 0KB.";
                    isValid = false;
                    break;
            }

            if (!isValid)
            {
                
                MessageBox.Show(errorMessage, "File Scanning Error. We could not find the name/path or size of your file. Please try again", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return isValid;
        }
    }
}
//--------------------------------------END OF CODE------------------------------------------------------------------------------
