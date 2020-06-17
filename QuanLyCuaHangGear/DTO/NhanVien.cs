using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangGear.DTO
{
    public class NhanVien
    {
        [Key]
        public int id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public DateTime DOB { get; set; }
        public string CMND { get; set; }
        public string QueQuan { get; set; }
        public string DiaChi { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        
        public virtual ICollection <Account> Accounts { get; set; }
        public NhanVien()
        {
            this.Accounts = new HashSet<Account>();
        }
    }
}
