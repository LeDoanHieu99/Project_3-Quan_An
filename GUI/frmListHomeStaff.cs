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
        }

        private void frmListHomeStaff_Load_1(object sender, EventArgs e)
        {
            DateTime today = DateTime.Now;
            labelTime.Text = today.ToString("F");

            int RevenueToday = BLL_Revenue.Instance.GetRevenueToDay();
            lblRevenueToday.Text = string.Format("{0:n0}", RevenueToday);

            lblCountOrder.Text = BillBLL.Instance.GetCountBillToDay().ToString();

        }

        private void btnImgFood_Click(object sender, EventArgs e)
        {
            panListHomeStaff.Controls.Clear();
            frmListFood foods = new frmListFood();
            panListHomeStaff.Controls.Add(foods);
            foods.BringToFront();
        }

        private void btnImgTable_Click(object sender, EventArgs e)
        {
            panListHomeStaff.Controls.Clear();
            frmListTable tables = new frmListTable();
            panListHomeStaff.Controls.Add(tables);
            tables.BringToFront();
        }

        private void btnImgRevenue_Click(object sender, EventArgs e)
        {
            panListHomeStaff.Controls.Clear();
            frmListRevenue revenues = new frmListRevenue();
            panListHomeStaff.Controls.Add(revenues);
            revenues.BringToFront();
        }

        private void btnImgBill_Click(object sender, EventArgs e)
        {
            panListHomeStaff.Controls.Clear();
            frmListBill bills = new frmListBill();
            panListHomeStaff.Controls.Add(bills);
            bills.BringToFront();
        }

        

      
    }
}
