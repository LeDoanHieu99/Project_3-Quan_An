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
using DATA;
using Menu = DATA.Menu;

namespace GUI
{
    public partial class frmListBill : UserControl
    {
        public frmListBill()
        {
            InitializeComponent();
        }

        int TongTien(int tableIds)
        {
            List<Menu> menus =  MenuBLL.Instance.GetListMenusById(tableIds) ;
            int tongtien = 0;
            foreach (var i in menus)
            {
                tongtien += i.TotalMoney;
            }
            return tongtien;  //bi loi
        }

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
                if (row.Cells[0].Value != null)
                {
                    int billIds = Convert.ToInt32(row.Cells[0].Value.ToString());
                    dtgvBillDetail.DataSource = BillBLL.Instance.GetListHistoryMenusById(billIds);
                    dtgvBillDetail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    for (int i = 0; i < dtgvBillDetail.Rows.Count; i++)
                    {
                        if (i % 2 == 0)
                        {
                            dtgvBillDetail.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(179, 213, 242);
                            dtgvBillDetail.Rows[i].DefaultCellStyle.SelectionBackColor = Color.FromArgb(179, 213, 242);
                        }
                        else
                        {
                            dtgvBillDetail.Rows[i].DefaultCellStyle.BackColor = Color.White;
                            dtgvBillDetail.Rows[i].DefaultCellStyle.SelectionBackColor = Color.White;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Bill not exist");
            }


        }

        private void frmListBill_Load(object sender, EventArgs e)
        {

        }

        private void datetimeGetDay_onValueChanged(object sender, EventArgs e)
        {
            //string date = datetimeGetDay.Value.ToShortDateString();
            //dtgvBill.DataSource = BillBLL.Instance.GetBillByDate(date);
            //dtgvBill.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //for (int i = 0; i < dtgvBill.Rows.Count; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        dtgvBill.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(179, 213, 242);
            //        dtgvBill.Rows[i].DefaultCellStyle.SelectionBackColor = Color.FromArgb(179, 213, 242);
            //    }
            //    else
            //    {
            //        dtgvBill.Rows[i].DefaultCellStyle.BackColor = Color.White;
            //        dtgvBill.Rows[i].DefaultCellStyle.SelectionBackColor = Color.White;
            //    }
            //}

            LoadBill();
        }

        private void DtimeGetDay_ValueChanged(object sender, EventArgs e)
        {
            string date = DtimeGetDay.Value.ToShortDateString();
            dtgvBill.DataSource = BillBLL.Instance.GetBillByDate(date);
            dtgvBill.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            for (int i = 0; i < dtgvBill.Rows.Count; i++)
            {
                if (i % 2 == 0)
                {
                    dtgvBillDetail.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(179, 213, 242);
                    dtgvBillDetail.Rows[i].DefaultCellStyle.SelectionBackColor = Color.FromArgb(179, 213, 242);
                }
                else
                {
                    dtgvBillDetail.Rows[i].DefaultCellStyle.BackColor = Color.White;
                    dtgvBillDetail.Rows[i].DefaultCellStyle.SelectionBackColor = Color.White;
                }
            }
        }
        private void btnImgSearch_Click(object sender, EventArgs e)
        {
            try
            {
                int tableId = Convert.ToInt32(txtTableId.Text);
                dtgvBill.DataSource = BillBLL.Instance.SearchBillByIdTable(tableId);
                dtgvBill.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                DataGridViewRow row = dtgvBill.Rows[0];
                if (row.Cells[0].Value != null)
                {
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
                    int billId = Convert.ToInt32(row.Cells[0].Value.ToString());
                    dtgvBillDetail.DataSource = BillBLL.Instance.GetListHistoryMenusById(billId);
                    for (int i = 0; i < dtgvBillDetail.Rows.Count; i++)
                    {
                        if (i % 2 == 0)
                        {
                            dtgvBillDetail.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(179, 213, 242);
                            dtgvBillDetail.Rows[i].DefaultCellStyle.SelectionBackColor = Color.FromArgb(179, 213, 242);
                        }
                        else
                        {
                            dtgvBillDetail.Rows[i].DefaultCellStyle.BackColor = Color.White;
                            dtgvBillDetail.Rows[i].DefaultCellStyle.SelectionBackColor = Color.White;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No bill to search");
                LoadBill();
            }
        }

        private void btnImgCountFood_Click(object sender, EventArgs e)
        {
            dtgvBill.DataSource = BillBLL.Instance.CountFood();
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

        private void dtgvBill_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dtgvBill.Rows[e.RowIndex];
                    txtBillId.Text = row.Cells[0].Value.ToString();
                    txtTableId.Text = row.Cells[1].Value.ToString();
                    txtStatus.Text = row.Cells[2].Value.ToString();
                    txtTotal.Text = row.Cells[3].Value.ToString();
                    int billIds = Convert.ToInt32(txtBillId.Text);
                    dtgvBillDetail.DataSource = BillBLL.Instance.GetListHistoryMenusById(billIds);
                    dtgvBillDetail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    for (int i = 0; i < dtgvBillDetail.Rows.Count; i++)
                    {
                        if (i % 2 == 0)
                        {
                            dtgvBillDetail.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(179, 213, 242);
                            dtgvBillDetail.Rows[i].DefaultCellStyle.SelectionBackColor = Color.FromArgb(179, 213, 242);
                        }
                        else
                        {
                            dtgvBillDetail.Rows[i].DefaultCellStyle.BackColor = Color.White;
                            dtgvBillDetail.Rows[i].DefaultCellStyle.SelectionBackColor = Color.White;
                        }
                    }
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("You have not entered anything yet !!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            dtgvBill.DataSource = BillBLL.Instance.CountFood();
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

       
    }
}
