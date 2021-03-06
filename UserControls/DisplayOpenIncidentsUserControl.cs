﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TechSupport.Controller;
using TechSupport.Model;

namespace TechSupport.UserControls
{
    /// <summary>
    /// Display Open Incident dialog that shows all of the currently open incidents
    /// </summary>
    public partial class DisplayOpenIncidentsUserControl : UserControl
    {
        private readonly IncidentController incidentController;

        /// <summary>
        /// 0 paramter constructor
        /// </summary>
        public DisplayOpenIncidentsUserControl()
        {
            InitializeComponent();
            this.incidentController = new IncidentController();
        }

        /// <summary>
        /// Populates the Open Incident List View
        /// </summary>
        public void PopulateListView()
        {
            List <Incident> incidentList = this.incidentController.GetOpenIncidents();
            try
            {
                if (incidentList.Count > 0)
                {
                    incidentListView.Items.Clear();
                    Incident incident;
                    for (int i = 0; i < incidentList.Count; i++)
                    {
                        incident = incidentList[i];
                        incidentListView.Items.Add(incident.ProductCode.ToString());
                        incidentListView.Items[i].SubItems.Add(incident.DateOpened.ToString("MM/dd/yyyy"));
                        incidentListView.Items[i].SubItems.Add(incident.Customer.ToString());
                        incidentListView.Items[i].SubItems.Add(incident.Technician);
                        incidentListView.Items[i].SubItems.Add(incident.Title);
                    }
                }
                else
                {
                    MessageBox.Show("There are no open incidents", "No open incidents");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }                
    }
}
