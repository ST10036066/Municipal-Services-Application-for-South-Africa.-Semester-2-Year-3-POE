using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Municipal_Services_Application_for_South_Africa
{
    /// <summary>
    /// Please ignore, im not using this class. It was for testing
    /// </summary>
    public class LocalEvents
    {
        public string EventDescription { get; set; } // / Detailed description  of the  event
        public string Category { get; set; } // Category of the event(main topic) (e.g., sanitation, roads, etc.)
        public string EventLocation{ get; set; } //Event location
        public List<IFileAttachment> MediaAttachments { get; set; } //= new List<IFileAttachment>(); // List of file paths or URIs for media attachments
        
        public DateTimePicker EventDateTimePicker { get; set; } //the date of the event 

    }
}
