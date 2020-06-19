using QuanLyCuaHangGear.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangGear.BLL
{
    class BLL_Product
    {
        // delegate for sorting
        public delegate bool Compare_Condition(int left, int right);
        private Compare_Condition _CompCond;
        public Compare_Condition CompCond { get; set; }

        // single-ton
        private static BLL_Product _Instance;
        public static BLL_Product Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLL_Product();
                }
                return _Instance;
            }
            set => _Instance = value;
        }
        private BLL_Product()
        {

        }


        // methods
        public DanhMuc Get_DanhMuc_by_ID(int id_dm)
        {
            QLCH_Model DB = new QLCH_Model();
            var li_method = DB.DanhMucs.Where(p => p.id == id_dm).FirstOrDefault();

            return li_method;
        }
        public HangHoa Get_HangHoa_by_ID(int id_hh)
        {
            QLCH_Model DB = new QLCH_Model();
            var li_method = DB.HangHoas.Where(p => p.id == id_hh).FirstOrDefault();
            return li_method;

        }
        public List<HangHoa> Get_HangHoa_by_IdDanhMuc(int id_dm)
        {
            QLCH_Model DB = new QLCH_Model();
            var li_method = DB.HangHoas.Where(p => p.idDanhMuc == id_dm);
            return li_method.ToList();
        }
        public List<HangHoa> Get_HangHoas()
        {
            QLCH_Model DB = new QLCH_Model();
            var li_method = DB.HangHoas.Select(p => p);
            return li_method.ToList();
        }
        public List<DanhMuc> Get_DanhMucs()
        {
            QLCH_Model db = new QLCH_Model();
            return db.DanhMucs.Select(p => p).ToList();
        }
        public void AddProduct(string Name,string GiaBan,string GiaNhap,int idPr)
        {
            QLCH_Model DB = new QLCH_Model();
            HangHoa pr = new HangHoa
            {
                Name = Name,
                DonGiaBan = Convert.ToInt32(GiaBan),
                DonGiaNhap = Convert.ToInt32(GiaNhap),
                idDanhMuc = idPr
            };

            DB.HangHoas.Add(pr);
            DB.SaveChanges();
        }
        public void EditProduct(int Id,string Name, string GiaBan, string GiaNhap, int idPr)
        {
            QLCH_Model DB = new QLCH_Model();
            HangHoa pr = DB.HangHoas.Where(p => p.id == Id).FirstOrDefault();
            pr.Name = Name;
            pr.DonGiaBan = Convert.ToInt32(GiaBan);
            pr.DonGiaNhap = Convert.ToInt32(GiaNhap);
            pr.idDanhMuc = idPr;
            DB.SaveChanges();
        }
        public void Delete(int id_pr)
        {
            QLCH_Model db = new QLCH_Model();
            id_pr = Convert.ToInt32(db.HangHoas.Where(p => p.id == id_pr).Select(p => p.id).FirstOrDefault());
            foreach (HangHoa i in db.HangHoas)
            {
                if (i.id == id_pr)
                {
                    db.HangHoas.Remove(i);
                }
            }
            db.SaveChanges();
        }
        public List<HangHoa> Search_by_DanhMuc(string s, int id)
        {
            QLCH_Model DB = new QLCH_Model();
            if (id == 0)
            {
                var query = DB.HangHoas.Where(p => p.Name.Contains(s)).Select(p => p);
                return query.ToList();
            }
            else
            {
                var query = DB.HangHoas.Where(p => p.Name.Contains(s) && p.idDanhMuc == id)
                                   .Select(p => p);
                return query.ToList();
            }
        }
        //Hàm sort và các hàm phục vụ sort
        public void Sort_GiaBan(List<HangHoa> list)
        {
            for (int i = 1; i < list.Count; i++)
            {
                for (int j = list.Count - 1; j >= i; j--)
                {
                    //if (arr[j].MSSV < arr[j - 1].MSSV)
                    if (this.CompCond(list[j].DonGiaBan, list[j - 1].DonGiaBan))
                    {
                        HangHoa temp = list[j];
                        list[j] = list[j - 1];
                        list[j - 1] = temp;
                    }
                }
            }
        }
        public void Sort_GiaNhap(List<HangHoa> list)
        {
            for (int i = 1; i < list.Count; i++)
            {
                for (int j = list.Count - 1; j >= i; j--)
                {
                    if (this.CompCond(list[j].DonGiaNhap, list[j - 1].DonGiaNhap))
                    {
                        HangHoa temp = list[j];
                        list[j] = list[j - 1];
                        list[j - 1] = temp;
                    }
                }
            }
        }
        public bool Ascending(int left, int right)
        {
            return left < right;
        }
        public bool Decrease(int left, int right)
        {
            return left > right;
        }
    }
}
