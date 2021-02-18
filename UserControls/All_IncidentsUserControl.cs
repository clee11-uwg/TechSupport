using System.Windows.Forms;
using TechSupport.Controller;

namespace TechSupport.UserControls
{
    /// <summary>
    /// All Incident Dialog that displays all of the incidents
    /// </summary>
    public partial class All_IncidentsUserControl : UserControl
    {
        private readonly IncidentController incidentController;

        /// <summary>
        /// 0 paramter constructor
        /// </summary>
        public All_IncidentsUserControl()
        {
            InitializeComponent();
            this.incidentController = new IncidentController();
            this.RefreshDataGridView();
        }        

        /// <summary>
        /// Refreshes the data grid view
        /// </summary>
        public void RefreshDataGridView()
        {
            this.incidentsDataGridView.DataSource = null;
            this.incidentsDataGridView.DataSource = this.incidentController.GetIncidents();
        }
    }
}
