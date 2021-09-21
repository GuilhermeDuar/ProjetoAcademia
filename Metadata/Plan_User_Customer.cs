using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metadata
{
    public class Plan_User_Customer 
    {
        public int ID_plan { get; set; }
        public Plan The_Plan { get; set; }
        public int ID_customer { get; set; }
        public Customer The_Customer { get; set; }
        public int ID_user { get; set; }
        public User The_User { get; set; }
        public bool Active { get; set; }
    }
}
