using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BLL
{
    public class FoodBILL
    {
        private FoodBILL()
        {

        }
        private static FoodBILL instance;
        public static FoodBILL Instance
        {
            get
            {
                if (instance == null) instance = new FoodBILL();
                return instance;
            }
        }

        public DataTable LoadFood()
        {
            DataTable data = new DataTable();
            string query = "SELECT FoodId as N'Mã thức ăn',FoodName as N'Tên thức ăn', Price as N'Giá',Food.FoodTypeId as N'Mã loại',FoodTypeName as N'Tên loại' FROM Food,FoodType WHERE Food.FoodTypeId = FoodType.FoodTypeId";
            data = DbConnection.Instance.ExecuteQuery(query);
            return data;
        }

        public bool InsertFood(string name, int price, int categoriesId)
        {
            string query = "INSERT INTO Food(FoodName,Price,FoodTypeId) VALUES (N'" + name + "'," + price + "," + categoriesId + ")";
            int x = DbConnection.Instance.ExecuteNonQuery(query);
            if (x > 0) return true;
            return false;
        }
        public bool UpdateFood(int foodId, string name, int price, int categoriesId)
        {
            string query = "UPDATE Food SET FoodName = N'" + name + "',Price = " + price + ",FoodTypeId=" + categoriesId + "WHERE FoodId=" + foodId;
            int x = DbConnection.Instance.ExecuteNonQuery(query);
            if (x > 0) return true;
            return false;
        }
        public bool DeleteFood(int foodId)
        {
            string query = "Delete FROM Food WHERE FoodId=" + foodId;
            int x = DbConnection.Instance.ExecuteNonQuery(query);
            if (x > 0) return true;
            return false;
        }
        public DataTable SearchFoodByName(string name)
        {
            string query = "SELECT FoodId as N'Mã thức ăn',FoodName as N'Tên thức ăn', Price as N'Giá', Food.FoodTypeId as N'Mã loại',FoodTypeName as N'Tên loại' FROM Food,FoodType WHERE Food.FoodTypeId = FoodType.FoodTypeId"; 
             DataTable data = new DataTable();
            data = DbConnection.Instance.ExecuteQuery(query);
            return data;
        }

        /*
        public List<Food> GetFoodByCategoryID(int categoryId)
        {
            List<Food> list = new List<Food>();

            string query = "SELECT * FROM Food WHERE FoodTypeId = " + categoryId;

            DataTable data = DbConnection.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Food food = new Food(item);
                list.Add(food);
            }

            return list;
        
        }
        */
    }
}
