using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class AcountBll
    {
        private static AcountBll instance;
        public static AcountBll Instance
        {
            get { if (instance == null) instance = new AcountBll(); return instance; }
            private set { instance = value; }
        }

        private AcountBll() { }
        public bool Login(string userName, string passWord)
        {
            byte[] temp = ASCIIEncoding.ASCII.GetBytes(passWord);
            byte[] hasData = new MD5CryptoServiceProvider().ComputeHash(temp);
            string hasPassword = "";
            foreach(byte item in hasData)
            {
                hasPassword += item;
            }
            string query = "USP_Login @userName , @passWord ";
            DataTable dataTable = DbConnection.Instance.ExecuteQuery(query, new object[] { userName, hasPassword });
            if (dataTable.Rows.Count > 0) return true;
            else return false;

        }

        public bool InsertAccout(string userName, string passWord)
        {
            byte[] temp = ASCIIEncoding.ASCII.GetBytes(passWord);
            byte[] hasData = new MD5CryptoServiceProvider().ComputeHash(temp);
            string hasPassword = "";
            foreach (byte item in hasData)
            {
                hasPassword += item;
            }
            string query = "EXEC USP_SIGNUP @USerName , @PassWord ";
            int result = DbConnection.Instance.ExecuteNonQuery(query,
                new object[] { userName, hasPassword });
            return result > 0;
        }

        public bool UpdateAccount(int userIds, string passwords)
        {
            byte[] temp = ASCIIEncoding.ASCII.GetBytes(passwords);
            byte[] hasData = new MD5CryptoServiceProvider().ComputeHash(temp);
            string hasPassword = "";
            foreach (byte item in hasData)
            {
                hasPassword += item;
            }
            string query = "UPDATE Account SET PassWord ='" + hasPassword + "' WHERE UserId = '" + userIds + "'";
            int result = DbConnection.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool IsExistAccount(string userName)
        {
            string query = "Select count(*) from Account " +
                "where UserName='" + userName + "'";
            int x = DbConnection.Instance.ExecuteScalar(query);
            if (x > 0) return true;
            return false;
        }
    }
}
