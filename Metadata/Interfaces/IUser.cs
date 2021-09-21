using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metadata.Interfaces
{
    public interface IUser
    {
        Feedback Insert(User u);
        Feedback Update(User u);
        Feedback Turn_Desactivated(int id);
        Feedback Turn_Activated(int id);
        Data_Feedback<User> GetAll();
        Single_Feedback<Teacher> MatchTeacher(User u);
        Single_Feedback<User> Search(User u);
        Feedback Delete(int id);
        Single_Feedback<User> GetByID(int id);
    }
}
