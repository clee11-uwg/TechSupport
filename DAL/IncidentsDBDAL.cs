using System.Collections.Generic;
using System.Data.SqlClient;
using TechSupport.Model;

namespace TechSupport.DAL
{
    /// <summary>
    /// This is the DAL class that deals with the Incidents from the DB
    /// </summary>
    public static class IncidentsDBDAL
    {
        /// <summary>
        /// Retrieves the Incidents from the database
        /// </summary>
        /// 
        public static List<Incident> GetIncidents()
        {
            List<Incident> incidentList = new List<Incident>();

            string selectStatement = "SELECT ProductCode, DateOpened, c.name as Customer, t.name as Technician, Title " +
                                        "FROM Incidents i Join Customers c On " +
                                        "i.CustomerID = c.CustomerID " +
                                        "LEFT OUTER JOIN Technicians t ON " +
                                        "i.TechID = t.TechID " +
                                        "WHERE DateClosed IS NULL; ";
            
            using (SqlConnection connection = IncidentsDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        int incidentProductCode = reader.GetOrdinal("ProductCode");
                        int incidentDateOpened = reader.GetOrdinal("DateOpened");
                        int incidentCustomer = reader.GetOrdinal("Customer");
                        int incidentTechnician = reader.GetOrdinal("Technician");
                        int incidentTitle = reader.GetOrdinal("Title");       
                        
                        while (reader.Read())
                        {
                            Incident incident = new Incident();
                            incident.ProductCode = reader.GetString(incidentProductCode);
                            incident.DateOpened = reader.GetDateTime(incidentDateOpened);
                            incident.Customer = reader.GetString(incidentCustomer);
                            if (reader.IsDBNull(incidentTechnician))
                            {
                                incident.Technician = "";
                            } else
                            {
                                incident.Technician = reader.GetString(incidentTechnician);
                            }
                            
                            incident.Title = reader.GetString(incidentTitle);
                            incidentList.Add(incident);
                        }
                    }
                }
            }
            return incidentList;
        }
    }
}
