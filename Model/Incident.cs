using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechSupport.Model
{
    public class Incident
    {
        public string Title { get; }
        public string Description { get; }
        public int CustomerID { get; }

        public Incident(string title, string description, int customerID)
        {

        }
    }
}
