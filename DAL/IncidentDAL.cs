using System;
using TechSupport.Model;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechSupport.DAL
{
    public class IncidentDAL
    {
        private static List<Incident> _incidents = new List<Incident>
        {
            new Incident("Site down", "The website is down", 5),
            new Incident("Can't close program", "I am unable to close the program", 2)
        };

        public List<Incident> GetIncidents()
        {
            return _incidents;
        }

        public void Add(Incident incident)
        {
            if (incident == null)
            {
                throw new ArgumentNullException("Incident cannot be null");
            }

            _incidents.Add(incident);
        }
    }
}
