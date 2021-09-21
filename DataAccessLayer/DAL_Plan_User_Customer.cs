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
    public class DAL_Plan_User_Customer : IPlan_User_Customer
    {
        private DAL_Plan pl_DAL = new DAL_Plan();
        private DAL_User u_DAL = new DAL_User();
        private DAL_Customer c_DAL = new DAL_Customer();
        public Data_Feedback<Plan_User_Customer> GetAll()
        {
            SqlConnection ConnectionString = new SqlConnection(Database_Connection_String.CONNECTION_STRING);
            SqlCommand command = new SqlCommand("SELECT * FROM PLAN_USER_CUSTOMER", ConnectionString);
            Data_Feedback<Plan_User_Customer> response = new Data_Feedback<Plan_User_Customer>();
            try
            {
                ConnectionString.Open();
                SqlDataReader reader = command.ExecuteReader();
                List<Plan_User_Customer> pucs = new List<Plan_User_Customer>();
                while (reader.Read())
                {
                    Plan_User_Customer puc = new Plan_User_Customer();
                    puc.ID_plan = Convert.ToInt32(reader["ID_PLAN"]);
                    puc.ID_user = Convert.ToInt32(reader["ID_REGISTER"]);
                    puc.ID_customer = Convert.ToInt32(reader["ID_CUSTOMER"]);
                    puc.The_Plan = pl_DAL.GetByID(puc.ID_plan).Item;
                    puc.The_Customer = c_DAL.GetByID(puc.ID_customer).Item;
                    puc.The_User = u_DAL.GetByID(puc.ID_user).Item;
                    puc.Active = Convert.ToBoolean(reader["ACTIVE"]);
                    pucs.Add(puc);
                }
                response = ResponseFactory<Plan_User_Customer>.CreateSuccessDataResponse(pucs);
                return response;
            }
            catch (Exception ex)
            {
                response = ResponseFactory<Plan_User_Customer>.CreateFailedDataResponse(new List<Plan_User_Customer>());
                return response;
            }
            finally
            {
                ConnectionString.Dispose();
            }
        }

        public Single_Feedback<Plan_User_Customer> GetByID(int c_id, int pl_id)
        {
            SqlConnection connectionString = new SqlConnection(Database_Connection_String.CONNECTION_STRING);
            SqlCommand command = new SqlCommand("SELECT * FROM PLAN_USER_CUSTOMER WHERE ID_CUSTOMER = @c_id AND ID_PLAN = @pl_id", connectionString);
            command.Parameters.AddWithValue("@c_id", c_id);
            command.Parameters.AddWithValue("@pl_id", pl_id);
            Single_Feedback<Plan_User_Customer> response = new Single_Feedback<Plan_User_Customer>();
            Plan_User_Customer puc = new Plan_User_Customer();
            try
            {
                connectionString.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    puc.ID_plan = Convert.ToInt32(reader["ID_PLAN"]);
                    puc.ID_user = Convert.ToInt32(reader["ID_REGISTER"]);
                    puc.ID_customer = Convert.ToInt32(reader["ID_CUSTOMER"]);
                    puc.The_Plan = pl_DAL.GetByID(puc.ID_plan).Item;
                    puc.The_Customer = c_DAL.GetByID(puc.ID_customer).Item;
                    puc.The_User = u_DAL.GetByID(puc.ID_user).Item;
                    puc.Active = Convert.ToBoolean(reader["ACTIVE"]);
                }
                return ResponseFactory<Plan_User_Customer>.CreateSuccessSingleResponse(puc);
            }
            catch (Exception)
            {
                response = ResponseFactory<Plan_User_Customer>.CreateFailedSingleResponse(new Plan_User_Customer());
                return response;
            }
            finally
            {
                connectionString.Dispose();
            }
        }

        public Feedback Insert(Plan_User_Customer puc)
        {
            SqlConnection ConnectionString = new SqlConnection(Database_Connection_String.CONNECTION_STRING);
            SqlCommand command = new SqlCommand(@"INSERT INTO PLAN_USER_CUSTOMER(ID_PLAN, ID_CUSTOMER, ID_REGISTER) VALUES (@pl_id, @c_id, @u_id)", ConnectionString);
            command.Parameters.AddWithValue("@pl_id", puc.ID_plan);
            command.Parameters.AddWithValue("@c_id", puc.ID_customer);
            command.Parameters.AddWithValue("@u_id", puc.ID_user);
            Feedback response = new Feedback();
            try
            {
                ConnectionString.Open();
                command.ExecuteNonQuery();
                response = ResponseFactory<Plan_User_Customer>.CreateSuccessResponse();
                return response;
            }
            catch (Exception ex)
            {
                response = ResponseFactory<Plan_User_Customer>.CreateFailedResponse();
                if (ex.Message.Contains("Violation of PRIMARY KEY"))
                {
                    response.Report = "This user is already registered in this plan!";
                }
                return response;
            }
            finally
            {
                ConnectionString.Dispose();
            }
        }

        public Feedback Turn_Activate(int c_id, int pl_id)
        {
            SqlConnection ConnectionString = new SqlConnection(Database_Connection_String.CONNECTION_STRING);
            SqlCommand command = new SqlCommand("UPDATE PLAN_USER_CUSTOMER SET ACTIVE = 1 WHERE ID_PLAN = @pl AND ID_CUSTOMER = @c", ConnectionString);
            command.Parameters.AddWithValue("@pl", pl_id);
            command.Parameters.AddWithValue("@c", c_id);
            Feedback response = new Feedback();
            try
            {
                ConnectionString.Open();
                command.ExecuteReader();
                response = ResponseFactory<Plan_User_Customer>.CreateSuccessResponse();
                return response;
            }
            catch (Exception ex)
            {
                response = ResponseFactory<Plan_User_Customer>.CreateFailedResponse();
                return response;
            }
            finally
            {
                ConnectionString.Dispose();
            }
        }

        public Feedback Turn_Desactivated(int c_id, int pl_id)
        {
            SqlConnection ConnectionString = new SqlConnection(Database_Connection_String.CONNECTION_STRING);
            SqlCommand command = new SqlCommand("UPDATE PLAN_USER_CUSTOMER SET ACTIVE = 0 WHERE ID_PLAN = @pl AND ID_CUSTOMER = @c", ConnectionString);
            command.Parameters.AddWithValue("@pl", pl_id);
            command.Parameters.AddWithValue("@c", c_id);
            Feedback response = new Feedback();
            try
            {
                ConnectionString.Open();
                command.ExecuteNonQuery();
                response = ResponseFactory<Plan_User_Customer>.CreateSuccessResponse();
                return response;
            }
            catch (Exception ex)
            {
                response = ResponseFactory<Plan_User_Customer>.CreateFailedResponse();
                return response;
            }
            finally
            {
                ConnectionString.Dispose();
            }
        }
    }
}
