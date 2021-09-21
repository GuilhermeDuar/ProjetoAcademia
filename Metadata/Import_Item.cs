using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metadata
{
    public class Import_Item
    {
        public int Importation_ID { get; set; }
        public int Product_ID { get; set; }
        public Product Imported_Product { get; set; }
        public int Amount { get; set; }
        public double Unitary_Value{ get; set; }
        public override string ToString()
        {
            return Imported_Product.Product_Name;
        }
    }
}
