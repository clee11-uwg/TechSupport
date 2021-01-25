using System;
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
                MainForm mainForm = new MainForm(txtBxUsername.Text);                
                DialogResult mainFormResult = mainForm.ShowDialog();
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
