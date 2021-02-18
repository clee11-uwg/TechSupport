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
            if (dashboardTabControl.SelectedTab.Text == "All Incidents")
            {
                this.all_IncidentsUserControl1.RefreshDataGridView();
            }
            if (dashboardTabControl.SelectedTab.Text == "Add Incident")
            {
                this.addIncidentUserControl1.ResetAddIncidentForm();
            }
        }

        private void LnkLblLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void MainDashboard_Load(object sender, EventArgs e)
        {
            this.addIncidentUserControl1.ResetAddIncidentForm();
        }
    }
}
