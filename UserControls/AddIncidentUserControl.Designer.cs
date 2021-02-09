﻿namespace TechSupport.User_Controls
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.customerIDTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.customerIDLabel = new System.Windows.Forms.Label();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.messageLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.customerIDTextBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.descriptionTextBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.titleLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.customerIDLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.titleTextBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.addButton, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.clearButton, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.messageLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.descriptionLabel, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 76F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(470, 350);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // customerIDTextBox
            // 
            this.customerIDTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.customerIDTextBox.Location = new System.Drawing.Point(238, 160);
            this.customerIDTextBox.Name = "customerIDTextBox";
            this.customerIDTextBox.Size = new System.Drawing.Size(229, 20);
            this.customerIDTextBox.TabIndex = 5;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.descriptionTextBox.Location = new System.Drawing.Point(238, 92);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(229, 20);
            this.descriptionTextBox.TabIndex = 4;
            // 
            // titleLabel
            // 
            this.titleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(3, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(229, 68);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Incident Title:";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // customerIDLabel
            // 
            this.customerIDLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customerIDLabel.AutoSize = true;
            this.customerIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerIDLabel.Location = new System.Drawing.Point(3, 136);
            this.customerIDLabel.Name = "customerIDLabel";
            this.customerIDLabel.Size = new System.Drawing.Size(229, 68);
            this.customerIDLabel.TabIndex = 2;
            this.customerIDLabel.Text = "Customer ID:";
            this.customerIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // titleTextBox
            // 
            this.titleTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.titleTextBox.Location = new System.Drawing.Point(238, 24);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(229, 20);
            this.titleTextBox.TabIndex = 3;
            // 
            // addButton
            // 
            this.addButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.Location = new System.Drawing.Point(67, 275);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(100, 72);
            this.addButton.TabIndex = 6;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(302, 275);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(100, 72);
            this.clearButton.TabIndex = 7;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.Location = new System.Drawing.Point(3, 204);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(0, 15);
            this.messageLabel.TabIndex = 8;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLabel.Location = new System.Drawing.Point(3, 68);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(229, 68);
            this.descriptionLabel.TabIndex = 1;
            this.descriptionLabel.Text = "Incident Description:";
            this.descriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddIncidentUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "AddIncidentUserControl";
            this.Size = new System.Drawing.Size(476, 356);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox customerIDTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label customerIDLabel;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.Label descriptionLabel;
    }
}