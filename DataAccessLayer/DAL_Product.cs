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
    public class DAL_Product : IProduct
    {
        public Feedback Delete(int id)
        {
            SqlConnection ConnectionString = new SqlConnection(Database_Connection_String.CONNECTION_STRING);
            SqlCommand command = new SqlCommand("DELETE FROM PRODUCTS WHERE PRODUCT_ID = @ID", ConnectionString);
            command.Parameters.AddWithValue("@ID", id);
            Feedback response = new Feedback();
            try
            {
                ConnectionString.Open();
                command.ExecuteReader();
                response = ResponseFactory<Product>.CreateSuccessResponse();
                return response;
            }
            catch (Exception ex)
            {
                response = ResponseFactory<Product>.CreateFailedResponse();
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    response.Report = "Product can't be deleted. There's transactions linked to it!";
                }
                return response;
            }
            finally
            {
                ConnectionString.Dispose();
            }
        }

        public Data_Feedback<Product> GetAll()
        {
            SqlConnection ConnectionString = new SqlConnection(Database_Connection_String.CONNECTION_STRING);
            SqlCommand command = new SqlCommand(@"SELECT P.PRODUCT_ID, P.PRODUCT_NAME, P.PRODUCT_DESCRIPTION, P.STOCK, P.PRICE, C.CATEGORY_NAME FROM PRODUCTS P INNER JOIN CATEGORIES C ON P.CATEGORY = C.ID", ConnectionString);
            Data_Feedback<Product> response = new Data_Feedback<Product>();
            try
            {
                ConnectionString.Open();
                SqlDataReader reader = command.ExecuteReader();
                List<Product> products = new List<Product>();
                while (reader.Read())
                {
                    Product p = new Product();
                    p.ID = Convert.ToInt32(reader["PRODUCT_ID"]);
                    p.Product_Name = Convert.ToString(reader["PRODUCT_NAME"]);
                    p.Product_Description = Convert.ToString(reader["PRODUCT_DESCRIPTION"]);
                    p.Category = Convert.ToString(reader["CATEGORY_NAME"]);
                    p.Stock = Convert.ToInt32(reader["STOCK"]);
                    p.Price = Convert.ToDouble(reader["PRICE"]);
                    products.Add(p);
                }
                response = ResponseFactory<Product>.CreateSuccessDataResponse(products);
                return response;
            }
            catch (Exception ex)
            {
                response = ResponseFactory<Product>.CreateFailedDataResponse(new List<Product>());
                return response;
            }
            finally
            {
                ConnectionString.Dispose();
            }
        }

        public Feedback Insert(Product p)
        {
            SqlConnection ConnectionString = new SqlConnection(Database_Connection_String.CONNECTION_STRING);
            SqlCommand command = new SqlCommand("INSERT INTO PRODUCTS(PRODUCT_NAME, PRODUCT_DESCRIPTION, CATEGORY) VALUES (@NAME, @DESCRIPTION, @CATEGORY)", ConnectionString);
            command.Parameters.AddWithValue("@NAME", p.Product_Name);
            command.Parameters.AddWithValue("@DESCRIPTION", p.Product_Description);
            command.Parameters.AddWithValue("@CATEGORY", p.Category);
            Feedback response = new Feedback();
            try
            {
                ConnectionString.Open();
                command.ExecuteNonQuery();
                response = ResponseFactory<Product>.CreateSuccessResponse();
                return response;
            }
            catch (Exception ex)
            {
                response = ResponseFactory<Product>.CreateFailedResponse();
                if (ex.Message.Contains("Violation of UNIQUE KEY"))
                {
                    response.Report = "This description is already linked to other product!";
                }
                return response;
            }
            finally
            {
                ConnectionString.Dispose();
            }
        }

        public Feedback Update(Product p)
        {
            SqlConnection ConnectionString = new SqlConnection(Database_Connection_String.CONNECTION_STRING);
            SqlCommand command = new SqlCommand("UPDATE PRODUCTS SET PRODUCT_NAME = @NAME, PRODUCT_DESCRIPTION = @DESCRIPTION, CATEGORY = @CATEGORY, STOCK = @STOCK, PRICE = @PRICE WHERE PRODUCT_ID = @ID", ConnectionString);
            command.Parameters.AddWithValue("@NAME", p.Product_Name);
            command.Parameters.AddWithValue("@DESCRIPTION", p.Product_Description);
            command.Parameters.AddWithValue("@CATEGORY", p.Category);
            command.Parameters.AddWithValue("@STOCK", p.Stock);
            command.Parameters.AddWithValue("@PRICE", p.Price);
            command.Parameters.AddWithValue("@ID", p.ID);
            Feedback response = new Feedback();
            try
            {
                ConnectionString.Open();
                command.ExecuteReader();
                response = ResponseFactory<Product>.CreateSuccessResponse();
                return response;
            }
            catch (Exception ex)
            {
                response = ResponseFactory<Product>.CreateFailedResponse();
                if (ex.Message.Contains("Violation of UNIQUE KEY"))
                {
                    response.Report = "This description is already linked to other product!";
                }
                return response;
            }
            finally
            {
                ConnectionString.Dispose();
            }
        }
        public Single_Feedback<Product> GetByID(int id)
        {
            SqlConnection connectionString = new SqlConnection(Database_Connection_String.CONNECTION_STRING);
            SqlCommand command = new SqlCommand("SELECT P.PRODUCT_ID, P.PRODUCT_NAME, P.PRODUCT_DESCRIPTION, P.STOCK, P.PRICE, C.CATEGORY_NAME FROM PRODUCTS P INNER JOIN CATEGORIES C ON P.CATEGORY = C.ID WHERE PRODUCT_ID = @ID", connectionString);
            command.Parameters.AddWithValue("@ID", id);

            Single_Feedback<Product> response = new Single_Feedback<Product>();
            Product p = new Product();
            try
            {
                connectionString.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    p.ID = Convert.ToInt32(reader["PRODUCT_ID"]);
                    p.Product_Name = Convert.ToString(reader["PRODUCT_NAME"]);
                    p.Product_Description = Convert.ToString(reader["PRODUCT_DESCRIPTION"]);
                    p.Category = Convert.ToString(reader["CATEGORY_NAME"]);
                    p.Stock = Convert.ToInt32(reader["STOCK"]);
                    p.Price = Convert.ToDouble(reader["PRICE"]);
                }
                return ResponseFactory<Product>.CreateSuccessSingleResponse(p);
            }
            catch (Exception ex)
            {
                response = ResponseFactory<Product>.CreateFailedSingleResponse(new Product());
                return response;
            }
            finally
            {
                connectionString.Dispose();
            }
        }

        public Feedback UpdatePrice_Stock(Product p)
        {
            SqlConnection ConnectionString = new SqlConnection(Database_Connection_String.CONNECTION_STRING);
            SqlCommand command = new SqlCommand("UPDATE PRODUCTS SET STOCK = @STOCK, PRICE = @PRICE WHERE PRODUCT_ID = @ID", ConnectionString);
            command.Parameters.AddWithValue("@STOCK", p.Stock);
            command.Parameters.AddWithValue("@PRICE", p.Price);
            command.Parameters.AddWithValue("@ID", p.ID);
            Feedback response = new Feedback();
            try
            {
                ConnectionString.Open();
                command.ExecuteReader();
                response = ResponseFactory<Product>.CreateSuccessResponse();
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

        public Feedback UpdateStockOnly(Product p)
        {
            SqlConnection ConnectionString = new SqlConnection(Database_Connection_String.CONNECTION_STRING);
            SqlCommand command = new SqlCommand("UPDATE PRODUCTS SET STOCK = @STOCK WHERE PRODUCT_ID = @ID", ConnectionString);
            command.Parameters.AddWithValue("@STOCK", p.Stock);
            command.Parameters.AddWithValue("@ID", p.ID);
            Feedback response = new Feedback();
            try
            {
                ConnectionString.Open();
                command.ExecuteReader();
                response = ResponseFactory<Product>.CreateSuccessResponse();
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
    }
}
