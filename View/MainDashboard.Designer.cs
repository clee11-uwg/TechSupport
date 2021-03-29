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
            this.displayOpenIncidentsTabPage = new System.Windows.Forms.TabPage();
            this.displayOpenIncidentsUserControl1 = new TechSupport.UserControls.DisplayOpenIncidentsUserControl();
            this.addIncidentTabPage = new System.Windows.Forms.TabPage();
            this.addIncidentUserControl1 = new TechSupport.User_Controls.AddIncidentUserControl();
            this.updateIncidentTabPage = new System.Windows.Forms.TabPage();
            this.updateIncidentUserControl1 = new TechSupport.UserControls.UpdateIncidentUserControl();
            this.viewIncidentByTechTabPage = new System.Windows.Forms.TabPage();
            this.viewIncidentsByTechUserControl1 = new TechSupport.UserControls.ViewIncidentsByTechUserControl();
            this.lnkLblLogout = new System.Windows.Forms.LinkLabel();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.reportTabPage = new System.Windows.Forms.TabPage();
            this.dashboardTabControl.SuspendLayout();
            this.displayOpenIncidentsTabPage.SuspendLayout();
            this.addIncidentTabPage.SuspendLayout();
            this.updateIncidentTabPage.SuspendLayout();
            this.viewIncidentByTechTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // dashboardTabControl
            // 
            this.dashboardTabControl.Controls.Add(this.displayOpenIncidentsTabPage);
            this.dashboardTabControl.Controls.Add(this.addIncidentTabPage);
            this.dashboardTabControl.Controls.Add(this.updateIncidentTabPage);
            this.dashboardTabControl.Controls.Add(this.viewIncidentByTechTabPage);
            this.dashboardTabControl.Controls.Add(this.reportTabPage);
            this.dashboardTabControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dashboardTabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboardTabControl.Location = new System.Drawing.Point(0, 103);
            this.dashboardTabControl.Name = "dashboardTabControl";
            this.dashboardTabControl.SelectedIndex = 0;
            this.dashboardTabControl.Size = new System.Drawing.Size(924, 812);
            this.dashboardTabControl.TabIndex = 0;
            this.dashboardTabControl.SelectedIndexChanged += new System.EventHandler(this.DashboardTabControl_SelectedIndexChanged);
            // 
            // displayOpenIncidentsTabPage
            // 
            this.displayOpenIncidentsTabPage.Controls.Add(this.displayOpenIncidentsUserControl1);
            this.displayOpenIncidentsTabPage.Location = new System.Drawing.Point(4, 34);
            this.displayOpenIncidentsTabPage.Name = "displayOpenIncidentsTabPage";
            this.displayOpenIncidentsTabPage.Size = new System.Drawing.Size(916, 774);
            this.displayOpenIncidentsTabPage.TabIndex = 3;
            this.displayOpenIncidentsTabPage.Text = "Display Open Incidents";
            this.displayOpenIncidentsTabPage.UseVisualStyleBackColor = true;
            // 
            // displayOpenIncidentsUserControl1
            // 
            this.displayOpenIncidentsUserControl1.Location = new System.Drawing.Point(6, 6);
            this.displayOpenIncidentsUserControl1.Margin = new System.Windows.Forms.Padding(6);
            this.displayOpenIncidentsUserControl1.Name = "displayOpenIncidentsUserControl1";
            this.displayOpenIncidentsUserControl1.Size = new System.Drawing.Size(880, 448);
            this.displayOpenIncidentsUserControl1.TabIndex = 0;
            // 
            // addIncidentTabPage
            // 
            this.addIncidentTabPage.Controls.Add(this.addIncidentUserControl1);
            this.addIncidentTabPage.Location = new System.Drawing.Point(4, 34);
            this.addIncidentTabPage.Name = "addIncidentTabPage";
            this.addIncidentTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.addIncidentTabPage.Size = new System.Drawing.Size(916, 774);
            this.addIncidentTabPage.TabIndex = 0;
            this.addIncidentTabPage.Text = "Add";
            this.addIncidentTabPage.UseVisualStyleBackColor = true;
            // 
            // addIncidentUserControl1
            // 
            this.addIncidentUserControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addIncidentUserControl1.Location = new System.Drawing.Point(11, 9);
            this.addIncidentUserControl1.Margin = new System.Windows.Forms.Padding(6);
            this.addIncidentUserControl1.Name = "addIncidentUserControl1";
            this.addIncidentUserControl1.Size = new System.Drawing.Size(880, 468);
            this.addIncidentUserControl1.TabIndex = 0;
            // 
            // updateIncidentTabPage
            // 
            this.updateIncidentTabPage.Controls.Add(this.updateIncidentUserControl1);
            this.updateIncidentTabPage.Location = new System.Drawing.Point(4, 34);
            this.updateIncidentTabPage.Name = "updateIncidentTabPage";
            this.updateIncidentTabPage.Size = new System.Drawing.Size(916, 774);
            this.updateIncidentTabPage.TabIndex = 4;
            this.updateIncidentTabPage.Text = "Update";
            this.updateIncidentTabPage.UseVisualStyleBackColor = true;
            // 
            // updateIncidentUserControl1
            // 
            this.updateIncidentUserControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.updateIncidentUserControl1.Location = new System.Drawing.Point(161, 7);
            this.updateIncidentUserControl1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 0);
            this.updateIncidentUserControl1.Name = "updateIncidentUserControl1";
            this.updateIncidentUserControl1.Size = new System.Drawing.Size(602, 744);
            this.updateIncidentUserControl1.TabIndex = 0;
            // 
            // viewIncidentByTechTabPage
            // 
            this.viewIncidentByTechTabPage.Controls.Add(this.viewIncidentsByTechUserControl1);
            this.viewIncidentByTechTabPage.Location = new System.Drawing.Point(4, 34);
            this.viewIncidentByTechTabPage.Name = "viewIncidentByTechTabPage";
            this.viewIncidentByTechTabPage.Size = new System.Drawing.Size(916, 774);
            this.viewIncidentByTechTabPage.TabIndex = 5;
            this.viewIncidentByTechTabPage.Text = "View Incidents by Technician";
            this.viewIncidentByTechTabPage.UseVisualStyleBackColor = true;
            // 
            // viewIncidentsByTechUserControl1
            // 
            this.viewIncidentsByTechUserControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.viewIncidentsByTechUserControl1.Location = new System.Drawing.Point(6, 17);
            this.viewIncidentsByTechUserControl1.Margin = new System.Windows.Forms.Padding(6);
            this.viewIncidentsByTechUserControl1.Name = "viewIncidentsByTechUserControl1";
            this.viewIncidentsByTechUserControl1.Size = new System.Drawing.Size(899, 586);
            this.viewIncidentsByTechUserControl1.TabIndex = 0;
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
            // reportTabPage
            // 
            this.reportTabPage.Location = new System.Drawing.Point(4, 34);
            this.reportTabPage.Name = "reportTabPage";
            this.reportTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.reportTabPage.Size = new System.Drawing.Size(916, 774);
            this.reportTabPage.TabIndex = 6;
            this.reportTabPage.Text = "Report";
            this.reportTabPage.UseVisualStyleBackColor = true;
            // 
            // MainDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 915);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.lnkLblLogout);
            this.Controls.Add(this.dashboardTabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MainDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainDashboard";
            this.Load += new System.EventHandler(this.MainDashboard_Load);
            this.dashboardTabControl.ResumeLayout(false);
            this.displayOpenIncidentsTabPage.ResumeLayout(false);
            this.addIncidentTabPage.ResumeLayout(false);
            this.updateIncidentTabPage.ResumeLayout(false);
            this.viewIncidentByTechTabPage.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl dashboardTabControl;
        private System.Windows.Forms.TabPage addIncidentTabPage;
        private System.Windows.Forms.TabPage displayOpenIncidentsTabPage;
        private UserControls.DisplayOpenIncidentsUserControl displayOpenIncidentsUserControl1;
        private System.Windows.Forms.LinkLabel lnkLblLogout;
        private System.Windows.Forms.Label usernameLabel;
        private User_Controls.AddIncidentUserControl addIncidentUserControl1;
        private System.Windows.Forms.TabPage updateIncidentTabPage;
        private UserControls.UpdateIncidentUserControl updateIncidentUserControl1;
        private System.Windows.Forms.TabPage viewIncidentByTechTabPage;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private UserControls.ViewIncidentsByTechUserControl viewIncidentsByTechUserControl1;
        private System.Windows.Forms.TabPage reportTabPage;
    }
}