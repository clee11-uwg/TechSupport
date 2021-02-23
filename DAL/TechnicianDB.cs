using System.Collections.Generic;
using System.Data.SqlClient;
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

        /// <summary>
        /// Retrieves specific tech based on its ID passed in
        /// </summary>
        /// <param name="techID">Used to find the correct technician</param>
        /// <returns>Returns technician based on its techID</returns>
        public static Technician GetTechnician(int techID)
        {
            Technician technician= new Technician();
            SqlConnection connection = IncidentsDBConnection.GetConnection();

            string selectStatement =
                "SELECT TechID, Name " +
                "FROM Technicians " +
                "WHERE TechID = @TechID";

            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            selectCommand.Parameters.AddWithValue("@TechID", techID);
            try
            {
                connection.Open();
                SqlDataReader reader = selectCommand.ExecuteReader(System.Data.CommandBehavior.SingleRow);
                int tech_ID = reader.GetOrdinal("TechID");
                int name = reader.GetOrdinal("Name");
                while (reader.Read())
                {
                    technician.TechID = reader.GetInt32(tech_ID);
                    technician.Name = reader.GetString(name);
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
            return technician;
        }
    }
}
