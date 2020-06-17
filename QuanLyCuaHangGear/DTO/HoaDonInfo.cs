using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangGear.DTO
{
    public class HoaDonInfo
    {
        [Key]
        public int id { get; set; }
        public int idHoaDon { get; set; }
        public string TenHangHoa { get; set; }
        public string DanhMuc { get; set; }
        public int DonGia { get; set; }
        public int SoLuong { get; set; }
        [ForeignKey("idHoaDon")]
        public virtual HoaDon HoaDon { get; set; }
    }
}
