using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechSupport.DAL;
using TechSupport.Model;

namespace TechSupport.Controller
{
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
    }
}
