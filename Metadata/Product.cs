using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metadata
{
    public class Product
    {
        public int ID { get; set; }
        public string Product_Name { get; set; }
        public string Product_Description { get; set; }
        public string Category { get; set; }
        public int Stock { get; set; }
        public double Price { get; set; }
        public override string ToString()
        {
            return $"{Product_Name} - {Price.ToString("C2")}" ;
        }
    }
}
