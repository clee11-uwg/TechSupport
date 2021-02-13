namespace TechSupport.UserControls
{
    partial class All_IncidentsUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.incidentsDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.incidentsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // incidentsDataGridView
            // 
            this.incidentsDataGridView.AllowUserToAddRows = false;
            this.incidentsDataGridView.AllowUserToDeleteRows = false;
            this.incidentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.incidentsDataGridView.Location = new System.Drawing.Point(3, 14);
            this.incidentsDataGridView.Name = "incidentsDataGridView";
            this.incidentsDataGridView.ReadOnly = true;
            this.incidentsDataGridView.RowHeadersWidth = 51;
            this.incidentsDataGridView.Size = new System.Drawing.Size(578, 282);
            this.incidentsDataGridView.TabIndex = 6;
            // 
            // All_IncidentsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.incidentsDataGridView);
            this.Name = "All_IncidentsUserControl";
            this.Size = new System.Drawing.Size(584, 315);
            ((System.ComponentModel.ISupportInitialize)(this.incidentsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView incidentsDataGridView;
    }
}
