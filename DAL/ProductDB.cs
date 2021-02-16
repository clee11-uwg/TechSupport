using System.Collections.Generic;
using System.Data.SqlClient;
using TechSupport.Model;

namespace TechSupport.DAL
{
    /// <summary>
    /// Handles the SQL connections and queries to the Products database table
    /// </summary>
    public static class ProductDB
    {
        /// <summary>
        /// Retrieves a list of Products from the database
        /// </summary>
        /// <returns>Returns a list of Product objects based on what is returned from the database</returns>
        public static List<Product> GetProductList()
        {
            List<Product> productList = new List<Product>();
            string selectStatement = "SELECT ProductCode, Name FROM Products;";

            SqlConnection connection = IncidentsDBConnection.GetConnection();

            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = selectCommand.ExecuteReader();
                int productCode = reader.GetOrdinal("ProductCode");
                int productName = reader.GetOrdinal("Name");

                while (reader.Read())
                {
                    Product product = new Product();
                    product.ProductCode = reader.GetString(productCode);
                    product.Name = reader.GetString(productName);
                    productList.Add(product);
                }
                reader.Close();
            }
            catch (SqlException sqlex)
            {
                throw sqlex;
            }
            finally
            {
                connection.Close();
            }
            return productList;
        }
    }
}
