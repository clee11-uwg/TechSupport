using System;
using System.Windows.Forms;

namespace TechSupport.View
{
    /// <summary>
    /// Class that displays and handles events for a login form
    /// </summary>
    public partial class LoginForm : Form
    {
        /// <summary>
        /// Zero parameter constructor for LoginForm
        /// </summary>
        public LoginForm()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (txtBxUsername.Text == "Jane" && maskedTxtBxPassword.Text == "test1234")
            {
                //MainForm mainForm = new MainForm(txtBxUsername.Text); 
                this.Hide();
                MainDashboard mainDashboard = new MainDashboard(txtBxUsername.Text);
                DialogResult mainFormResult = mainDashboard.ShowDialog();
                if (mainFormResult.ToString() == "OK")
                {
                    this.Show();
                }
                if (mainFormResult.ToString() == "Cancel")
                {
                    this.Close();
                }
            }
            else
            {
               lblPasswordErrorMsg.Text = "Invalid username/password";
                lblPasswordErrorMsg.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void TextFieldChange(object sender, EventArgs e)
        {
            lblPasswordErrorMsg.Text = "";
        }
    }
}
