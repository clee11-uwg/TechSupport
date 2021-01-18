using System;
using System.Windows.Forms;

namespace TechSupport.View
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public MainForm(String username)
        {
            InitializeComponent();
            lblUsernameMF.Text = username;
        }

        private void LnkLblLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Directs user to new Login Form
            this.Hide();
            LoginForm myLoginForm = new LoginForm();
            myLoginForm.ShowDialog();
            this.Close();
        }
    }
}
