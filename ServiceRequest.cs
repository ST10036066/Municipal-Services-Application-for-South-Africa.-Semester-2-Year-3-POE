using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Municipal_Services_Application_for_South_Africa
{
    public  class ServiceRequest
    {
        public ServiceRequest() { }
        public string ServiceLocation { get; set; }
        public string ServiceCategory { get; set; }
        public string ServiceDescription { get; set; }
        public DateTime PreferredDate { get; set; }
        public string ProgressStatus { get; set; }
    }
}
