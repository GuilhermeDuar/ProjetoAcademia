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
    public class BLL_Exportation : BaseValidator<Exportation>, IExportation
    {
        private DAL_Product p_DAL = new DAL_Product();
        private DAL_Exportation e_DAL = new DAL_Exportation();
        public Data_Feedback<Exportation> GetAll()
        {
            Data_Feedback<Exportation> response = this.e_DAL.GetAll();
            if (response.Successful && response.Data.Count == Basic_Values.Zero)
            {
                response.Successful = false;
                response.Report = "Exports have not yet been carried out in the database.";
            }
            return response;
        }

        public Single_Feedback<Exportation> GetByID(int id)
        {
            return e_DAL.GetByID(id);
        }

        public Data_Feedback<Export_Item> GetExportsByID(int id)
        {
            return e_DAL.GetExportsByID(id);
        }

        public Feedback Insert(Exportation exportation)
        {
            Feedback response = e_DAL.Insert(exportation);
            if (response.Successful)
            {
                foreach (Export_Item item in exportation.Exported_products)
                {
                    Product oldP = p_DAL.GetByID(item.Exported_Product.ID).Item;
                    int newStock = oldP.Stock - item.Amount;
                    item.Exported_Product.Stock = newStock;
                    p_DAL.UpdateStockOnly(item.Exported_Product);
                }
            }
            return response;
        }
    }
}
