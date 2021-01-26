using System;
using System.Windows.Forms;
using TechSupport.Controller;

namespace TechSupport.View
{
    public partial class SearchIncidentDialog : Form
    {
        /// <summary>
        /// Dialog that allows a user to search incidents based on a provided customerID
        /// </summary>
        private readonly IncidentController incidentController;
        /// <summary>
        /// 0 paramter constructor that initializes the component and creates a new instance of the instance controller
        /// </summary>
        public SearchIncidentDialog()
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

        private void BackToMainFormButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
