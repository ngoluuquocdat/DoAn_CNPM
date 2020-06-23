using QuanLyCuaHangGear.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangGear.BLL
{
    class BLL_Bill
    {
        private static BLL_Bill _Instance;
        public static BLL_Bill Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLL_Bill();
                }
                return _Instance;
            }
            set => _Instance = value;
        }
        private BLL_Bill()
        {

        }

        
        public HoaDon Get_Lastest_Bill()
        {
            QLCH_Model DB = new QLCH_Model();
            return DB.HoaDons.OrderByDescending(p => p.id).FirstOrDefault();
        }
        public void Add_Bill(DateTime date, string customer_name, string phone, string staff_name,
                                      string cmnd, int type, int tongtien)
        {
            QLCH_Model DB = new QLCH_Model();
            DB.HoaDons.Add(new HoaDon
            {
                MakeDate = date,
                TenKhachHang = customer_name,
                Phone = phone,
                TenNhanVien = staff_name,
                CMND = cmnd,
                Type = type,
                TongTien = tongtien
            });
            DB.SaveChanges();
        }
       
        public void Add_Bill_Info(int id_bill, string product_name, string category, int price, int count)
        {
            QLCH_Model DB = new QLCH_Model();
            DB.HoaDonInfoes.Add(new HoaDonInfo
            {
                idHoaDon = id_bill,
                TenHangHoa = product_name,
                DanhMuc = category,
                DonGia = price,               
                SoLuong = count
            });
            DB.SaveChanges();
        }
        // get bill and import
        public List<HoaDon> Get_Bill_by_Date(DateTime d1, DateTime d2)
        {
            QLCH_Model DB = new QLCH_Model();
            var li_method = DB.HoaDons.Where(p => d1 <= p.MakeDate && p.MakeDate <= d2);

            return li_method.ToList();
        }
        public HoaDon Get_Bill_by_ID(int id)
        {
            QLCH_Model DB = new QLCH_Model();
            var li_method = DB.HoaDons.Where(p => p.id == id).FirstOrDefault();

            return li_method;
        }
        public List<HoaDonInfo> Get_Bill_Infoes(int id_bill)
        {
            QLCH_Model DB = new QLCH_Model();
            var li_method = DB.HoaDonInfoes.Where(p => p.idHoaDon == id_bill).ToList();

            return li_method;
        }

    }
}
