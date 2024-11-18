using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Municipal_Services_Application_for_South_Africa
{
//   How the interface is helpful:
//It ensures that the ServiceRequest class(this one) provides a CompareTo method. ComparedTo is also useul for sorting and ordering

    public  class ServiceRequest : IComparable<ServiceRequest>
    {
        public ServiceRequest() { }
        public string ServiceLocation { get; set; }
        public string ServiceCategory { get; set; }
        public string ServiceDescription { get; set; }
        public DateTime PreferredDate { get; set; }
        public string ProgressStatus { get; set; }
        public int Priority { get; set; } // Lower number = higher priority

        public int CompareTo(ServiceRequest other)
        {
            return Priority.CompareTo(other.Priority); // Min-Heap behavior
        }
    }

}
