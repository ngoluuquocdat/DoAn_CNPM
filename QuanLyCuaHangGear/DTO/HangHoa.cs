using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangGear.DTO
{
    public class HangHoa
    {
        [Key]
        public int id { get; set; }
        public string Name { get; set; }
        public int idDanhMuc { get; set; }
        public int SoLuong { get; set; }
        public int DonGiaNhap { get; set; }
        public int DonGiaBan { get; set; }

        [ForeignKey("idDanhMuc")]
        public virtual DanhMuc DanhMuc { get; set; }
    }
}
