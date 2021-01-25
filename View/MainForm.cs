using System;
using System.Windows.Forms;

namespace TechSupport.View
{
    /// <summary>
    /// Class that creates and implements events for the main form
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Zero parameter constructor for MainForm
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 1 parameter constructor for MainForm
        /// </summary>
        /// <param name="username"></param>
        public MainForm(String username)
        {
            InitializeComponent();
            lblUsernameMF.Text = username;
        }

        private void LnkLblLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
