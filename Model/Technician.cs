using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechSupport.Model
{
    /// <summary>
    /// Technician class to create a technician object
    /// </summary>
    public class Technician
    {
        public string Name { get; set; }

        public int TechID { get; set; }

        /// <summary>
        /// 0 parameter Customer constructor
        /// </summary>
        public Technician() { }
    }
}
