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
            if (incident.Technician.Equals(null))
            {
                technicianComboBox.Text = "-- Unassigned --";
            }
            else
            {
                technicianComboBox.Text = incident.Technician;
            }
            
            titleTextBox.Text = incident.Title;
            dateOpenedTextBox.Text = incident.DateOpened.ToString("MM/dd/yyyy");
            descriptionTextBox.Text = incident.Description;
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            incidentIDTextBox.Text = "";
            customerTextBox.Text = "";
            productTextBox.Text = "";
            //tech combo box
            titleTextBox.Text = "";
            dateOpenedTextBox.Text = "";
            descriptionTextBox.Text = "";
            textToAddTextBox.Text = "";
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to close this incident?", "Close Incident", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                int incidentID = Convert.ToInt32(incidentIDTextBox.Text);
                bool isIncidentClosed = this.incidentController.CloseIncident(incidentID);
                if (isIncidentClosed)
                {
                    MessageBox.Show("The incident has been closed");
                }
            }
            
        }
    }
}
