namespace TechSupport.UserControls
{
    partial class UpdateIncidentUserControl
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
            this.incidentIDTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.incidentIDLabel = new System.Windows.Forms.Label();
            this.incidentIDTextBox = new System.Windows.Forms.TextBox();
            this.getIncidentButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.prefillTablePayout = new System.Windows.Forms.TableLayoutPanel();
            this.customerLabel = new System.Windows.Forms.Label();
            this.customerTextBox = new System.Windows.Forms.TextBox();
            this.productLabel = new System.Windows.Forms.Label();
            this.productTextBox = new System.Windows.Forms.TextBox();
            this.techLabel = new System.Windows.Forms.Label();
            this.technicianComboBox = new System.Windows.Forms.ComboBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.dateOpenedLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.textToAddLabel = new System.Windows.Forms.Label();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.dateOpenedTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.textToAddTextBox = new System.Windows.Forms.TextBox();
            this.buttonTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.updateButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.incidentIDTableLayout.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.prefillTablePayout.SuspendLayout();
            this.buttonTableLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // incidentIDTableLayout
            // 
            this.incidentIDTableLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.incidentIDTableLayout.ColumnCount = 3;
            this.incidentIDTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.incidentIDTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.85714F));
            this.incidentIDTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.80952F));
            this.incidentIDTableLayout.Controls.Add(this.incidentIDTextBox, 1, 0);
            this.incidentIDTableLayout.Controls.Add(this.incidentIDLabel, 0, 0);
            this.incidentIDTableLayout.Controls.Add(this.getIncidentButton, 2, 0);
            this.incidentIDTableLayout.Location = new System.Drawing.Point(0, 0);
            this.incidentIDTableLayout.Margin = new System.Windows.Forms.Padding(0);
            this.incidentIDTableLayout.Name = "incidentIDTableLayout";
            this.incidentIDTableLayout.RowCount = 1;
            this.incidentIDTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.incidentIDTableLayout.Size = new System.Drawing.Size(338, 32);
            this.incidentIDTableLayout.TabIndex = 0;
            // 
            // incidentIDLabel
            // 
            this.incidentIDLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.incidentIDLabel.AutoSize = true;
            this.incidentIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incidentIDLabel.Location = new System.Drawing.Point(3, 6);
            this.incidentIDLabel.Name = "incidentIDLabel";
            this.incidentIDLabel.Size = new System.Drawing.Size(94, 20);
            this.incidentIDLabel.TabIndex = 0;
            this.incidentIDLabel.Text = "Incident ID:";
            // 
            // incidentIDTextBox
            // 
            this.incidentIDTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.incidentIDTextBox.Location = new System.Drawing.Point(115, 6);
            this.incidentIDTextBox.Name = "incidentIDTextBox";
            this.incidentIDTextBox.Size = new System.Drawing.Size(138, 20);
            this.incidentIDTextBox.TabIndex = 1;
            // 
            // getIncidentButton
            // 
            this.getIncidentButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.getIncidentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getIncidentButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.getIncidentButton.Location = new System.Drawing.Point(259, 3);
            this.getIncidentButton.Name = "getIncidentButton";
            this.getIncidentButton.Size = new System.Drawing.Size(69, 26);
            this.getIncidentButton.TabIndex = 2;
            this.getIncidentButton.Text = "Get";
            this.getIncidentButton.UseVisualStyleBackColor = true;
            this.getIncidentButton.Click += new System.EventHandler(this.GetIncidentButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.incidentIDTableLayout, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.prefillTablePayout, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonTableLayout, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 275F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(753, 446);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // prefillTablePayout
            // 
            this.prefillTablePayout.ColumnCount = 2;
            this.prefillTablePayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.8497F));
            this.prefillTablePayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.1503F));
            this.prefillTablePayout.Controls.Add(this.textToAddTextBox, 1, 6);
            this.prefillTablePayout.Controls.Add(this.titleLabel, 0, 3);
            this.prefillTablePayout.Controls.Add(this.customerLabel, 0, 0);
            this.prefillTablePayout.Controls.Add(this.customerTextBox, 1, 0);
            this.prefillTablePayout.Controls.Add(this.productLabel, 0, 1);
            this.prefillTablePayout.Controls.Add(this.productTextBox, 1, 1);
            this.prefillTablePayout.Controls.Add(this.techLabel, 0, 2);
            this.prefillTablePayout.Controls.Add(this.technicianComboBox, 1, 2);
            this.prefillTablePayout.Controls.Add(this.dateOpenedLabel, 0, 4);
            this.prefillTablePayout.Controls.Add(this.titleTextBox, 1, 3);
            this.prefillTablePayout.Controls.Add(this.dateOpenedTextBox, 1, 4);
            this.prefillTablePayout.Controls.Add(this.descriptionTextBox, 1, 5);
            this.prefillTablePayout.Controls.Add(this.descriptionLabel, 0, 5);
            this.prefillTablePayout.Controls.Add(this.textToAddLabel, 0, 6);
            this.prefillTablePayout.Location = new System.Drawing.Point(3, 38);
            this.prefillTablePayout.Name = "prefillTablePayout";
            this.prefillTablePayout.RowCount = 7;
            this.prefillTablePayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.prefillTablePayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.prefillTablePayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.prefillTablePayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.prefillTablePayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.prefillTablePayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.prefillTablePayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.prefillTablePayout.Size = new System.Drawing.Size(499, 269);
            this.prefillTablePayout.TabIndex = 1;
            // 
            // customerLabel
            // 
            this.customerLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.customerLabel.AutoSize = true;
            this.customerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerLabel.Location = new System.Drawing.Point(3, 5);
            this.customerLabel.Name = "customerLabel";
            this.customerLabel.Size = new System.Drawing.Size(87, 20);
            this.customerLabel.TabIndex = 0;
            this.customerLabel.Text = "Customer:";
            // 
            // customerTextBox
            // 
            this.customerTextBox.Location = new System.Drawing.Point(127, 3);
            this.customerTextBox.Name = "customerTextBox";
            this.customerTextBox.Size = new System.Drawing.Size(291, 20);
            this.customerTextBox.TabIndex = 1;
            // 
            // productLabel
            // 
            this.productLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.productLabel.AutoSize = true;
            this.productLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productLabel.Location = new System.Drawing.Point(3, 35);
            this.productLabel.Name = "productLabel";
            this.productLabel.Size = new System.Drawing.Size(72, 20);
            this.productLabel.TabIndex = 2;
            this.productLabel.Text = "Product:";
            // 
            // productTextBox
            // 
            this.productTextBox.Location = new System.Drawing.Point(127, 33);
            this.productTextBox.Name = "productTextBox";
            this.productTextBox.Size = new System.Drawing.Size(291, 20);
            this.productTextBox.TabIndex = 3;
            // 
            // techLabel
            // 
            this.techLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.techLabel.AutoSize = true;
            this.techLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.techLabel.Location = new System.Drawing.Point(3, 65);
            this.techLabel.Name = "techLabel";
            this.techLabel.Size = new System.Drawing.Size(95, 20);
            this.techLabel.TabIndex = 4;
            this.techLabel.Text = "Technician:";
            // 
            // technicianComboBox
            // 
            this.technicianComboBox.FormattingEnabled = true;
            this.technicianComboBox.Location = new System.Drawing.Point(127, 63);
            this.technicianComboBox.Name = "technicianComboBox";
            this.technicianComboBox.Size = new System.Drawing.Size(291, 21);
            this.technicianComboBox.TabIndex = 5;
            // 
            // titleLabel
            // 
            this.titleLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(3, 95);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(46, 20);
            this.titleLabel.TabIndex = 6;
            this.titleLabel.Text = "Title:";
            // 
            // dateOpenedLabel
            // 
            this.dateOpenedLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dateOpenedLabel.AutoSize = true;
            this.dateOpenedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateOpenedLabel.Location = new System.Drawing.Point(3, 125);
            this.dateOpenedLabel.Name = "dateOpenedLabel";
            this.dateOpenedLabel.Size = new System.Drawing.Size(113, 20);
            this.dateOpenedLabel.TabIndex = 7;
            this.dateOpenedLabel.Text = "Date Opened:";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLabel.Location = new System.Drawing.Point(3, 150);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(100, 20);
            this.descriptionLabel.TabIndex = 8;
            this.descriptionLabel.Text = "Description:";
            // 
            // textToAddLabel
            // 
            this.textToAddLabel.AutoSize = true;
            this.textToAddLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textToAddLabel.Location = new System.Drawing.Point(3, 210);
            this.textToAddLabel.Name = "textToAddLabel";
            this.textToAddLabel.Size = new System.Drawing.Size(104, 20);
            this.textToAddLabel.TabIndex = 9;
            this.textToAddLabel.Text = "Text To Add:";
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(127, 93);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(291, 20);
            this.titleTextBox.TabIndex = 10;
            // 
            // dateOpenedTextBox
            // 
            this.dateOpenedTextBox.Location = new System.Drawing.Point(127, 123);
            this.dateOpenedTextBox.Name = "dateOpenedTextBox";
            this.dateOpenedTextBox.Size = new System.Drawing.Size(143, 20);
            this.dateOpenedTextBox.TabIndex = 11;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(127, 153);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(291, 54);
            this.descriptionTextBox.TabIndex = 12;
            // 
            // textToAddTextBox
            // 
            this.textToAddTextBox.Location = new System.Drawing.Point(127, 213);
            this.textToAddTextBox.Multiline = true;
            this.textToAddTextBox.Name = "textToAddTextBox";
            this.textToAddTextBox.Size = new System.Drawing.Size(291, 54);
            this.textToAddTextBox.TabIndex = 13;
            // 
            // buttonTableLayout
            // 
            this.buttonTableLayout.ColumnCount = 4;
            this.buttonTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.buttonTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.buttonTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.buttonTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.buttonTableLayout.Controls.Add(this.updateButton, 1, 0);
            this.buttonTableLayout.Controls.Add(this.closeButton, 2, 0);
            this.buttonTableLayout.Controls.Add(this.clearButton, 3, 0);
            this.buttonTableLayout.Location = new System.Drawing.Point(3, 313);
            this.buttonTableLayout.Name = "buttonTableLayout";
            this.buttonTableLayout.RowCount = 1;
            this.buttonTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.buttonTableLayout.Size = new System.Drawing.Size(499, 33);
            this.buttonTableLayout.TabIndex = 2;
            // 
            // updateButton
            // 
            this.updateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.Location = new System.Drawing.Point(127, 3);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(118, 27);
            this.updateButton.TabIndex = 0;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            // 
            // closeButton
            // 
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.Location = new System.Drawing.Point(251, 3);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(118, 27);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(375, 3);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(118, 27);
            this.clearButton.TabIndex = 2;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            // 
            // UpdateIncidentUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UpdateIncidentUserControl";
            this.Size = new System.Drawing.Size(602, 357);
            this.incidentIDTableLayout.ResumeLayout(false);
            this.incidentIDTableLayout.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.prefillTablePayout.ResumeLayout(false);
            this.prefillTablePayout.PerformLayout();
            this.buttonTableLayout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel incidentIDTableLayout;
        private System.Windows.Forms.Label incidentIDLabel;
        private System.Windows.Forms.Button getIncidentButton;
        private System.Windows.Forms.TextBox incidentIDTextBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel prefillTablePayout;
        private System.Windows.Forms.Label customerLabel;
        private System.Windows.Forms.TextBox customerTextBox;
        private System.Windows.Forms.Label productLabel;
        private System.Windows.Forms.TextBox productTextBox;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label techLabel;
        private System.Windows.Forms.ComboBox technicianComboBox;
        private System.Windows.Forms.Label dateOpenedLabel;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.TextBox dateOpenedTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label textToAddLabel;
        private System.Windows.Forms.TextBox textToAddTextBox;
        private System.Windows.Forms.TableLayoutPanel buttonTableLayout;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button clearButton;
    }
}
