using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA
{
    public class FoodCategoryData
    {
        private int typeId;
        private string typeName;

        public FoodCategoryData(DataRow row)
        {
            typeId = (int) row["FoodTypeId"];
            typeName = (string)row["FoodTypeName"];

        }
        public int TypeId { get => typeId; set => typeId = value; }
        public string TypeName { get => typeName; set => typeName = value; }

    }
}
