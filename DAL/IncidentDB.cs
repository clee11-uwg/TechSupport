using System;
using System.Data.SqlClient;
using TechSupport.Controller;
using TechSupport.Model;

namespace TechSupport.DAL
{
    /// <summary>
    /// Handles the SQL connections and queries to the Incidents table
    /// </summary>
    public static class IncidentDB
    {
        /// <summary>
        /// Adds given incident to database
        /// </summary>
        /// <param name="incident">Incident to be added to the database</param>
        /// <returns>Returns incidentID given by the databse when created</returns>
        public static int AddIncident(Incident incident)
        {
            IncidentController incidentController = new IncidentController();

            SqlConnection connection = IncidentsDBConnection.GetConnection();
            string insertStatement =
                "INSERT Incidents (CustomerID, ProductCode, DateOpened, Title, Description) " +
                "VALUES (@CustomerID, @ProductCode, @DateOpened, @Title, @Description)";
            SqlCommand insertCommand = new SqlCommand(insertStatement, connection);
            insertCommand.Parameters.AddWithValue("@CustomerID", incident.CustomerID);
            insertCommand.Parameters.AddWithValue("@ProductCode", incident.ProductCode);
            insertCommand.Parameters.AddWithValue("@DateOpened", incident.DateOpened);
            insertCommand.Parameters.AddWithValue("@Title", incident.Title);
            insertCommand.Parameters.AddWithValue("@Description", incident.Description);
            
            try
            {
                connection.Open();
                int registrationCount = incidentController.CheckRegistration(incident);
                if (registrationCount == 0)
                {
                    throw new Exception("The customer and product selected are not registered together.");
                }
                else
                {
                    insertCommand.ExecuteNonQuery();
                }
                string selectStatement = "SELECT IDENT_CURRENT('Incidents') FROM Incidents";
                SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
                int incidentID = Convert.ToInt32(selectCommand.ExecuteScalar());
                return incidentID;
            }
            catch (SqlException sqlex)
            {
                throw sqlex;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
