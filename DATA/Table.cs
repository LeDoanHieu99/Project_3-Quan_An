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
        private int tableIds;
        private string tableNames;
        private string statuss;
        public Table(DataRow data)
        {
            this.tableIds = (int)data["TableId"];
            this.statuss = (string)data["Status"];
            this.tableNames = (string)data["TableName"];

        }
        public Table(int tableId, string status)
        {
            this.tableIds = tableId;

            this.statuss = status;
        }


        public int TableId { get => tableIds; set => tableIds = value; }
        public string TableName { get => tableNames; set => tableNames = value; }
        public string Status { get => statuss; set => statuss = value; }
        public static bool IsValidateSwitchTable(Table tablemoving, Table tablemovedto)
        {
            string[] liststatus = new String[] { "Empty", "Already someone" };
            if (tablemoving == null || tablemovedto == null)
            {
                return false;
            }
            if (tablemoving.tableIds <= 0 | tablemovedto.tableIds <= 0)
            {
                return false;
            }
            if (Array.IndexOf(liststatus, tablemoving.statuss) == -1)
            {
                return false;
            }
            if (Array.IndexOf(liststatus, tablemovedto.statuss) == -1)
            {
                return false;
            }

            if (tablemoving.statuss == "Empty")
            {
                return false;
            }
            if (tablemoving.tableIds == tablemovedto.tableIds)
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
            if (tablemoving.tableIds <= 0 | tablemovedto.tableIds <= 0)
            {
                return false;
            }
            if (Array.IndexOf(liststatus, tablemoving.statuss) == -1)
            {
                return false;
            }
            if (Array.IndexOf(liststatus, tablemovedto.statuss) == -1)
            {
                return false;
            }

            if (tablemoving.statuss == "Empty")
            {
                return false;
            }
            if (tablemoving.tableIds == tablemovedto.tableIds)
            {

                return false;

            }

            return true;
        }
    }
}
