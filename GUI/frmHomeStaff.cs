using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmHomeStaff : Form
    {
        public frmHomeStaff()
        {
            InitializeComponent();          
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            btnHome.BackColor = Color.FromArgb(136, 232, 242);

            frmListHomeStaff home = new frmListHomeStaff();
            this.panMainData.Controls.Add(home);
            home.BringToFront();

            btnFood.BackColor = Color.FromArgb(5, 199, 242);
            btnTable.BackColor = Color.FromArgb(5, 199, 242);
            btnBill.BackColor = Color.FromArgb(5, 199, 242);         
        }

        private void btnTable_Click(object sender, EventArgs e)
        {
            btnTable.BackColor = Color.FromArgb(136, 232, 242);

            frmListTable table = new frmListTable();
            this.panMainData.Controls.Add(table);
            table.BringToFront();

            btnFood.BackColor = Color.FromArgb(5, 199, 242);
            btnHome.BackColor = Color.FromArgb(5, 199, 242);
            btnBill.BackColor = Color.FromArgb(5, 199, 242);
        }

        private void btnFood_Click(object sender, EventArgs e)
        {
            btnFood.BackColor = Color.FromArgb(136, 232, 242);

            frmListFood food = new frmListFood();
            this.panMainData.Controls.Add(food);
            food.BringToFront();

            btnHome.BackColor = Color.FromArgb(5, 199, 242);
            btnTable.BackColor = Color.FromArgb(5, 199, 242);
            btnBill.BackColor = Color.FromArgb(5, 199, 242);
        }

        private void BtnBill_Click(object sender, EventArgs e)
        {
            btnBill.BackColor = Color.FromArgb(136, 232, 242);

            frmListBill bill = new frmListBill();
            this.panMainData.Controls.Add(bill);
            bill.BringToFront();

            btnFood.BackColor = Color.FromArgb(5, 199, 242);
            btnTable.BackColor = Color.FromArgb(5, 199, 242);
            btnHome.BackColor = Color.FromArgb(5, 199, 242);
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            new frmLogin().Show();
        }
    }
}
