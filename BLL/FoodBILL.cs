using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DATA;

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
            string query = "SELECT FoodId as N'ID',FoodName , Price , Food.FoodTypeId as N'CategorieId',FoodTypeName as N'CategorieName' FROM Food,FoodType WHERE Food.FoodTypeId = FoodType.FoodTypeId";
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
            string query = "SELECT FoodId as N'ID',FoodName , Price , Food.FoodTypeId as 'CategorieId',FoodTypeName as 'CategorieName' FROM Food,FoodType WHERE Food.FoodTypeId = FoodType.FoodTypeId AND FoodName like N'%" + name + "%'"; 
             DataTable data = new DataTable();
            data = DbConnection.Instance.ExecuteQuery(query);
            return data;
        }

        public List<FoodData> GetFoodByCategoryID(int categoryId)
        {
            List<FoodData> list = new List<FoodData>();

            string query = "SELECT * FROM Food WHERE FoodTypeId = " + categoryId;

            DataTable data = DbConnection.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                FoodData food = new FoodData(item);
                list.Add(food);
            }

            return list;
        
        }      
    }
}
