using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA
{
    public class Bill
    {
        int billId;
        int tableId;
        DateTime checkInDate;
        DateTime checkOutDate;
        string status;
        public Bill(DataRow row)
        {
            billId = (int)row["BillId"];
            tableId = (int)row["TableId"];
            status = (string)row["Status"];
            try
            {
                checkInDate = (DateTime)row["CheckInDate"];
                checkOutDate = (DateTime)row["CheckOutDate"];
            }
            catch
            {

            }


        }

        public int BillId { get => billId; set => billId = value; }
        public int TableId { get => tableId; set => tableId = value; }
        public DateTime CheckInDate { get => checkInDate; set => checkInDate = value; }
        public DateTime CheckOutDate { get => checkOutDate; set => checkOutDate = value; }
        public string Status { get => status; set => status = value; }
    }
}
