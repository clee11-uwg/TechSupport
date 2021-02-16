using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using TechSupport.Model;

namespace TechSupport.DAL
{
    public static class CustomerDB
    {
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
