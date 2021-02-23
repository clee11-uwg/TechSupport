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
                    this.DisplayIncident(incident);
                }
            }
            catch (NullReferenceException nre)
            {
                MessageBox.Show("An incident with that IncidentID does not exist. Please try again.", nre.GetType().ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void DisplayIncident(Incident incident)
        {
            customerTextBox.Text = incident.Customer;
            productTextBox.Text = incident.ProductCode;
            if (incident.Technician == "")
            {
                technicianComboBox.Text = "-- Unassigned --";
            }
            else
            {
                technicianComboBox.Text = incident.Technician;
            }
            if (incident.DateClosed > DateTime.MinValue)
            {
                textToAddTextBox.Enabled = false;
                updateButton.Enabled = false;
                closeButton.Enabled = false;
            }
            else
            {
                updateButton.Enabled = true;
                closeButton.Enabled = true;
                textToAddTextBox.Enabled = true;
            }
            titleTextBox.Text = incident.Title;
            dateOpenedTextBox.Text = incident.DateOpened.ToString("MM/dd/yyyy");
            descriptionTextBox.Text = incident.Description;          
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

            DialogResult result = MessageBox.Show("Are you sure you want to close this incident? The incident can't be updated once it has been closed.", "Close Incident", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                int incidentID = Convert.ToInt32(incidentIDTextBox.Text);
                bool isIncidentClosed = this.incidentController.CloseIncident(incidentID);
                if (isIncidentClosed)
                {
                    MessageBox.Show("The incident has been closed");
                    GetIncident(incidentID);
                }
            }
            
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            // Only doing logic for the text to add text box for now until i can figure out how to get the technician box to be empty
            // when the value is null within the database
            if (textToAddTextBox.Text.Trim() == "")
            {
                if (incident.Description.Length < 185)
                    MessageBox.Show("Please make sure to add text to the Text To Add text box", "Text To Add Field Required");
                else
                    MessageBox.Show("Anything added to the Text To Add text box will result in the description field being over 200 characters long.", "Unable to Add Text");
            }
            else
            {
                Incident newIncident = new Incident();
                newIncident.IncidentID = Convert.ToInt32(incidentIDTextBox.Text.Trim());
                newIncident.Customer = incident.Customer;
                newIncident.ProductCode = incident.ProductCode;
                newIncident.TechID = Convert.ToInt32(technicianComboBox.SelectedValue);
                Technician technician = this.incidentController.GetTechnician(newIncident.TechID);
                newIncident.Technician = technician.Name;
                newIncident.Title = incident.Title;
                newIncident.DateOpened = incident.DateOpened;
                try
                {
                    if (incident.Description.Length >= 200)
                    {
                        throw new Exception("Description already contains 200 characters. No more can be added");
                    }
                    else
                    {
                        string newDescription = descriptionTextBox.Text + Environment.NewLine + Environment.NewLine + "<" + DateTime.Now.ToString("MM/dd/yyyy") + ">" + "\t " + textToAddTextBox.Text.Trim();
                        if (newDescription.Length >= 200)
                        {
                            textToAddTextBox.Text = "";
                            throw new Exception("The value entered into the Text To Add field put the description field over 200 characters and therefore was not added");                            
                        }
                        else
                        {
                            newIncident.Description = newDescription;
                        }
                    }                
                    bool isIncidentUpdated = this.incidentController.UpdateIncident(incident, newIncident);
                    if (isIncidentUpdated)
                    {
                        MessageBox.Show("Incident has been updated", "Successfully Updated!");
                        DisplayIncident(newIncident);
                        textToAddTextBox.Text = "";
                    }
                }                
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }
            }
        }
    }
}
