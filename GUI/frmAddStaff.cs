using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BLL;

namespace GUI
{
    public partial class frmAddStaff : Form
    {
        public frmAddStaff()
        {
            InitializeComponent();
        }

        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            if(txtNameSraff.Text == "" || txtDate.Text == "" || txtPosition.Text == "" || cboGender.SelectedItem == null)
            {
                MessageBox.Show("Missing employee information !!");
            }
            else
            {
                try
                {
                    string staff_name = txtNameSraff.Text;
                    string position = txtPosition.Text;
                    string gerder = cboGender.SelectedItem.ToString();
                    DateTime date = Convert.ToDateTime(txtDate.Text);
                    if (Staff_BLL.Instance.InsertStaff(staff_name,position,gerder,date) == true)
                    {
                        MessageBox.Show("Successfully added employees !!");
                    }
                    txtNameSraff.Text = " ";
                    txtDate.Text = " ";
                    txtPosition.Text = " ";
                    cboGender.Text = " ";
                    txtNameSraff.Focus();
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Syntax error !!");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Add failed employees !!");
                }              
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddStaff_Load(object sender, EventArgs e)
        {
            cboGender.Items.Add("Male");
            cboGender.Items.Add("Female");
        }
    }
}
