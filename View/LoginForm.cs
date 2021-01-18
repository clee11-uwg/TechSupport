using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechSupport.View
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (txtBxUsername.Text == "Jane" && maskedTxtBxPassword.Text == "test1234")
            {
                // Directs user to MainForm       
                this.Hide();
                MainForm mainForm = new MainForm(txtBxUsername.Text);
                mainForm.ShowDialog();
                this.Close();
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
