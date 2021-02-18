using System.Collections.Generic;
using System.Data.SqlClient;
using TechSupport.Model;

namespace TechSupport.DAL
{
    /// <summary>
    /// Handles getting a list of customers from the database
    /// </summary>
    public static class CustomerDB
    {
        /// <summary>
        /// Retrieves a list of Customers from the database
        /// </summary>
        /// <returns>Returns a list of Customer objects based on what is returned from the database</returns>
        public static List<Customer> GetCustomerList()
        {
            List<Customer> customerList = new List<Customer>();
            string selectStatement = "SELECT CustomerID, Name FROM Customers;";

            SqlConnection connection = IncidentsDBConnection.GetConnection();            

            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = selectCommand.ExecuteReader();
                int customerID = reader.GetOrdinal("CustomerID");
                int customerName = reader.GetOrdinal("Name");
                while (reader.Read())
                {
                    Customer customer = new Customer();
                    customer.CustomerID = reader.GetInt32(customerID);
                    customer.Name = reader.GetString(customerName);
                    customerList.Add(customer);
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
            return customerList;
        }
    }
}
