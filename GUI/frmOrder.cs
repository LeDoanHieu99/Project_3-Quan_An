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

namespace GUI
{
    public partial class frmOrder : Form
    {
        private int TableId = 0;
        public frmOrder()
        {
            InitializeComponent();
        }

        public frmOrder(int tableId, string tableName)
        {
            InitializeComponent();
            this.TableId = tableId;
            txtTableName.Text = tableName;

            LoadDanhMuc();
        }

        public void LoadDanhMuc()
        {
            List<FoodCategoryData> categories = FoodCategoryBILL.Instance.GetListFoodCategories();
            cboCategory.DataSource = categories;
            cboCategory.DisplayMember = "TypeName";
        }
    }
}
