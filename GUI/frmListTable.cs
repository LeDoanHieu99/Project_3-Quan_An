using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DATA;
using BLL;
using Menu = DATA.Menu;

namespace GUI
{
    public partial class frmListTable : UserControl
    {
        public frmListTable()
        {
            InitializeComponent();
            LoadTable();
            LoadComboboxTableName();
        }

        private void btnNewTable_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure want more tables ?", "Warning", MessageBoxButtons.YesNo);
            if(dialogResult == DialogResult.Yes)
            {
                TableBLL.Instance.AddTable();
                LoadTable();
                LoadComboboxTableName();
            }
        }

        public void LoadTable()
        {
            this.flowLayoutPanel1.Controls.Clear();
            List<Table> tabeList = TableBLL.Instance.GetListTable();
            foreach (Table table in tabeList)
            {
                Button btn = new Button() { Width = 100, Height = 100 };
                btn.Text = table.TableName + "\n" + table.Status;
                btn.Tag = table;
                
                btn.Click += btn_Click;
                btn.Leave += btn_Leave;
                this.flowLayoutPanel1.Controls.Add(btn);

                if (table.Status == "Empty")
                    btn.BackColor = Color.Lavender;
                else
                {
                    btn.BackColor = Color.Red;
                }

            }
        }

        private void btn_Click(object sender, EventArgs e) //xem lai cho nay 
        {

            int TableId = ((Table)(sender as Button).Tag).TableId;
            dtgvFoodbyId.Tag = (sender as Button).Tag;
            LoadBill(TableId);
            Button btn = sender as Button;
            btn.BackColor = Color.LightYellow;
        }

        private void btn_Leave(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            Table table = btn.Tag as Table;
            if (table.Status == "Empty")
                btn.BackColor = Color.Lavender;
            else
            {
                btn.BackColor = Color.Red;
            }
        }

        public void LoadComboboxTableName()
        {
            cbbSwichTable.DataSource = TableBLL.Instance.GetListTable();
            cbbSwichTable.DisplayMember = "TableName";
            cbbMergeTable.DataSource = TableBLL.Instance.GetListTable();
            cbbMergeTable.DisplayMember = "TableName";
        }

        public void LoadBill(int TableId)
        {
            List<Menu> menus = MenuBLL.Instance.GetListMenusById(TableId);
            dtgvFoodbyId.DataSource = MenuBLL.Instance.LoadBillByIdTable(TableId);
            dtgvFoodbyId.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvFoodbyId.RowHeadersVisible = false;
            for (int i = 0; i < dtgvFoodbyId.Rows.Count; i++)
            {
                if (i % 2 == 0)
                {
                    dtgvFoodbyId.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(179, 213, 242);
                    dtgvFoodbyId.Rows[i].DefaultCellStyle.SelectionBackColor = Color.FromArgb(179, 213, 242);
                }
                else
                {
                    dtgvFoodbyId.Rows[i].DefaultCellStyle.BackColor = Color.White;
                    dtgvFoodbyId.Rows[i].DefaultCellStyle.SelectionBackColor = Color.White;
                }
            }

            int totalMoney = 0;
            foreach (var i in menus)
            {
                totalMoney += i.TotalMoney;
            }
            txtTotal.Text = totalMoney.ToString();

        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (dtgvFoodbyId.Tag != null)
            {
                int tableId = (dtgvFoodbyId.Tag as Table).TableId;
                string tableName = (dtgvFoodbyId.Tag as Table).TableName;

                frmOrder f = new frmOrder(tableId, tableName);
                f.ShowDialog();
                LoadTable();
                LoadBill(tableId);
                this.Show();
            }
            else
            {
                MessageBox.Show("Please select a table before ordering !!");
            }
        }

        private void btnPayMonney_Click(object sender, EventArgs e)
        {
            Table table = (dtgvFoodbyId.Tag as Table);
            if (table == null)
            {
                MessageBox.Show("Please select a table to pay !!");
            }
            else
            {
                int billId = BillBLL.Instance.GetIdBillByCheckStatusTable(table.TableId);
                if (billId == -1)
                {
                    MessageBox.Show("This table has no dishes !!");
                }
                if (billId != -1)
                {

                    this.Hide();
                    frmBill f = new frmBill(table.TableId);
                    f.ShowDialog();

                    LoadTable();
                    LoadBill(table.TableId);
                    this.Show();
                }
            }
        }

        private void btnMergeTable_Click(object sender, EventArgs e)
        {
            Table table1 = dtgvFoodbyId.Tag as Table;
            Table table2 = cbbMergeTable.SelectedItem as Table;
            if (table1 != null)
            {
                if (table1.Status == "Empty")
                {
                    MessageBox.Show(table1.TableName + " Is empty, cannot be merged");

                }

                else if (table1.TableId == table2.TableId)
                {
                    MessageBox.Show("You are at the current table");
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Do you want to merge from table " +
                   table1.TableId + " to table " +
                   table2.TableId
                   , "Warning", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        TableBLL.Instance.MergeTable(table1.TableId, table2.TableId);
                        LoadTable();
                    }
                }
            }
            else
            {
                MessageBox.Show("You have not selected a table yet");
            }
        }

        private void btnSwichTable_Click(object sender, EventArgs e)
        {
            Table table1 = dtgvFoodbyId.Tag as Table;
            Table table2 = (cbbSwichTable.SelectedItem as Table);
            if (table1 != null)
            {
                if (table1.Status == "Empty")
                {
                    MessageBox.Show("This table is currently empty");
                }
                else if (table1.TableId != table2.TableId)
                {
                    DialogResult dialogResult = MessageBox.Show("Do you want to switch from the table " +
                    table1.TableId + " to table " +
                    table2.TableId
                    , "Warning", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        TableBLL.Instance.SwitchTable(table1.TableId, table2.TableId);
                        LoadTable();
                    }
                    //LoadTable();
                }

                else
                {
                    MessageBox.Show("You are at the current table");
                    return;
                }
            }
            else
            {
                MessageBox.Show("You have not selected a table yet");
            }
        }
    }
}
