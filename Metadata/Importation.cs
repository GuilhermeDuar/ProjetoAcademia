using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metadata
{
    public class Importation
    {
        public int ID { get; set; }
        public int User_ID { get; set; }
        public User Current_User { get; set; }
        public double TotalPrice { get; set; }
        public DateTime Import_date { get; set; }
        public List<Import_Item> Imported_products { get; set; }
        public void AddPrice()
        {
            this.TotalPrice = this.Imported_products.Sum(p => p.Amount * p.Unitary_Value);
        }
    }
}
