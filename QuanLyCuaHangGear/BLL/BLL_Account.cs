using QuanLyCuaHangGear.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
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
        public Account Get_Account(string UserName, string PassWord)
        {
            try 
            {
                QLCH_Model DB = new QLCH_Model();
                var li_method = DB.Accounts.Where(p => (p.UserName == UserName && p.Type == 0) || (p.PassWord == PassWord && p.Type == 1)).FirstOrDefault();
                return li_method;
            }
            catch (Exception)
            {
                return null;
            }
            
        }
        public bool CheckNewPass(string pass)
        {
          return Regex.IsMatch(pass, @".{6,}");
        }
        public Account CheckOldPass(string pass)
        {
            QLCH_Model DB = new QLCH_Model();
            var li_method = DB.Accounts.Where(p => p.PassWord == pass).FirstOrDefault();
            return li_method;
        }
        public void UpdatePass(int id, string pass)
        {
            QLCH_Model DB = new QLCH_Model();
            Account ac = DB.Accounts.Where(p => p.idNhanVien == id).FirstOrDefault();
            ac.PassWord = pass;
            DB.SaveChanges();
        }
    } 
}
