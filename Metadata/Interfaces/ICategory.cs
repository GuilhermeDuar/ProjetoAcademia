using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metadata.Interfaces
{
    public interface ICategory
    {
        Feedback Insert(Category c);
        Feedback Update(Category c);
        Data_Feedback<Category> GetAll();
        Feedback Delete(int id);
        Single_Feedback<Category> GetByID(int id);
    }
}
