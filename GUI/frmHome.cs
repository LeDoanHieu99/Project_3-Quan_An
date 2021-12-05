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
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();          
            btnHome.BackColor = Color.FromArgb(136,232,242);
        }

        private void btnHome_Click(object sender, EventArgs e)
        { 
            btnHome.BackColor = Color.FromArgb(136, 232, 242);

            frmListHome home = new frmListHome();
            this.panMainData.Controls.Add(home);
            home.BringToFront();

            btnFood.BackColor = Color.FromArgb(5,199,242);
            btnTable.BackColor = Color.FromArgb(5, 199, 242);
            btnBill.BackColor = Color.FromArgb(5, 199, 242);
            btnRevenue.BackColor = Color.FromArgb(5, 199, 242);
            btnStaff.BackColor = Color.FromArgb(5, 199, 242);
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
            btnRevenue.BackColor = Color.FromArgb(5, 199, 242);
            btnStaff.BackColor = Color.FromArgb(5, 199, 242);
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
            btnRevenue.BackColor = Color.FromArgb(5, 199, 242);
            btnStaff.BackColor = Color.FromArgb(5, 199, 242);
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            btnBill.BackColor = Color.FromArgb(136, 232, 242);

            frmListBill bill = new frmListBill();
            this.panMainData.Controls.Add(bill);
            bill.BringToFront();

            btnFood.BackColor = Color.FromArgb(5, 199, 242);
            btnTable.BackColor = Color.FromArgb(5, 199, 242);
            btnHome.BackColor = Color.FromArgb(5, 199, 242);
            btnRevenue.BackColor = Color.FromArgb(5, 199, 242);
            btnStaff.BackColor = Color.FromArgb(5, 199, 242);
        }

        private void btnRevenue_Click(object sender, EventArgs e)
        {
            btnRevenue.BackColor = Color.FromArgb(136, 232, 242);

            frmListRevenue revenue = new frmListRevenue();
            this.panMainData.Controls.Add(revenue);
            revenue.BringToFront();

            btnFood.BackColor = Color.FromArgb(5, 199, 242);
            btnTable.BackColor = Color.FromArgb(5, 199, 242);
            btnBill.BackColor = Color.FromArgb(5, 199, 242);
            btnHome.BackColor = Color.FromArgb(5, 199, 242);
            btnStaff.BackColor = Color.FromArgb(5, 199, 242);
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            btnStaff.BackColor = Color.FromArgb(136, 232, 242);

            frmListStaff staff = new frmListStaff();
            this.panMainData.Controls.Add(staff);
            staff.BringToFront();

            btnFood.BackColor = Color.FromArgb(5, 199, 242);
            btnTable.BackColor = Color.FromArgb(5, 199, 242);
            btnBill.BackColor = Color.FromArgb(5, 199, 242);
            btnHome.BackColor = Color.FromArgb(5, 199, 242);
            btnHome.BackColor = Color.FromArgb(5, 199, 242);
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();            
        }

        private void panMainData_Paint(object sender, PaintEventArgs e)
        {
            //frmListHome home = new frmListHome();
            //this.panMainData.Controls.Add(home);
           // home.BringToFront();
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            frmListHome home = new frmListHome();
            this.panMainData.Controls.Add(home);
            home.BringToFront();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmLogin().ShowDialog();
            this.Close();
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
