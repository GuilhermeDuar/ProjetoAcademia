using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metadata.Interfaces
{
    public interface ICustomer
    {
        Feedback Insert(Customer s);
        Feedback Update(Customer s);
        Feedback Turn_Desactivated(int id);
        Feedback Turn_Activated(int id);
        Data_Feedback<Customer> GetAll();
        Single_Feedback<Customer> GetByID(int id);

    }
}
