    using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BLL;
using DATA;

namespace GUI
{
    public partial class frmAddFood : Form
    {
        public frmAddFood()
        {
            InitializeComponent();
        }
        void LoadFoodCategory()
        {
            List<FoodCategoryData> categories = FoodCategoryBILL.Instance.GetListFoodCategories();
            cboCategory.DataSource = categories;
            cboCategory.DisplayMember = "TypeName";
           // this.cboCategory.DataSource = FoodCategoryBILL.Instance.LoadFoodCategory();
            //cboCategory.DisplayMember = "FoodTypeName";
        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            if (txtFoodName.Text == "" || txtFoodPrice.Text == "" || cboCategory.SelectedItem == null)
            {
                MessageBox.Show("Please enter full information !!");
                return;
            }
            try
            {

                string name = txtFoodName.Text;
                int price = Convert.ToInt32(txtFoodPrice.Text);

                FoodCategoryData category = cboCategory.SelectedItem as FoodCategoryData;
                string TypeName = category.TypeName;
                int categoryId = FoodCategoryBILL.Instance.GetIdByNameFoodCategory(TypeName);

                if (FoodBILL.Instance.InsertFood(name, price, categoryId) == true)
                {
                    MessageBox.Show("Add successful dishes !!");                   
                    txtFoodName.Text = "";
                    txtFoodPrice.Text = "";                
                    cboCategory.Text = "";
                    txtFoodName.Focus();

                }
            }
            catch (SqlException ex)
            {
                switch (ex.Number)
                {
                    case 2627: //Mã lỗi này show ra vi phạm khoá chính
                        MessageBox.Show("The dish code already exists or the dish name is duplicated !!");
                        break;
                    case 547:
                        MessageBox.Show("Type code does not exist !!");
                        break;
                    default:
                        throw;
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Format error !!");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddFood_Load(object sender, EventArgs e)
        {
            LoadFoodCategory();
        }

        private void btnAddCategorie_Click(object sender, EventArgs e)
        {
            frmAddCategorie frmAddCategorie = new frmAddCategorie();
            frmAddCategorie.ShowDialog();
            LoadFoodCategory();

           // txtFoodID.Text = (FoodDAO.Instance.GetMaxIdFood() + 1).ToString();
        }
    }
}
