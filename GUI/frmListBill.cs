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

namespace GUI
{
    public partial class frmListBill : UserControl
    {
        public frmListBill()
        {
            InitializeComponent();
            LoadBill();
        }

        //int TongTien(int MABAN)
        //{

        //    List<Menu> menus = MenuBLL.Instance.GetListMenusById(MABAN);


        //    int tongtien = 0;
        //    foreach (var i in menus)
        //    {
        //        tongtien += i.Thanhtien;
        //    }
        //    return tongtien;  //bi loi


        //}
        public void LoadBill()
        {
            string date = datetimeGetDay.Value.ToShortDateString();
            dtgvBill.DataSource = BillBLL.Instance.GetBillByDate(date);
            dtgvBill.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            for (int i = 0; i < dtgvBill.Rows.Count; i++)
            {
                if (i % 2 == 0)
                {
                    dtgvBill.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(179, 213, 242);
                    dtgvBill.Rows[i].DefaultCellStyle.SelectionBackColor = Color.FromArgb(179, 213, 242);
                }
                else
                {
                    dtgvBill.Rows[i].DefaultCellStyle.BackColor = Color.White;
                    dtgvBill.Rows[i].DefaultCellStyle.SelectionBackColor = Color.White;
                }
            }
            try
            {
                DataGridViewRow row = dtgvBill.Rows[0];
                if (row.Cells["Mã hoá đơn"].Value != null)
                {
                    int mahoadon = Convert.ToInt32(row.Cells["Mã hoá đơn"].Value.ToString());
                    dtgvBillDetail.DataSource = BillBLL.Instance.GetListHistoryMenusById(mahoadon);
                }
            }
            catch (Exception ex)
            {

            }


        }

        private void frmListBill_Load(object sender, EventArgs e)
        {

        }

        private void datetimeGetDay_onValueChanged(object sender, EventArgs e)
        {
            string date = datetimeGetDay.Value.ToShortDateString();
            dtgvBill.DataSource = BillBLL.Instance.GetBillByDate(date);
            dtgvBill.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            for (int i = 0; i < dtgvBill.Rows.Count; i++)
            {
                if (i % 2 == 0)
                {
                    dtgvBill.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(179, 213, 242);
                    dtgvBill.Rows[i].DefaultCellStyle.SelectionBackColor = Color.FromArgb(179, 213, 242);
                }
                else
                {
                    dtgvBill.Rows[i].DefaultCellStyle.BackColor = Color.White;
                    dtgvBill.Rows[i].DefaultCellStyle.SelectionBackColor = Color.White;
                }
            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            try
            {
                int tableId = Convert.ToInt32(txtTableId.Text);
                dtgvBill.DataSource = BillBLL.Instance.SearchBillByIdTable(tableId);
                dtgvBill.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                DataGridViewRow row = dtgvBill.Rows[0];
                if (row.Cells["Bill Id"].Value != null)
                {
                    int billId = Convert.ToInt32(row.Cells["Bill Id"].Value.ToString());
                    dtgvBillDetail.DataSource = BillBLL.Instance.GetListHistoryMenusById(billId);
                    for (int i = 0; i < dtgvBill.Rows.Count; i++)
                    {
                        if (i % 2 == 0)
                        {
                            dtgvBill.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(179, 213, 242);
                            dtgvBill.Rows[i].DefaultCellStyle.SelectionBackColor = Color.FromArgb(179, 213, 242);
                        }
                        else
                        {
                            dtgvBill.Rows[i].DefaultCellStyle.BackColor = Color.White;
                            dtgvBill.Rows[i].DefaultCellStyle.SelectionBackColor = Color.White;
                        }
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("No bill to search");
            }
        }

        private void dtgvBill_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dtgvBill.Rows[e.RowIndex];
                    txtBillId.Text = row.Cells["Bill Id"].Value.ToString();
                    txtTableId.Text = row.Cells["Table Id"].Value.ToString();
                    txtStatus.Text = row.Cells["Status"].Value.ToString();
                    txtTotal.Text = row.Cells["Total Money"].Value.ToString();
                    int mahoadon = Convert.ToInt32(txtBillId.Text);
                    dtgvBillDetail.DataSource = BillBLL.Instance.GetListHistoryMenusById(mahoadon);
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("You have not entered anything yet !!");
            }
        }
    }
}
