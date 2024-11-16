using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Municipal_Services_Application_for_South_Africa
{
    public class RedBlackNode
    {
        public RedBlackNode() { }
        public int Key { get; set; }
        public ServiceRequest  Value { get; set; } //requesting data from
        public RedBlackNode Left { get; set; }
        public RedBlackNode Right { get; set; }
        public RedBlackNode Parent { get; set; }
        public bool IsRed { get; set; } //Red-Black Tree property

        public RedBlackNode(int key, ServiceRequest value)
        {

            Key = key;
            Value = value;
            IsRed = true;
        }
    }
}
    
