using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangGear.DTO
{
    public class HoaDon
    {
        [Key]
        public int id { get; set; }
        public DateTime MakeDate { get; set; }     // giong int, auto not null
        public string TenKhachHang { get; set; }
        public string Phone { get; set; }
        public string TenNhanVien { get; set; }
        public string CMND { get; set; }
        public int Type { get; set; }              //   0: nhap hang; 1: ban hang
        public int TongTien { get; set; }
        public HoaDon()
        {
            this.HoaDonInfoes = new HashSet<HoaDonInfo>();
        }
        public virtual ICollection<HoaDonInfo> HoaDonInfoes { get; set; }
    }
}
