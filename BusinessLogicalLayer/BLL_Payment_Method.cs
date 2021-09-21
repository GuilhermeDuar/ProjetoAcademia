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
    public class BLL_Payment_Method : BaseValidator<Payment_Method>, IPayment_Method
    {
        private DAL_Payment_Method pm_DAL = new DAL_Payment_Method();
        public override Feedback Validate(Payment_Method item)
        {
            if (string.IsNullOrWhiteSpace(item.Method))
            {
                this.AddError("New method must be informed!");
            }
            else
            {
                item.Method = Normatization.NormatizeString(item.Method, true);
                this.AddError(BaseValidator<Payment_Method>.IsValidLength(item.Method, Basic_Values.MinimumLenght, Basic_Values.MaximumLenght, "Method"));
            }
            return base.Validate(item);
        }
        public Data_Feedback<Payment_Method> GetAll()
        {
            Data_Feedback<Payment_Method> response = this.pm_DAL.GetAll();
            if (response.Successful && response.Data.Count == Basic_Values.Zero)
            {
                response.Successful = false;
                response.Report = "There are no registered payment methods yet";
            }
            return response;
        }

        public Feedback Insert(Payment_Method pm)
        {
            Feedback response = this.Validate(pm);
            if (!response.Successful)
            {
                return response;
            }
            return pm_DAL.Insert(pm);
        }

        public Feedback Update(Payment_Method pm)
        {
            Feedback response = this.Validate(pm);
            if (!response.Successful)
            {
                return response;
            }

            return pm_DAL.Update(pm);
        }

        public Feedback Delete(int id)
        {
            return pm_DAL.Delete(id);
        }

        public Single_Feedback<Payment_Method> GetByID(int id)
        {
            return pm_DAL.GetByID(id);
        }
    }
}
