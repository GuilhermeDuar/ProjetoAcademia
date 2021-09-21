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
    public class DAL_Category : ICategory
    {
        public Feedback Delete(int id)
        {
            SqlConnection ConnectionString = new SqlConnection(Database_Connection_String.CONNECTION_STRING);
            SqlCommand command = new SqlCommand("DELETE FROM CATEGORIES WHERE ID = @ID", ConnectionString);
            command.Parameters.AddWithValue("@ID", id);
            Feedback response = new Feedback();
            try
            {
                ConnectionString.Open();
                command.ExecuteReader();
                response = ResponseFactory<Category>.CreateSuccessResponse();
                return response;
            }
            catch (Exception ex)
            {
                response = ResponseFactory<Category>.CreateFailedResponse();
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    response.Report = "Category can't be deleted. There's products linked to it!";
                }
                return response;
            }
            finally
            {
                ConnectionString.Dispose();
            }
        }
        public Data_Feedback<Category> GetAll()
        {
            SqlConnection ConnectionString = new SqlConnection(Database_Connection_String.CONNECTION_STRING);
            SqlCommand command = new SqlCommand("SELECT * FROM CATEGORIES ORDER BY ID", ConnectionString);
            Data_Feedback<Category> response = new Data_Feedback<Category>();
            try
            {
                ConnectionString.Open();
                SqlDataReader reader = command.ExecuteReader();
                List<Category> categories = new List<Category>();
                while (reader.Read())
                {
                    Category c = new Category();
                    c.ID = Convert.ToInt32(reader["ID"]);
                    c.Category_Name = Convert.ToString(reader["CATEGORY_NAME"]);
                    categories.Add(c);
                }
                response = ResponseFactory<Category>.CreateSuccessDataResponse(categories);
                return response;
            }
            catch (Exception)
            {
                response = ResponseFactory<Category>.CreateFailedDataResponse(new List<Category>());
                return response;
            }
            finally
            {
                ConnectionString.Dispose();
            }
        }

        public Single_Feedback<Category> GetByID(int id)
        {
            SqlConnection ConnectionString = new SqlConnection(Database_Connection_String.CONNECTION_STRING);
            SqlCommand command = new SqlCommand("SELECT * FROM CATEGORIES WHERE ID = @ID", ConnectionString);
            command.Parameters.AddWithValue("@ID", id);
            Single_Feedback<Category> response = new Single_Feedback<Category>();
            Category match = new Category();
            try
            {
                ConnectionString.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    match.ID = Convert.ToInt32(reader["ID"]);
                    match.Category_Name = Convert.ToString(reader["CATEGORY_NAME"]);
                    return ResponseFactory<Category>.CreateSuccessSingleResponse(match);
                }
                return response = ResponseFactory<Category>.CreateFailedSingleResponse(null);
            }
            catch (Exception ex)
            {
                response = ResponseFactory<Category>.CreateFailedSingleResponse(null);
                return response;
            }
            finally
            {
                ConnectionString.Dispose();
            }
        }

        public Feedback Insert(Category c)
        {
            SqlConnection ConnectionString = new SqlConnection(Database_Connection_String.CONNECTION_STRING);
            SqlCommand command = new SqlCommand("INSERT INTO CATEGORIES(CATEGORY_NAME) VALUES (@NAME)", ConnectionString);
            command.Parameters.AddWithValue("@NAME", c.Category_Name);
            Feedback response = new Feedback();
            try
            {
                ConnectionString.Open();
                command.ExecuteNonQuery();
                response = ResponseFactory<Category>.CreateSuccessResponse();
                return response;
            }
            catch (Exception ex)
            {
                response = ResponseFactory<Category>.CreateFailedResponse();
                if (ex.Message.Contains("Violation of UNIQUE KEY"))
                {
                    response.Report = "This category already exists!";
                }
                return response;
            }
            finally
            {
                ConnectionString.Dispose();
            }
        }

        public Feedback Update(Category c)
        {
            SqlConnection ConnectionString = new SqlConnection(Database_Connection_String.CONNECTION_STRING);
            SqlCommand command = new SqlCommand("UPDATE CATEGORIES SET CATEGORY_NAME = @NAME WHERE ID = @ID", ConnectionString);
            command.Parameters.AddWithValue("@NAME", c.Category_Name);
            command.Parameters.AddWithValue("@ID", c.ID);
            Feedback response = new Feedback();
            try
            {
                ConnectionString.Open();
                command.ExecuteReader();
                response = ResponseFactory<Category>.CreateSuccessResponse();
                return response;
            }
            catch (Exception ex)
            {
                response = ResponseFactory<Category>.CreateFailedResponse();
                if (ex.Message.Contains("Violation of UNIQUE KEY"))
                {
                    response.Report = "This categories already exists!";
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
