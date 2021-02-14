using System;
using System.Windows.Forms;
using TechSupport.Controller;

namespace TechSupport.UserControls
{
    public partial class SearchIncidentsUserControl : UserControl
    {
        private readonly IncidentController incidentController;
        public SearchIncidentsUserControl()
        {
            InitializeComponent();
            this.incidentController = new IncidentController();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            int customerID = int.Parse(this.customerIDSearchTextBox.Text);
            this.searchResultsDataGridView.DataSource = null;
            this.searchResultsDataGridView.DataSource = this.incidentController.Search(customerID);
        }
    }
}
