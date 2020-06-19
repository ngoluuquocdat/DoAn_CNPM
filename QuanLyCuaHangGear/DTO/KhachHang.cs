using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangGear.DTO
{
    public class KhachHang
    {
        [Key]
        public int id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int Type { get; set; }           // 0: nha cung cap; 1: khach hang
    }
}
