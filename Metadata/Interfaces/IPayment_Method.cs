using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metadata.Interfaces
{
    public interface IPayment_Method
    {
        Feedback Insert(Payment_Method pm);
        Feedback Update(Payment_Method pm);
        Feedback Delete(int id);
        Data_Feedback<Payment_Method> GetAll();
        Single_Feedback<Payment_Method> GetByID(int id);

    }
}
