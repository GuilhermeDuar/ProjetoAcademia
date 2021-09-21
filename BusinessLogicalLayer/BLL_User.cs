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
    public class BLL_User : BaseValidator<User>, IUser
    {
        private DAL_User u_DAL = new DAL_User();
        public override Feedback Validate(User item)
        {
            if (string.IsNullOrWhiteSpace(item.Email) || string.IsNullOrWhiteSpace(item.User_Password) || string.IsNullOrWhiteSpace((string)item.Role.ToString()))
            {
                this.AddError("All fields must be informed!");
            }
            else
            {
                this.AddError(BaseValidator<User>.IsValidLength(item.Email, Basic_Values.MinimumLenght, Basic_Values.MaximumLenght_Email, "Email"));
                this.AddError(BaseValidator<User>.RegexValidation(item.Email, @"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$", "Email"));
                this.AddError(BaseValidator<User>.IsValidLength(Basic_Values.MinimumLenght, item.User_Password, "Password"));
                item.User_Password = BaseValidator<User>.HashPassword(item.User_Password);
            }
            return base.Validate(item);
        }
        public Data_Feedback<User> GetAll()
        {
            return this.u_DAL.GetAll();
        }

        public Feedback Insert(User u)
        {
            Feedback response = this.Validate(u);
            if (!response.Successful)
            {
                return response;
            }
            return u_DAL.Insert(u);
        }

        public Feedback Turn_Activated(int id)
        {
            return u_DAL.Turn_Activated(id);
        }

        public Feedback Turn_Desactivated(int id)
        {
            return u_DAL.Turn_Desactivated(id);
        }

        public Feedback Update(User u)
        {
            Feedback response = this.Validate(u);
            if (!response.Successful)
            {
                return response;
            }

            return u_DAL.Update(u);
        }

        public Single_Feedback<User> Search(User u)
        {
             u.User_Password = BaseValidator<User>.HashPassword(u.User_Password);
            Single_Feedback<User> response = u_DAL.Search(u);
            if (response.Successful)
            {
                Current_System_User.SetCurrentUser(response.Item);
            }
            return response;
        }
        
        public Single_Feedback<Teacher> MatchTeacher(User u)
        {
            return u_DAL.MatchTeacher(u);
        }
        public Feedback Delete(int id)
        {
            return u_DAL.Delete(id);
        }

        public Single_Feedback<User> GetByID(int id)
        {
            return u_DAL.GetByID(id);
        }
    }
}
