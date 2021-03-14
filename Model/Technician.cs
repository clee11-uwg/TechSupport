
namespace TechSupport.Model
{
    /// <summary>
    /// Technician class to create a technician object
    /// </summary>
    public class Technician
    {
        public string Name { get; set; }

        public int TechID { get; set; }
        public string Email { get; set; }
        public string Phone{ get; set; }

        /// <summary>
        /// 0 parameter Customer constructor
        /// </summary>
        public Technician() { }
    }
}
