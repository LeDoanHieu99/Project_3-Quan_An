    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DATA;

namespace BLL
{
    public class FoodCategoryBILL
    {
        private FoodCategoryBILL() { }
        private static FoodCategoryBILL instance;
        public static FoodCategoryBILL Instance
        {
            get
            {
                if (instance == null) instance = new FoodCategoryBILL();
                return instance;
            }
        }

        public DataTable LoadFoodCategory()
        {
            DataTable data = new DataTable();
            data = DbConnection.Instance.ExecuteQuery(" SELECT FoodTypeId as N'ID', FoodTypeName as N'CategorieName' FROM FoodType");
            return data;
        }

        public bool InsertFoodCategory(string name)
        {
            string query = "AddFoodCategory @FoodTypeName";

            int x = DbConnection.Instance.ExecuteNonQuery(query, new object[] { name });
            if (x > 0) return true;
            return false;
        }
        public bool DeleteFoodCategory(string name)
        {
            string query = "DELETE FROM  FoodType WHERE FoodTypeName =N'" + name + "'";
            int x = DbConnection.Instance.ExecuteNonQuery(query);
            if (x > 0) return true;
            return false;

        }

        public bool UpdateFoodCateGory(string newName, string oldName)
        {
            string query = "UpdateFoodCategory @newName , @oldName";
            int result = DbConnection.Instance.ExecuteNonQuery(query, new object[] { newName, oldName });
            if (result > 0) return true;
            return false;
        }

        public List<FoodCategoryData> GetListFoodCategories()
        {
            string query = "SELECT * FROM FoodType";
            DataTable data = DbConnection.Instance.ExecuteQuery(query);
            List<FoodCategoryData> categories = new List<FoodCategoryData>();
            foreach (DataRow i in data.Rows)
            {
                FoodCategoryData category = new FoodCategoryData(i);
                categories.Add(category);

            }
            return categories;
        }

        public int GetIdByNameFoodCategory(string name)
        {
            int id = -1;
            DataTable data = new DataTable();
            data = DbConnection.Instance.ExecuteQuery("SELECT FoodTypeId FROM FoodType WHERE FoodTypeName = N'" + name + "'");
            try
            {
                id = (int)data.Rows[0][0];
                return id;
            }
            catch
            {
                return -1;
            }
        }

        public DataTable GetCategoryMaxId()
        {
            DataTable data = new DataTable();         
            data = DbConnection.Instance.ExecuteQuery("SELECT FoodTypeName FROM FoodType WHERE FoodTypeId = (SELECT MAX(FoodTypeId) FROM FoodType)");
            return data;
        }
    }
}
