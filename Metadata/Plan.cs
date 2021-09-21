using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metadata
{
    public class Plan
    {
        public int ID { get; set; }
        public int Modality_ID { get; set; }
        public Modality m { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }

        public string Display { get { return this.ToString(); } }
        public override string ToString()
        {
            return $"{m.Modality_Name} - {Price.ToString("C2")}";
        }
    }
}
