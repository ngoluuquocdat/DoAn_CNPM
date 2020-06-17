
/*--------------------------------------Bản Chính--------------------------------------*/
using QuanLyCuaHangGear.DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace QuanLyCuaHangGear.BLL
{
    class BLL_Staff
    {
        private static BLL_Staff _Instance;

        public static BLL_Staff Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLL_Staff();
                }
                return _Instance;
            }
            set => _Instance = value;
        }
        public string Random()
        {
            string Numrd_str;
            Random rd = new Random();
            Numrd_str = rd.Next(100000, 999999).ToString();//Chuyển giá trị ramdon về kiểu string
            return Numrd_str;
        }
        public IList Get_List()
        {
            QLCH_Model db = new QLCH_Model();
            var query = db.NhanViens.Select(p => new { p.id, p.Name, p.Gender, p.CMND, p.Phone, p.Email });
            return query.ToList();
        }
        public NhanVien Get_Inf_Nv(string id)
        {
            QLCH_Model db = new QLCH_Model();
            NhanVien nv = new NhanVien();
            id = db.NhanViens.Where(p => p.id.ToString() == id).Select(p => p.id).FirstOrDefault().ToString();
            nv = db.NhanViens.Where(p => p.id.ToString() == id).Select(p => p).FirstOrDefault();

            return nv;
        }
        public Account Get_Account_NV(string id)
        {
            QLCH_Model db = new QLCH_Model();
            Account ac = new Account();
            ac = db.Accounts.Where(p => p.idNhanVien.ToString() == id).Select(p => p).FirstOrDefault();
            return ac;
        }
        public void AddStaff(string name, string gender, DateTime dob, string cmnd, string quequan, string diachi, string email, string phone, string username, string dname, string pass)
        {
            QLCH_Model db = new QLCH_Model();
            NhanVien n = new NhanVien
            {
                Name = name,
                Gender = gender,
                DOB = dob,
                CMND = cmnd,
                QueQuan = quequan,
                DiaChi = diachi,
                Email = email,
                Phone = phone
            };
            db.NhanViens.Add(n);
            db.SaveChanges();
            NhanVien nv = db.NhanViens.OrderByDescending(p => p.id).First();
            Account account = new Account
            {
                UserName = xoakhoangtrang(convertToUnSign(username.ToLower())) + nv.id,
                DisplayName = dname,
                idNhanVien = nv.id,
                Type = 0,
                PassWord = pass
            };

            db.Accounts.Add(account);
            db.SaveChanges();
        }
        public void DelStaff(int id)
        {

            QLCH_Model db = new QLCH_Model();
           // List<int> idl = new List<int>();
            id = db.NhanViens.Where(p => p.id == id).Select(p => p.id).FirstOrDefault();
            foreach (NhanVien i in db.NhanViens)
            {
                if (i.id == id)
                {
                    db.NhanViens.Remove(i);
                }
            }
            db.SaveChanges();
        }
        public void DelAccount(int id)
        {

            QLCH_Model db = new QLCH_Model();
            // List<int> idl = new List<int>();
            id = Convert.ToInt32(db.Accounts.Where(p => p.idNhanVien == id).Select(p => p.idNhanVien).FirstOrDefault());
            foreach (Account i in db.Accounts)
            {
                if (i.idNhanVien == id)
                {
                    db.Accounts.Remove(i);
                }
            }
            db.SaveChanges();
        }
        public void EditStaff(int id, string name, string gender, DateTime dob, string cmnd, string quequan, string diachi, string email, string phone, string dname,string pass)
        {
            QLCH_Model db = new QLCH_Model();
            NhanVien nv = db.NhanViens.Where(p => p.id == id).FirstOrDefault();
            nv.Name = name;
            nv.Gender = gender;
            nv.DOB = dob;
            nv.CMND = cmnd;
            nv.QueQuan = quequan;
            nv.DiaChi = diachi;
            nv.Email = email;
            nv.Phone = phone;
            Account ac = db.Accounts.Where(p => p.idNhanVien == id).FirstOrDefault();
            ac.DisplayName = dname;
            ac.PassWord = pass;
            db.SaveChanges();
        }
        public IList Search(string StringSearch)
        { 
            QLCH_Model db = new QLCH_Model();
            var query = db.NhanViens.Where(p => p.Name.Contains(StringSearch))
                           .Select(p => new { p.id, p.Name, p.Gender, p.QueQuan,p.DiaChi, p.Phone, p.Email });
             return query.ToList();
            
        }
        public string convertToUnSign(string s)
        {
            Regex regex = new Regex("\\p{IsCombiningDiacriticalMarks}+");
            string temp = s.Normalize(NormalizationForm.FormD);
            return regex.Replace(temp, String.Empty).Replace('\u0111', 'd').Replace('\u0110', 'D');
        }
        public string xoakhoangtrang(string s)
        {
            s = Regex.Replace(s, @"\s", "");   //sau do thay the bang 1 khoang trong            

            return s;
        }
        public NhanVien Get_NhanVien_ById(int Id)
        {
            QLCH_Model db = new QLCH_Model();
            return db.NhanViens.Where(p => p.id == Id).FirstOrDefault();
        }
        public Account Get_Account_ById(int Id)
        {
            QLCH_Model db = new QLCH_Model();
            return db.Accounts.Where(p => p.idNhanVien == Id).FirstOrDefault();
        }
    }
}
