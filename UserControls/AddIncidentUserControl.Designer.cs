namespace TechSupport.User_Controls
{
    partial class AddIncidentUserControl
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
            this.clearButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.fieldsTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.customerLabel = new System.Windows.Forms.Label();
            this.productLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.customerComboBox = new System.Windows.Forms.ComboBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.productComboBox = new System.Windows.Forms.ComboBox();
            this.fieldsTableLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // clearButton
            // 
            this.clearButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(424, 173);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(102, 31);
            this.clearButton.TabIndex = 6;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // addButton
            // 
            this.addButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.Location = new System.Drawing.Point(94, 173);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(154, 31);
            this.addButton.TabIndex = 5;
            this.addButton.Text = "Create Incident";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // fieldsTableLayout
            // 
            this.fieldsTableLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.fieldsTableLayout.ColumnCount = 3;
            this.fieldsTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.62162F));
            this.fieldsTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.37838F));
            this.fieldsTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 185F));
            this.fieldsTableLayout.Controls.Add(this.clearButton, 2, 4);
            this.fieldsTableLayout.Controls.Add(this.addButton, 1, 4);
            this.fieldsTableLayout.Controls.Add(this.customerLabel, 0, 0);
            this.fieldsTableLayout.Controls.Add(this.productLabel, 0, 1);
            this.fieldsTableLayout.Controls.Add(this.titleLabel, 0, 2);
            this.fieldsTableLayout.Controls.Add(this.descriptionLabel, 0, 3);
            this.fieldsTableLayout.Controls.Add(this.customerComboBox, 1, 0);
            this.fieldsTableLayout.Controls.Add(this.titleTextBox, 1, 2);
            this.fieldsTableLayout.Controls.Add(this.descriptionTextBox, 1, 3);
            this.fieldsTableLayout.Controls.Add(this.productComboBox, 1, 1);
            this.fieldsTableLayout.Dock = System.Windows.Forms.DockStyle.Top;
            this.fieldsTableLayout.Location = new System.Drawing.Point(0, 0);
            this.fieldsTableLayout.Margin = new System.Windows.Forms.Padding(3, 3, 13, 3);
            this.fieldsTableLayout.Name = "fieldsTableLayout";
            this.fieldsTableLayout.RowCount = 5;
            this.fieldsTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.15385F));
            this.fieldsTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.84615F));
            this.fieldsTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.fieldsTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.fieldsTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.fieldsTableLayout.Size = new System.Drawing.Size(607, 296);
            this.fieldsTableLayout.TabIndex = 8;
            // 
            // customerLabel
            // 
            this.customerLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.customerLabel.AutoSize = true;
            this.customerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerLabel.Location = new System.Drawing.Point(3, 0);
            this.customerLabel.Name = "customerLabel";
            this.customerLabel.Size = new System.Drawing.Size(82, 26);
            this.customerLabel.TabIndex = 0;
            this.customerLabel.Text = "Customer:";
            this.customerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // productLabel
            // 
            this.productLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.productLabel.AutoSize = true;
            this.productLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productLabel.Location = new System.Drawing.Point(3, 31);
            this.productLabel.Name = "productLabel";
            this.productLabel.Size = new System.Drawing.Size(72, 20);
            this.productLabel.TabIndex = 1;
            this.productLabel.Text = "Product:";
            this.productLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // titleLabel
            // 
            this.titleLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(3, 62);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(46, 20);
            this.titleLabel.TabIndex = 2;
            this.titleLabel.Text = "Title:";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLabel.Location = new System.Drawing.Point(3, 91);
            this.descriptionLabel.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(77, 40);
            this.descriptionLabel.TabIndex = 3;
            this.descriptionLabel.Text = "Description:";
            this.descriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // customerComboBox
            // 
            this.fieldsTableLayout.SetColumnSpan(this.customerComboBox, 2);
            this.customerComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.customerComboBox.FormattingEnabled = true;
            this.customerComboBox.Location = new System.Drawing.Point(94, 3);
            this.customerComboBox.Name = "customerComboBox";
            this.customerComboBox.Size = new System.Drawing.Size(435, 21);
            this.customerComboBox.TabIndex = 1;
            // 
            // titleTextBox
            // 
            this.fieldsTableLayout.SetColumnSpan(this.titleTextBox, 2);
            this.titleTextBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.titleTextBox.Location = new System.Drawing.Point(94, 63);
            this.titleTextBox.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(435, 20);
            this.titleTextBox.TabIndex = 3;
            // 
            // descriptionTextBox
            // 
            this.fieldsTableLayout.SetColumnSpan(this.descriptionTextBox, 2);
            this.descriptionTextBox.Location = new System.Drawing.Point(94, 91);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(435, 76);
            this.descriptionTextBox.TabIndex = 4;
            // 
            // productComboBox
            // 
            this.fieldsTableLayout.SetColumnSpan(this.productComboBox, 2);
            this.productComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.productComboBox.FormattingEnabled = true;
            this.productComboBox.Location = new System.Drawing.Point(94, 29);
            this.productComboBox.Name = "productComboBox";
            this.productComboBox.Size = new System.Drawing.Size(435, 21);
            this.productComboBox.TabIndex = 2;
            // 
            // AddIncidentUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.fieldsTableLayout);
            this.Name = "AddIncidentUserControl";
            this.Size = new System.Drawing.Size(607, 312);
            this.fieldsTableLayout.ResumeLayout(false);
            this.fieldsTableLayout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TableLayoutPanel fieldsTableLayout;
        private System.Windows.Forms.Label customerLabel;
        private System.Windows.Forms.Label productLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.ComboBox customerComboBox;
        private System.Windows.Forms.ComboBox productComboBox;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
    }
}
