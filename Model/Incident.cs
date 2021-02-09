using System;
namespace TechSupport.Model
{
    public class Incident
    {
        /// <summary>
        /// Incident class to create an Incident object
        /// </summary>
        /// 

        private string title;
        private string description;
        private int customerID;
        private int incidentID;

        public string Title { get; set; }
        public string Description { get; set; }
        public int CustomerID { get; set; }
        public int IncidentID { get; set; }

        /// <summary>
        /// Incident 0-parameter constructor
        /// </summary>
        public Incident() { }

        /// <summary>
        /// 3 parameter constructor for Incident class
        /// </summary>
        /// <param name="title"></param>
        /// <param name="description"></param>
        /// <param name="customerID"></param>
        public Incident(string title, string description, int customerID)
        {
            if (string.IsNullOrEmpty(title))
            {
                throw new ArgumentException("Incident title cannot be null or empty");
            }

            if (string.IsNullOrEmpty(description))
            {
                throw new ArgumentException("Incident description cannot be null or empty");
            }

            if (customerID <= 0)
            {
                throw new ArgumentException("customerID", "Incident's customerID must be more than 0");
            }

            this.Title = title;
            this.Description = description;
            this.CustomerID = customerID;
        }
    }
}
