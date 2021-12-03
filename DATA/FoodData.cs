using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DATA
{
    public class FoodData
    {
        private int foodId;
        private int price;
        private int categorieId;
        private string foodName;

        public FoodData(string foodId, string price, string categorieId, string foodName)
        {
            try
            {
                this.foodId = Convert.ToInt32(foodId);
                this.categorieId = Convert.ToInt32(categorieId);
                this.price = Convert.ToInt32(price);
                this.foodName = foodName;

            }
            catch (FormatException ex)
            {


            }
        }

        public FoodData(int foodid, int price, string foodname, int categorieid)
        {
            this.foodId = foodid;
            this.price = price;
            this.foodName = foodname;
            this.categorieId = categorieid;
        }

        public FoodData(DataRow row)
        {
            foodId = (int)row["FoodId"];
            price = (int)row["Price"];
            foodName = (string)row["FoodName"];
            categorieId = (int)row["FoodTypeId"];
        }
       
        public FoodData()
        {
        }
        public int foodIds { get => foodId; set => foodId = value; }
        public int prices { get => price; set => price = value; }
        public string foodNames { get => foodName; set => foodName = value; }
        public int categorieIds { get => categorieId; set => categorieId = value; }
    }
}
