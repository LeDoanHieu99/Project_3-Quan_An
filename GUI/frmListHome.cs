using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmListHome : UserControl
    {
        public frmListHome()
        {
            InitializeComponent();
        }

        private void btnImgFood_Click(object sender, EventArgs e)
        {
            frmListFood foods = new frmListFood();
            this.panListHome.Controls.Add(foods);
            foods.BringToFront();
        }

        private void btnImgTable_Click(object sender, EventArgs e)
        {
            frmListTable tables = new frmListTable();
            this.panListHome.Controls.Add(tables);
            tables.BringToFront();
        }

        private void btnImgBill_Click(object sender, EventArgs e)
        {
            frmListBill bills = new frmListBill();
            this.panListHome.Controls.Add(bills);
            bills.BringToFront();
        }

        private void btnImgRevenue_Click(object sender, EventArgs e)
        {
            frmListRevenue revenues = new frmListRevenue();
            this.panListHome.Controls.Add(revenues);
            revenues.BringToFront();
        }

        private void btnImgStaff_Click(object sender, EventArgs e)
        {
            frmListStaff staffs = new frmListStaff();
            this.panListHome.Controls.Add(staffs);
            staffs.BringToFront();
        }


        

    }
}
