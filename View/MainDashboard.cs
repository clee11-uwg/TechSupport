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

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                var title = this.titleTextBox.Text;
                var description = this.descriptionTextBox.Text;
                var customerID = int.Parse(this.customerIDTextBox.Text);

                this.incidentController.Add(new Incident(title, description, customerID));
                this.messageLabel.Text = "Movie is added";
            }
            catch (Exception exc)
            {
                MessageBox.Show("One of the inputs appear to be off \n" + exc.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            this.titleTextBox.Text = "";
            this.descriptionTextBox.Text = "";
            this.customerIDTextBox.Text = "";
            this.messageLabel.Text = "";
        }

        private void DashboardTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dashboardTabControl.SelectedTab.Text == "All Incidents")
            {
                this.incidentsDataGridView.DataSource = null;
                this.incidentsDataGridView.DataSource = this.incidentController.GetIncidents();
            }
        }
    }
}
