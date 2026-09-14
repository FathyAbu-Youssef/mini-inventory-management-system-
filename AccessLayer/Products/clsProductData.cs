using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CommonUtilities;
namespace AccessLayer
{ 
    public class clsProductData
    {
        public static int AddNewProduct(string ProductName, decimal ProductPrice, int QuantityInStock, int MinimumQuantity, DateTime? ExpiryDate , string ImagePath)
        {
            int NewProductID = 0;

            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand Command = new SqlCommand("sp_AddNewProduct", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue("@ProductName", ProductName);
                        Command.Parameters.AddWithValue("@ProductPrice", ProductPrice);
                        Command.Parameters.AddWithValue("@QuantityInStock", QuantityInStock);
                        Command.Parameters.AddWithValue("@MinimumQuantity", MinimumQuantity);
                        Command.Parameters.AddWithValue("@ExpiryDate", (object)ExpiryDate ?? DBNull.Value);
                        Command.Parameters.AddWithValue("@ImagePath", ImagePath);

                        SqlParameter OutputParameter = new SqlParameter("@NewProductID", DbType.Int32)
                        {
                            Direction = ParameterDirection.Output
                        };
                        Command.Parameters.Add(OutputParameter);

                        Connection.Open();
                        Command.ExecuteNonQuery();
                        NewProductID = (int)Command.Parameters["@NewProductID"].Value;
                    }

                }
            }
            catch (Exception ex)
            {
                clsLogger.LogException(ex);
                return -1; 
            }

            return NewProductID;
        }

        public static bool ReadProduct(int ProductID, out string ProductName, out decimal ProductPrice, out int QuantityInStock, out int MinimumQuantity, out DateTime? ExpirationDate , out string ImagePath)
        {
            ProductName = default(string);
            ProductPrice = default(decimal);
            QuantityInStock = default(int);
            MinimumQuantity = default(int);
            ExpirationDate = default(DateTime?);
            ImagePath = default(string);
      
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand Command = new SqlCommand("sp_ReadProduct", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue("@ProductID", ProductID);
                        SqlParameter PN_OutputParameter = new SqlParameter("@ProductName", SqlDbType.NVarChar) { Direction = ParameterDirection.Output };
                        PN_OutputParameter.Size = 100;


                        SqlParameter PP_OutputParameter = new SqlParameter("@ProductPrice", SqlDbType.Decimal) { Direction = ParameterDirection.Output };
                        SqlParameter QIS_OutputParameter = new SqlParameter("@QuantityInStock", SqlDbType.Int) { Direction = ParameterDirection.Output };
                        SqlParameter MQ_OutputParameter = new SqlParameter("@MinimumQuantity", SqlDbType.Int) { Direction = ParameterDirection.Output };
                        SqlParameter ED_OutputParameter = new SqlParameter("@ExpiryDate", SqlDbType.Date) { Direction = ParameterDirection.Output };
                        SqlParameter IMP_OutputParameter = new SqlParameter("@ImagePath", SqlDbType.NVarChar) { Direction = ParameterDirection.Output };
                        IMP_OutputParameter.Size = 100;



                        Command.Parameters.Add(PN_OutputParameter);
                        Command.Parameters.Add(PP_OutputParameter);
                        Command.Parameters.Add(QIS_OutputParameter);
                        Command.Parameters.Add(MQ_OutputParameter);
                        Command.Parameters.Add(ED_OutputParameter);
                        Command.Parameters.Add(IMP_OutputParameter);

                        Connection.Open();
                        Command.ExecuteNonQuery();

                        ProductName = PN_OutputParameter.Value.ToString();
                        ProductPrice = (Decimal)PP_OutputParameter.Value;
                        QuantityInStock = (int)QIS_OutputParameter.Value;
                        MinimumQuantity = (int)MQ_OutputParameter.Value;
                        ExpirationDate = (ED_OutputParameter.Value == DBNull.Value) ? (DateTime?)null : (DateTime)ED_OutputParameter.Value;
                        ImagePath = IMP_OutputParameter.Value.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                clsLogger.LogException(ex);
                return false;
            }
            return true;
        }

        public static bool UpdateProduct(int ProductID, string ProductName, decimal ProductPrice, int QuantityInStock, int MinimumQuantity, DateTime? ExpirationDate, string ImagePath)
        {
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand Command = new SqlCommand("sp_UpdateProduct", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue("@ProductID", ProductID);
                        Command.Parameters.AddWithValue("@ProductName", ProductName);
                        Command.Parameters.AddWithValue("@ProductPrice", ProductPrice);
                        Command.Parameters.AddWithValue("@QuantityInStock", QuantityInStock);
                        Command.Parameters.AddWithValue("@ExpiryDate", (object)ExpirationDate??DBNull.Value);
                        Command.Parameters.AddWithValue("@ImagePath", ImagePath);

                        Connection.Open();
                        Command.ExecuteNonQuery();
                    }
                }
            }

            catch (Exception ex)
            {
                clsLogger.LogException(ex);
                return false;
            }
            return true;
        }

        public static bool DeleteProduct(int ProductID)
        {
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand Command = new SqlCommand("sp_DeleteProduct", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@ProductID", ProductID);

                        Connection.Open();
                        Command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                clsLogger.LogException(ex);
                return false;
            }
            return true;
        }

        public static DataTable GetAllProdcuts()
        {
            DataTable dtResult = new DataTable();
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand Command = new SqlCommand("sp_GetAllProducts", Connection))
                    {
                        Connection.Open();
                        SqlDataReader reader = Command.ExecuteReader();
                        dtResult.Load(reader);
                    } 
                }
            }
            catch (Exception ex)
            {
                clsLogger.LogException(ex);
            }

            return dtResult;
        }

    }
}
