using DATA;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class MenuBLL
    {
        private static MenuBLL instance;
        private MenuBLL() { }
        public static MenuBLL Instance
        {
            get
            {
                if (instance == null) instance = new MenuBLL();
                return instance;
            }
        }
        public List<Menu> GetListMenusById(int tableId)
        {
            string query = "USP_GetListMenuByIdTable @tableId";
            List<Menu> menus = new List<Menu>();
            DataTable data = DbConnection.Instance.ExecuteQuery(query, new object[] { tableId });
            foreach (DataRow dataRow in data.Rows)
            {
                Menu menu = new Menu(dataRow);

                menus.Add(menu);

            }
            return menus;
        }
        public DataTable LoadBillByIdTable(int tableId)
        {
            DataTable data = new DataTable();
            string query = "select ta.FoodName as 'Food Name',sum(ct.Quantity) as'Quantity'," +
                "sum(ta.Price) as 'Price',sum(ct.Quantity*ta.Price) as 'Total Money'" +
                " from Food as ta,BillDetails as ct,Bill as hd " +
                "where ta.FoodId=ct.FoodId and ct.BillId=hd.BillId" +
                " and hd.TableId=" + tableId + " and hd.Status='Unpaid'" +
                " group by ta.FoodName";
            data = DbConnection.Instance.ExecuteQuery(query);
            return data;
        }

    }
}


/*
 select ta.FoodName as 'Food Name',ct.Quantity as 'Quantity'," +
                "ta.Price as 'Price',ct.Quantity*ta.Price as 'Total Money'" +
                " from Food as ta,BillDetails as ct,Bill as hd " +
                "where ta.FoodId=ct.FoodId and ct.BillId=hd.BillId" +
                " and hd.TableId=" + tableId + " and hd.Status= 'Unpaid'
     
     */

