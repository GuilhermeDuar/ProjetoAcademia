using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metadata
{
    public interface IImportation
    {
        Feedback Insert(Importation importation);
        Data_Feedback<Importation> GetAll();
        Single_Feedback<Importation> GetByID(int id);
        Data_Feedback<Import_Item> GetImportsByID(int id);

    }
}
