using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmSignUp : Form
    {
        public frmSignUp()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            new frmLogin().Show();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txtPassword_OnValueChanged(object sender, EventArgs e)
        {
            this.txtPassword.isPassword = true;
        }

        private void txtRePassword_OnValueChanged(object sender, EventArgs e)
        {
            this.txtRePassword.isPassword = true;
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            string newUserName = txtUserName.Text;
            string newPassword = txtPassword.Text;
            string rePassword = txtRePassword.Text;
            if(newPassword == "" || newUserName == "" || rePassword == "")
            {
                MessageBox.Show("Information cannot be left blank !");
            }
            else
            {
                try
                {
                    AcountBll.Instance.InsertAccout(newUserName, newPassword);
                    MessageBox.Show("Sign up Success !!");
                    this.Close();
                    new frmLogin().Show();
                }
                catch(SqlException ex)
                {
                    MessageBox.Show("Registration failed !!");
                }
            }
        }

        private void txtUserName_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void txtUserName_Validating(object sender, CancelEventArgs e)
        {
            if (AcountBll.Instance.IsExistAccount(txtUserName.Text) == true)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtUserName, "Account already exists !!");
                MessageBox.Show("Account already exists !!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtUserName, null);
            }
        }

        private void txtRePassword_Validating(object sender, CancelEventArgs e)
        {
            if (txtPassword.Text != txtRePassword.Text)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtRePassword, "Password incorrect !!");
                MessageBox.Show("Password incorrect !!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtRePassword, null);
            }
        }
    }
}
