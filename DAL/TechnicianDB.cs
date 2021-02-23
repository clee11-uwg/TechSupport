using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechSupport.Model;

namespace TechSupport.DAL
{

    /// <summary>
    /// Handles getting a list of customers from the database
    /// </summary>
    public static class TechnicianDB
    {
        /// <summary>
        /// Retrieves a list of techs from the database
        /// </summary>
        /// <returns>Returns a list of Technician objects based on what is returned from the database</returns>
        public static List<Technician> GetTechnicianList()
        {
            List<Technician> techList = new List<Technician>();
            string selectStatement = "SELECT TechID, Name FROM Technicians;";

            SqlConnection connection = IncidentsDBConnection.GetConnection();

            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = selectCommand.ExecuteReader();
                int techID = reader.GetOrdinal("TechID");
                int techName = reader.GetOrdinal("Name");
                while (reader.Read())
                {
                    Technician tech = new Technician();
                    tech.TechID = reader.GetInt32(techID);
                    tech.Name = reader.GetString(techName);
                    techList.Add(tech);
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
            return techList;
        }
    }
}
