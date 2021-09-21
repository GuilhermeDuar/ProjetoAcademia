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
    public class DAL_User : IUser
    {
        public Data_Feedback<User> GetAll()
        {
            SqlConnection ConnectionString = new SqlConnection(Database_Connection_String.CONNECTION_STRING);
            SqlCommand command = new SqlCommand("SELECT * FROM USERS ORDER BY ID", ConnectionString);
            Data_Feedback<User> response = new Data_Feedback<User>();
            try
            {
                ConnectionString.Open();
                SqlDataReader reader = command.ExecuteReader();
                List<User> users = new List<User>();
                while (reader.Read())
                {
                    User u = new User();
                    u.ID = Convert.ToInt32(reader["ID"]);
                    u.Email = Convert.ToString(reader["EMAIL"]);
                    u.User_Password = Convert.ToString(reader["USER_PASSWORD"]);
                    u.Role = (Users_Role)reader["USER_ROLE"];
                    u.Active = Convert.ToBoolean(reader["ACTIVE"]);
                    users.Add(u);
                }
                response = ResponseFactory<User>.CreateSuccessDataResponse(users);
                return response;
            }
            catch (Exception)
            {
                response = ResponseFactory<User>.CreateFailedDataResponse(new List<User>());
                return response;
            }
            finally
            {
                ConnectionString.Dispose();
            }
        }

        public Feedback Insert(User u)
        {
            SqlConnection ConnectionString = new SqlConnection(Database_Connection_String.CONNECTION_STRING);
            SqlCommand command = new SqlCommand(@"INSERT INTO USERS(EMAIL, USER_PASSWORD, USER_ROLE) VALUES (@EMAIL, @USER_PASSWORD, @USER_ROLE); SELECT SCOPE_IDENTITY()", ConnectionString);
            command.Parameters.AddWithValue("@EMAIL", u.Email);
            command.Parameters.AddWithValue("@USER_PASSWORD", u.User_Password);
            command.Parameters.AddWithValue("@USER_ROLE", (int)u.Role);
            Feedback response = new Feedback();
            try
            {
                ConnectionString.Open();
                u.ID = Convert.ToInt32(command.ExecuteScalar());
                response = ResponseFactory<User>.CreateSuccessResponse();
                return response;
            }
            catch (Exception ex)
            {
                response = ResponseFactory<User>.CreateFailedResponse();
                if (ex.Message.Contains("Violation of UNIQUE KEY"))
                {
                    response.Report = "This user already exists!";
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
            SqlCommand command = new SqlCommand("UPDATE USERS SET ACTIVE = 1 WHERE ID = @ID", ConnectionString);
            command.Parameters.AddWithValue("@ID", id);
            Feedback response = new Feedback();
            try
            {
                ConnectionString.Open();
                command.ExecuteReader();
                response = ResponseFactory<User>.CreateSuccessResponse();
                return response;
            }
            catch (Exception ex)
            {
                response = ResponseFactory<User>.CreateFailedResponse();
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
            SqlCommand command = new SqlCommand("UPDATE USERS SET ACTIVE = 0 WHERE ID = @ID", ConnectionString);
            command.Parameters.AddWithValue("@ID", id);
            Feedback response = new Feedback();
            try
            {
                ConnectionString.Open();
                command.ExecuteNonQuery();
                response = ResponseFactory<User>.CreateSuccessResponse();
                return response;
            }
            catch (Exception ex)
            {
                response = ResponseFactory<User>.CreateFailedResponse();
                return response;
            }
            finally
            {
                ConnectionString.Dispose();
            }
        }

        public Feedback Update(User u)
        {
            SqlConnection ConnectionString = new SqlConnection(Database_Connection_String.CONNECTION_STRING);
            SqlCommand command = new SqlCommand("UPDATE USERS SET EMAIL = @EMAIL, USER_PASSWORD = @USER_PASSWORD, USER_ROLE = @USER_ROLE WHERE ID = @ID", ConnectionString);
            command.Parameters.AddWithValue("@ID", u.ID);
            command.Parameters.AddWithValue("@EMAIL", u.Email);
            command.Parameters.AddWithValue("@USER_PASSWORD", u.User_Password);
            command.Parameters.AddWithValue("@USER_ROLE", (int)u.Role);
            Feedback response = new Feedback();
            try
            {
                ConnectionString.Open();
                command.ExecuteReader();
                response = ResponseFactory<User>.CreateSuccessResponse();
                return response;
            }
            catch (Exception ex)
            {
                response = ResponseFactory<User>.CreateFailedResponse();
                if (ex.Message.Contains("Violation of UNIQUE KEY"))
                {
                    response.Report = "This user already exists!";
                }
                return response;
            }
            finally
            {
                ConnectionString.Dispose();
            }
        }
        public Single_Feedback<User> Search(User u)
        {
            SqlConnection ConnectionString = new SqlConnection(Database_Connection_String.CONNECTION_STRING);
            SqlCommand command = new SqlCommand("SELECT * FROM USERS WHERE EMAIL = @EMAIL AND USER_PASSWORD = @USER_PASSWORD", ConnectionString);
            command.Parameters.AddWithValue("@EMAIL", u.Email);
            command.Parameters.AddWithValue("@USER_PASSWORD", u.User_Password);
            Single_Feedback<User> response = new Single_Feedback<User>();
            User match = new User();
            try
            {
                ConnectionString.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    match.ID = Convert.ToInt32(reader["ID"]);
                    match.Email = Convert.ToString(reader["EMAIL"]);
                    match.User_Password = Convert.ToString(reader["USER_PASSWORD"]);
                    match.Role = (Users_Role)Convert.ToInt32(reader["USER_ROLE"]);
                    match.Active = Convert.ToBoolean(reader["ACTIVE"]);
                    return ResponseFactory<User>.CreateSuccessSingleResponse(match);
                }
                return response = ResponseFactory<User>.CreateFailedSingleResponse(null);
            }
            catch (Exception ex)
            {
                response = ResponseFactory<User>.CreateFailedSingleResponse(null);
                return response;
            }
            finally
            {
                ConnectionString.Dispose();
            }
        }
        public Single_Feedback<Teacher> MatchTeacher (User u)
        {
            SqlConnection ConnectionString = new SqlConnection(Database_Connection_String.CONNECTION_STRING);
            SqlCommand command = new SqlCommand(@"SELECT * FROM TEACHERS WHERE USER_ID = @USER_ID", ConnectionString);
            command.Parameters.AddWithValue("@USER_ID", u.ID);
            Single_Feedback<Teacher> response = new Single_Feedback<Teacher>();
            Teacher t = new Teacher();
            try
            {
                ConnectionString.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    t.ID = Convert.ToInt32(reader["ID"]);
                    t.Teacher_Name = Convert.ToString(reader["TEACHER_NAME"]);
                    t.CPF = Convert.ToString(reader["CPF"]);
                    t.RG = Convert.ToString(reader["RG"]);
                    t.Adress = Convert.ToString(reader["ADRESS"]);
                    t.Phone_Number = Convert.ToString(reader["PHONE_NUMBER"]);
                    t.Wage = Convert.ToDouble(reader["WAGE"]);
                    t.Comission = Convert.ToDouble(reader["COMISSION"]);
                    t.User_ID = Convert.ToInt32(reader["USER_ID"]);
                }
                response = ResponseFactory<Teacher>.CreateSuccessSingleResponse(t);
                return response;
            }
            catch (Exception ex)
            {
                response = ResponseFactory<Teacher>.CreateFailedSingleResponse(null);
                return response;
            }
            finally
            {
                ConnectionString.Dispose();
            }
        }
        public Feedback Delete(int id)
        {
            SqlConnection ConnectionString = new SqlConnection(Database_Connection_String.CONNECTION_STRING);
            SqlCommand command = new SqlCommand("DELETE FROM USERS WHERE ID = @ID", ConnectionString);
            command.Parameters.AddWithValue("@ID", id);
            Feedback response = new Feedback();
            try
            {
                ConnectionString.Open();
                command.ExecuteReader();
                response = ResponseFactory<User>.CreateSuccessResponse();
                return response;
            }
            catch (Exception ex)
            {
                response = ResponseFactory<Product>.CreateFailedResponse();
                return response;
            }
            finally
            {
                ConnectionString.Dispose();
            }
        }

        public Single_Feedback<User> GetByID(int id)
        {
            SqlConnection ConnectionString = new SqlConnection(Database_Connection_String.CONNECTION_STRING);
            SqlCommand command = new SqlCommand("SELECT * FROM USERS WHERE ID = @ID", ConnectionString);
            command.Parameters.AddWithValue("@ID", id);
            Single_Feedback<User> response = new Single_Feedback<User>();
            User match = new User();
            try
            {
                ConnectionString.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    match.ID = Convert.ToInt32(reader["ID"]);
                    match.Email = Convert.ToString(reader["EMAIL"]);
                    match.User_Password = Convert.ToString(reader["USER_PASSWORD"]);
                    match.Role = (Users_Role)Convert.ToInt32(reader["USER_ROLE"]);
                    match.Active = Convert.ToBoolean(reader["ACTIVE"]);
                    return ResponseFactory<User>.CreateSuccessSingleResponse(match);
                }
                return response = ResponseFactory<User>.CreateFailedSingleResponse(null);
            }
            catch (Exception ex)
            {
                response = ResponseFactory<User>.CreateFailedSingleResponse(null);
                return response;
            }
            finally
            {
                ConnectionString.Dispose();
            }
        }
    }
}
