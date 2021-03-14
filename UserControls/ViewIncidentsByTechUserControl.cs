﻿using System;
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

        public ViewIncidentsByTechUserControl()
        {
            InitializeComponent();
            this.incidentController = new IncidentController();
        }

        public void ResetTechnician()
        {
            
        }

        private void NameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            Technician technician = techList[nameComboBox.SelectedIndex];

            technicianBindingSource.Clear();
            technicianBindingSource.Add(technician);
        }

        private void ViewIncidentsByTechUserControl_Load(object sender, EventArgs e)
        {
            techList = incidentController.GetTechniciansWithIncidents();
            nameComboBox.DataSource = techList;
        }
    }
}
