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

        
        private void btnFood_Click_1(object sender, EventArgs e)
        {
            frmListFood food = new frmListFood();
            this.panListHome.Controls.Add(food);
            food.BringToFront();
        }

        private void btnTable_Click(object sender, EventArgs e)
        {
            frmListTable table = new frmListTable();
            this.panListHome.Controls.Add(table);
            table.BringToFront();
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            frmListBill food = new frmListBill();
            this.panListHome.Controls.Add(food);
            food.BringToFront();
        }

        private void btnRevenue_Click(object sender, EventArgs e)
        {
            frmListRevenue food = new frmListRevenue();
            this.panListHome.Controls.Add(food);
            food.BringToFront();
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            frmListStaff food = new frmListStaff();
            this.panListHome.Controls.Add(food);
            food.BringToFront();
        }
    }
}
