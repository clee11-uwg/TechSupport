namespace TechSupport.View
{
    partial class SearchIncidentDialog
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
            this.searchLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.customerIDSearchTextBox = new System.Windows.Forms.TextBox();
            this.searchResultsDataGridView = new System.Windows.Forms.DataGridView();
            this.searchButton = new System.Windows.Forms.Button();
            this.backToMainFormButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchResultsDataGridView)).BeginInit();
            this.SuspendLayout();
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
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.38202F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.61798F));
            this.tableLayoutPanel1.Controls.Add(this.searchLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.customerIDSearchTextBox, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(118, 58);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(356, 62);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // customerIDSearchTextBox
            // 
            this.customerIDSearchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.customerIDSearchTextBox.Location = new System.Drawing.Point(160, 21);
            this.customerIDSearchTextBox.Name = "customerIDSearchTextBox";
            this.customerIDSearchTextBox.Size = new System.Drawing.Size(193, 20);
            this.customerIDSearchTextBox.TabIndex = 1;
            // 
            // searchResultsDataGridView
            // 
            this.searchResultsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchResultsDataGridView.Location = new System.Drawing.Point(125, 168);
            this.searchResultsDataGridView.Name = "searchResultsDataGridView";
            this.searchResultsDataGridView.Size = new System.Drawing.Size(349, 176);
            this.searchResultsDataGridView.TabIndex = 3;
            // 
            // searchButton
            // 
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(332, 127);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(139, 35);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // backToMainFormButton
            // 
            this.backToMainFormButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backToMainFormButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backToMainFormButton.Location = new System.Drawing.Point(125, 127);
            this.backToMainFormButton.Name = "backToMainFormButton";
            this.backToMainFormButton.Size = new System.Drawing.Size(139, 35);
            this.backToMainFormButton.TabIndex = 4;
            this.backToMainFormButton.Text = "Back to Main Form";
            this.backToMainFormButton.UseVisualStyleBackColor = true;
            this.backToMainFormButton.Click += new System.EventHandler(this.BackToMainFormButton_Click);
            // 
            // SearchIncidentDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 444);
            this.Controls.Add(this.backToMainFormButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchResultsDataGridView);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SearchIncidentDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search Incident Dialog";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchResultsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox customerIDSearchTextBox;
        private System.Windows.Forms.DataGridView searchResultsDataGridView;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button backToMainFormButton;
    }
}