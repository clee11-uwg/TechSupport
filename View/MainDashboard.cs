using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TechSupport.Controller;
using TechSupport.Model;

namespace TechSupport.View
{
    public partial class MainDashboard : Form
    {
        /// <summary>
        /// Add Incident Dialog that displays the fields needed to create a new incident
        /// </summary>
        private readonly IncidentController incidentController;

        /// <summary>
        /// 0 parameter constructor that creates a new instance of the incident controller
        /// </summary>
        public MainDashboard()
        {
            InitializeComponent();
            this.incidentController = new IncidentController();
        }

        private void DashboardTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dashboardTabControl.SelectedTab.Text == "All Incidents")
            {
                this.incidentsDataGridView.DataSource = null;
                this.incidentsDataGridView.DataSource = this.incidentController.GetIncidents();
            }
            if (dashboardTabControl.SelectedTab.Text == "Display Open Incidents")
            {
                List<Incident> incidentList = this.incidentController.GetOpenIncidents();
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            int customerID = int.Parse(this.customerIDSearchTextBox.Text);
            this.searchResultsDataGridView.DataSource = null;
            this.searchResultsDataGridView.DataSource = this.incidentController.Search(customerID);
        }
    }
}
