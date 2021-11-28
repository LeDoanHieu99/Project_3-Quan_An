using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        bool Login(string userName, string password)
        {
            return AcountBll.Instance.Login(userName, password);
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            string passWord = txtPassword.Text;

            if(rBtnStaff.Checked == true && userName != "admin")
            {
                if (Login(userName, passWord) == true)
                {
                    frmHomeStaff homeStaff = new frmHomeStaff();
                    this.Hide();
                    homeStaff.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Invalid username or password !!");
                }
            }
            else if(rBtnAdmin.Checked == true && userName == "admin" && Login(userName, passWord) == true)
            {
                frmHome home = new frmHome();
                this.Hide();
                home.ShowDialog();
            }
            else
            {
                MessageBox.Show("Invalid username or password !!");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSignUp signUp = new frmSignUp();
            signUp.ShowDialog();
            this.Show();
        }

        private void txtPassword_OnValueChanged(object sender, EventArgs e)
        {
            this.txtPassword.isPassword = true;
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
