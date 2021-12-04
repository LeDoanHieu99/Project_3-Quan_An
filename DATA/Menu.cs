using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA
{
    public class Menu
    {
        private string foodName;
        private int quantity;
        private int price;
        private int totalMoney;


        public string FoodName { get => foodName; set => foodName = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public int Price { get => price; set => price = value; }
        public int TotalMoney { get => totalMoney; set => totalMoney = value; }

        public Menu(DataRow row)
        {
            foodName = (string)row["Food Name"];
            quantity = (int)row["Quantity"];
            price = (int)row["Price"];
            totalMoney = (int)row["Total Money"];
        }

    }
}
