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
    public class BLL_Product : BaseValidator<Product>, IProduct
    {
        private DAL_Product p_DAL = new DAL_Product();
        public override Feedback Validate(Product item)
        {
            if (string.IsNullOrWhiteSpace(item.Product_Name) || string.IsNullOrWhiteSpace(item.Product_Description) || string.IsNullOrWhiteSpace(item.Category.ToString()))
            {
                this.AddError("All fields must be informed!");
            }
            else
            {
                item.Product_Name = Normatization.NormatizeString(item.Product_Name, false);
                this.AddError(BaseValidator<Product>.IsValidLength(item.Product_Name, Basic_Values.MinimumLenght, Basic_Values.MaximumLenght_ProductName, "Product name"));
                this.AddError(BaseValidator<Product>.IsValidLength(item.Product_Description, Basic_Values.MinimumLenght, Basic_Values.MaximumLenght_Description, "Product description"));
            }
            return base.Validate(item);
        }

        public Feedback Delete(int id)
        {
            return this.p_DAL.Delete(id);
        }

        public Data_Feedback<Product> GetAll()
        {
            Data_Feedback<Product> response = this.p_DAL.GetAll();
            if (response.Successful && response.Data.Count == Basic_Values.Zero)
            {
                response.Successful = false;
                response.Report = "There are no registered products yet";
            }
            return response;
        }

        public Feedback Insert(Product p)
        {
            Feedback response = this.Validate(p);
            if (!response.Successful)
            {
                return response;
            }
            return p_DAL.Insert(p);
        }

        public Feedback Update(Product p)
        {
            Feedback response = this.Validate(p);
            if (!response.Successful)
            {
                return response;
            }
            return p_DAL.Update(p);
        }
        public Single_Feedback<Product> GetByID(int id)
        {
            return this.p_DAL.GetByID(id);
        }

        public Feedback UpdatePrice_Stock(Product p)
        {
            return p_DAL.UpdatePrice_Stock(p);
        }

        public Feedback UpdateStockOnly(Product p)
        {
            return p_DAL.UpdateStockOnly(p);
        }
    }
}

