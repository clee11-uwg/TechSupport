namespace TechSupport.View
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
            this.lnkLblLogout = new System.Windows.Forms.LinkLabel();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.all_IncidentsUserControl1 = new TechSupport.UserControls.All_IncidentsUserControl();
            this.searchIncidentsUserControl1 = new TechSupport.UserControls.SearchIncidentsUserControl();
            this.displayOpenIncidentsUserControl1 = new TechSupport.UserControls.DisplayOpenIncidentsUserControl();
            this.addIncidentUserControl1 = new TechSupport.User_Controls.AddIncidentUserControl();
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
            this.dashboardTabControl.Location = new System.Drawing.Point(0, 108);
            this.dashboardTabControl.Name = "dashboardTabControl";
            this.dashboardTabControl.SelectedIndex = 0;
            this.dashboardTabControl.Size = new System.Drawing.Size(924, 503);
            this.dashboardTabControl.TabIndex = 0;
            this.dashboardTabControl.SelectedIndexChanged += new System.EventHandler(this.DashboardTabControl_SelectedIndexChanged);
            // 
            // addIncidentTabPage
            // 
            this.addIncidentTabPage.Controls.Add(this.addIncidentUserControl1);
            this.addIncidentTabPage.Location = new System.Drawing.Point(4, 34);
            this.addIncidentTabPage.Name = "addIncidentTabPage";
            this.addIncidentTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.addIncidentTabPage.Size = new System.Drawing.Size(916, 465);
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
            this.incidentsTabPage.Size = new System.Drawing.Size(916, 465);
            this.incidentsTabPage.TabIndex = 1;
            this.incidentsTabPage.Text = "All Incidents";
            this.incidentsTabPage.UseVisualStyleBackColor = true;
            // 
            // searchTabPage
            // 
            this.searchTabPage.Controls.Add(this.searchIncidentsUserControl1);
            this.searchTabPage.Location = new System.Drawing.Point(4, 34);
            this.searchTabPage.Name = "searchTabPage";
            this.searchTabPage.Size = new System.Drawing.Size(916, 465);
            this.searchTabPage.TabIndex = 2;
            this.searchTabPage.Text = "Search Incidents";
            this.searchTabPage.UseVisualStyleBackColor = true;
            // 
            // displayOpenIncidentsTabPage
            // 
            this.displayOpenIncidentsTabPage.Controls.Add(this.displayOpenIncidentsUserControl1);
            this.displayOpenIncidentsTabPage.Location = new System.Drawing.Point(4, 34);
            this.displayOpenIncidentsTabPage.Name = "displayOpenIncidentsTabPage";
            this.displayOpenIncidentsTabPage.Size = new System.Drawing.Size(916, 465);
            this.displayOpenIncidentsTabPage.TabIndex = 3;
            this.displayOpenIncidentsTabPage.Text = "Display Open Incidents";
            this.displayOpenIncidentsTabPage.UseVisualStyleBackColor = true;
            // 
            // lnkLblLogout
            // 
            this.lnkLblLogout.AutoSize = true;
            this.lnkLblLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkLblLogout.Location = new System.Drawing.Point(701, 59);
            this.lnkLblLogout.Name = "lnkLblLogout";
            this.lnkLblLogout.Size = new System.Drawing.Size(65, 22);
            this.lnkLblLogout.TabIndex = 2;
            this.lnkLblLogout.TabStop = true;
            this.lnkLblLogout.Text = "Logout";
            this.lnkLblLogout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkLblLogout_LinkClicked);
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.Location = new System.Drawing.Point(705, 23);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(0, 22);
            this.usernameLabel.TabIndex = 3;
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
            this.searchIncidentsUserControl1.Margin = new System.Windows.Forms.Padding(6);
            this.searchIncidentsUserControl1.Name = "searchIncidentsUserControl1";
            this.searchIncidentsUserControl1.Size = new System.Drawing.Size(780, 356);
            this.searchIncidentsUserControl1.TabIndex = 0;
            // 
            // displayOpenIncidentsUserControl1
            // 
            this.displayOpenIncidentsUserControl1.Location = new System.Drawing.Point(6, 6);
            this.displayOpenIncidentsUserControl1.Margin = new System.Windows.Forms.Padding(6);
            this.displayOpenIncidentsUserControl1.Name = "displayOpenIncidentsUserControl1";
            this.displayOpenIncidentsUserControl1.Size = new System.Drawing.Size(785, 365);
            this.displayOpenIncidentsUserControl1.TabIndex = 0;
            // 
            // addIncidentUserControl1
            // 
            this.addIncidentUserControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addIncidentUserControl1.Location = new System.Drawing.Point(11, 9);
            this.addIncidentUserControl1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.addIncidentUserControl1.Name = "addIncidentUserControl1";
            this.addIncidentUserControl1.Size = new System.Drawing.Size(880, 430);
            this.addIncidentUserControl1.TabIndex = 0;
            // 
            // MainDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 611);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.lnkLblLogout);
            this.Controls.Add(this.dashboardTabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MainDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainDashboard";
            this.dashboardTabControl.ResumeLayout(false);
            this.addIncidentTabPage.ResumeLayout(false);
            this.incidentsTabPage.ResumeLayout(false);
            this.searchTabPage.ResumeLayout(false);
            this.displayOpenIncidentsTabPage.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl dashboardTabControl;
        private System.Windows.Forms.TabPage addIncidentTabPage;
        private System.Windows.Forms.TabPage incidentsTabPage;
        private System.Windows.Forms.TabPage searchTabPage;
        private System.Windows.Forms.TabPage displayOpenIncidentsTabPage;
        private UserControls.All_IncidentsUserControl all_IncidentsUserControl1;
        private UserControls.SearchIncidentsUserControl searchIncidentsUserControl1;
        private UserControls.DisplayOpenIncidentsUserControl displayOpenIncidentsUserControl1;
        private System.Windows.Forms.LinkLabel lnkLblLogout;
        private System.Windows.Forms.Label usernameLabel;
        private User_Controls.AddIncidentUserControl addIncidentUserControl1;
    }
}