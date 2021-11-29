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
                MessageBox.Show("Thông tin còn thiếu");
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
                        MessageBox.Show("Thêm nhân viên thành công");
                    }
                    txtNameSraff.Text = " ";
                    txtDate.Text = " ";
                    txtPosition.Text = " ";
                    cboGender.Text = " ";
                    txtNameSraff.Focus();
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Lỗi cú pháp");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Thêm nhân viên thất bại");
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
            cboGender.Items.Add("female");
        }
    }
}
