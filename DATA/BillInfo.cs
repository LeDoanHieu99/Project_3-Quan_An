using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA
{
    public class BillInfo
    {
        int billDetailsId;
        int billId;
        int foodId;
        int quantity;
        public BillInfo(DataRow row)
        {
            billDetailsId = (int)row["BillDetailsId"];
            billId = (int)row["BillId"];
            foodId = (int)row["FoodId"];
            quantity = (int)row["Quantity"];
        }
        public int BillDetailsId { get => billDetailsId; set => billDetailsId = value; }
        public int BillId { get => billId; set => billId = value; }
        public int FoodId { get => foodId; set => foodId = value; }
        public int Quantity { get => quantity; set => quantity = value; }
    }
}
