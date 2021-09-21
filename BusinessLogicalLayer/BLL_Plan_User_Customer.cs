using DataAccessLayer;
using Metadata;
using Metadata.Interfaces;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicalLayer
{
    public class BLL_Plan_User_Customer : IPlan_User_Customer
    {
        DAL_Plan_User_Customer puc_DAL = new DAL_Plan_User_Customer();
        DAL_User u_DAL = new DAL_User();
        DAL_Teacher t_DAL = new DAL_Teacher();

        public Data_Feedback<Plan_User_Customer> GetAll()
        {
            Data_Feedback<Plan_User_Customer> response = this.puc_DAL.GetAll();
            if (response.Successful && response.Data.Count == Basic_Values.Zero)
            {
                response.Successful = false;
                response.Report = "No customers were linked to any plans in the database";
            }
            return response;
        }

        public Single_Feedback<Plan_User_Customer> GetByID(int c_id, int pl_id)
        {
            return puc_DAL.GetByID(c_id, pl_id);
        }

        public Feedback Insert(Plan_User_Customer puc)
        {
            Feedback response = puc_DAL.Insert(puc);
            if (response.Successful && Current_System_User.GetCurrentUser().Role == Users_Role.Teacher)
            {
                Teacher t = u_DAL.MatchTeacher(puc.The_User).Item;
                t.Comission += puc.The_Plan.Price * 0.1;
                t_DAL.Update(t);
            }
            return response;
        }

        public Feedback Turn_Activate(int c_id, int pl_id)
        {
            return puc_DAL.Turn_Activate(c_id, pl_id);

        }

        public Feedback Turn_Desactivated(int c_id, int pl_id)
        {
            return puc_DAL.Turn_Desactivated(c_id, pl_id);

        }
    }
}
