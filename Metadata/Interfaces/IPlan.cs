using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metadata.Interfaces
{
    public interface IPlan
    {
        Feedback Insert(Plan sc);
        Feedback Update(Plan sc);
        Data_Feedback<Plan> GetAll();
        Feedback Delete(int id);
        Single_Feedback<Plan> GetByID(int id);
    }
}
