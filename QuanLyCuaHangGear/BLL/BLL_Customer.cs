using QuanLyCuaHangGear.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangGear.BLL
{
    class BLL_Customer
    {
        private static BLL_Customer _Instance;
        public static BLL_Customer Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLL_Customer();
                }
                return _Instance;
            }
            set => _Instance = value;
        }
        private BLL_Customer()
        {

        }

        //methods

        // khach hang
        public KhachHang Get_Customer(string sdt)
        {
            QLCH_Model DB = new QLCH_Model();
            var li_method = DB.KhachHangs.Where(p => p.Phone == sdt && p.Type == 1).FirstOrDefault();

            return li_method;
        }

        public void Add_Customer(string name, string phone, string email)
        {
            QLCH_Model DB = new QLCH_Model();
          
            var li_method = DB.KhachHangs.Add(new KhachHang
            {
                Name = name,
                Phone = phone,
                Email = email,
                Type = 1
            });
            DB.SaveChanges();
        }

        // nha cung cap
        public KhachHang Get_Provider(string name)
        {
            QLCH_Model DB = new QLCH_Model();
            var li_method = DB.KhachHangs.Where(p => p.Name == name && p.Type == 0).FirstOrDefault();

            return li_method;
        }
        public void Add_Provider(string name, string phone, string email)
        {
            QLCH_Model DB = new QLCH_Model();
            var li_method = DB.KhachHangs.Add(new KhachHang
            {
                Name = name,
                Phone = phone,
                Email = email,
                Type = 0
            });
            DB.SaveChanges();
        }
    }
}
