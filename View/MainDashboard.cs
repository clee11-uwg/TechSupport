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
            /*if (dashboardTabControl.SelectedTab.Text == "Display Open Incidents")
            {
                List<Incident> incidentList = this.incidentController.GetOpenIncidents();

                try
                {
                    if (incidentList.Count > 0)
                    {
                        Incident incident;
                        for (int i = 0; i < incidentList.Count; i++)
                        {
                            incident = incidentList[i];
                            incidentListView.Items.Add(incident.IncidentID.ToString());
                            incidentListView.Items[i].SubItems.Add(incident.ProductCode.ToString());
                            incidentListView.Items[i].SubItems.Add(incident.DateOpened.ToString("MM/dd/yyyy"));
                            incidentListView.Items[i].SubItems.Add(incident.Title);
                            incidentListView.Items[i].SubItems.Add(incident.Description);
                        }
                    }
                    else
                    {
                        MessageBox.Show("There are no open incidents", "No open incidents");
                        this.Close();
                    }
                } catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                    this.Close();
                }
                
            }*/
            if (dashboardTabControl.SelectedTab.Text == "All Incidents")
            {
                this.all_IncidentsUserControl1.RefreshDataGridView();
            }
        }
    }
}
