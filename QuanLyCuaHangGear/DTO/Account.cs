using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangGear.DTO
{

    public class Account
    {
        [Key]

        public string UserName { get; set; }

        [Index(IsUnique = true)]
        public Nullable<int> idNhanVien { get; set; }
        public string DisplayName { get; set; }
        public string PassWord { get; set; }
        public int Type { get; set; }

        [ForeignKey("idNhanVien")]
        public virtual NhanVien NhanVien { get; set; }
    }
}
