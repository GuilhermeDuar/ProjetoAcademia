using Metadata;
using Metadata.Interfaces;
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
    public class DAL_Exportation : IExportation
    {
        private DAL_User u_DAL = new DAL_User();
        private DAL_Customer c_DAL = new DAL_Customer();
        private DAL_Payment_Method pm_DAL = new DAL_Payment_Method();
        private DAL_Product p_DAL = new DAL_Product();
        public Data_Feedback<Exportation> GetAll()
        {
            SqlConnection ConnectionString = new SqlConnection(Database_Connection_String.CONNECTION_STRING);
            SqlCommand command = new SqlCommand("SELECT * FROM EXPORTATION ORDER BY ID", ConnectionString);
            Data_Feedback<Exportation> response = new Data_Feedback<Exportation>();
            try
            {
                ConnectionString.Open();
                SqlDataReader reader = command.ExecuteReader();
                List<Exportation> record = new List<Exportation>();
                while (reader.Read())
                {
                    Exportation i = new Exportation();
                    i.ID = Convert.ToInt32(reader["ID"]);
                    i.Customer_ID = Convert.ToInt32(reader["CUSTOMER_ID"]);
                    i.Customer = c_DAL.GetByID(i.Customer_ID).Item;
                    i.User_ID = Convert.ToInt32(reader["USER_ID"]);
                    i.Current_User = u_DAL.GetByID(i.User_ID).Item;
                    i.TotalValue = Convert.ToDouble(reader["TOTAL_VALUE"]);
                    i.Export_date = Convert.ToDateTime(reader["EXPORT_TIME"]);
                    i.ID_Payment_Method = Convert.ToInt32(reader["ID_PAYMENT_METHOD"]);
                    i.PM = pm_DAL.GetByID(i.ID_Payment_Method).Item;
                    record.Add(i);
                }
                response = ResponseFactory<Exportation>.CreateSuccessDataResponse(record);
                return response;
            }
            catch (Exception ex)
            {
                response = ResponseFactory<Exportation>.CreateFailedDataResponse(new List<Exportation>());
                return response;
            }
            finally
            {
                ConnectionString.Dispose();
            }
        }

        public Single_Feedback<Exportation> GetByID(int id)
        {
            SqlConnection ConnectionString = new SqlConnection(Database_Connection_String.CONNECTION_STRING);
            SqlCommand command = new SqlCommand("SELECT * FROM EXPORTATION WHERE ID = @EXPORTATION_ID", ConnectionString);
            command.Parameters.AddWithValue("@EXPORTATION_ID", id);
            Single_Feedback<Exportation> response = new Single_Feedback<Exportation>();
            try
            {
                ConnectionString.Open();
                SqlDataReader reader = command.ExecuteReader();
                Exportation match = new Exportation();
                if (reader.Read())
                {
                    match.ID = Convert.ToInt32(reader["ID"]);
                    match.Customer_ID = Convert.ToInt32(reader["CUSTOMER_ID"]);
                    match.Customer = c_DAL.GetByID(match.Customer_ID).Item;
                    match.User_ID = Convert.ToInt32(reader["USER_ID"]);
                    match.Current_User = u_DAL.GetByID(match.User_ID).Item;
                    match.TotalValue = Convert.ToDouble(reader["TOTAL_VALUE"]);
                    match.Export_date = Convert.ToDateTime(reader["EXPORT_TIME"]);
                    match.ID_Payment_Method = Convert.ToInt32(reader["ID_PAYMENT_METHOD"]);
                    match.PM = pm_DAL.GetByID(match.ID_Payment_Method).Item;
                    response = ResponseFactory<Exportation>.CreateSuccessSingleResponse(match);
                }
                else
                {
                    response = ResponseFactory<Exportation>.CreateFailedSingleResponse(match);
                }
                return response;
            }
            catch (Exception ex)
            {
                response = ResponseFactory<Exportation>.CreateFailedSingleResponse(null);
                return response;
            }
            finally
            {
                ConnectionString.Dispose();
            }
        }

        public Data_Feedback<Export_Item> GetExportsByID(int id)
        {
            SqlConnection ConnectionString = new SqlConnection(Database_Connection_String.CONNECTION_STRING);
            SqlCommand command = new SqlCommand("SELECT * FROM EXPORT_ITEM WHERE EXPORTATION_ID = @ID_EXPORTATION", ConnectionString);
            command.Parameters.AddWithValue("@ID_EXPORTATION", id);
            Data_Feedback<Export_Item> response = new Data_Feedback<Export_Item>();
            try
            {
                ConnectionString.Open();
                SqlDataReader reader = command.ExecuteReader();
                List<Export_Item> match = new List<Export_Item>();
                while (reader.Read())
                {
                    Export_Item ip = new Export_Item();
                    ip.Exportation_ID = Convert.ToInt32(reader["EXPORTATION_ID"]);
                    ip.Product_ID = Convert.ToInt32(reader["EXPORTED_PRODUCT_ID"]);
                    ip.Exported_Product = p_DAL.GetByID(ip.Product_ID).Item;
                    ip.Amount = Convert.ToInt32(reader["AMOUNT"]);
                    ip.Unitary_Value = Convert.ToDouble(reader["UNITARY_VALUE"]);
                    match.Add(ip);
                }
                response = ResponseFactory<Export_Item>.CreateSuccessDataResponse(match);
                return response;
            }
            catch (Exception ex)
            {
                response = ResponseFactory<Export_Item>.CreateFailedDataResponse(null);
                return response;
            }
            finally
            {
                ConnectionString.Dispose();
            }
        }

        public Feedback Insert(Exportation exportation)
        {
            SqlConnection ConnectionString = new SqlConnection(Database_Connection_String.CONNECTION_STRING);
            SqlCommand command = new SqlCommand("INSERT INTO EXPORTATION (USER_ID, CUSTOMER_ID,TOTAL_VALUE,ID_PAYMENT_METHOD) VALUES (@USER_ID,@CUSTOMER_ID,@TOTAL_VALUE,@ID_PM); SELECT SCOPE_IDENTITY()", ConnectionString);
            command.Parameters.AddWithValue("@USER_ID", exportation.User_ID);
            command.Parameters.AddWithValue("@CUSTOMER_ID", exportation.Customer_ID);
            command.Parameters.AddWithValue("@ID_PM", exportation.ID_Payment_Method);
            command.Parameters.AddWithValue("@TOTAL_VALUE", exportation.TotalValue);
            Feedback response = new Feedback();
            using (TransactionScope scope = new TransactionScope())
            {
                try
                {
                    ConnectionString.Open();
                    exportation.ID = Convert.ToInt32(command.ExecuteScalar());
                    foreach (Export_Item item in exportation.Exported_products)
                    {
                        SqlCommand command1 = new SqlCommand();
                        command1.CommandText = "INSERT INTO EXPORT_ITEM VALUES (@EXPORTATION_ID,@PRODUCT_ID,@AMOUNT, @UP)";
                        command1.Parameters.AddWithValue("@EXPORTATION_ID", exportation.ID);
                        command1.Parameters.AddWithValue("@PRODUCT_ID", item.Product_ID);
                        command1.Parameters.AddWithValue("@AMOUNT", item.Amount);
                        command1.Parameters.AddWithValue("@UP", item.Unitary_Value);
                        command1.Connection = ConnectionString;
                        command1.ExecuteNonQuery();
                    }
                    scope.Complete();
                    response = ResponseFactory<Exportation>.CreateSuccessResponse();
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
