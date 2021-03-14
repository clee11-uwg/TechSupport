using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using TechSupport.DAL;
using TechSupport.Model;

namespace TechSupport.Controller
{
    /// <summary>
    /// Incident Controller class that acts as the mediator between the DAL and the View
    /// </summary>
    public class IncidentController
    {
        /// <summary>
        /// Incident Controller class that handles the interaction between the DAL and the View
        /// </summary>
        private IncidentDAL incidentSource;
         public IncidentController()
        {
            this.incidentSource = new IncidentDAL();
        }

        /// <summary>
        /// Returns a list of incidents from the DAL
        /// </summary>
        /// <returns></returns>
        public List<Incident> GetIncidents()
        {
            return this.incidentSource.GetIncidents();
        }

        /// <summary>
        /// Returns a list of open incidents from the DAL that retrieves the data from the database
        /// </summary>
        /// <returns></returns>
        public List<Incident> GetOpenIncidents()
        {
            return IncidentsDBDAL.GetIncidents();
        }

        /// <summary>
        /// Adds an incident to the incidents list through the DAL
        /// </summary>
        /// <param name="incident"></param>
        public void Add(Incident incident)
        {
            if (incident == null)
            {
                throw new ArgumentNullException("Incident cannot be null");
            }
            this.incidentSource.Add(incident);
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
            filteredList = this.incidentSource.Search(customerID);
            return filteredList;
        }

        /// <summary>
        /// Adds incident to database via the IncidentDB's AddIncident method
        /// </summary>
        /// <param name="incident">Incident to be added</param>
        /// <returns>Returns incidentID of incident that was added</returns>
        public int AddIncidentToDB(Incident incident)
        {
            int incidentID;
            incidentID = IncidentDB.AddIncident(incident);
            return incidentID;
        }

        /// <summary>
        /// Rtrieves the incident from the IncidentDB class based on provided incidentID
        /// </summary>
        /// <param name="incidentID"></param>
        /// <returns>Returns incident whose ID is the ID passed in</returns>
        public Incident GetIncident(int incidentID)
        {
            Incident incident = IncidentDB.GetIncident(incidentID);
            return incident;
        }

        /// <summary>
        /// Closes incident
        /// </summary>
        /// <param name="incidentID"></param>
        /// <returns>Returns either true or false if the incident has been closed</returns>
        public bool CloseIncident(int incidentID)
        {
            return IncidentDB.CloseIncident(incidentID);
        }

        /// <summary>
        /// Retrieves list of technicians
        /// </summary>
        /// <returns>Returns list of technicians</returns>
        public List<Technician> GetTechnicianList()
        {
            List<Technician> myTechList;
            myTechList = TechnicianDB.GetTechnicianList();
            return myTechList;
        }

        /// <summary>
        /// Retrieves list of technicians that have incidents
        /// </summary>
        /// <returns>Returns list of technicians that have incidents</returns>
        public List<Technician> GetTechniciansWithIncidents()
        {
            List<Technician> myTechList;
            myTechList = TechnicianDB.GetTechniciansWithIncidents();
            return myTechList;
        }

        /// <summary>
        /// Retrieves list of incidents for a certain technician
        /// </summary>
        /// <param name="techID">Technician to show incidents for</param>
        /// <returns>Returns list of incidents for a certain technician</returns>
        public List<Incident> GetIncidentsForTech(int techID)
        {
            List<Incident> myIncidentList;
            myIncidentList = IncidentDB.GetIncidentsForTech(techID);
            return myIncidentList;
        }

        /// <summary>
        /// Retrieves a list of customers from the database via the CustomerDB's GetCustomerList method
        /// </summary>
        /// <returns>Returns a list of customers from the database</returns>
        public List<Customer> GetCustomerList()
        {
            List<Customer> myCustomerList;
            myCustomerList = CustomerDB.GetCustomerList();
            return myCustomerList;
        }

        /// <summary>
        /// Returns whether or not the incident was updated successfully
        /// </summary>
        /// <param name="oldIncident">Old incident as a reference</param>
        /// <param name="newIncident">new reference used to populate fields</param>
        /// <returns>Returns true or false depending on if the incident was properly updated</returns>
        public bool UpdateIncident(Incident oldIncident, Incident newIncident)
        {
            bool isIncidentUpdated = IncidentDB.UpdateIncident(oldIncident, newIncident);
            return isIncidentUpdated;
        }

        /// <summary>
        /// Retrieves specific tech based on its ID passed in
        /// </summary>
        /// <param name="techID">Used to find the correct technician</param>
        /// <returns>Returns technician based on its techID</returns>
        public Technician GetTechnician(int techID)
        {
            Technician technician = TechnicianDB.GetTechnician(techID);
            return technician;
        }

        /// <summary>
        /// Retrieves a list of products form the database via the ProductDB's GetProductList method
        /// </summary>
        /// <returns>Returns a list of products from the database</returns>
        public List<Product> GetProductList()
        {
            List<Product> myProductList;
            myProductList = ProductDB.GetProductList();
            return myProductList;
        }

        /// <summary>
        /// Checks if there is a regsitration associated with the customer for product selected
        /// </summary>
        /// <param name="incident">Used to retrieve the customer ID and product code</param>
        /// <returns>Returns the count of registrations between the customer and product selected</returns>
        public int CheckRegistration(Incident incident)
        {
            int registrationCount;
            SqlConnection connection = IncidentsDBConnection.GetConnection();
            string registrationCheckStatement =
                    "SELECT COUNT(*) FROM Registrations " +
                    "WHERE CustomerID = @CustomerID " +
                    "AND ProductCode = @ProductCode";
            SqlCommand registrationCommand = new SqlCommand(registrationCheckStatement, connection);
            registrationCommand.Parameters.AddWithValue("@CustomerID", incident.CustomerID);
            registrationCommand.Parameters.AddWithValue("@ProductCode", incident.ProductCode);
            connection.Open();
            registrationCount = Convert.ToInt32(registrationCommand.ExecuteScalar());
            return registrationCount;
        }
    }
}
