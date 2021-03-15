using System;
using System.Collections.Generic;
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

            // I couldn't quite get the technician being null figured out. Many hours were spent trying
            // to figure out how it can work within the current context but nothing seemed to work. From
            // my testing, anytime the technician was null, the reader wouldnt even read() and therefore 
            // everything would be blank if you searched for an incident that didnt have a technician. I
            // am not sure what could be off 
            Incident incident = new Incident();
            SqlConnection connection = IncidentsDBConnection.GetConnection();
            
            string selectStatement =
                "SELECT IncidentID, c.name as Customer, ProductCode, t.name as Technician, DateOpened, DateClosed, Title, Description " +
                "FROM incidents i JOIN Customers c ON " +
                "i.CustomerID = c.CustomerID " +
                "LEFT OUTER JOIN Technicians t ON " +
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
                
                //int tech = reader.GetOrdinal("Technician");
                int dateOpened = reader.GetOrdinal("DateOpened");
                int dateClosed = reader.GetOrdinal("DateClosed");
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
                    else
                    {
                        incident.Technician = DBNull.Value.ToString();
                    }
                    //incident.Technician = reader.GetString(tech);
                    incident.DateOpened = reader.GetDateTime(dateOpened);
                    if (reader["DateClosed"].GetType() != typeof(DBNull))
                    {
                        incident.DateClosed = reader.GetDateTime(dateClosed);
                    }
                    else
                    {
                        incident.DateClosed = Convert.ToDateTime("1/1/0001");
                    }
                    
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

        /// <summary>
        /// Retrieves list of incidents for a certain technician
        /// </summary>
        /// <param name="techID">TechID used to retrieve a lsit of incidents for that tech</param>
        /// <returns>Returns list of incidents for a certain technician</returns>
        public static List<Incident> GetIncidentsForTech(int techID)
        {
            List<Incident> myIncidents = new List<Incident>();
            SqlConnection connection = IncidentsDBConnection.GetConnection();

            string selectStatement =
                "SELECT p.Name AS Product, i.DateOpened, c.Name AS Customer, i.Title " +
                "FROM Incidents i JOIN Products p ON " +
                "i.ProductCode = p.ProductCode " +
                "JOIN Customers c ON " +
                "i.CustomerID = c.CustomerID " +
                "WHERE techID = @TechID " +
                "AND i.DateClosed IS NULL";

            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            selectCommand.Parameters.AddWithValue("@TechID", techID);

            try
            {
                connection.Open();
                SqlDataReader reader = selectCommand.ExecuteReader();
                int product = reader.GetOrdinal("Product");
                int dateOpened = reader.GetOrdinal("DateOpened");
                int customer = reader.GetOrdinal("Customer");
                int title = reader.GetOrdinal("Title");
                while (reader.Read())
                {
                    Incident incident = new Incident();
                    incident.Customer = reader.GetString(customer);
                    incident.Product = reader.GetString(product);
                    incident.DateOpened = reader.GetDateTime(dateOpened).Date;
                    incident.Title = reader.GetString(title);
                    myIncidents.Add(incident);
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
            return myIncidents;
        }

        /// <summary>
        /// Returns if the incident has been closed successfully
        /// </summary>
        /// <param name="incidentID">ID of the incident to be closed</param>
        /// <returns>Returns true or false if the incident was properly closed</returns>
        public static bool CloseIncident(int incidentID)
        {
            SqlConnection connection = IncidentsDBConnection.GetConnection();
            string updateStatement = 
                "UPDATE Incidents " +
                "SET DateClosed = @DateClosed " +
                "WHERE IncidentID = @IncidentID";
            SqlCommand updateCommand = new SqlCommand(updateStatement, connection);
            updateCommand.Parameters.AddWithValue("@DateClosed", DateTime.Now);
            updateCommand.Parameters.AddWithValue("@IncidentID", incidentID);

            try
            {
                connection.Open();
                int count = updateCommand.ExecuteNonQuery();
                if (count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
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
        /// Returns whether or not the incident was updated successfully
        /// </summary>
        /// <param name="oldIncident">Old incident as a reference</param>
        /// <param name="newIncident">new reference used to populate fields</param>
        /// <returns>Returns true or false depending on if the incident was properly updated</returns>
        public static bool UpdateIncident(Incident oldIncident, Incident newIncident)
        {
            SqlConnection connection = IncidentsDBConnection.GetConnection();
            string updateStatement =
                "UPDATE Incidents " +
                "SET techID = @NewTechID, " +
                "Description = @NewDescription " +
                "WHERE IncidentID = @OldIncidentID " +
                "AND Description = @OldDescription";
            
            SqlCommand updateCommand = new SqlCommand(updateStatement, connection);
            updateCommand.Parameters.AddWithValue("@NewTechID", newIncident.TechID);
             // the 200 character logic for the description to be handled in the same place where this method is called
            updateCommand.Parameters.AddWithValue("@NewDescription", newIncident.Description);
            updateCommand.Parameters.AddWithValue("@OldIncidentID", oldIncident.IncidentID);
            updateCommand.Parameters.AddWithValue("@OldDescription", oldIncident.Description);

            try
            {
                connection.Open();
                int count = updateCommand.ExecuteNonQuery();
                if (count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
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
