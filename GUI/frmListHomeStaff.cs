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
            int RevenueToday = BLL_Revenue.Instance.GetRevenueToDay();
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

        private void btnImgFood_Click(object sender, EventArgs e)
        {
            frmListFood foods = new frmListFood();
            this.panListHomeStaff.Controls.Add(foods);
            foods.BringToFront();
        }

        private void btnImgTable_Click(object sender, EventArgs e)
        {
            frmListTable tables = new frmListTable();
            this.panListHomeStaff.Controls.Add(tables);
            tables.BringToFront();
        }

        private void btnImgRevenue_Click(object sender, EventArgs e)
        {
            frmListRevenue revenues = new frmListRevenue();
            this.panListHomeStaff.Controls.Add(revenues);
            revenues.BringToFront();
        }

        private void btnImgBill_Click(object sender, EventArgs e)
        {
            frmListBill bills = new frmListBill();
            this.panListHomeStaff.Controls.Add(bills);
            bills.BringToFront();
        }
    }
}
