using System.Data.SqlClient;

namespace TechSupport.DAL
{
    /// <summary>
    /// Connection class that handles connecting to the database with the proper credentials
    /// </summary>
    public static class IncidentsDBConnection
    {
        /// <summary>
        /// Sets up the proper database connection and returns that connection
        /// </summary>
        /// <returns></returns>
        public static SqlConnection GetConnection()
        {
            string connectionString =
                "Data Source=localhost;Initial Catalog=TechSupport;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }
    }
}
