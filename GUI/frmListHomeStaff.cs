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
    public partial class frmListHomeStaff : UserControl
    {
        public frmListHomeStaff()
        {
            InitializeComponent();
        }

        private void btnFood_Click(object sender, EventArgs e)
        {
            frmListFood food = new frmListFood();
            this.panListHomeStaff.Controls.Add(food);
            food.BringToFront();
        }

        private void btnTable_Click(object sender, EventArgs e)
        {
            frmListTable food = new frmListTable();
            this.panListHomeStaff.Controls.Add(food);
            food.BringToFront();
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            frmListBill food = new frmListBill();
            this.panListHomeStaff.Controls.Add(food);
            food.BringToFront();
        }

        private void btnRevenue_Click(object sender, EventArgs e)
        {
            frmListRevenue food = new frmListRevenue();
            this.panListHomeStaff.Controls.Add(food);
            food.BringToFront();
        }
    }
}
