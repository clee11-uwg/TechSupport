using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechSupport.Model
{
    public class Incident
    {
        /// <summary>
        /// Incident class to create an Incident object
        /// </summary>
        public string Title { get; }
        public string Description { get; }
        public int CustomerID { get; }

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
