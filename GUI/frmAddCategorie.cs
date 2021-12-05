using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using System.Data.SqlClient;

namespace GUI
{
    public partial class frmAddCategorie : Form
    {
        public frmAddCategorie()
        {
            InitializeComponent();
        }

        private void frmAddCategorie_Load(object sender, EventArgs e)
        {

        }

        private void btnAddCategorie_Click(object sender, EventArgs e)
        {
            if (txtTypeName.Text == "")
            {
                MessageBox.Show("Please enter information !!");
                return;
            }
            try
            {
                string name = txtTypeName.Text;
                if (FoodCategoryBILL.Instance.InsertFoodCategory(name) == true)
                {
                    MessageBox.Show("Successfully");
                    Close();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Already Exist");
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Format Error");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        /*
private void btnAddCategorie_Click(object sender, EventArgs e)
{
if (txtTypeName.Text == "" )
{
MessageBox.Show("Vui lòng nhập thông tin");
return;
}
try
{
string name = txtTypeName.Text;
if (FoodCategoryBILL.Instance.InsertFoodCategory(name) == true)
{
  MessageBox.Show("Accept");
  Close();
}
}
catch(SqlException ex)
{
MessageBox.Show("Already Exist");
}
catch (FormatException ex)
{
MessageBox.Show("Format Error");
}
}

private void btnCancel_Click(object sender, EventArgs e)
{
Close();
}*/


    }
}
