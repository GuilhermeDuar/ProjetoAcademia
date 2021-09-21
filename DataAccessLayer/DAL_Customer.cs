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
    public class DAL_Customer : ICustomer
    {
        public Data_Feedback<Customer> GetAll()
        {
            SqlConnection ConnectionString = new SqlConnection(Database_Connection_String.CONNECTION_STRING);
            SqlCommand command = new SqlCommand("SELECT * FROM CUSTOMERS ORDER BY ID", ConnectionString);
            Data_Feedback<Customer> response = new Data_Feedback<Customer>();
            try
            {
                ConnectionString.Open();
                SqlDataReader reader = command.ExecuteReader();
                List<Customer> students = new List<Customer>();
                while (reader.Read())
                {
                    Customer s = new Customer();
                    s.ID = Convert.ToInt32(reader["ID"]);
                    s.Customer_Name = Convert.ToString(reader["CUSTOMER_NAME"]);
                    s.CPF = Convert.ToString(reader["CPF"]);
                    s.RG = Convert.ToString(reader["RG"]);
                    s.First_Phone_Number = Convert.ToString(reader["FIRST_PHONE_NUMBER"]);
                    s.Second_Phone_Number = Convert.ToString(reader["SECOND_PHONE_NUMBER"]);
                    s.Email = Convert.ToString(reader["EMAIL"]);
                    s.BirthDate = Convert.ToDateTime(reader["BIRTHDATE"]);
                    s.Register_Date = Convert.ToDateTime(reader["REGISTER_DATE"]);
                    s.Active = Convert.ToBoolean(reader["ACTIVE"]);
                    students.Add(s);
                }
                response = ResponseFactory<Customer>.CreateSuccessDataResponse(students);
                return response;
            }
            catch (Exception)
            {
                response = ResponseFactory<Customer>.CreateFailedDataResponse(new List<Customer>());
                return response;
            }
            finally
            {
                ConnectionString.Dispose();
            }
        }

        public Single_Feedback<Customer> GetByID(int id)
        {
            SqlConnection ConnectionString = new SqlConnection(Database_Connection_String.CONNECTION_STRING);
            SqlCommand command = new SqlCommand("SELECT * FROM CUSTOMERS WHERE ID = @ID", ConnectionString);
            command.Parameters.AddWithValue("@ID", id);
            Single_Feedback<Customer> response = new Single_Feedback<Customer>();
            Customer match = new Customer();
            try
            {
                ConnectionString.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    match.ID = Convert.ToInt32(reader["ID"]);
                    match.Customer_Name = Convert.ToString(reader["CUSTOMER_NAME"]);
                    match.CPF = Convert.ToString(reader["CPF"]);
                    match.RG = Convert.ToString(reader["RG"]);
                    match.First_Phone_Number = Convert.ToString(reader["FIRST_PHONE_NUMBER"]);
                    match.Second_Phone_Number = Convert.ToString(reader["SECOND_PHONE_NUMBER"]);
                    match.Email = Convert.ToString(reader["EMAIL"]);
                    match.BirthDate = Convert.ToDateTime(reader["BIRTHDATE"]);
                    match.Active = Convert.ToBoolean(reader["ACTIVE"]);
                    return ResponseFactory<Customer>.CreateSuccessSingleResponse(match);
                }
                return response = ResponseFactory<Customer>.CreateFailedSingleResponse(null);
            }
            catch (Exception ex)
            {
                response = ResponseFactory<Customer>.CreateFailedSingleResponse(null);
                return response;
            }
            finally
            {
                ConnectionString.Dispose();
            }
        }

        public Feedback Insert(Customer s)
        {
            SqlConnection ConnectionString = new SqlConnection(Database_Connection_String.CONNECTION_STRING);
            SqlCommand command = new SqlCommand("INSERT INTO CUSTOMERS(CUSTOMER_NAME, CPF, RG, FIRST_PHONE_NUMBER, SECOND_PHONE_NUMBER, EMAIL, BIRTHDATE) VALUES (@CUSTOMER_NAME, @CPF, @RG, @FIRST_PHONE_NUMBER, @SECOND_PHONE_NUMBER, @EMAIL, @BIRTHDATE); SELECT SCOPE_IDENTITY()", ConnectionString);
            command.Parameters.AddWithValue("@CUSTOMER_NAME", s.Customer_Name);
            command.Parameters.AddWithValue("@CPF", s.CPF);
            command.Parameters.AddWithValue("@RG", s.RG);
            command.Parameters.AddWithValue("@FIRST_PHONE_NUMBER", s.First_Phone_Number);
            command.Parameters.AddWithValue("@SECOND_PHONE_NUMBER", s.Second_Phone_Number);
            command.Parameters.AddWithValue("@EMAIL", s.Email);
            command.Parameters.AddWithValue("@BIRTHDATE", s.BirthDate);
            Feedback response = new Feedback();
            try
            {
                ConnectionString.Open();
                s.ID = Convert.ToInt32(command.ExecuteScalar());
                response = ResponseFactory<Customer>.CreateSuccessResponse();
                return response;
            }
            catch (Exception ex)
            {
                response = ResponseFactory<Customer>.CreateFailedResponse();
                if (ex.Message.Contains("UQ__CUSTOMER__161CF724BC209795"))
                {
                    response.Report = "This email is already linked to other customer";
                }
                else if (ex.Message.Contains("UQ__CUSTOMER__C1F89731C13B418D"))
                {
                    response.Report = "This CPF is already linked to other customer";
                }
                else if (ex.Message.Contains("UQ__CUSTOMER__321537C8ED60E367"))
                {
                    response.Report = "This RG is already linked to other customer";
                }
                else if (ex.Message.Contains("UQ__CUSTOMER__2BFEC1912F6FA395"))
                {
                    response.Report = "This phone number is already linked to other customer";
                }
                else if (ex.Message.Contains("UQ__CUSTOMER__6A7260FD99DA7B6A"))
                {
                    response.Report = "This phone number is already linked to other customer";
                }
                return response;
            }
            finally
            {
                ConnectionString.Dispose();
            }
        }
        public Feedback Turn_Activated(int id)
        {
            SqlConnection ConnectionString = new SqlConnection(Database_Connection_String.CONNECTION_STRING);
            SqlCommand command = new SqlCommand("UPDATE CUSTOMERS SET ACTIVE = 1 WHERE ID = @ID", ConnectionString);
            command.Parameters.AddWithValue("@ID", id);
            Feedback response = new Feedback();
            try
            {
                ConnectionString.Open();
                command.ExecuteReader();
                response = ResponseFactory<Customer>.CreateSuccessResponse();
                return response;
            }
            catch (Exception ex)
            {
                response = ResponseFactory<Customer>.CreateFailedResponse();
                return response;
            }
            finally
            {
                ConnectionString.Dispose();
            }
        }
        public Feedback Turn_Desactivated(int id)
        {
            SqlConnection ConnectionString = new SqlConnection(Database_Connection_String.CONNECTION_STRING);
            SqlCommand command = new SqlCommand("UPDATE CUSTOMERS SET ACTIVE = 0 WHERE ID = @ID", ConnectionString);
            command.Parameters.AddWithValue("@ID", id);
            Feedback response = new Feedback();
            try
            {
                ConnectionString.Open();
                command.ExecuteReader();
                response = ResponseFactory<Customer>.CreateSuccessResponse();
                return response;
            }
            catch (Exception ex)
            {
                response = ResponseFactory<Customer>.CreateFailedResponse();
                return response;
            }
            finally
            {
                ConnectionString.Dispose();
            }
        }
        public Feedback Update(Customer s)
        {
            SqlConnection ConnectionString = new SqlConnection(Database_Connection_String.CONNECTION_STRING);
            SqlCommand command = new SqlCommand("UPDATE CUSTOMERS SET CUSTOMER_NAME = @CUSTOMER_NAME, FIRST_PHONE_NUMBER = @FIRST_PHONE_NUMBER, SECOND_PHONE_NUMBER = @SECOND_PHONE_NUMBER, EMAIL = @EMAIL WHERE ID = @ID", ConnectionString);
            command.Parameters.AddWithValue("@ID", s.ID);
            command.Parameters.AddWithValue("@CUSTOMER_NAME", s.Customer_Name);
            command.Parameters.AddWithValue("@FIRST_PHONE_NUMBER", s.First_Phone_Number);
            command.Parameters.AddWithValue("@SECOND_PHONE_NUMBER", s.Second_Phone_Number);
            command.Parameters.AddWithValue("@EMAIL", s.Email);
            Feedback response = new Feedback();
            try
            {
                ConnectionString.Open();
                command.ExecuteReader();
                response = ResponseFactory<Customer>.CreateSuccessResponse();
                return response;
            }
            catch (Exception ex)
            {
                response = ResponseFactory<Customer>.CreateFailedResponse();
                if (ex.Message.Contains("UQ__CUSTOMER__161CF724BC209795"))
                {
                    response.Report = "This email is already linked to other customer";
                }
                else if (ex.Message.Contains("UQ__CUSTOMER__2BFEC1912F6FA395"))
                {
                    response.Report = "This phone number is already linked to other customer";
                }
                else if (ex.Message.Contains("UQ__CUSTOMER__6A7260FD99DA7B6A"))
                {
                    response.Report = "This phone number is already linked to other customer";
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
