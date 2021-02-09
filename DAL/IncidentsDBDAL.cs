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

            string selectStatement = "SELECT * FROM Incidents";
            
            using (SqlConnection connection = IncidentsDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        int incidentTitle = reader.GetOrdinal("Title");
                        int incidentDescription = reader.GetOrdinal("Description");
                        int incidentCustomerID = reader.GetOrdinal("CustomerID");

                        while (reader.Read())
                        {
                            Incident incident = new Incident();
                            incident.Title = reader.GetString(incidentTitle);
                            incident.Description = reader.GetString(incidentDescription);
                            incident.CustomerID = reader.GetInt32(incidentCustomerID);
                            incidentList.Add(incident);
                        }
                    }
                }
            }
            return incidentList;
        }
    }
}
