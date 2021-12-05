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
    public partial class frmUpdatePassword : Form
    {
      
        public frmUpdatePassword()
        {
            InitializeComponent();
        }
      
        private void btnNewPassword_Click(object sender, EventArgs e)
        {
            if (txtNewPassword.Text == "" || txtId.Text == "")
            {
                MessageBox.Show("Please enter information !!");
                return;
            }
            try
            {
                int id = Convert.ToInt32(txtId.Text);
                string name = txtNewPassword.Text;                
                if (AcountBll.Instance.UpdateAccount(id, name) == true)
                {
                    MessageBox.Show("Successfully");
                    Close();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Already Exist");
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Format Error");
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
