using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using Microsoft.SqlServer.Server;

namespace BLL
{
    public class Staff_BLL
    {
        private static Staff_BLL instance;
        public static Staff_BLL Instance
        {
            get
            {
                if (instance == null)
                    instance = new Staff_BLL();
                return Staff_BLL.instance;
            }

            private set { Staff_BLL.instance = value; }
        }
        private Staff_BLL()
        {

        } 

        public DataTable LoadStaff()
        {
            return DbConnection.Instance.ExecuteQuery("SELECT UserId as N'Mã nhân viên', Name as N'Họ tên', Birthday as N'Ngày sinh', Role as N'Chức vụ', Gender as N'Giới tính' FROM Account"); 
        }

        public bool InsertStaff(string name, string position, string gender, DateTime dates)
        {
            string query = "INSERT INTO Account(Name,Role,Gender,Birthday) VALUES (N'" + name + "',N'" + position + "',N'" + gender + "',N'" + dates + "')";
            int x = DbConnection.Instance.ExecuteNonQuery(query);
            if (x > 0) return true;
            return false;
        }

        public bool UpdateStaff(int id, string name, string position, string gender, DateTime dates)
        {
            string query = "UPDATE Account SET Name = N'" + name + "', Role = N'" + position + "',Gender = N'" + gender + "',Birthday ='" + dates + "' WHERE UserId ='" + id + "'";
            int x = DbConnection.Instance.ExecuteNonQuery(query);
            if (x > 0) return true;
            return false;
        }

        public bool DeleteStaff(int id)
        {
            string query = "DELETE FROM Account WHERE UserId ='" + id + "'";
            int x = DbConnection.Instance.ExecuteNonQuery(query);
            if (x > 0) return true;
            return false;


        }
        public DataTable SearchStaffByName(string name)
        {
            string query = "SELECT UserId as N'Mã nhân viên', Name as N'Họ tên', Birthday as N'Ngày sinh', Role as N'Chức vụ', Gender as N'Giới tính' FROM Account like N'%" + name + "%'";
            DataTable data = new DataTable();
            data = DbConnection.Instance.ExecuteQuery(query);
            return data;

        }

    }
}
