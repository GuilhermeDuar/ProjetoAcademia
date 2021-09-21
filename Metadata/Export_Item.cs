using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metadata
{
    public class Export_Item
    {
        public int Exportation_ID { get; set; }
        public int Product_ID { get; set; }
        public Product Exported_Product { get; set; }
        public int Amount { get; set; }
        public double Unitary_Value { get; set; }
    }
}
