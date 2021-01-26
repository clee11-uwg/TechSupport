using System;
using TechSupport.Model;
using System.Collections.Generic;

namespace TechSupport.DAL
{
    public class IncidentDAL
    {
        /// <summary>
        /// Incident Data Access Layer that handles retrieving, adding, and searching functionality to the incident list
        /// </summary>
        private static List<Incident> _incidents = new List<Incident>
        {
            new Incident("Site down", "The website is down", 5),
            new Incident("Can't close program", "I am unable to close the program", 2)
        };

        /// <summary>
        /// Retrieves the list of incidents
        /// </summary>
        /// <returns>Returns list of incidents</returns>
        public List<Incident> GetIncidents()
        {
            return _incidents;
        }

        /// <summary>
        /// Adds passed in incident to the incident list
        /// </summary>
        /// <param name="incident">Incident to be added</param>
        public void Add(Incident incident)
        {
            if (incident == null)
            {
                throw new ArgumentNullException("Incident cannot be null");
            }

            _incidents.Add(incident);
        }

        /// <summary>
        /// Returns new filtered list based on customerId entered
        /// </summary>
        /// <param name="customerID">CustomerID to filter the list by</param>
        /// <returns>Returns new fitlered list based on customerID</returns>
        public List<Incident> Search(int customerID)
        {
            if (customerID <= 0)
            {
                throw new ArgumentException("CustomerID must be greater than 0 and not null");
            }

            List<Incident> filteredList = new List<Incident>();
            foreach (var incident in _incidents)
            {
                if (customerID == incident.CustomerID)
                {
                    filteredList.Add(incident);
                }
            }
            return filteredList;

        }
    }
}
