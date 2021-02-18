using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TechSupport.Controller;
//using TechSupport.DAL;
using TechSupport.Model;

namespace TechSupport.User_Controls
{
    /// <summary>
    /// Add Incident Dialog that displays the fields needed to create a new incident
    /// </summary>
    public partial class AddIncidentUserControl : UserControl
    {        
        private readonly IncidentController incidentController;
        public Incident incident;

        /// <summary>
        /// 0 parameter constructor that creates a new instance of the incident controller
        /// </summary>
        public AddIncidentUserControl()
        {
            InitializeComponent();
            this.incidentController = new IncidentController();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            incident = new Incident();
            
            try
            {
                this.SetIncidentData(incident);
                incident.IncidentID = this.incidentController.AddIncidentToDB(incident);
                MessageBox.Show("Incident has been added to the database", "Successfully Added!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            this.resetAddIncidentForm();
        }

        /// <summary>
        /// Resets the combo boxes and the text boxes
        /// </summary>
        public void resetAddIncidentForm()
        {
            this.LoadComboBoxes();
            titleTextBox.Text = "";
            descriptionTextBox.Text = "";
        }

        private void LoadComboBoxes()
        {
            List<Customer> customerList;
            customerList = CustomerDB.GetCustomerList();
            customerComboBox.DataSource = customerList;
            customerComboBox.DisplayMember = "Name";
            customerComboBox.ValueMember = "CustomerID";

            List<Product> productList;
            productList = ProductDB.GetProductList();
            productComboBox.DataSource = productList;
            productComboBox.DisplayMember = "Name";
            productComboBox.ValueMember = "ProductCode";
        }

        private void SetIncidentData(Incident incident)
        {
            incident.CustomerID = (int)customerComboBox.SelectedValue;
            incident.ProductCode = productComboBox.SelectedValue.ToString();
            incident.DateOpened = DateTime.Now;
            if (string.IsNullOrEmpty(titleTextBox.Text.Trim()) || string.IsNullOrEmpty(descriptionTextBox.Text.Trim()))
            {
                throw new Exception("Title and description cannot be empty");
            }
            else
            {
                incident.Title = titleTextBox.Text;
                incident.Description = descriptionTextBox.Text;
            }
        }
    }
}
