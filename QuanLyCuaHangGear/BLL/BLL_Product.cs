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



        // methods
        public DanhMuc Get_DanhMuc_by_ID(int id_dm)
        {
            QLCH_Model DB = new QLCH_Model();
            var li_method = DB.DanhMucs.Where(p => p.id == id_dm).FirstOrDefault();

            return li_method;
        }
    }
}
