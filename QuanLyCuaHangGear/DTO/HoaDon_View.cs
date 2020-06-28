using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangGear.DTO
{
    public class HoaDon_View
    {
        public int ID { get; set; }
        public DateTime Date { get; set; }     // giong int, auto not null
        public string Partner { get; set; }
        public string Phone { get; set; }  
        public string Staff { get; set; }
        public string CMND { get; set; }
        public string Type { get; set; }              //   0: nhap hang; 1: ban hang
        public int Total { get; set; }
    }
}
