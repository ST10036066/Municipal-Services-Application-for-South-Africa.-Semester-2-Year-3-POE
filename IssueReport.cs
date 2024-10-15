using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Municipal_Services_Application_for_South_Africa
{

///// <summary>
///please ignore. Im not using this class. Part 2 changes
   
///// </summary>

    public class IssueReport 
    {
        public string Location { get; set; } // Location of the reported issue
        public string Category { get; set; } // Category of the issue (e.g., sanitation, roads, etc.)
        public string Description { get; set; } // Detailed description of the issue
        public List<IFileAttachment> MediaAttachments { get; set; } //= new List<IFileAttachment>(); // List of file paths or URIs for media attachments
        public DateTime DateReported { get; set; }

        public IssueReport(string location, string category, string description, List<IFileAttachment> mediaAttachments)
        {
            Location = location;
            Category = category;
            Description = description;
            MediaAttachments = mediaAttachments;
            DateReported = DateTime.Now;
        }
    }
}

//--------------------------------------END OF CODE------------------------------------------------------------------------------