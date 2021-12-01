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
    public partial class frmListHomeStaff : UserControl
    {
        public frmListHomeStaff()
        {
            InitializeComponent();
            LoadRevenueToday();
            LoadCountBillToDay();
        }

        public void LoadRevenueToday()
        {
            int RevenueToday = RevenueBLL.Instance.GetRevenueToDay();
            lblRevenueToday.Text = string.Format("{0:n0}", RevenueToday);
        }

        public void LoadCountBillToDay()
        {
            lblCountOrder.Text = BillBLL.Instance.GetCountBillToDay().ToString();
        }

        private void frmListHomeStaff_Load(object sender, EventArgs e)
        {
            DateTime today = DateTime.Now;
            labelTime.Text = today.ToString("F");
        }

        private void btnFood_Click(object sender, EventArgs e)
        {
            
            frmListFood listFood = new frmListFood();
            listFood.BringToFront();
        }

        private void btnTable_Click(object sender, EventArgs e)
        {
           
            frmListTable listTable = new frmListTable();
            listTable.BringToFront();
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            frmBill bill = new frmBill();
            bill.BringToFront();
        }

        private void btnRevenue_Click(object sender, EventArgs e)
        {
            frmListRevenue listRevenue = new frmListRevenue();
            listRevenue.BringToFront();
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {

        }
    }
}
