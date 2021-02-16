using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechSupport.Model;

namespace TechSupport.DAL
{
    public static class CustomerDB
    {
        public static List<Customer> GetCustomerList()
        {
            List<Customer> customerList = new List<Customer>();
            string selectStatement = "SELECT name FROM Customers;";

            SqlConnection connection = IncidentsDBConnection.GetConnection();            

            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = selectCommand.ExecuteReader();
                int customerName = reader.GetOrdinal("Name");
                while (reader.Read())
                {
                    Customer customer = new Customer();
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
