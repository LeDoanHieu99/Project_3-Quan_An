using DATA;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BillInfoBLL
    {
        private static BillInfoBLL instance;

        public static BillInfoBLL Instance
        {
            get { if (instance == null) instance = new BillInfoBLL(); return BillInfoBLL.instance; }
            private set { BillInfoBLL.instance = value; }
        }

        private BillInfoBLL() { }

        public List<BillInfo> GetListBillInfo(int id)
        {
            List<BillInfo> listBillInfo = new List<BillInfo>();

            DataTable data = DbConnection.Instance.ExecuteQuery("SELECT * FROM dbo.BillDetails WHERE BillId = " + id);

            foreach (DataRow item in data.Rows)
            {
                BillInfo info = new BillInfo(item);
                listBillInfo.Add(info);
            }

            return listBillInfo;
        }

        public bool InsertBillInfo(int billId, int foodId, int quantity)
        {

            string query = "Insert into BillDetails(BillId,FoodId,Quantity)" +
                " values("
                + billId + "," + foodId + "," + quantity + ")";
            int x = DbConnection.Instance.ExecuteNonQuery(query);
            if (x > 0) return true;
            return false;
        }
    }
}
