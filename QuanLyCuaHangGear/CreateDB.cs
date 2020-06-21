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
            //nhanvien
            //context.NhanViens.Add(new NhanVien
            //{
            //    Name = "Hồ Văn An",
            //    Gender = "Nam",
            //    DOB = DateTime.Parse("10/09/2000"),
            //    CMND = "206284752",
            //    QueQuan = "Duy Xuyên, Quảng Nam",
            //    DiaChi = "K7/55 Phan Văn Định, Đà Nẵng",
            //    Phone = "09051234",
            //    Email = "hovanan1009@gmail.com",
            //});
            context.Accounts.Add(new Account
            {
                UserName = "admin",
                DisplayName = "Ngô Lưu Quốc Đạt",
                PassWord = "131810",
                idNhanVien = null,
                Type = 0
            });
            //context.Accounts.Add(new Account
            //{
            //    UserName = "hovanan1",
            //    DisplayName = "Hồ Văn An",
            //    PassWord = "123",
            //    idNhanVien = 1,
            //    Type = 1
            //});


            // danh muc
            context.DanhMucs.Add(new DanhMuc
            {
                Name = "Chuột"
            });
            context.DanhMucs.Add(new DanhMuc
            {
                Name = "Bàn phím"
            });
            context.DanhMucs.Add(new DanhMuc
            {
                Name = "Tai nghe"
            });
            context.DanhMucs.Add(new DanhMuc
            {
                Name = "Loa"
            });
            context.DanhMucs.Add(new DanhMuc
            {
                Name = "Màn hình"
            });

            // hang hoa
            context.HangHoas.Add(new HangHoa 
            {
                Name = "Chuột gaming Logitech G102",
                idDanhMuc = 1,
                SoLuong = 10,
                DonGiaNhap = 300000,
                DonGiaBan = 400000
            });
            context.HangHoas.Add(new HangHoa
            {
                Name = "Bàn phím cơ Consair K68",
                idDanhMuc = 2,
                SoLuong = 10,
                DonGiaNhap = 1500000,
                DonGiaBan = 2000000
            });
            // khach hang
            context.KhachHangs.Add(new KhachHang
            {
                Name = "Nguyễn Văn Nguyên",
                Phone = "0935813841",
                Email = "Oc0204@gmail.com",
                Type = 1
            });
            context.KhachHangs.Add(new KhachHang
            {
                Name = "Đặng Quốc Tuấn",
                Phone = "0905123456",
                Email = "tuandang123@gmail.com",
                Type = 1
            });
            // nha cung cap
            context.KhachHangs.Add(new KhachHang
            {
                Name = "Công ty ABC",
                Phone = "0907070707",
                Email = "ABCCompany@gmail.com",
                Type = 0
            });
        }
    }
}
