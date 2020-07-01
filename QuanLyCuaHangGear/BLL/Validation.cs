using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace QuanLyCuaHangGear.BLL
{
    public class Validation
    {
        public static bool is_Price(string price)
        {
            string strRegex = @"^[0-9]{1,}$";
            Regex re = new Regex(strRegex);
            if (re.IsMatch(price))
            {
                if (Convert.ToInt32(price) <= 0)
                    return false;
                else
                    return true;
            }
            else
                return false;
        }
        public static bool isEmail(string email)
        {
            // email = email ?? string.Empty;
            string strPattern = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                  @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                  @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            Regex re = new Regex(strPattern);
            if (re.IsMatch(email))
                return true;
            else
                return false;
        }
        public static bool isPhone(string phone)
        {
            string strPattern = @"^[0-9]{10,11}$";
            Regex re = new Regex(strPattern);
            if (re.IsMatch(phone))
                return true;
            else
                return false;
        }
        public static bool isCMND(string cmnd)
        {
            string strPattern = @"^[0-9]{9}$";
            Regex re = new Regex(strPattern);
            if (re.IsMatch(cmnd))
                return true;
            else
                return false;
        }
    }
}
