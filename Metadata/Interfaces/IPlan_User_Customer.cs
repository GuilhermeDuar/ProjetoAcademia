using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metadata.Interfaces
{
    public interface IPlan_User_Customer
    {
        Feedback Insert(Plan_User_Customer puc );
        Data_Feedback<Plan_User_Customer> GetAll();
        Single_Feedback<Plan_User_Customer> GetByID(int c_id, int pl_id);
        Feedback Turn_Desactivated(int c_id, int pl_id);
        Feedback Turn_Activate(int c_id, int pl_id);
    }
}
