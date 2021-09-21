using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metadata
{
    public class Payment_Method
    {
        public int ID { get; set; }
        public string Method { get; set; }
        public override string ToString()
        {
            return Method; 
        }
    }
}
