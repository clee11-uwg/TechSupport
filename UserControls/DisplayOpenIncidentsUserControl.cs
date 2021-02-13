using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TechSupport.Controller;
using TechSupport.Model;

namespace TechSupport.UserControls
{
    public partial class DisplayOpenIncidentsUserControl : UserControl
    {
        private readonly IncidentController incidentController;
        public DisplayOpenIncidentsUserControl()
        {
            InitializeComponent();
            this.incidentController = new IncidentController();
            this.PopulateListView();
        }

        private void PopulateListView()
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
                this.Close();
            }
        }                
    }
}
