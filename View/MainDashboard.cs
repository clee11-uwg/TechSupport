using System;
using System.Windows.Forms;
using TechSupport.Controller;

namespace TechSupport.View
{
    public partial class MainDashboard : Form
    {
        /// <summary>
        /// Add Incident Dialog that displays the fields needed to create a new incident
        /// </summary>
        private readonly IncidentController incidentController;

        /// <summary>
        /// 1 parameter constructor that creates a new instance of the incident controller
        /// </summary>
        /// <param name="username"></param>
        public MainDashboard(String username)
        {
            InitializeComponent();
            this.incidentController = new IncidentController();
            usernameLabel.Text = username;
        }

        private void DashboardTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dashboardTabControl.SelectedTab.Text == "Add")
            {
                this.addIncidentUserControl1.ResetAddIncidentForm();
            }
            if (dashboardTabControl.SelectedTab.Text == "Display Open Incidents")
            {
                this.displayOpenIncidentsUserControl1.PopulateListView();
            }
            if (dashboardTabControl.SelectedTab.Text == "Update")
            {
                this.updateIncidentUserControl1.ResetTechComboBox();
            }
            if (dashboardTabControl.SelectedTab.Text == "View Incidents by Technician")
            {
                this.viewIncidentsByTechUserControl1.ResetTechnician();
            }
        }

        private void LnkLblLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void MainDashboard_Load(object sender, EventArgs e)
        {
            this.displayOpenIncidentsUserControl1.PopulateListView();
            this.addIncidentUserControl1.ResetAddIncidentForm();
        }
    }
}
