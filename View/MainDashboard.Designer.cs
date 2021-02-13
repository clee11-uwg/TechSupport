﻿namespace TechSupport.View
{
    partial class MainDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dashboardTabControl = new System.Windows.Forms.TabControl();
            this.addIncidentTabPage = new System.Windows.Forms.TabPage();
            this.incidentsTabPage = new System.Windows.Forms.TabPage();
            this.searchTabPage = new System.Windows.Forms.TabPage();
            this.displayOpenIncidentsTabPage = new System.Windows.Forms.TabPage();
            this.incidentListView = new System.Windows.Forms.ListView();
            this.incidentIDHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.productCodeHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.titleHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.descriptionHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dateOpenedHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addIncidentUserControl1 = new TechSupport.User_Controls.AddIncidentUserControl();
            this.all_IncidentsUserControl1 = new TechSupport.UserControls.All_IncidentsUserControl();
            this.searchIncidentsUserControl1 = new TechSupport.UserControls.SearchIncidentsUserControl();
            this.dashboardTabControl.SuspendLayout();
            this.addIncidentTabPage.SuspendLayout();
            this.incidentsTabPage.SuspendLayout();
            this.searchTabPage.SuspendLayout();
            this.displayOpenIncidentsTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // dashboardTabControl
            // 
            this.dashboardTabControl.Controls.Add(this.addIncidentTabPage);
            this.dashboardTabControl.Controls.Add(this.incidentsTabPage);
            this.dashboardTabControl.Controls.Add(this.searchTabPage);
            this.dashboardTabControl.Controls.Add(this.displayOpenIncidentsTabPage);
            this.dashboardTabControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dashboardTabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboardTabControl.Location = new System.Drawing.Point(0, 84);
            this.dashboardTabControl.Name = "dashboardTabControl";
            this.dashboardTabControl.SelectedIndex = 0;
            this.dashboardTabControl.Size = new System.Drawing.Size(810, 420);
            this.dashboardTabControl.TabIndex = 0;
            this.dashboardTabControl.SelectedIndexChanged += new System.EventHandler(this.DashboardTabControl_SelectedIndexChanged);
            // 
            // addIncidentTabPage
            // 
            this.addIncidentTabPage.Controls.Add(this.addIncidentUserControl1);
            this.addIncidentTabPage.Location = new System.Drawing.Point(4, 34);
            this.addIncidentTabPage.Name = "addIncidentTabPage";
            this.addIncidentTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.addIncidentTabPage.Size = new System.Drawing.Size(802, 382);
            this.addIncidentTabPage.TabIndex = 0;
            this.addIncidentTabPage.Text = "Add Incident";
            this.addIncidentTabPage.UseVisualStyleBackColor = true;
            // 
            // incidentsTabPage
            // 
            this.incidentsTabPage.Controls.Add(this.all_IncidentsUserControl1);
            this.incidentsTabPage.Location = new System.Drawing.Point(4, 34);
            this.incidentsTabPage.Name = "incidentsTabPage";
            this.incidentsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.incidentsTabPage.Size = new System.Drawing.Size(802, 382);
            this.incidentsTabPage.TabIndex = 1;
            this.incidentsTabPage.Text = "All Incidents";
            this.incidentsTabPage.UseVisualStyleBackColor = true;
            // 
            // searchTabPage
            // 
            this.searchTabPage.Controls.Add(this.searchIncidentsUserControl1);
            this.searchTabPage.Location = new System.Drawing.Point(4, 34);
            this.searchTabPage.Name = "searchTabPage";
            this.searchTabPage.Size = new System.Drawing.Size(802, 382);
            this.searchTabPage.TabIndex = 2;
            this.searchTabPage.Text = "Search Incidents";
            this.searchTabPage.UseVisualStyleBackColor = true;
            // 
            // displayOpenIncidentsTabPage
            // 
            this.displayOpenIncidentsTabPage.Controls.Add(this.incidentListView);
            this.displayOpenIncidentsTabPage.Location = new System.Drawing.Point(4, 34);
            this.displayOpenIncidentsTabPage.Name = "displayOpenIncidentsTabPage";
            this.displayOpenIncidentsTabPage.Size = new System.Drawing.Size(802, 382);
            this.displayOpenIncidentsTabPage.TabIndex = 3;
            this.displayOpenIncidentsTabPage.Text = "Display Open Incidents";
            this.displayOpenIncidentsTabPage.UseVisualStyleBackColor = true;
            // 
            // incidentListView
            // 
            this.incidentListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.incidentIDHeader,
            this.productCodeHeader,
            this.titleHeader,
            this.descriptionHeader,
            this.dateOpenedHeader});
            this.incidentListView.HideSelection = false;
            this.incidentListView.Location = new System.Drawing.Point(3, 22);
            this.incidentListView.Name = "incidentListView";
            this.incidentListView.Size = new System.Drawing.Size(796, 325);
            this.incidentListView.TabIndex = 0;
            this.incidentListView.UseCompatibleStateImageBehavior = false;
            this.incidentListView.View = System.Windows.Forms.View.Details;
            // 
            // incidentIDHeader
            // 
            this.incidentIDHeader.Text = "Incident ID";
            this.incidentIDHeader.Width = 108;
            // 
            // productCodeHeader
            // 
            this.productCodeHeader.Text = "Product Code";
            this.productCodeHeader.Width = 144;
            // 
            // titleHeader
            // 
            this.titleHeader.DisplayIndex = 3;
            this.titleHeader.Text = "Title";
            this.titleHeader.Width = 111;
            // 
            // descriptionHeader
            // 
            this.descriptionHeader.DisplayIndex = 4;
            this.descriptionHeader.Text = "Description";
            this.descriptionHeader.Width = 278;
            // 
            // dateOpenedHeader
            // 
            this.dateOpenedHeader.DisplayIndex = 2;
            this.dateOpenedHeader.Text = "Date Opened";
            this.dateOpenedHeader.Width = 138;
            // 
            // addIncidentUserControl1
            // 
            this.addIncidentUserControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addIncidentUserControl1.Location = new System.Drawing.Point(160, 8);
            this.addIncidentUserControl1.Margin = new System.Windows.Forms.Padding(6);
            this.addIncidentUserControl1.Name = "addIncidentUserControl1";
            this.addIncidentUserControl1.Size = new System.Drawing.Size(461, 368);
            this.addIncidentUserControl1.TabIndex = 0;
            // 
            // all_IncidentsUserControl1
            // 
            this.all_IncidentsUserControl1.Location = new System.Drawing.Point(102, 38);
            this.all_IncidentsUserControl1.Margin = new System.Windows.Forms.Padding(6);
            this.all_IncidentsUserControl1.Name = "all_IncidentsUserControl1";
            this.all_IncidentsUserControl1.Size = new System.Drawing.Size(584, 315);
            this.all_IncidentsUserControl1.TabIndex = 0;
            // 
            // searchIncidentsUserControl1
            // 
            this.searchIncidentsUserControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.searchIncidentsUserControl1.Location = new System.Drawing.Point(11, 15);
            this.searchIncidentsUserControl1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.searchIncidentsUserControl1.Name = "searchIncidentsUserControl1";
            this.searchIncidentsUserControl1.Size = new System.Drawing.Size(780, 356);
            this.searchIncidentsUserControl1.TabIndex = 0;
            // 
            // MainDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 504);
            this.Controls.Add(this.dashboardTabControl);
            this.Name = "MainDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainDashboard";
            this.dashboardTabControl.ResumeLayout(false);
            this.addIncidentTabPage.ResumeLayout(false);
            this.incidentsTabPage.ResumeLayout(false);
            this.searchTabPage.ResumeLayout(false);
            this.displayOpenIncidentsTabPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl dashboardTabControl;
        private System.Windows.Forms.TabPage addIncidentTabPage;
        private System.Windows.Forms.TabPage incidentsTabPage;
        private System.Windows.Forms.TabPage searchTabPage;
        private System.Windows.Forms.TabPage displayOpenIncidentsTabPage;
        private System.Windows.Forms.ListView incidentListView;
        private System.Windows.Forms.ColumnHeader titleHeader;
        private System.Windows.Forms.ColumnHeader descriptionHeader;
        private System.Windows.Forms.ColumnHeader incidentIDHeader;
        private System.Windows.Forms.ColumnHeader productCodeHeader;
        private System.Windows.Forms.ColumnHeader dateOpenedHeader;
        private User_Controls.AddIncidentUserControl addIncidentUserControl1;
        private UserControls.All_IncidentsUserControl all_IncidentsUserControl1;
        private UserControls.SearchIncidentsUserControl searchIncidentsUserControl1;
    }
}