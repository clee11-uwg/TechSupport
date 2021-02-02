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
            this.searchButton = new System.Windows.Forms.Button();
            this.searchResultsDataGridView = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.searchLabel = new System.Windows.Forms.Label();
            this.customerIDSearchTextBox = new System.Windows.Forms.TextBox();
            this.addIncidentUserControl1 = new TechSupport.User_Controls.AddIncidentUserControl();
            this.incidentsDataGridView = new System.Windows.Forms.DataGridView();
            this.dashboardTabControl.SuspendLayout();
            this.addIncidentTabPage.SuspendLayout();
            this.incidentsTabPage.SuspendLayout();
            this.searchTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchResultsDataGridView)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.incidentsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dashboardTabControl
            // 
            this.dashboardTabControl.Controls.Add(this.addIncidentTabPage);
            this.dashboardTabControl.Controls.Add(this.incidentsTabPage);
            this.dashboardTabControl.Controls.Add(this.searchTabPage);
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
            this.addIncidentTabPage.Location = new System.Drawing.Point(4, 38);
            this.addIncidentTabPage.Name = "addIncidentTabPage";
            this.addIncidentTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.addIncidentTabPage.Size = new System.Drawing.Size(802, 378);
            this.addIncidentTabPage.TabIndex = 0;
            this.addIncidentTabPage.Text = "Add Incident";
            this.addIncidentTabPage.UseVisualStyleBackColor = true;
            // 
            // incidentsTabPage
            // 
            this.incidentsTabPage.Controls.Add(this.incidentsDataGridView);
            this.incidentsTabPage.Location = new System.Drawing.Point(4, 38);
            this.incidentsTabPage.Name = "incidentsTabPage";
            this.incidentsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.incidentsTabPage.Size = new System.Drawing.Size(802, 378);
            this.incidentsTabPage.TabIndex = 1;
            this.incidentsTabPage.Text = "All Incidents";
            this.incidentsTabPage.UseVisualStyleBackColor = true;
            // 
            // searchTabPage
            // 
            this.searchTabPage.Controls.Add(this.searchButton);
            this.searchTabPage.Controls.Add(this.searchResultsDataGridView);
            this.searchTabPage.Controls.Add(this.tableLayoutPanel2);
            this.searchTabPage.Location = new System.Drawing.Point(4, 38);
            this.searchTabPage.Name = "searchTabPage";
            this.searchTabPage.Size = new System.Drawing.Size(802, 378);
            this.searchTabPage.TabIndex = 2;
            this.searchTabPage.Text = "Search Incidents";
            this.searchTabPage.UseVisualStyleBackColor = true;
            // 
            // searchButton
            // 
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(432, 81);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(139, 35);
            this.searchButton.TabIndex = 6;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // searchResultsDataGridView
            // 
            this.searchResultsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchResultsDataGridView.Location = new System.Drawing.Point(225, 122);
            this.searchResultsDataGridView.Name = "searchResultsDataGridView";
            this.searchResultsDataGridView.RowHeadersWidth = 51;
            this.searchResultsDataGridView.Size = new System.Drawing.Size(349, 176);
            this.searchResultsDataGridView.TabIndex = 7;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.38202F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.61798F));
            this.tableLayoutPanel2.Controls.Add(this.searchLabel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.customerIDSearchTextBox, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(218, 12);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(356, 62);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // searchLabel
            // 
            this.searchLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchLabel.AutoSize = true;
            this.searchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLabel.Location = new System.Drawing.Point(3, 0);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(151, 62);
            this.searchLabel.TabIndex = 0;
            this.searchLabel.Text = "CustomerID:";
            this.searchLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // customerIDSearchTextBox
            // 
            this.customerIDSearchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.customerIDSearchTextBox.Location = new System.Drawing.Point(160, 13);
            this.customerIDSearchTextBox.Name = "customerIDSearchTextBox";
            this.customerIDSearchTextBox.Size = new System.Drawing.Size(193, 36);
            this.customerIDSearchTextBox.TabIndex = 1;
            // 
            // addIncidentUserControl1
            // 
            this.addIncidentUserControl1.Location = new System.Drawing.Point(0, 0);
            this.addIncidentUserControl1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.addIncidentUserControl1.Name = "addIncidentUserControl1";
            this.addIncidentUserControl1.Size = new System.Drawing.Size(802, 378);
            this.addIncidentUserControl1.TabIndex = 0;
            // 
            // incidentsDataGridView
            // 
            this.incidentsDataGridView.AllowUserToAddRows = false;
            this.incidentsDataGridView.AllowUserToDeleteRows = false;
            this.incidentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.incidentsDataGridView.Location = new System.Drawing.Point(92, 35);
            this.incidentsDataGridView.Name = "incidentsDataGridView";
            this.incidentsDataGridView.ReadOnly = true;
            this.incidentsDataGridView.RowHeadersWidth = 51;
            this.incidentsDataGridView.Size = new System.Drawing.Size(599, 242);
            this.incidentsDataGridView.TabIndex = 5;
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
            ((System.ComponentModel.ISupportInitialize)(this.searchResultsDataGridView)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.incidentsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl dashboardTabControl;
        private System.Windows.Forms.TabPage addIncidentTabPage;
        private System.Windows.Forms.TabPage incidentsTabPage;
        private System.Windows.Forms.TabPage searchTabPage;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.DataGridView searchResultsDataGridView;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.TextBox customerIDSearchTextBox;
        private User_Controls.AddIncidentUserControl addIncidentUserControl1;
        private System.Windows.Forms.DataGridView incidentsDataGridView;
    }
}