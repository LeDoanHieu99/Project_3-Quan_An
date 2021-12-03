using BLL;
using DATA;
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
using DATA;

namespace GUI
{
    public partial class frmOrder : Form
    {

        int tableId = 0;
        public frmOrder()
        {
            InitializeComponent();
        }

        public frmOrder(int tableID, string tablename)
        {
            InitializeComponent();
            this.tableId = tableID;
            txtTableId.Text = tablename;

            LoadFoodCategory();
        }
        void LoadFoodCategory()
        {
            List<FoodCategoryData> categories = FoodCategoryBILL.Instance.GetListFoodCategories();
            cboCategory.DataSource = categories;
            cboCategory.DisplayMember = "TypeName";           
        }

        void LoadFoodListByCategoryID(int id)
        {
            List<FoodData> listFood = FoodBILL.Instance.GetFoodByCategoryID(id);
            if (listFood.Count == 0)
            {
                MessageBox.Show("Loại này chưa có món");
                cboCategory.SelectedIndex = 0;
                LoadFoodListByCategoryID(1);
            }
            else
            {
                cboFood.DataSource = listFood;
                cboFood.DisplayMember = "foodNames";
            }
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            int foodId = (cboFood.SelectedItem as FoodData).foodIds;
            int billId = BillBLL.Instance.GetIdBillByCheckStatusTable(tableId);
            TableBLL.Instance.UpdateStatusById(tableId);

            int number = (int)numQuantity.Value;
            if (number <= 0)
            {
                MessageBox.Show("Số lượng món tối thiểu là 1");
                return;
            }
            //Khi bàn chưa có hoá đơn
            if (billId == -1)
            {
                BillBLL.Instance.InsertBill(tableId);
                //  Tạo hoá đơn mới cho bàn
                billId = BillBLL.Instance.GetMaxIDBill();
                BillBLL.Instance.UpdateDayOrder(billId);
                if (BillInfoBLL.Instance.InsertBillInfo(billId, foodId, number) == true)
                {
                    MessageBox.Show("successfully");
                }


            }
            //Khi bàn đã có hoá đơn
            else
            {
                if (BillInfoBLL.Instance.InsertBillInfo(billId, foodId, number) == true)
                {

                    MessageBox.Show("successfully");
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmOrder_Load(object sender, EventArgs e)
        {
            LoadFoodCategory();
        }

        private void cboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            FoodCategoryData category = cboCategory.SelectedItem as FoodCategoryData;
            string TypeName = category.TypeName;
            int categoryId = FoodCategoryBILL.Instance.GetIdByNameFoodCategory(TypeName);

            LoadFoodListByCategoryID(categoryId);
        }

        private void cboFood_SelectedIndexChanged(object sender, EventArgs e)
        {
            FoodData food = cboFood.SelectedItem as FoodData;
            int Prices = food.prices;
            txtOrderPrice.Text = Prices.ToString();
        }
    }
}
