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
    public class BLL_Customer : BaseValidator<Customer>, ICustomer
    {
        private DAL_Customer s_DAL = new DAL_Customer();
        public override Feedback Validate(Customer item)
        {
            if (string.IsNullOrWhiteSpace(item.Customer_Name) || string.IsNullOrWhiteSpace(item.CPF) || string.IsNullOrWhiteSpace(item.RG) || string.IsNullOrWhiteSpace(item.First_Phone_Number) || string.IsNullOrWhiteSpace(item.Second_Phone_Number) || string.IsNullOrWhiteSpace(item.Email) || string.IsNullOrWhiteSpace(item.BirthDate.ToString()) || string.IsNullOrWhiteSpace(item.Register_Date.ToString()))
            {
                this.AddError("All fields must be informed!");
            }
            else
            {
                this.AddError(BaseValidator<Customer>.IsValidLength(item.Customer_Name, Basic_Values.MinimumLenght, Basic_Values.MaximumLenght_Name, "Name"));
                this.AddError(BaseValidator<Customer>.IsValidLength("CPF", Basic_Values.FixedLenght_CPF, item.CPF));
                this.AddError(BaseValidator<Customer>.IsValidLength("RG", Basic_Values.FixedLenght_RG, item.RG));
                this.AddError(BaseValidator<Customer>.IsValidLength(item.First_Phone_Number, Basic_Values.MinimumLenght_PhoneNumber, Basic_Values.MaximumLenght_PhoneNumber, "First Phone Number"));
                this.AddError(BaseValidator<Customer>.IsValidLength(item.Second_Phone_Number, Basic_Values.MinimumLenght_PhoneNumber, Basic_Values.MaximumLenght_PhoneNumber, "Second Phone Number"));
                this.AddError(BaseValidator<Customer>.IsValidLength(item.Email, Basic_Values.MinimumLenght, Basic_Values.MaximumLenght_Email, "Email"));
                this.AddError(BaseValidator<Customer>.AssertOnlyLetters(item.Customer_Name, "Customer name"));
                this.AddError(BaseValidator<Customer>.IsValidAge(item.BirthDate));
                item.Customer_Name = Normatization.NormatizeString(item.Customer_Name, false);
            }
            return base.Validate(item);
        }
        public Data_Feedback<Customer> GetAll()
        {
            Data_Feedback<Customer> response = this.s_DAL.GetAll();
            if (response.Successful && response.Data.Count == Basic_Values.Zero)
            {
                response.Successful = false;
                response.Report = "There are no registered customers yet";
            }
            return response;
        }

        public Feedback Insert(Customer s)
        {
            Feedback response = this.Validate(s);
            if (!response.Successful)
            {
                return response;
            }
            return s_DAL.Insert(s);
        }

        public Feedback Turn_Activated(int id)
        {
            return s_DAL.Turn_Activated(id);
        }

        public Feedback Turn_Desactivated(int id)
        {
            return s_DAL.Turn_Desactivated(id);
        }

        public Feedback Update(Customer s)
        {
            Feedback response = this.Validate(s);
            if (!response.Successful)
            {
                return response;
            }

            return s_DAL.Update(s);
        }

        public Single_Feedback<Customer> GetByID(int id)
        {
            return s_DAL.GetByID(id);
        }
    }
}
