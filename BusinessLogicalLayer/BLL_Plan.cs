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
    public class BLL_Plan : BaseValidator<Plan>, IPlan
    {
        private DAL_Plan sc_DAL = new DAL_Plan();
        public override Feedback Validate(Plan item)
        {
            if (string.IsNullOrWhiteSpace(item.Modality_ID.ToString()) || string.IsNullOrWhiteSpace(item.Description) || string.IsNullOrWhiteSpace(item.Price.ToString()))
            {
                this.AddError("All fields must be informed!");
            }
            else
            {
                this.AddError(BaseValidator<Plan>.IsValidLength(item.Description, Basic_Values.MinimumLenght, Basic_Values.MaximumLenght_Description, "description"));
                this.AddError(BaseValidator<Plan>.IsValidPrice(item.Price, Basic_Values.MinimumSchedulePrice));
            }
            return base.Validate(item);
        }
        public Feedback Delete(int id)
        {
            return this.sc_DAL.Delete(id);
        }

        public Data_Feedback<Plan> GetAll()
        {
            Data_Feedback<Plan> response = this.sc_DAL.GetAll();
            if (response.Successful && response.Data.Count == Basic_Values.Zero)
            {
                response.Successful = false;
                response.Report = "There are no registered plans yet";
            }
            return response;
        }

        public Single_Feedback<Plan> GetByID(int id)
        {
            return sc_DAL.GetByID(id);
        }

        public Feedback Insert(Plan sc)
        {
            Feedback response = this.Validate(sc);
            if (!response.Successful)
            {
                return response;
            }
            return sc_DAL.Insert(sc);
        }

        public Feedback Update(Plan sc)
        {
            Feedback response = this.Validate(sc);
            if (!response.Successful)
            {
                return response;
            }
            return sc_DAL.Update(sc);
        }
    }
}
