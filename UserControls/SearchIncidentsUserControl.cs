using System;
using System.Windows.Forms;
using TechSupport.Controller;

namespace TechSupport.UserControls
{
    /// <summary>
    /// Search Incident Dialog that allows the user to search for a set of incidents based on that incident's customerID associated with it
    /// </summary>
    public partial class SearchIncidentsUserControl : UserControl
    {
        private readonly IncidentController incidentController;

        /// <summary>
        /// 0 paramter constructor
        /// </summary>
        public SearchIncidentsUserControl()
        {
            InitializeComponent();
            this.incidentController = new IncidentController();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            int customerID;
            if (int.TryParse(this.customerIDSearchTextBox.Text, out customerID))
            {
                customerID = int.Parse(this.customerIDSearchTextBox.Text);
                this.searchResultsDataGridView.DataSource = null;
                this.searchResultsDataGridView.DataSource = this.incidentController.Search(customerID);
            }
            else
            {
                MessageBox.Show("Please enter a valid integer for the CustomerID and try again");
            }
        }
    }
}
