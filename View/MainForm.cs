using System;
using System.Windows.Forms;
using TechSupport.Controller;

namespace TechSupport.View
{
    /// <summary>
    /// Class that creates and implements events for the main form
    /// </summary>
    public partial class MainForm : Form
    {
        private readonly IncidentController incidentController;
        /// <summary>
        /// Zero parameter constructor for MainForm
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            this.incidentController = new IncidentController();
        }

        /// <summary>
        /// 1 parameter constructor for MainForm
        /// </summary>
        /// <param name="username"></param>
        public MainForm(String username)
        {
            InitializeComponent();
            this.incidentController = new IncidentController();
            lblUsernameMF.Text = username;
        }

        private void LnkLblLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void AddIncidentButton_Click(object sender, EventArgs e)
        {
            AddIncidentDialog incidentDialog = new AddIncidentDialog();
            DialogResult incidentResult = incidentDialog.ShowDialog();

            if (incidentResult == DialogResult.OK)
            {
                this.RefreshDataGrid();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.RefreshDataGrid();
        }

        private void RefreshDataGrid()
        {
            this.incidentsDataGridView.DataSource = null;
            this.incidentsDataGridView.DataSource = this.incidentController.GetIncidents();
        }

        private void SearchIncidentButton_Click(object sender, EventArgs e)
        {
            SearchIncidentDialog searchDialog = new SearchIncidentDialog();
            DialogResult searchResult = searchDialog.ShowDialog();
        }
    }
}
