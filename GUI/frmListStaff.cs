using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using System.Data.SqlClient;    

namespace GUI
{
    public partial class frmListStaff : UserControl
    {
        public frmListStaff()
        {
            InitializeComponent();
        }

        private void frmListStaff_Load(object sender, EventArgs e)
        {
            dtgvStaff.DataSource = Staff_BLL.Instance.LoadStaff();
            dtgvStaff.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            for (int i = 0; i < dtgvStaff.Rows.Count; i++)
            {
                if (i % 2 == 0)
                {
                    dtgvStaff.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(179, 213, 242);
                    dtgvStaff.Rows[i].DefaultCellStyle.SelectionBackColor = Color.FromArgb(179, 213, 242);
                }
                else
                {
                    dtgvStaff.Rows[i].DefaultCellStyle.BackColor = Color.White;
                    dtgvStaff.Rows[i].DefaultCellStyle.SelectionBackColor = Color.White;
                }
            }
        }

        void LoadStaff()
        {
            dtgvStaff.DataSource = Staff_BLL.Instance.LoadStaff();
            dtgvStaff.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            for (int i = 0; i < dtgvStaff.Rows.Count; i++)
            {
                if (i % 2 == 0)
                {
                    dtgvStaff.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(179, 213, 242);
                    dtgvStaff.Rows[i].DefaultCellStyle.SelectionBackColor = Color.FromArgb(179, 213, 242);
                }
                else
                {
                    dtgvStaff.Rows[i].DefaultCellStyle.BackColor = Color.White;
                    dtgvStaff.Rows[i].DefaultCellStyle.SelectionBackColor = Color.White;
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddStaff staff = new frmAddStaff();
            staff.ShowDialog();
            LoadStaff();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtUserId.Text == "" || txtNameStaff.Text == "" || txtStaffGender.Text == "" || txtStaffDate.Text == "" || txtStaffRole.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else
            {
                try
                {
                    int userid = Convert.ToInt32(txtUserId.Text);
                    string name = txtNameStaff.Text;
                    string position = txtStaffRole.Text;
                    string gender = txtStaffGender.Text;
                    DateTime dates = Convert.ToDateTime(txtStaffDate.Text);
                    if (Staff_BLL.Instance.UpdateStaff(userid, name, position, gender, dates) == true)
                    {
                        MessageBox.Show("Cập nhật thành công thành công !");
                        LoadStaff();
                    }
                    else
                    {
                        MessageBox.Show("Mã nhân viên không tồn tại");
                    }

                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Một số thông tin không chính xác, vui lòng kiểm tra lại");
                }
            }
            txtUserId.Focus();
            txtNameStaff.Focus();
            txtStaffDate.Focus();
            txtStaffGender.Focus();
            txtStaffRole.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtUserId.Text == "")
            {
                MessageBox.Show("Mã nhân viên không được trống");

            }
            else
            {
                int id = Convert.ToInt32(txtUserId.Text);
                if (Staff_BLL.Instance.DeleteStaff(id) == true)
                {
                    MessageBox.Show("xóa thành công !");
                    LoadStaff();
                }
                else
                {
                    MessageBox.Show("Mã nhân viên không tồn tại");
                }

            }
            txtUserId.Focus();
            txtNameStaff.Focus();
            txtStaffDate.Focus();
            txtStaffGender.Focus();
            txtStaffRole.Focus();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string name = txtSearchStaff.Text;
            DataTable data = Staff_BLL.Instance.SearchStaffByName(name);
            if (data.Rows.Count == 0 || name == "")
                MessageBox.Show("Không có thông tin nhân viên cần tìm");
            else
            {
                dtgvStaff.DataSource = data;
                for (int i = 0; i < dtgvStaff.Rows.Count; i++)
                {
                    if (i % 2 == 0)
                    {
                        dtgvStaff.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(179, 213, 242);
                        dtgvStaff.Rows[i].DefaultCellStyle.SelectionBackColor = Color.FromArgb(179, 213, 242);
                    }
                    else
                    {
                        dtgvStaff.Rows[i].DefaultCellStyle.BackColor = Color.White;
                        dtgvStaff.Rows[i].DefaultCellStyle.SelectionBackColor = Color.White;
                    }
                }
            }
        }

        private void dtgvStaff_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgvStaff.Rows[e.RowIndex];
                txtUserId.Text = row.Cells["Mã nhân viên"].Value.ToString();
                txtNameStaff.Text = row.Cells["Họ tên"].Value.ToString();
                txtStaffDate.Text = row.Cells["Ngày sinh"].Value.ToString();                           
                txtStaffRole.Text = row.Cells["Chức vụ"].Value.ToString();
                txtStaffGender.Text = row.Cells["Giới tính"].Value.ToString();
            }
        }
    }
}
