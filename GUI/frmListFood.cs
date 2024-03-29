﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BLL;

namespace GUI
{
    public partial class frmListFood : UserControl
    {
        public frmListFood()
        {
            InitializeComponent();
        }

        void Display( DataGridView ojb)
        {
            ojb.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ojb.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;
            for (int i = 0; i < ojb.Rows.Count; i++)
            {
                if (i % 2 == 0)
                {
                    ojb.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(179, 213, 242);
                    ojb.Rows[i].DefaultCellStyle.SelectionBackColor = Color.FromArgb(179, 213, 242);
                }
                else
                {
                    ojb.Rows[i].DefaultCellStyle.BackColor = Color.White;
                    ojb.Rows[i].DefaultCellStyle.SelectionBackColor = Color.White;
                }
            }           
        }

        private void cboSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboSelect.SelectedIndex == 0)
            {
                this.dtgvFood.DataSource = FoodCategoryBILL.Instance.LoadFoodCategory();
                Display(dtgvFood);
            }
            else
            {
                this.dtgvFood.DataSource = FoodBILL.Instance.LoadFood();
                Display(dtgvFood);
            }
        }

        private void dtgvFood_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (cboSelect.SelectedIndex == 1 && e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgvFood.Rows[e.RowIndex];
                txtFoodId.Text = row.Cells[0].Value.ToString();
                txtFoodName.Text = row.Cells[1].Value.ToString();
                txtPrice.Text = row.Cells[2].Value.ToString();
                txtFoodTypeID.Text = row.Cells[3].Value.ToString();
                txtFoodTypeName.Text = row.Cells[4].Value.ToString();
                
                //txtFoodId.Text = dtgvFood.Rows[e.RowIndex].Cells[1].Value.ToString();
               // txtFoodName.Text = dtgvFood.Rows[e.RowIndex].Cells[1].Value.ToString();
                
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddFood f = new frmAddFood();
            f.ShowDialog();
            this.dtgvFood.DataSource = FoodBILL.Instance.LoadFood();
            Display(dtgvFood);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtFoodId.Text == "" || txtFoodName.Text == "" || txtPrice.Text == "" || txtFoodTypeID.Text == "")
            {
                MessageBox.Show("Please enter full information !!");
            }
            else
            {
                try
                {
                    int foodId = Convert.ToInt32(txtFoodId.Text);
                    string foodName = txtFoodName.Text;
                    int price = Convert.ToInt32(txtPrice.Text);
                    int categoryId = Convert.ToInt32(txtFoodId.Text);
                    if (FoodBILL.Instance.UpdateFood(foodId, foodName, price, categoryId) == true)
                    {
                        MessageBox.Show("Update successful !!");
                        dtgvFood.DataSource = FoodBILL.Instance.LoadFood();
                    }
                    else
                    {
                        MessageBox.Show("The dish code does not exist !!");
                    }
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Invalid information !!");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("The dish code cannot match !!");
                }
            }
            this.dtgvFood.DataSource = FoodBILL.Instance.LoadFood();
            Display(dtgvFood);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (txtFoodId.Text == "")
            {
                MessageBox.Show("Information cannot be left blank !!");
            }
            else
            {
                try
                {
                    int foodId = Convert.ToInt32(txtFoodId.Text);
                    if (FoodBILL.Instance.DeleteFood(foodId) == true)
                    {
                        MessageBox.Show("Delete the dish successfully !!");
                        this.dtgvFood.DataSource = FoodBILL.Instance.LoadFood();
                        Display(dtgvFood);
                        //Khi xóa xong các textbox trở thành rỗng
                        txtFoodId.Text = "";
                        txtFoodName.Text = "";
                        txtPrice.Text = "";
                        txtFoodTypeID.Text = "";
                        txtFoodTypeName.Text = "";
                        
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Can't delete this dish because the item code is existing invoice details !!");
                }

            }
        }

        /* private void btnSearch_Click(object sender, EventArgs e)
         {
             string f = txtSearch.Text;
             DataTable data = FoodBILL.Instance.SearchFoodByName(f);           
             if (data.Rows.Count == 0)
             {
                 MessageBox.Show("Không có món ăn cần tìm kiếm");
             }
             else
             {
                 dtgvFood.DataSource = data;

             }
            // txtSearch.Text = "";
         }*/

        private void bunifuThinButton21_search_Click(object sender, EventArgs e)
        {
            string m = txt_SearchFood.text;
            DataTable data = FoodBILL.Instance.SearchFoodByName(m);
            if (data.Rows.Count == 0 || txt_SearchFood.text == "")
            {
                MessageBox.Show("No dishes to look for !!");
            }
            else
            {
                dtgvFood.DataSource = data;
                dtgvFood.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            txt_SearchFood.Text = "";
        }
    }
}

