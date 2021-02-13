using System.Windows.Forms;
using TechSupport.Controller;

namespace TechSupport.UserControls
{
    public partial class All_IncidentsUserControl : UserControl
    {
        private readonly IncidentController incidentController;
        public All_IncidentsUserControl()
        {
            InitializeComponent();
            this.incidentController = new IncidentController();
            this.RefreshDataGridView();
        }

        private void RefreshDataGridView()
        {
            this.incidentsDataGridView.DataSource = null;
            this.incidentsDataGridView.DataSource = this.incidentController.GetIncidents();
        }
    }
}
