using QuanLyCuaHangGear.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHangGear.BLL
{
    class BLL_Account
    {
        private static BLL_Account _Instance;
        public static BLL_Account Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLL_Account();
                }
                return _Instance;
            }
            set => _Instance = value;
        }
        private BLL_Account()
        {

        }
        public Account Get_Account(string UserName)
        {
            try
            {
                QLCH_Model DB = new QLCH_Model();
                var li_method = DB.Accounts.Where(p => (p.UserName == UserName )).FirstOrDefault();
                return li_method;
            }
            catch (Exception)
            {
                return null;
            }

        }
        public string MaHoa(string password)
        {
            byte[] temp = ASCIIEncoding.ASCII.GetBytes(password);
            byte[] hashdata = new MD5CryptoServiceProvider().ComputeHash(temp);
            string hashpass = "";
            foreach(byte i in hashdata)
            {
                hashpass += i;
            }
            return hashpass;
        }
        public bool CheckNewPass(string pass)
        {
            return Regex.IsMatch(pass, @".{6,}");
        }
        public Account Get_Account_by_Username(string username)
        {
            QLCH_Model DB = new QLCH_Model();
            var li_method = DB.Accounts.Where(p => p.UserName==username).FirstOrDefault();
            return li_method;
        }
        public void UpdatePass(string username, string pass)
        {
            QLCH_Model DB = new QLCH_Model();
            Account ac = DB.Accounts.Where(p => p.UserName == username).FirstOrDefault();
            ac.PassWord = pass;
            DB.SaveChanges();
        }
        public Account Get_Account_by_ID(int id)
        {
            QLCH_Model DB = new QLCH_Model();
            var li_method = DB.Accounts.Where(p => p.idNhanVien == id).FirstOrDefault();
            return li_method;
        }
        public void Add_Account(string username, int id_nv, string displayname, string pass)
        {
            QLCH_Model DB = new QLCH_Model();
            Account acc = new Account
            {
                UserName = username,
                DisplayName = displayname,
                idNhanVien = id_nv,
                Type = 1,
                PassWord = pass
            };

            DB.Accounts.Add(acc);
            DB.SaveChanges();
        }
        public void Delete_Account(int id)
        {

            QLCH_Model db = new QLCH_Model();
            id = Convert.ToInt32(db.Accounts.Where(p => p.idNhanVien == id).Select(p => p.idNhanVien).FirstOrDefault());
            foreach (Account i in db.Accounts)
            {
                if (i.idNhanVien == id)
                {
                    db.Accounts.Remove(i);
                }
            }
            db.SaveChanges();
        }
    }    
}
