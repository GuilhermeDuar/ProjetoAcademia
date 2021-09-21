using Metadata;
using Shared;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace DataAccessLayer
{
    public class DAL_Importation : IImportation
    {
        private DAL_User u_DAL = new DAL_User();
        private DAL_Product p_DAL = new DAL_Product();
        public Data_Feedback<Importation> GetAll()
        {
            SqlConnection ConnectionString = new SqlConnection(Database_Connection_String.CONNECTION_STRING);
            SqlCommand command = new SqlCommand("SELECT * FROM IMPORTATION ORDER BY ID", ConnectionString);
            Data_Feedback<Importation> response = new Data_Feedback<Importation>();
            try
            {
                ConnectionString.Open();
                SqlDataReader reader = command.ExecuteReader();
                List<Importation> record = new List<Importation>();
                while (reader.Read())
                {
                    Importation i = new Importation();
                    i.ID = Convert.ToInt32(reader["ID"]);
                    i.Import_date = Convert.ToDateTime(reader["IMPORT_DATE"]);
                    i.TotalPrice = Convert.ToDouble(reader["TOTAL_VALUE"]);
                    i.User_ID = Convert.ToInt32(reader["USER_ID"]);
                    i.Current_User = u_DAL.GetByID(i.User_ID).Item;
                    record.Add(i);
                }
                response = ResponseFactory<Importation>.CreateSuccessDataResponse(record);
                return response;
            }
            catch (Exception ex)
            {
                response = ResponseFactory<Importation>.CreateFailedDataResponse(new List<Importation>());
                return response;
            }
            finally
            {
                ConnectionString.Dispose();
            }
        }

        public Single_Feedback<Importation> GetByID(int id)
        {
            SqlConnection ConnectionString = new SqlConnection(Database_Connection_String.CONNECTION_STRING);
            SqlCommand command = new SqlCommand("SELECT * FROM IMPORTATION WHERE ID = @IMPORTATION_ID", ConnectionString);
            command.Parameters.AddWithValue("@IMPORTATION_ID", id);
            Single_Feedback<Importation> response = new Single_Feedback<Importation>();
            try
            {
                ConnectionString.Open();
                SqlDataReader reader = command.ExecuteReader();
                Importation match = new Importation();
                if (reader.Read())
                {
                    match.ID = Convert.ToInt32(reader["ID"]);
                    match.Import_date = Convert.ToDateTime(reader["IMPORT_DATE"]);
                    match.TotalPrice = Convert.ToDouble(reader["TOTAL_VALUE"]);
                    match.User_ID = Convert.ToInt32(reader["USER_ID"]);
                    match.Current_User = u_DAL.GetByID(match.User_ID).Item;
                    response = ResponseFactory<Importation>.CreateSuccessSingleResponse(match);
                }
                else
                {
                    response = ResponseFactory<Importation>.CreateFailedSingleResponse(match);
                }
                return response;
            }
            catch (Exception ex)
            {
                response = ResponseFactory<Importation>.CreateFailedSingleResponse(null);
                return response;
            }
            finally
            {
                ConnectionString.Dispose();
            }
        }

        public Data_Feedback<Import_Item> GetImportsByID(int id)
        {
            SqlConnection ConnectionString = new SqlConnection(Database_Connection_String.CONNECTION_STRING);
            SqlCommand command = new SqlCommand("SELECT * FROM IMPORT_ITEM WHERE IMPORTATION_ID = @ID_IMPORTATION", ConnectionString);
            command.Parameters.AddWithValue("@ID_IMPORTATION", id);
            Data_Feedback<Import_Item> response = new Data_Feedback<Import_Item>();
            try
            {
                ConnectionString.Open();
                SqlDataReader reader = command.ExecuteReader();
                List<Import_Item> match = new List<Import_Item>();
                while (reader.Read())
                {
                    Import_Item ip = new Import_Item();
                    ip.Importation_ID = Convert.ToInt32(reader["IMPORTATION_ID"]);
                    ip.Product_ID = Convert.ToInt32(reader["IMPORTED_PRODUCT_ID"]);
                    ip.Imported_Product = p_DAL.GetByID(ip.Product_ID).Item;
                    ip.Amount = Convert.ToInt32(reader["AMOUNT"]);
                    ip.Unitary_Value = Convert.ToDouble(reader["UNITARY_VALUE"]);
                    match.Add(ip);
                }
                response = ResponseFactory<Import_Item>.CreateSuccessDataResponse(match);
                return response;
            }
            catch (Exception ex)
            {
                response = ResponseFactory<Import_Item>.CreateFailedDataResponse(null);
                return response;
            }
            finally
            {
                ConnectionString.Dispose();
            }
        }

        public Feedback Insert(Importation importation)
        {
            SqlConnection ConnectionString = new SqlConnection(Database_Connection_String.CONNECTION_STRING);
            SqlCommand command = new SqlCommand("INSERT INTO IMPORTATION (USER_ID,TOTAL_VALUE) VALUES (@USER_ID,@TOTAL_VALUE); SELECT SCOPE_IDENTITY()", ConnectionString);
            command.Parameters.AddWithValue("@USER_ID", importation.User_ID);
            command.Parameters.AddWithValue("@TOTAL_VALUE", importation.TotalPrice);
            Feedback response = new Feedback();
            using (TransactionScope scope = new TransactionScope())
            {
                try
                {
                    ConnectionString.Open();
                    importation.ID = Convert.ToInt32(command.ExecuteScalar());
                    foreach (Import_Item item in importation.Imported_products)
                    {
                        SqlCommand command1 = new SqlCommand();
                        command1.CommandText = "INSERT INTO IMPORT_ITEM VALUES (@IMPORTATION_ID,@PRODUCT_ID,@AMOUNT, @UP)";
                        command1.Parameters.AddWithValue("@IMPORTATION_ID", importation.ID);
                        command1.Parameters.AddWithValue("@PRODUCT_ID", item.Product_ID);
                        command1.Parameters.AddWithValue("@AMOUNT", item.Amount);
                        command1.Parameters.AddWithValue("@UP", item.Unitary_Value);
                        command1.Connection = ConnectionString;
                        command1.ExecuteNonQuery();
                    }
                    scope.Complete();
                    response = ResponseFactory<Importation>.CreateSuccessResponse();
                    return response;
                }
                catch (Exception ex)
                {
                    response = ResponseFactory<Exportation>.CreateFailedResponse();
                    return response;
                }
                finally
                {
                    ConnectionString.Dispose();
                }
            }
        }
    }
}
