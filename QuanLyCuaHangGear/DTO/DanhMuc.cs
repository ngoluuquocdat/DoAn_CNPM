using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangGear.DTO
{
    public class DanhMuc
    {
        [Key]
        public int id { get; set; }
        public string Name { get; set; }
        public DanhMuc()
        {
            this.HangHoas = new HashSet<HangHoa>();
        }
        public virtual ICollection<HangHoa> HangHoas { get; set; }
    }
}
