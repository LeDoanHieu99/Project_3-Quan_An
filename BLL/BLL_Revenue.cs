using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BLL
{
    public class BLL_Revenue
    {
        private static BLL_Revenue instance;
        public static BLL_Revenue Instance
        {
            get { if (instance == null) instance = new BLL_Revenue(); return BLL_Revenue.instance; }
            private set { BLL_Revenue.instance = value; }
        }

        private BLL_Revenue()
        {

        }

        public DataTable LoadRevenue_ByDay(string fromDate, string toDate, int selectRows, int exceptRows)
        {
            string query = ";with RevenueShow as (SELECT TOP 100 PERCENT DAY(DatePayment) as 'Day', MONTH(DatePayment) as 'Month', YEAR(DatePayment) as 'Year', "
                                + "sum(Total) as N'Total Money' from Bill where Total > 0 "
                                + "AND DatePayment >= '" + fromDate + "' AND DatePayment <= '" + toDate + "' "
                                + "group by DAY(DatePayment), MONTH(DatePayment), YEAR(DatePayment) "
                                + "order by DAY(DatePayment), MONTH(DatePayment), YEAR(DatePayment) asc) "
                                + "select top " + selectRows + " * from RevenueShow except select top " + exceptRows + " * from RevenueShow;";
            DataTable data = new DataTable();
            data = DbConnection.Instance.ExecuteQuery(query);
            return data;
        }
        public DataTable LoadRevenue_ByMonth(string fromDate, string toDate, int selectRows, int exceptRows)
        {
            string query = ";with RevenueShow as (SELECT TOP 100 PERCENT MONTH(DatePayment) as 'Month', YEAR(DatePayment) as 'Year', "
                                + "sum(Total) as N'Total Money' from Bill where Total > 0 "
                                + "AND MONTH(DatePayment) >= '" + fromDate + "' AND MONTH(DatePayment) <= '" + toDate + "' "
                                + "group by MONTH(DatePayment), YEAR(DatePayment) "
                                + "order by MONTH(DatePayment), YEAR(DatePayment) asc) "
                                + "select top " + selectRows + " * from RevenueShow except select top " + exceptRows + " * from RevenueShow;";
            DataTable data = new DataTable();
            data = DbConnection.Instance.ExecuteQuery(query);
            return data;
        }
        public DataTable LoadRevenue_ByYear(string fromDate, string toDate, int selectRows, int exceptRows)
        {
            string query = ";with RevenueShow as (SELECT TOP 100 PERCENT YEAR(DatePayment) as 'Year', "
                                 + "sum(Total) as 'Total Money' from Bill where Total > 0 "
                                 + "AND YEAR(DatePayment) >= '" + fromDate + "' AND YEAR(DatePayment) <= '" + toDate + "' "
                                 + "group by YEAR(DatePayment) "
                                 + "order by YEAR(DatePayment) asc) "
                                 + "select top " + selectRows + " * from RevenueShow except select top " + exceptRows + " * from RevenueShow;";
            DataTable data = new DataTable();
            data = DbConnection.Instance.ExecuteQuery(query);
            return data;
        }
        public int GetNumBillList_ByDay(string fromDate, string toDate)
        {
            string query = ";with RevenueShow as (SELECT TOP 100 PERCENT DAY(DatePayment) as 'Day', MONTH(DatePayment) as 'Month', YEAR(DatePayment) as 'Year', "
                                + "sum(Total) as 'Total Money' from Bill where Total > 0 "
                                + "AND DatePayment >= '" + fromDate + "' AND DatePayment <= '" + toDate + "' "
                                + "group by DAY(DatePayment), MONTH(DatePayment), YEAR(DatePayment) "
                                + "order by DAY(DatePayment), MONTH(DatePayment), YEAR(DatePayment) asc) "
                                + "select count(*) from RevenueShow;";
            int x = DbConnection.Instance.ExecuteScalar(query);
            return x;
        }
        public int GetNumBillList_ByMonth(string fromDate, string toDate)
        {
            string query = ";with RevenueShow as (SELECT TOP 100 PERCENT MONTH(DatePayment) as 'Month', YEAR(DatePayment) as 'Year', "
                                 + "sum(Total) as 'Total Money' from Bill where Total > 0 "
                                 + "AND MONTH(DatePayment) >= '" + fromDate + "' AND MONTH(DatePayment) <= '" + toDate + "' "
                                 + "group by MONTH(DatePayment), YEAR(DatePayment) "
                                 + "order by MONTH(DatePayment), YEAR(DatePayment) asc) "
                                 + "select count(*) from RevenueShow;";
            int x = DbConnection.Instance.ExecuteScalar(query);
            return x;
        }
        public int GetNumBillList_ByYear(string fromDate, string toDate)
        {
            string query = ";with RevenueShow as (SELECT TOP 100 PERCENT YEAR(DatePayment) as 'Year', "
                                 + "sum(Total) as 'Total Money' from Bill where Total > 0 "
                                 + "AND YEAR(DatePayment) >= '" + fromDate + "' AND YEAR(DatePayment) <= '" + toDate + "' "
                                 + "group by YEAR(DatePayment) "
                                 + "order by YEAR(DatePayment) asc) "
                                 + "select count(*) from RevenueShow;";
            int x = DbConnection.Instance.ExecuteScalar(query);
            return x;
        }
        public int GetRevenueToDay()
        {
            string query = "select SUM(Total) from Bill where DatePayment='" +
                 DateTime.Now.ToShortDateString() + "'";
            int revenue = DbConnection.Instance.ExecuteScalar(query);
            return revenue;
        }
    }
}
