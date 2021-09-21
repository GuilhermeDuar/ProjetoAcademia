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
    public class DAL_Plan : IPlan
    {
        private DAL_Modality m_DAL = new DAL_Modality();
        public Feedback Delete(int id)
        {
            SqlConnection ConnectionString = new SqlConnection(Database_Connection_String.CONNECTION_STRING);
            SqlCommand command = new SqlCommand("DELETE FROM PLANS WHERE ID = @ID", ConnectionString);
            command.Parameters.AddWithValue("@ID", id);
            Feedback response = new Feedback();
            try
            {
                ConnectionString.Open();
                command.ExecuteReader();
                response = ResponseFactory<Plan>.CreateSuccessResponse();
                return response;
            }
            catch (Exception ex)
            {
                response = ResponseFactory<Plan>.CreateFailedResponse();
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    response.Report = "Plan can't be deleted. There's customers linked to it!";
                }
                return response;
            }
            finally
            {
                ConnectionString.Dispose();
            }
        }

        public Data_Feedback<Plan> GetAll()
        {
            SqlConnection ConnectionString = new SqlConnection(Database_Connection_String.CONNECTION_STRING);
            SqlCommand command = new SqlCommand("SELECT * FROM PLANS ORDER BY ID", ConnectionString);
            Data_Feedback<Plan> response = new Data_Feedback<Plan>();
            try
            {
                ConnectionString.Open();
                SqlDataReader reader = command.ExecuteReader();
                List<Plan> schedules = new List<Plan>();
                while (reader.Read())
                {
                    Plan sc = new Plan();
                    sc.ID = Convert.ToInt32(reader["ID"]);
                    sc.Modality_ID = Convert.ToInt32(reader["ID_MODALITY"]);
                    sc.m = m_DAL.GetByID(sc.Modality_ID).Item;
                    sc.Description = Convert.ToString(reader["DESCRIPTION"]);
                    sc.Price = Convert.ToDouble(reader["PRICE"]);
                    schedules.Add(sc);
                }
                response = ResponseFactory<Plan>.CreateSuccessDataResponse(schedules);
                return response;
            }
            catch (Exception)
            {
                response = ResponseFactory<Plan>.CreateFailedDataResponse(new List<Plan>());
                return response;
            }
            finally
            {
                ConnectionString.Dispose();
            }
        }

        public Single_Feedback<Plan> GetByID(int id)
        {
            SqlConnection ConnectionString = new SqlConnection(Database_Connection_String.CONNECTION_STRING);
            SqlCommand command = new SqlCommand("SELECT * FROM PLANS WHERE ID = @ID", ConnectionString);
            command.Parameters.AddWithValue("@ID", id);
            Single_Feedback<Plan> response = new Single_Feedback<Plan>();
            Plan match = new Plan();
            try
            {
                ConnectionString.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    match.ID = Convert.ToInt32(reader["ID"]);
                    match.Modality_ID = Convert.ToInt32(reader["ID_MODALITY"]);
                    match.m = m_DAL.GetByID(match.Modality_ID).Item;
                    match.Description = Convert.ToString(reader["DESCRIPTION"]);
                    match.Price = Convert.ToDouble(reader["PRICE"]);
                    return ResponseFactory<Plan>.CreateSuccessSingleResponse(match);
                }
                return response = ResponseFactory<Plan>.CreateFailedSingleResponse(null);
            }
            catch (Exception ex)
            {
                response = ResponseFactory<Plan>.CreateFailedSingleResponse(null);
                return response;
            }
            finally
            {
                ConnectionString.Dispose();
            }
        }

        public Feedback Insert(Plan sc)
        {
            SqlConnection ConnectionString = new SqlConnection(Database_Connection_String.CONNECTION_STRING);
            SqlCommand command = new SqlCommand("INSERT INTO PLANS(ID_MODALITY, DESCRIPTION, PRICE) VALUES (@ID, @DESC, @PRICE)", ConnectionString);
            command.Parameters.AddWithValue("@ID", sc.Modality_ID);
            command.Parameters.AddWithValue("@DESC", sc.Description);
            command.Parameters.AddWithValue("@PRICE", sc.Price);
            Feedback response = new Feedback();
            try
            {
                ConnectionString.Open();
                command.ExecuteNonQuery();
                response = ResponseFactory<Plan>.CreateSuccessResponse();
                return response;
            }
            catch (Exception ex)
            {
                response = ResponseFactory<Plan>.CreateFailedResponse();
                if (ex.Message.Contains("Violation of UNIQUE KEY"))
                {
                    response.Report = "This description in already linked to other plan!";
                }
                return response;
            }
            finally
            {
                ConnectionString.Dispose();
            }
        }

        public Feedback Update(Plan sc)
        {
            SqlConnection ConnectionString = new SqlConnection(Database_Connection_String.CONNECTION_STRING);
            SqlCommand command = new SqlCommand("UPDATE PLANS SET ID_MODALITY = @MODALITY_ID, DESCRIPTION = @DESC, PRICE = @PRICE WHERE ID = @ID", ConnectionString);
            command.Parameters.AddWithValue("@ID", sc.ID);
            command.Parameters.AddWithValue("@MODALITY_ID", sc.Modality_ID);
            command.Parameters.AddWithValue("@DESC", sc.Description);
            command.Parameters.AddWithValue("@PRICE", sc.Price);
            Feedback response = new Feedback();
            try
            {
                ConnectionString.Open();
                command.ExecuteReader();
                response = ResponseFactory<Plan>.CreateSuccessResponse();
                return response;
            }
            catch (Exception ex)
            {
                response = ResponseFactory<Plan>.CreateFailedResponse();
                if (ex.Message.Contains("Violation of UNIQUE KEY"))
                {
                    response.Report = "This description in already linked to other plan!";
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
