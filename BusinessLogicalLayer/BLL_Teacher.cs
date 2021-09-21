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
    public class BLL_Teacher : BaseValidator<Teacher>, ITeacher
    {
        private DAL_Teacher t_DAL = new DAL_Teacher();
        public override Feedback Validate(Teacher item)
        {
            if (string.IsNullOrWhiteSpace(item.Teacher_Name) || string.IsNullOrWhiteSpace(item.CPF) || string.IsNullOrWhiteSpace(item.RG) || string.IsNullOrWhiteSpace(item.Adress) || string.IsNullOrWhiteSpace(item.Phone_Number) || string.IsNullOrWhiteSpace(item.Wage.ToString()))
            {
                this.AddError("All fields must be informed!");
            }
            else
            {
                this.AddError(BaseValidator<Teacher>.IsValidLength(item.Teacher_Name, Basic_Values.MinimumLenght, Basic_Values.MaximumLenght_Name, "Name"));
                this.AddError(BaseValidator<Teacher>.IsValidLength("CPF", item.CPF, Basic_Values.FixedLenght_CPF));
                this.AddError(BaseValidator<Teacher>.IsValidLength("RG", item.RG, Basic_Values.FixedLenght_RG));
                this.AddError(BaseValidator<Teacher>.IsValidLength(item.Phone_Number, Basic_Values.MinimumLenght_PhoneNumber, Basic_Values.MaximumLenght_PhoneNumber, "Phone Number"));
                this.AddError(BaseValidator<Teacher>.IsValidLength(item.Adress, Basic_Values.MinimumLenght, Basic_Values.MaximumLenght_Adress, "Adress"));
                this.AddError(BaseValidator<Teacher>.IsValidPrice(item.Wage, Basic_Values.MinimumSalary));
                this.AddError(BaseValidator<Teacher>.AssertOnlyLetters(item.Teacher_Name, "Teacher name"));
                item.Teacher_Name = Normatization.NormatizeString(item.Teacher_Name, false);
            }
            return base.Validate(item);
        }
        public Data_Feedback<Teacher> GetAll()
        {
            Data_Feedback<Teacher> response = this.t_DAL.GetAll();
            if (response.Successful && response.Data.Count == Basic_Values.Zero)
            {
                response.Successful = false;
                response.Report = "There are no registered teachers yet";
            }
            return response;
        }

        public Feedback Insert(Teacher t)
        {
            Feedback response = this.Validate(t);
            if (!response.Successful)
            {
                return response;
            }
            return t_DAL.Insert(t);
        }

        public Feedback Turn_Activated(int id)
        {
            return t_DAL.Turn_Activated(id);
        }

        public Feedback Turn_Desactivated(int id)
        {
            return t_DAL.Turn_Desactivated(id);
        }

        public Feedback Update(Teacher t)
        {
            Feedback response = this.Validate(t);
            if (!response.Successful)
            {
                return response;
            }

            return t_DAL.Update(t);
        }
    }
}

