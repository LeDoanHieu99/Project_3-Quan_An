using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA
{
    public class Table
    {
        private int tableId;
        private string tableName;
        private string status;
        public Table(DataRow data)
        {
            this.TableId = (int)data["TableId"];
            this.Status = (string)data["Status"];
            this.TableName = (string)data["TableName"];

        }
        public Table(int tableId, string status)
        {
            this.tableId = tableId;

            this.status = status;
        }


        public int TableId { get => tableId; set => tableId = value; }
        public string TableName { get => tableName; set => tableName = value; }
        public string Status { get => status; set => status = value; }
        public static bool IsValidateSwitchTable(Table tablemoving, Table tablemovedto)
        {
            string[] liststatus = new String[] { "Empty", "Already someone" };
            if (tablemoving == null || tablemovedto == null)
            {
                return false;
            }
            if (tablemoving.tableId <= 0 | tablemovedto.tableId <= 0)
            {
                return false;
            }
            if (Array.IndexOf(liststatus, tablemoving.status) == -1)
            {
                return false;
            }
            if (Array.IndexOf(liststatus, tablemovedto.status) == -1)
            {
                return false;
            }

            if (tablemoving.status == "Empty")
            {
                return false;
            }
            if (tablemoving.tableId == tablemovedto.tableId)
            {

                return false;

            }

            return true;



        }
        public static bool IsValidateMergeTable(Table tablemoving, Table tablemovedto)
        {
            string[] liststatus = new String[] { "Empty", "Already someone" };
            if (tablemoving == null || tablemovedto == null)
            {
                return false;
            }
            if (tablemoving.tableId <= 0 | tablemovedto.tableId <= 0)
            {
                return false;
            }
            if (Array.IndexOf(liststatus, tablemoving.status) == -1)
            {
                return false;
            }
            if (Array.IndexOf(liststatus, tablemovedto.status) == -1)
            {
                return false;
            }

            if (tablemoving.status == "Empty")
            {
                return false;
            }
            if (tablemoving.tableId == tablemovedto.tableId)
            {

                return false;

            }

            return true;
        }
    }
}
