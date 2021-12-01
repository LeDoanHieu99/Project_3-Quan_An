using DATA;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class TableBLL
    {
        private static TableBLL instance;
        public static TableBLL Instance
        {
            get
            {
                if (instance == null) instance = new TableBLL();
                return instance;
            }
        }
        public List<Table> GetListTable()
        {
            DataTable data = DbConnection.Instance.ExecuteQuery("Select *from ReserveTable");
            List<Table> TableList = new List<Table>();

            for (int i = 0; i < data.Rows.Count; i++)
            {
                Table table = new Table(data.Rows[i]);
                TableList.Add(table);
            }
            return TableList;
        }
        public List<Table> GetListTableById(int id)
        {
            DataTable data = DbConnection.Instance.ExecuteQuery
                ("Select *from ReserveTable where TableId=" + id);
            List<Table> TableList = new List<Table>();

            for (int i = 0; i < data.Rows.Count; i++)
            {
                Table table = new Table(data.Rows[i]);
                TableList.Add(table);
            }
            return TableList;

        }
        public void UpdateStatusById(int tableId)
        {
            string query = "Update ReserveTable set Status='Already someone' "
                + "where TableId=" + tableId;
            DbConnection.Instance.ExecuteNonQuery(query);

        }
        public void ResetStatusById(int tableId)
        {
            string query = "Update ReserveTable set Status='Empty' "
                + "where TableId=" + tableId;
            DbConnection.Instance.ExecuteNonQuery(query);
        }
        public void SwitchTable(int tableId1, int tableId2)
        {
            string query = "USP_SwitchTable @tableId1 , @tableId2";
            DbConnection.Instance.ExecuteNonQuery(query, new object[] { tableId1, tableId2 });
        }
        public void MergeTable(int tableId1, int tableId2)
        {
            string query = "USP_MergeTable @tableId1 , @tableId2";
            DbConnection.Instance.ExecuteNonQuery(query, new object[] { tableId1, tableId2 });
        }
        public int GetMaxIdTable()
        {
            string query = "select max(TableId) from ReserveTable";
            int x = DbConnection.Instance.ExecuteScalar(query);
            return x;
        }
        public void AddTable()
        {
            int tableId = TableBLL.Instance.GetMaxIdTable() + 1;
            string query = "Insert into ReserveTable(TableId,TableName) " +
                "values(" + tableId + ",'Table " + tableId + "')";
            DbConnection.Instance.ExecuteNonQuery(query);
        }
    }
}
