using System;
using System.Collections.Generic;
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
            updateButton.Enabled = false;
            closeButton.Enabled = false;
            textToAddTextBox.Enabled = false;
        }

        /// <summary>
        /// Resets the Technician Combo Box
        /// </summary>
        public void ResetTechComboBox()
        {
            List<Technician> techList;
            techList = this.incidentController.GetTechnicianList();
            technicianComboBox.DataSource = techList;
            technicianComboBox.DisplayMember = "Name";
            technicianComboBox.ValueMember = "TechID";
        }

        private void GetIncidentButton_Click(object sender, EventArgs e)
        {
            int incidentID;
            if (incidentIDTextBox.Text.Trim() == "" || !int.TryParse(incidentIDTextBox.Text.Trim(), out _))
            {
                MessageBox.Show("Incident ID is not a valid number. Please try again", "Invalid Incident ID");
                ResetAllFields();
            }
            else
            {
                incidentID = Convert.ToInt32(incidentIDTextBox.Text.Trim());
                this.GetIncident(incidentID);
            }  
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

            updateButton.Enabled = true;
            closeButton.Enabled = true;
            textToAddTextBox.Enabled = true;
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ResetAllFields();
        }

        private void ResetAllFields()
        {
            incidentIDTextBox.Text = "";
            customerTextBox.Text = "";
            productTextBox.Text = "";
            ResetTechComboBox();
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

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            // Only doing logic for the text to add text box for now until i can figure out how to get the technician box to be empty
            // when the value is null within the database
            if (textToAddTextBox.Text.Trim() == "")
            {
                MessageBox.Show("Please make sure to add text to the Text To Add text box", "Text To Add Field Required");
            }
        }
    }
}
