﻿using System.Collections.Generic;
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

            string selectStatement = "SELECT * FROM Incidents WHERE DateClosed IS NULL;";
            
            using (SqlConnection connection = IncidentsDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        int incidentTitle = reader.GetOrdinal("Title");
                        int incidentDescription = reader.GetOrdinal("Description");
                        int incidentIncidentID = reader.GetOrdinal("IncidentID");
                        int incidentProductCode = reader.GetOrdinal("ProductCode");
                        int incidentDateOpened = reader.GetOrdinal("DateOpened");

                        while (reader.Read())
                        {
                            Incident incident = new Incident();
                            incident.Title = reader.GetString(incidentTitle);
                            incident.Description = reader.GetString(incidentDescription);
                            incident.IncidentID = reader.GetInt32(incidentIncidentID);
                            incident.ProductCode = reader.GetString(incidentProductCode);
                            incident.DateOpened = reader.GetDateTime(incidentDateOpened);
                            incidentList.Add(incident);
                        }
                    }
                }
            }
            return incidentList;
        }
    }
}