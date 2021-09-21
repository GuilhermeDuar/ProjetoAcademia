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
    public class BLL_Category : BaseValidator<Category>, ICategory
    {
        private DAL_Category c_DAL = new DAL_Category();
        public override Feedback Validate(Category item)
        {
            if (string.IsNullOrWhiteSpace(item.Category_Name))
            {
                this.AddError("New category must be informed!");
            }
            else
            {
                item.Category_Name = Normatization.NormatizeString(item.Category_Name, true);
                this.AddError(BaseValidator<Category>.IsValidLength(item.Category_Name, Basic_Values.MinimumLenght, Basic_Values.MaximumLenght_Category, "Category Name"));
            }
            return base.Validate(item);
        }

        public Feedback Delete(int id)
        {
            return this.c_DAL.Delete(id);
        }

        public Data_Feedback<Category> GetAll()
        {
            Data_Feedback<Category> response = this.c_DAL.GetAll();
            if (response.Successful && response.Data.Count == Basic_Values.Zero)
            {
                response.Successful = false;
                response.Report = "There are no registered categories yet";
            }
            return response;
        }

        public Feedback Insert(Category c)
        {
            Feedback response = this.Validate(c);
            if (!response.Successful)
            {
                return response;
            }
            return c_DAL.Insert(c);
        }

        public Feedback Update(Category c)
        {
            Feedback response = this.Validate(c);
            if (!response.Successful)
            {
                return response;
            }

            return c_DAL.Update(c);
        }

        public Single_Feedback<Category> GetByID(int id)
        {
            return c_DAL.GetByID(id);
        }
    }
}
