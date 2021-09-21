using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metadata.Interfaces
{
    public interface IProduct
    {
        Feedback Insert(Product p);
        Feedback Update(Product p);
        Feedback UpdatePrice_Stock(Product p);
        Feedback UpdateStockOnly(Product p);
        Feedback Delete(int id);
        Data_Feedback<Product> GetAll();
        Single_Feedback<Product> GetByID(int id);
    }
}
