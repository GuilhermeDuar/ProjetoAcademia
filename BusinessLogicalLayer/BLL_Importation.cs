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
    public class BLL_Importation : BaseValidator<Importation>, IImportation
    {
        private DAL_Product p_DAL = new DAL_Product();
        private DAL_Importation i_DAL = new DAL_Importation();
        public Data_Feedback<Importation> GetAll()
        {
            Data_Feedback<Importation> response = this.i_DAL.GetAll();
            if (response.Successful && response.Data.Count == Basic_Values.Zero)
            {
                response.Successful = false;
                response.Report = "Imports have not yet been carried out in the database.";
            }
            return response;
        }

        public Single_Feedback<Importation> GetByID(int id)
        {
            return i_DAL.GetByID(id);
        }

        public Data_Feedback<Import_Item> GetImportsByID(int id)
        {
            return i_DAL.GetImportsByID(id);
        }

        public Feedback Insert(Importation importation)
        {
            Feedback response = i_DAL.Insert(importation);
            if (response.Successful)
            {
                foreach (Import_Item item in importation.Imported_products)
                {
                    Product oldP = p_DAL.GetByID(item.Imported_Product.ID).Item;
                    int newStock = oldP.Stock + item.Amount;
                    item.Imported_Product.Price = ((oldP.Stock * oldP.Price) + (item.Imported_Product.Stock * item.Imported_Product.Price)) / newStock;
                    item.Imported_Product.Stock = newStock;
                    p_DAL.UpdatePrice_Stock(item.Imported_Product);
                }
            }
            return response;
        }
    }
}
