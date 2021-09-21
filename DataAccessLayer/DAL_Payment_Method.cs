using Metadata;
using Metadata.Interfaces;
using Shared;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DAL_Payment_Method : IPayment_Method
    {
        public Feedback Delete(int id)
        {
            SqlConnection ConnectionString = new SqlConnection(Database_Connection_String.CONNECTION_STRING);
            SqlCommand command = new SqlCommand("DELETE FROM PAYMENT_METHODS WHERE ID = @ID", ConnectionString);
            command.Parameters.AddWithValue("@ID", id);
            Feedback response = new Feedback();
            try
            {
                ConnectionString.Open();
                command.ExecuteReader();
                response = ResponseFactory<Payment_Method>.CreateSuccessResponse();
                return response;
            }
            catch (Exception ex)
            {
                response = ResponseFactory<Payment_Method>.CreateFailedResponse();
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    response.Report = "Method can't be deleted. There's importation linked to it!";
                }
                return response;
            }
            finally
            {
                ConnectionString.Dispose();
            }
        }
        public Data_Feedback<Payment_Method> GetAll()
        {
            SqlConnection ConnectionString = new SqlConnection(Database_Connection_String.CONNECTION_STRING);
            SqlCommand command = new SqlCommand("SELECT * FROM PAYMENT_METHODS ORDER BY ID", ConnectionString);
            Data_Feedback<Payment_Method> response = new Data_Feedback<Payment_Method>();
            try
            {
                ConnectionString.Open();
                SqlDataReader reader = command.ExecuteReader();
                List<Payment_Method> pms = new List<Payment_Method>();
                while (reader.Read())
                {
                    Payment_Method pm = new Payment_Method();
                    pm.ID = Convert.ToInt32(reader["ID"]);
                    pm.Method = Convert.ToString(reader["METHOD"]);
                    pms.Add(pm);
                }
                response = ResponseFactory<Payment_Method>.CreateSuccessDataResponse(pms);
                return response;
            }
            catch (Exception)
            {
                response = ResponseFactory<Payment_Method>.CreateFailedDataResponse(new List<Payment_Method>());
                return response;
            }
            finally
            {
                ConnectionString.Dispose();
            }
        }

        public Single_Feedback<Payment_Method> GetByID(int id)
        {
            SqlConnection ConnectionString = new SqlConnection(Database_Connection_String.CONNECTION_STRING);
            SqlCommand command = new SqlCommand("SELECT * FROM PAYMENT_METHODS WHERE ID = @ID", ConnectionString);
            command.Parameters.AddWithValue("@ID", id);
            Single_Feedback<Payment_Method> response = new Single_Feedback<Payment_Method>();
            Payment_Method match = new Payment_Method();
            try
            {
                ConnectionString.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    match.ID = Convert.ToInt32(reader["ID"]);
                    match.Method = Convert.ToString(reader["METHOD"]);
                    return ResponseFactory<Payment_Method>.CreateSuccessSingleResponse(match);
                }
                return response = ResponseFactory<Payment_Method>.CreateFailedSingleResponse(null);
            }
            catch (Exception ex)
            {
                response = ResponseFactory<Payment_Method>.CreateFailedSingleResponse(null);
                return response;
            }
            finally
            {
                ConnectionString.Dispose();
            }
        }

        public Feedback Insert(Payment_Method m)
        {
            SqlConnection ConnectionString = new SqlConnection(Database_Connection_String.CONNECTION_STRING);
            SqlCommand command = new SqlCommand("INSERT INTO PAYMENT_METHODS(METHOD) VALUES (@NAME)", ConnectionString);
            command.Parameters.AddWithValue("@NAME", m.Method);
            Feedback response = new Feedback();
            try
            {
                ConnectionString.Open();
                command.ExecuteNonQuery();
                response = ResponseFactory<Payment_Method>.CreateSuccessResponse();
                return response;
            }
            catch (Exception ex)
            {
                response = ResponseFactory<Payment_Method>.CreateFailedResponse();
                if (ex.Message.Contains("Violation of UNIQUE KEY"))
                {
                    response.Report = "This method already exists!";
                }
                return response;
            }
            finally
            {
                ConnectionString.Dispose();
            }
        }

        public Feedback Update(Payment_Method m)
        {
            SqlConnection ConnectionString = new SqlConnection(Database_Connection_String.CONNECTION_STRING);
            SqlCommand command = new SqlCommand("UPDATE PAYMENT_METHODS SET METHOD = @NAME WHERE ID = @ID", ConnectionString);
            command.Parameters.AddWithValue("@NAME", m.Method);
            command.Parameters.AddWithValue("@ID", m.ID);
            Feedback response = new Feedback();
            try
            {
                ConnectionString.Open();
                command.ExecuteReader();
                response = ResponseFactory<Payment_Method>.CreateSuccessResponse();
                return response;
            }
            catch (Exception ex)
            {
                response = ResponseFactory<Payment_Method>.CreateFailedResponse();
                if (ex.Message.Contains("Violation of UNIQUE KEY"))
                {
                    response.Report = "This method already exists!";
                }
                return response;
            }
            finally
            {
                ConnectionString.Dispose();
            }
        }
    }
}