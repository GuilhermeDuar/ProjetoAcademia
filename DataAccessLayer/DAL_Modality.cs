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
    public class DAL_Modality : IModality
    {
        public Feedback Delete(int id)
        {
            SqlConnection ConnectionString = new SqlConnection(Database_Connection_String.CONNECTION_STRING);
            SqlCommand command = new SqlCommand("DELETE FROM MODALITIES WHERE ID = @ID", ConnectionString);
            command.Parameters.AddWithValue("@ID", id);
            Feedback response = new Feedback();
            try
            {
                ConnectionString.Open();
                command.ExecuteReader();
                response = ResponseFactory<Modality>.CreateSuccessResponse();
                return response;
            }
            catch (Exception ex)
            {
                response = ResponseFactory<Modality>.CreateFailedResponse();
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    response.Report = "Modality can't be deleted. There's Schedules linked to it!";
                }
                return response;
            }
            finally
            {
                ConnectionString.Dispose();
            }
        }
        public Data_Feedback<Modality> GetAll()
        {
            SqlConnection ConnectionString = new SqlConnection(Database_Connection_String.CONNECTION_STRING);
            SqlCommand command = new SqlCommand("SELECT * FROM MODALITIES ORDER BY ID", ConnectionString);
            Data_Feedback<Modality> response = new Data_Feedback<Modality>();
            try
            {
                ConnectionString.Open();
                SqlDataReader reader = command.ExecuteReader();
                List<Modality> modalities = new List<Modality>();
                while (reader.Read())
                {
                    Modality m = new Modality();
                    m.ID = Convert.ToInt32(reader["ID"]);
                    m.Modality_Name = Convert.ToString(reader["MODALITY_NAME"]);
                    modalities.Add(m);
                }
                response = ResponseFactory<Modality>.CreateSuccessDataResponse(modalities);
                return response;
            }
            catch (Exception)
            {
                response = ResponseFactory<Modality>.CreateFailedDataResponse(new List<Modality>());
                return response;
            }
            finally
            {
                ConnectionString.Dispose();
            }
        }

        public Single_Feedback<Modality> GetByID(int id)
        {
            SqlConnection ConnectionString = new SqlConnection(Database_Connection_String.CONNECTION_STRING);
            SqlCommand command = new SqlCommand("SELECT * FROM MODALITIES WHERE ID = @ID", ConnectionString);
            command.Parameters.AddWithValue("@ID", id);
            Single_Feedback<Modality> response = new Single_Feedback<Modality>();
            Modality match = new Modality();
            try
            {
                ConnectionString.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    match.ID = Convert.ToInt32(reader["ID"]);
                    match.Modality_Name = Convert.ToString(reader["MODALITY_NAME"]);
                    return ResponseFactory<Modality>.CreateSuccessSingleResponse(match);
                }
                return response = ResponseFactory<Modality>.CreateFailedSingleResponse(null);
            }
            catch (Exception ex)
            {
                response = ResponseFactory<Modality>.CreateFailedSingleResponse(null);
                return response;
            }
            finally
            {
                ConnectionString.Dispose();
            }
        }

        public Feedback Insert(Modality m)
        {
            SqlConnection ConnectionString = new SqlConnection(Database_Connection_String.CONNECTION_STRING);
            SqlCommand command = new SqlCommand("INSERT INTO MODALITIES(MODALITY_NAME) VALUES (@NAME)", ConnectionString);
            command.Parameters.AddWithValue("@NAME", m.Modality_Name);
            Feedback response = new Feedback();
            try
            {
                ConnectionString.Open();
                command.ExecuteNonQuery();
                response = ResponseFactory<Modality>.CreateSuccessResponse();
                return response;
            }
            catch (Exception ex)
            {
                response = ResponseFactory<Modality>.CreateFailedResponse();
                if (ex.Message.Contains("Violation of UNIQUE KEY"))
                {
                    response.Report = "This modality already exists!";
                }
                return response;
            }
            finally
            {
                ConnectionString.Dispose();
            }
        }

        public Feedback Update(Modality m)
        {
            SqlConnection ConnectionString = new SqlConnection(Database_Connection_String.CONNECTION_STRING);
            SqlCommand command = new SqlCommand("UPDATE MODALITIES SET MODALITY_NAME = @NAME WHERE ID = @ID", ConnectionString);
            command.Parameters.AddWithValue("@NAME", m.Modality_Name);
            command.Parameters.AddWithValue("@ID", m.ID);
            Feedback response = new Feedback();
            try
            {
                ConnectionString.Open();
                command.ExecuteReader();
                response = ResponseFactory<Modality>.CreateSuccessResponse();
                return response;
            }
            catch (Exception ex)
            {
                response = ResponseFactory<Modality>.CreateFailedResponse();
                if (ex.Message.Contains("Violation of UNIQUE KEY"))
                {
                    response.Report = "This modality already exists!";
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
