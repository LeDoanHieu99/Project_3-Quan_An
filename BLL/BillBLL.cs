using DATA;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BillBLL
    {
        private static BillBLL instance;

        public static BillBLL Instance
        {
            get { if (instance == null) instance = new BillBLL(); return BillBLL.instance; }
            private set { BillBLL.instance = value; }
        }

        private BillBLL() { }

        public int GetIdBillByCheckStatusTable(int tableId)
        {
            DataTable data = DbConnection.Instance.ExecuteQuery(
                "SELECT * FROM Bill " +
                "WHERE TableId = " + tableId + " AND Status = 'Unpaid'");


            if (data.Rows.Count > 0)
            {
                Bill bill = new Bill(data.Rows[0]);
                return bill.BillId;
            }

            return -1;
        }
        public DataRow GetInforBillByIdTable(int tableId)
        {
            DataTable data = DbConnection.Instance.ExecuteQuery("SELECT * FROM Bill " +
               "WHERE TableId = " + tableId + " AND Status ='Unpaid'");
            if (data.Rows.Count > 0)
            {
                return data.Rows[0];
            }
            return null;
        }
        public bool InsertBill(int tableId)
        {
            string query = "insert into Bill(TableId)"
                         + "values (" + tableId + ")";
            int x = DbConnection.Instance.ExecuteNonQuery(query);
            if (x > 0) return true;
            return false;
        }

        public int GetMaxIDBill()
        {
            try
            {
                return (int)DbConnection.Instance.ExecuteScalar("SELECT MAX(BillId) FROM Bill");
            }
            catch
            {
                return 1;
            }
        }
        public bool Checkout(int billId)
        {
            string query = "Update Bill set Status='Paid'"
                + "where BillId=" + billId;

            int x = DbConnection.Instance.ExecuteNonQuery(query);
            if (x > 0) return true;//Đã thanh toán
            return false;


        }
        public bool UpdateBill(int billId, DateTime datePayment, int total)
        {
            string query = "Update Bill set DatePayment='" + datePayment
                + "',Total=" + total
                + " where BillId=" + billId;
            int x = DbConnection.Instance.ExecuteNonQuery(query);
            if (x > 0) return true; //Update Bill thanh cong
            return false; //Update that bai
        }
        public bool IsExistBill(int tableId)
        {
            string query = "select count(DatePayment) "
                          + "from Bill "
                           + "where TableId =" + tableId
                    + " and Status='Unpaid'";

            int x = DbConnection.Instance.ExecuteScalar(query);
            if (x > 0) return true; //Hoá đơn đã được lưu
            return false;   //Hoá đơn chưa được lưu
        }
        public DataTable GetBillByDate(string date)
        {
            DataTable data = new DataTable();
            string query = "select BillId as 'Bill Id'," +
                "TableId as 'Table Id',Status as 'Status'," +
                "Total as 'Total Money'" +
                " from Bill where DatePayment='" +
               date + "'";
            data = DbConnection.Instance.ExecuteQuery(query);
            return data;

        }
        public DataTable GetListHistoryMenusById(int billId)
        {
            string query = "select ta.FoodName as 'Food Name',sum(ct.Quantity) as 'Quantity'," +
                "sum(ta.Price) as 'Price',sum(ct.Quantity*ta.Price) as 'Total Money'" +
                " from Food as ta,BillDetails as ct,Bill as hd " +
                "where ta.FoodId=ct.FoodId and ct.BillId=hd.BillId" +
                " and hd.BillId=" + billId + " Group by ta.FoodName";

            DataTable data = DbConnection.Instance.ExecuteQuery(query);

            return data;
        }
        public DataTable SearchBillByIdTable(int tableId)
        {
            DataTable data = new DataTable();
            string query = "Select BillId as 'Bill Id'," +
                "TableId as 'Table Id',Status as 'Status'," +
                "Total as 'Total Money' " +
                "from Bill where TableId= " + tableId + " and Status='Paid'";
            data = DbConnection.Instance.ExecuteQuery(query);
            return data;

        }
        public int GetCountBillToDay()
        {
            string query = "select count(BillId) from Bill where DateOrder='" +
                DateTime.Now.ToShortDateString() + "'";
            int count = DbConnection.Instance.ExecuteScalar(query);
            return count;
        }
        public void UpdateDayOrder(int billId)
        {
            string query = "Update Bill set DateOrder='" +
                DateTime.Now.ToShortDateString() +
                "' where BillId=" + billId;
            DbConnection.Instance.ExecuteNonQuery(query);

        }
    }
}
