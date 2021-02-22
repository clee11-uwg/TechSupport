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
    public partial class UpdateIncidentUserControl : UserControl
    {
        private readonly IncidentController incidentController;
        private Incident incident;

        public UpdateIncidentUserControl()
        {
            InitializeComponent();
            this.incidentController = new IncidentController();
        }

        private void GetIncidentButton_Click(object sender, EventArgs e)
        {
            // Add if statement to see if incident id entered is a number and if it exists in the database
            int incidentID = Convert.ToInt32(incidentIDTextBox.Text);
            this.GetIncident(incidentID);
        }

        private void GetIncident(int incidentID)
        {
            try
            {
                incident = this.incidentController.GetIncident(incidentID);
                if (incident == null)
                {
                    MessageBox.Show("No incident found with this ID." + "Please try again", "Incident Not Found");
                }
                else
                {
                    this.DisplayIncident();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void DisplayIncident()
        {
            customerTextBox.Text = incident.Customer;
            productTextBox.Text = incident.ProductCode;
            if (incident.Technician == null)
            {
                technicianComboBox.Text = "~~ Unassigned ~~";
            }
            
            titleTextBox.Text = incident.Title;
            dateOpenedTextBox.Text = incident.DateOpened.ToString("MM/dd/yyyy");
            descriptionTextBox.Text = incident.Description;
        }
    }
}
