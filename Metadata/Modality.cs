using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metadata
{
    public class Modality
    {
        public int ID { get; set; }
        public string Modality_Name { get; set; }
        public override string ToString()
        {
            return Modality_Name;
        }
    }
    
}
