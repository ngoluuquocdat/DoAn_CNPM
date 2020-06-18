using QuanLyCuaHangGear.DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangGear
{
    class CreateDB : CreateDatabaseIfNotExists<QLCH_Model>
    {
        protected override void Seed(QLCH_Model context)
        {
            context.Accounts.Add(new Account
            {
                UserName = "admin",
                DisplayName = "Ngô Lưu Quốc Đạt",
                PassWord = "131810",
                idNhanVien = null
            });
            context.NhanViens.Add(new NhanVien
            {
                Name = "Hồ Văn An",
                Gender = "Nam",
                DOB = DateTime.Parse("10/09/2000"),
                CMND = "206284752",
                QueQuan = "Duy Xuyên, Quảng Nam",
                DiaChi = "K7/55 Phan Văn Định, Đà Nẵng",
                Phone = "09051234",
                Email = "hovanan1009@gmail.com",
            });
            context.DanhMucs.Add(new DanhMuc
            {
                id = 1,
                Name = "Chuột"
            });
            context.DanhMucs.Add(new DanhMuc
            {
                id = 2,
                Name = "Bàn Phím"
            });
            context.DanhMucs.Add(new DanhMuc
            {
                id = 3,
                Name = "Tai Nghe"
            });
        }
    }
}
