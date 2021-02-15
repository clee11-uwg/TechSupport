namespace TechSupport.UserControls
{
    partial class DisplayOpenIncidentsUserControl
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
            this.incidentListView = new System.Windows.Forms.ListView();
            this.customerHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.productCodeHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dateOpenedHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.titleHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.technicianHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // incidentListView
            // 
            this.incidentListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.productCodeHeader,
            this.dateOpenedHeader,
            this.customerHeader,
            this.technicianHeader,
            this.titleHeader});
            this.incidentListView.HideSelection = false;
            this.incidentListView.Location = new System.Drawing.Point(3, 3);
            this.incidentListView.Name = "incidentListView";
            this.incidentListView.Size = new System.Drawing.Size(760, 365);
            this.incidentListView.TabIndex = 1;
            this.incidentListView.UseCompatibleStateImageBehavior = false;
            this.incidentListView.View = System.Windows.Forms.View.Details;
            // 
            // customerHeader
            // 
            this.customerHeader.Text = "Customer";
            this.customerHeader.Width = 119;
            // 
            // productCodeHeader
            // 
            this.productCodeHeader.Text = "Product Code";
            this.productCodeHeader.Width = 137;
            // 
            // dateOpenedHeader
            // 
            this.dateOpenedHeader.Text = "Date Opened";
            this.dateOpenedHeader.Width = 137;
            // 
            // titleHeader
            // 
            this.titleHeader.Text = "Title";
            this.titleHeader.Width = 217;
            // 
            // technicianHeader
            // 
            this.technicianHeader.Text = "Technician";
            this.technicianHeader.Width = 129;
            // 
            // DisplayOpenIncidentsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.incidentListView);
            this.Name = "DisplayOpenIncidentsUserControl";
            this.Size = new System.Drawing.Size(766, 381);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView incidentListView;
        private System.Windows.Forms.ColumnHeader customerHeader;
        private System.Windows.Forms.ColumnHeader productCodeHeader;
        private System.Windows.Forms.ColumnHeader titleHeader;
        private System.Windows.Forms.ColumnHeader technicianHeader;
        private System.Windows.Forms.ColumnHeader dateOpenedHeader;
    }
}
