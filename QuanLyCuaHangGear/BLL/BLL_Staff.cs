
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
        public delegate bool Compare_Condition(string left, string right);
        private Compare_Condition _CompCond;
        public Compare_Condition CompCond { get; set; }
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
            //set => _Instance = value;
        }
        private BLL_Staff()
        {

        }
        // methods
        public string Random()
        {
            string Numrd_str;
            Random rd = new Random();
            Numrd_str = rd.Next(100000, 999999).ToString();  //Chuyển giá trị ramdon về kiểu string
            return Numrd_str;
        }
        // các hàm tương tác với đối tượng NhanVien
        public List<NhanVien> Get_NhanViens()
        {
            QLCH_Model DB = new QLCH_Model();
            var li_method = DB.NhanViens.Select(p => p);
            return li_method.ToList();
        }
        public NhanVien Get_NhanVien_by_ID(int id)
        {
            QLCH_Model DB = new QLCH_Model();
            var li_method = DB.NhanViens.Where(p => p.id == id).FirstOrDefault(); ;

            return li_method;
        }
        public void Add_Staff(string name, string gender, DateTime dob, string cmnd, string quequan, string diachi, string email, string phone)
        {
            QLCH_Model DB = new QLCH_Model();
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
            DB.NhanViens.Add(n);
            DB.SaveChanges();
         
        }
        
        public void Delete_Staff(int id)
        {
            QLCH_Model db = new QLCH_Model();
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
        
        public void Edit_Staff(int id, string name, string gender, DateTime dob, string cmnd, string quequan, string diachi, string email, string phone, string pass)
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
            ac.PassWord = pass;
            db.SaveChanges();
        }
        public List<NhanVien> Search_by_Name(string name)
        { 
            QLCH_Model DB = new QLCH_Model();
            var li_method = DB.NhanViens.Where(p => p.Name.Contains(name));
            
            return li_method.ToList();           
        }

        public int Get_Lastest_ID()
        {
            QLCH_Model DB = new QLCH_Model();
            try
            {
                return DB.NhanViens.OrderByDescending(p => p.id).First().id;
            }
            catch (InvalidOperationException )
            {
                return 0;
            }
            
        }
        // các hàm tương tác với đối tượng Account
        

        // các hàm xử lý chuỗi
        public string Convert_to_UnSign(string s)
        {
            Regex regex = new Regex("\\p{IsCombiningDiacriticalMarks}+");
            string temp = s.Normalize(NormalizationForm.FormD);
            return regex.Replace(temp, String.Empty).Replace('\u0111', 'd').Replace('\u0110', 'D');
        }
        public string Remove_Space(string s)
        {
            s = Regex.Replace(s, @"\s", "");   //sau do thay the bang 1 khoang trong            

            return s;
        }
        public string Name_to_Username(string name)
        {
            return Remove_Space(Convert_to_UnSign(name.ToLower()));
        }

        // các hàm phục vụ sắp xếp
        public bool A_to_Z(string left, string right)
        {
            return String.Compare(left, right) < 0;
        }
        public bool Z_to_A(string left, string right)
        {
            return String.Compare(left, right) > 0;
        }

        public bool name_compare(string name1, string name2, Compare_Condition CompCond)
        {
            string[] word1; string[] word2;
            word1 = name1.Split();
            word2 = name2.Split();
            if (word1[word1.Length - 1].Equals(word2[word2.Length - 1]))
            {
                if (CompCond(word1[word1.Length - 2], word2[word2.Length - 2]))
                {
                    return true;
                }
            }
            if (CompCond(word1[word1.Length - 1], word2[word2.Length - 1]))
            {
                return true;
            }
            return false;
        }

        public void Sort(List<NhanVien> list)
        {
            for (int i = 1; i < list.Count; i++)
            {
                for (int j = list.Count - 1; j >= i; j--)
                {
                    //if (arr[j].MSSV < arr[j - 1].MSSV)
                    if (name_compare(list[j].Name, list[j - 1].Name, this.CompCond))
                    {
                        NhanVien temp = list[j];
                        list[j] = list[j - 1];
                        list[j - 1] = temp;
                    }
                }
            }
        }
    }
}
