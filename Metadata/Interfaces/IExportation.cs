using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metadata.Interfaces
{
    public interface IExportation
    {
        Feedback Insert(Exportation exportation);
        Data_Feedback<Exportation> GetAll();
        Single_Feedback<Exportation> GetByID(int id);
        Data_Feedback<Export_Item> GetExportsByID(int id);

    }
}
