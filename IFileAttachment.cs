using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Municipal_Services_Application_for_South_Africa
{
    //    /// <summary>
    //    /// This interface defines the structure for file attachments. It requires implementing classes to provide the file name, 
    //    file path, file size, and a method to validate the attachment.

    //    Methods:
    //- ValidateFileAttachment: Ensures that the file attachment meets specific requirements(e.g., file name, path, size).
    //    /// </summary>
    public interface IFileAttachment
    {
        string FileName { get; set; }
        string FilePath { get; set; }
        long FileSize { get; set; }

        // Method to validate the attachment
        bool ValidateFileAttachment();
    }
}
//--------------------------------------END OF CODE------------------------------------------------------------------------------
