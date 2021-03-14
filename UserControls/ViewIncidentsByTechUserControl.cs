using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TechSupport.Controller;
using TechSupport.Model;

namespace TechSupport.UserControls
{
    public partial class ViewIncidentsByTechUserControl : UserControl
    {
        private readonly IncidentController incidentController;
        private List<Technician> techList;
        private List<Incident> incidentList;

        public ViewIncidentsByTechUserControl()
        {
            InitializeComponent();
            this.incidentController = new IncidentController();
        }

        private void NameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (nameComboBox.SelectedIndex < 0)
            {
                return;
            }
            Technician technician = techList[nameComboBox.SelectedIndex];

            technicianBindingSource.Clear();
            technicianBindingSource.Add(technician);
        }

        private void ViewIncidentsByTechUserControl_Load(object sender, EventArgs e)
        {
            techList = incidentController.GetTechniciansWithIncidents();
            nameComboBox.DataSource = techList;
            this.GetIncidentsForTech();
        }

        private void GetIncidentsForTech()
        {
            int techID = (int)nameComboBox.SelectedValue;
            try
            {
                incidentList = incidentController.GetIncidentsForTech(techID);
                incidentDataGridView.DataSource = incidentList;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }
    }
}
