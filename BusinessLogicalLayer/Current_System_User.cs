using DataAccessLayer;
using Metadata;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicalLayer
{
    public static class Current_System_User
    {
        private static User current_U;
        private static Teacher current_T;
        private static DAL_Teacher t_DAL = new DAL_Teacher();
        public static void SetCurrentUser(User u)
        {
            current_U = u;
            if (u.Role == Users_Role.Teacher)
            {
                Single_Feedback<Teacher> response = t_DAL.SearchByID(u.ID);
                if (response.Successful)
                {
                    current_T = response.Item;
                }
            }
        }
        public static User GetCurrentUser()
        {
            return current_U;
        }
        public static Teacher GetCurrentTeacher()
        {
            return current_T;
        }
        public static void Logout()
        {
            current_U = null;
        }
    }
}
