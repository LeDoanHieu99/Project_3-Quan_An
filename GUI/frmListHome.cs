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
    public partial class frmListHome : UserControl
    {
        public frmListHome()
        {
            InitializeComponent();
        }
        private void frmListHome_Load(object sender, EventArgs e)
        {
            DateTime today = DateTime.Now;
            labelTime.Text = today.ToString("F");

            int RevenueToday = BLL_Revenue.Instance.GetRevenueToDay();
            lblRevenueToday.Text = string.Format("{0:n0}", RevenueToday);

            lblCountOrder.Text = BillBLL.Instance.GetCountBillToDay().ToString();

        }

        private void btnImgFood_Click(object sender, EventArgs e)
        {
            panListHome.Controls.Clear();
            frmListFood foods = new frmListFood();
            panListHome.Controls.Add(foods);
            foods.BringToFront();
        }

        private void btnImgTable_Click(object sender, EventArgs e)
        {
            panListHome.Controls.Clear();
            frmListTable tables = new frmListTable();
            panListHome.Controls.Add(tables);
            tables.BringToFront();
        }

        private void btnImgBill_Click(object sender, EventArgs e)
        {
            panListHome.Controls.Clear();
            frmListBill bills = new frmListBill();
            panListHome.Controls.Add(bills);
            bills.BringToFront();
        }

        private void btnImgRevenue_Click(object sender, EventArgs e)
        {
            panListHome.Controls.Clear();
            frmListRevenue revenues = new frmListRevenue();
            panListHome.Controls.Add(revenues);
            revenues.BringToFront();
        }

        private void btnImgStaff_Click(object sender, EventArgs e)
        {
            panListHome.Controls.Clear();
            frmListStaff staffs = new frmListStaff();
            panListHome.Controls.Add(staffs);
            staffs.BringToFront();
        }       
    }
}
