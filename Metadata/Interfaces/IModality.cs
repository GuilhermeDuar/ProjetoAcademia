using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metadata.Interfaces
{
    public interface IModality
    {
        Feedback Insert(Modality m);
        Feedback Update(Modality m);
        Data_Feedback<Modality> GetAll();
        Feedback Delete(int id);
        Single_Feedback<Modality> GetByID(int id);

    }
}
