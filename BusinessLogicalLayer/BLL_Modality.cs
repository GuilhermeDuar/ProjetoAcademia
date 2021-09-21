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
    public class BLL_Modality : BaseValidator<Modality>, IModality
    {
        private DAL_Modality m_DAL = new DAL_Modality();
        public override Feedback Validate(Modality item)
        {
            if (string.IsNullOrWhiteSpace(item.Modality_Name))
            {
                this.AddError("All fields must be informed!");
            }
            else
            {
                item.Modality_Name = Normatization.NormatizeString(item.Modality_Name, true);
                this.AddError(BaseValidator<Modality>.IsValidLength(item.Modality_Name, Basic_Values.MinimumLenght, Basic_Values.MaximumLenght, "Modality name"));
            }
            return base.Validate(item);
        }

        public Feedback Delete(int id)
        {
            return this.m_DAL.Delete(id);
        }

        public Data_Feedback<Modality> GetAll()
        {
            Data_Feedback<Modality> response = this.m_DAL.GetAll();
            if (response.Successful && response.Data.Count == Basic_Values.Zero)
            {
                response.Successful = false;
                response.Report = "There are no registered modalities yet";
            }
            return response;
        }

        public Feedback Insert(Modality m)
        {
            Feedback response = this.Validate(m);
            if (!response.Successful)
            {
                return response;
            }
            return m_DAL.Insert(m);
        }

        public Feedback Update(Modality m)
        {
            Feedback response = this.Validate(m);
            if (!response.Successful)
            {
                return response;
            }

            return m_DAL.Update(m);
        }

        public Single_Feedback<Modality> GetByID(int id)
        {
            return m_DAL.GetByID(id);
        }
    }
}
