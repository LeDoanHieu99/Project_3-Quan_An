using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace DATA
{
    public class Staff_DATA
    {
        int userId;
        string name, date, position, gender;

        public Staff_DATA()
        {

        }
        public Staff_DATA(string userId, string gender, string name,string date, string position)
        {
            try
            {
                this.userId = Convert.ToInt32(userId);
                this.gender = gender;
                this.name = name;
                this.date = date;
                this.position = position;
            }
            catch (FormatException e)
            {

            }
        }

        public bool CompareStaff(Staff_DATA staff)
        {
            if (this == null)
            {
                return false;
            }
            if (userId == staff.userId && gender == staff.gender && name == staff.name && date == staff.date && position == staff.position)
            {
                return true;
            }
            return false;
        }

        public static bool checkInsertStaff(string userId, string gender, string name, string dates, string position)
        {
            DateTime dt;
            string[] list_gender = new String[] { "Nam", "Nữ"};
            bool check_date = DateTime.TryParseExact(dates, "d", new CultureInfo("en-US"), DateTimeStyles.None, out dt);

            if (String.IsNullOrEmpty(userId) || String.IsNullOrEmpty(name) || String.IsNullOrEmpty(dates) || String.IsNullOrEmpty(position))
            {
                return false;
            }
            
            if (Array.IndexOf(list_gender, dates) == -1)
            {
                return false;
            }

            if (userId.Length > 100 || name.Length > 100 || position.Length > 100 )
            {
                return false;
            }
            if (!check_date)
            {
                return false;
            }

            return true;
        }

        public static Staff_DATA checkUpdateStaff(string userId, string gender, string name, string dates, string position)
        {
            DateTime dt;
            string[] list_gender = new String[] { "Nam", "Nữ"};
            bool check_date = DateTime.TryParseExact(dates, "d", new CultureInfo("en-US"), DateTimeStyles.None, out dt);

            if ( String.IsNullOrEmpty(name) || String.IsNullOrEmpty(dates) || String.IsNullOrEmpty(position))
            {
                return null;
            }

            if (Array.IndexOf(list_gender, dates) == -1)
            {
                return null;
            }

            if (name.Length > 100 || position.Length > 100)
            {
                return null;
            }
            if (!check_date)
            {
                return null;
            }
            try
            {
                if (Convert.ToInt32(userId) < 0)
                {
                    return null;
                }

                return new Staff_DATA()
                {
                    userId = Convert.ToInt32(userId),
                    gender = gender,
                    name = name,
                    date = dates,
                    position = position,

                };

            }
            catch (FormatException ex)
            {
                return null;
                throw new Exception("Mã nhân viên là số");
            }


        }
        public static bool CheckDeleteStaff(List<Staff_DATA> staffs, string userId)
        {
            //Tìm index của nhân viên theo mã nhân viên nếu ko có trả về -1
            try
            {
                int index = staffs.FindIndex(value => value.userId == Convert.ToInt32(userId));
                if (index == -1)
                {
                    return false;
                }
                return true;
            }
            catch (FormatException e)
            {
                return false;
            }


        }

    }
}
