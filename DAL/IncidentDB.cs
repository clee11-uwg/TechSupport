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

        /// <summary>
        /// Retrieves the incident that has the incidentID provided
        /// </summary>
        /// <param name="incidentID">Incident ID used to retrieve a certain incident</param>
        /// <returns>Returns incident based on its incidentID</returns>
        public static Incident GetIncident(int incidentID)
        {

            // THIS NEEDS THE MOST WORK AS THIS STILL DOESNT BRING IN THE INCIDENTS THAT DONT HAVE A TECH
            // UNTIL THIS GETS RESOLVED, JUST TEST WITH INCIDENTS THAT DO HAVE A TECH ASSOCIATED WITH IT
            Incident incident = new Incident();
            SqlConnection connection = IncidentsDBConnection.GetConnection();
            
            string selectStatement =
                "SELECT IncidentID, c.name as Customer, ProductCode, t.name as Technician, DateOpened, Title, Description " +
                "FROM incidents i JOIN Customers c ON " +
                "i.CustomerID = c.CustomerID " +
                "JOIN Technicians t ON " +
                "i.TechID = t.TechID " +
                "WHERE IncidentID = @IncidentID";
            
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            selectCommand.Parameters.AddWithValue("@IncidentID", incidentID);

            try
            {
                connection.Open();
                SqlDataReader reader = selectCommand.ExecuteReader(System.Data.CommandBehavior.SingleRow);
                int incident_ID = reader.GetOrdinal("IncidentID");
                int customer = reader.GetOrdinal("Customer");
                int productCode = reader.GetOrdinal("ProductCode");
                
               // int tech = reader.GetOrdinal("Technician");
                int dateOpened = reader.GetOrdinal("DateOpened");
                int title = reader.GetOrdinal("Title");
                int description = reader.GetOrdinal("Description");
                while (reader.Read())
                {
                    incident.IncidentID = reader.GetInt32(incident_ID);
                    incident.Customer = reader.GetString(customer);
                    incident.ProductCode = reader.GetString(productCode);
                    if (reader["Technician"].GetType() != typeof(DBNull))
                    {
                        incident.Technician = reader["Technician"].ToString();
                    }
                    //incident.Technician = reader.GetString(tech);
                    incident.DateOpened = reader.GetDateTime(dateOpened);
                    incident.Title = reader.GetString(title);
                    incident.Description = reader.GetString(description);
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
            return incident;
        }

        private static Boolean CheckForTechnician(int incidentID)
        {
            bool techPresent = false;
            SqlConnection connection = IncidentsDBConnection.GetConnection();            
            string selectTechStatement = "SELECT techID FROM Incidents WHERE IncidentID = @IncidentID";
            SqlCommand selectTechCommand = new SqlCommand(selectTechStatement, connection);
            selectTechCommand.Parameters.AddWithValue("@IncidentID", incidentID);
            connection.Open();
            SqlDataReader techReader = selectTechCommand.ExecuteReader();
            if (techReader.Read())
            {
                if (techReader.HasRows)
                {
                    techPresent = true;
                }
                else
                {
                    techPresent = false;
                }
            }
            connection.Close();
            techReader.Close();
            return techPresent;
        }
    }
}
