using Metadata;
using Metadata.Interfaces;
using Shared;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class DAL_Teacher : ITeacher
    {
        private DAL_User u_DAL = new DAL_User();
        public Data_Feedback<Teacher> GetAll()
        {
            SqlConnection ConnectionString = new SqlConnection(Database_Connection_String.CONNECTION_STRING);
            SqlCommand command = new SqlCommand("SELECT * FROM TEACHERS", ConnectionString);
            Data_Feedback<Teacher> response = new Data_Feedback<Teacher>();
            try
            {
                ConnectionString.Open();
                SqlDataReader reader = command.ExecuteReader();
                List<Teacher> teachers = new List<Teacher>();
                if (reader.Read())
                {
                    Teacher t = new Teacher();
                    t.ID = Convert.ToInt32(reader["ID"]);
                    t.Teacher_Name = Convert.ToString(reader["TEACHER_NAME"]);
                    t.CPF= Convert.ToString(reader["CPF"]);
                    t.RG = Convert.ToString(reader["RG"]);
                    t.Adress = Convert.ToString(reader["ADRESS"]);
                    t.Phone_Number = Convert.ToString(reader["PHONE_NUMBER"]);
                    t.Wage = Convert.ToDouble(reader["WAGE"]);
                    t.User_ID = Convert.ToInt32(reader["USER_ID"]);
                    teachers.Add(t);
                }
                response = ResponseFactory<Teacher>.CreateSuccessDataResponse(teachers);
                return response;
            }
            catch (Exception ex)
            {
                response = ResponseFactory<Teacher>.CreateFailedDataResponse(new List<Teacher>());
                return response;
            }
            finally
            {
                ConnectionString.Dispose();
            }
        }

        public Feedback Insert(Teacher t)
        {
            SqlConnection ConnectionString = new SqlConnection(Database_Connection_String.CONNECTION_STRING);
            SqlCommand command = new SqlCommand("INSERT INTO TEACHERS(TEACHER_NAME, CPF, RG, ADRESS, PHONE_NUMBER, WAGE, USER_ID) VALUES (@TEACHER_NAME, @CPF, @RG, @ADRESS, @PHONE_NUMBER, @WAGE, @USER_ID)", ConnectionString);
            command.Parameters.AddWithValue("@TEACHER_NAME", t.Teacher_Name);
            command.Parameters.AddWithValue("@CPF", t.CPF);
            command.Parameters.AddWithValue("@RG", t.RG);
            command.Parameters.AddWithValue("@ADRESS", t.Adress);
            command.Parameters.AddWithValue("@PHONE_NUMBER", t.Phone_Number);
            command.Parameters.AddWithValue("@WAGE", t.Wage);
            command.Parameters.AddWithValue("@USER_ID", t.User_ID);
            Feedback response = new Feedback();
            try
            {
                ConnectionString.Open();
                command.ExecuteNonQuery();
                response = ResponseFactory<Teacher>.CreateSuccessResponse();
                return response;
            }
            catch (Exception ex)
            {
                response = ResponseFactory<Teacher>.CreateFailedResponse();
                if (ex.Message.Contains("UQ__TEACHERS__C1F89731A6EA9006"))
                {
                    response.Report = "This CPF is already linked with other teacher!";
                }
                else if (ex.Message.Contains("UQ__TEACHERS__321537C808384079"))
                {
                    response.Report = "This RG is already linked with other teacher!";
                }
                else if (ex.Message.Contains("UQ__TEACHERS__D94A4FFB114AD1AB"))
                {
                    response.Report = "This phone number is already linked with other teacher!";
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
            SqlCommand command = new SqlCommand("UPDATE TEACHERS SET ACTIVE = 1 WHERE ID = @ID", ConnectionString);
            command.Parameters.AddWithValue("@ID", id);
            Feedback response = new Feedback();
            try
            {
                ConnectionString.Open();
                command.ExecuteReader();
                response = ResponseFactory<Teacher>.CreateSuccessResponse();
                return response;
            }
            catch (Exception ex)
            {
                response = ResponseFactory<Teacher>.CreateFailedResponse();
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
            SqlCommand command = new SqlCommand("UPDATE TEACHER SET ACTIVE = 0 WHERE ID = @ID", ConnectionString);
            command.Parameters.AddWithValue("@ID", id);
            Feedback response = new Feedback();
            try
            {
                ConnectionString.Open();
                command.ExecuteReader();
                response = ResponseFactory<Teacher>.CreateSuccessResponse();
                return response;
            }
            catch (Exception ex)
            {
                response = ResponseFactory<Teacher>.CreateFailedResponse();
                return response;
            }
            finally
            {
                ConnectionString.Dispose();
            }
        }

        public Feedback Update(Teacher t)
        {
            SqlConnection ConnectionString = new SqlConnection(Database_Connection_String.CONNECTION_STRING);
            SqlCommand command = new SqlCommand("UPDATE TEACHERS SET TEACHER_NAME = @TEACHER_NAME, ADRESS = @ADRESS, PHONE_NUMBER = @PHONE_NUMBER, WAGE = @WAGE, COMISSION = @COMISSION WHERE USER_ID = @ID", ConnectionString);
            command.Parameters.AddWithValue("@ID", t.User_ID);
            command.Parameters.AddWithValue("@TEACHER_NAME", t.Teacher_Name);
            command.Parameters.AddWithValue("@PHONE_NUMBER", t.Phone_Number);
            command.Parameters.AddWithValue("@ADRESS", t.Adress);
            command.Parameters.AddWithValue("@WAGE", t.Wage);
            command.Parameters.AddWithValue("@COMISSION", t.Comission);
            Feedback response = new Feedback();
            try
            {
                ConnectionString.Open();
                command.ExecuteReader();
                response = ResponseFactory<Teacher>.CreateSuccessResponse();
                return response;
            }
            catch (Exception ex)
            {
                response = ResponseFactory<Teacher>.CreateFailedResponse();
                if (ex.Message.Contains("UQ__TEACHERS__D94A4FFB114AD1AB"))
                {
                    response.Report = "This phone number is already linked with other teacher!";
                }
                return response;
            }
            finally
            {
                ConnectionString.Dispose();
            }
        }
        public Single_Feedback<Teacher> SearchByID(int user_ID)
        {
            SqlConnection ConnectionString = new SqlConnection(Database_Connection_String.CONNECTION_STRING);
            SqlCommand command = new SqlCommand("SELECT * FROM TEACHERS WHERE USER_ID = @ID", ConnectionString);
            command.Parameters.AddWithValue("@ID", user_ID);
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
                    t.User_ID = Convert.ToInt32(reader["USER_ID"]);
                }
                return ResponseFactory<Teacher>.CreateSuccessSingleResponse(t);
            }
            catch (Exception ex)
            {
                response = ResponseFactory<Teacher>.CreateFailedSingleResponse(new Teacher());
                return response;
            }
            finally
            {
                ConnectionString.Dispose();
            }
        }
    }
}
