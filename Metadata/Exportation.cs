using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metadata
{
    public class Exportation
    {
        public int ID { get; set; } 
        public User Current_User { get; set; }
        public int User_ID { get; set; }
        public Customer Customer { get; set; }
        public int Customer_ID { get; set; }
        public double TotalValue { get; set; }
        public DateTime Export_date { get; set; }
        public List<Export_Item> Exported_products { get; set; }
        public int ID_Payment_Method { get; set; }
        public Payment_Method PM { get; set; }
        public void AddPrice()
        {
            this.TotalValue = this.Exported_products.Sum(p => p.Amount * p.Unitary_Value);
        }
    }
}
