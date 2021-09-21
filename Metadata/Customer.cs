using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metadata
{
    public class Customer
    {
        public int ID { get; set; }
        public string Customer_Name { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public string First_Phone_Number { get; set; }
        public string Second_Phone_Number { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime Register_Date { get; set; }
        public bool Active { get; set; }
        public override string ToString()
        {
            return $"{Customer_Name} - {Email}";
        }
    }
}
