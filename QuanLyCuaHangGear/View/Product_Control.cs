using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyCuaHangGear.View;
using QuanLyCuaHangGear.DTO;
using QuanLyCuaHangGear.BLL;

namespace QuanLyCuaHangGear
{
    public partial class Product_Control : UserControl
    {
        private static Product_Control _instance;
        public static Product_Control Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Product_Control();
                return _instance;
            }
        }
        public Product_Control()
        {
            InitializeComponent();
        }

        // methods
        // hàm này chép dữ liệu từ đối tượng HangHoa sang đối tượng HangHoa_view
        // đối tượng HangHoa_view cho phép chỉ view lên thuộc tính ID, Ten, DanhMuc, SoLuong
        public List<HangHoa_View> To_View(List<HangHoa> list)
        {
            List<HangHoa_View> list_view = new List<HangHoa_View>();
            foreach (HangHoa h in list)
            {
                list_view.Add(new HangHoa_View
                {
                    ID = h.id,
                    Ten = h.Name,
                    DanhMuc = BLL_Product.Instance.Get_DanhMuc_by_ID(h.idDanhMuc).Name,
                    SoLuong = h.SoLuong,
                }) ;
            }

            return list_view;
        }

        //events
        private void btn_Add_Click(object sender, EventArgs e)
        {
            A_Product_Form ae_f = new A_Product_Form();
            ae_f.ShowDialog();
        }
    }
}
