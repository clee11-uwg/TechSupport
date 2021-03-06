﻿namespace TechSupport.View
{
    partial class MainForm
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
            this.lblUsernameMF = new System.Windows.Forms.Label();
            this.lnkLblLogout = new System.Windows.Forms.LinkLabel();
            this.addIncidentButton = new System.Windows.Forms.Button();
            this.searchIncidentButton = new System.Windows.Forms.Button();
            this.incidentsDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.incidentsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUsernameMF
            // 
            this.lblUsernameMF.AutoSize = true;
            this.lblUsernameMF.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsernameMF.Location = new System.Drawing.Point(662, 31);
            this.lblUsernameMF.Name = "lblUsernameMF";
            this.lblUsernameMF.Size = new System.Drawing.Size(0, 22);
            this.lblUsernameMF.TabIndex = 0;
            // 
            // lnkLblLogout
            // 
            this.lnkLblLogout.AutoSize = true;
            this.lnkLblLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkLblLogout.Location = new System.Drawing.Point(633, 90);
            this.lnkLblLogout.Name = "lnkLblLogout";
            this.lnkLblLogout.Size = new System.Drawing.Size(65, 22);
            this.lnkLblLogout.TabIndex = 1;
            this.lnkLblLogout.TabStop = true;
            this.lnkLblLogout.Text = "Logout";
            this.lnkLblLogout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkLblLogout_LinkClicked);
            // 
            // addIncidentButton
            // 
            this.addIncidentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addIncidentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addIncidentButton.Location = new System.Drawing.Point(85, 115);
            this.addIncidentButton.Name = "addIncidentButton";
            this.addIncidentButton.Size = new System.Drawing.Size(135, 36);
            this.addIncidentButton.TabIndex = 2;
            this.addIncidentButton.Text = "Add Incident";
            this.addIncidentButton.UseVisualStyleBackColor = true;
            this.addIncidentButton.Click += new System.EventHandler(this.AddIncidentButton_Click);
            // 
            // searchIncidentButton
            // 
            this.searchIncidentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchIncidentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchIncidentButton.Location = new System.Drawing.Point(324, 115);
            this.searchIncidentButton.Name = "searchIncidentButton";
            this.searchIncidentButton.Size = new System.Drawing.Size(144, 36);
            this.searchIncidentButton.TabIndex = 3;
            this.searchIncidentButton.Text = "Search Incident";
            this.searchIncidentButton.UseVisualStyleBackColor = true;
            this.searchIncidentButton.Click += new System.EventHandler(this.SearchIncidentButton_Click);
            // 
            // incidentsDataGridView
            // 
            this.incidentsDataGridView.AllowUserToAddRows = false;
            this.incidentsDataGridView.AllowUserToDeleteRows = false;
            this.incidentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.incidentsDataGridView.Location = new System.Drawing.Point(85, 199);
            this.incidentsDataGridView.Name = "incidentsDataGridView";
            this.incidentsDataGridView.ReadOnly = true;
            this.incidentsDataGridView.Size = new System.Drawing.Size(383, 183);
            this.incidentsDataGridView.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.incidentsDataGridView);
            this.Controls.Add(this.searchIncidentButton);
            this.Controls.Add(this.addIncidentButton);
            this.Controls.Add(this.lnkLblLogout);
            this.Controls.Add(this.lblUsernameMF);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Form";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.incidentsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsernameMF;
        private System.Windows.Forms.LinkLabel lnkLblLogout;
        private System.Windows.Forms.Button addIncidentButton;
        private System.Windows.Forms.Button searchIncidentButton;
        private System.Windows.Forms.DataGridView incidentsDataGridView;
    }
}