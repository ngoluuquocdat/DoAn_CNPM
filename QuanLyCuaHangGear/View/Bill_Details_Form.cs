using QuanLyCuaHangGear.DTO;
using QuanLyCuaHangGear.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHangGear.View
{
    
    public partial class Bill_Details_Form : Form
    {
        // fields
        private int _ID_hoadon;
        public int ID_hoadon { get => _ID_hoadon; set => _ID_hoadon = value; }

        // constructor
        public Bill_Details_Form(int id_hoadon)
        {
            this.ID_hoadon = id_hoadon;
            InitializeComponent();
            SetView();
        }

        // methods
        public List<HoaDonInfo_View> To_View(List<HoaDonInfo> list)
        {
            List<HoaDonInfo_View> list_view = new List<HoaDonInfo_View>();
            foreach (HoaDonInfo hd_info in list)
            {
                list_view.Add(new HoaDonInfo_View
                {
                    TenHang = hd_info.TenHangHoa,
                    DanhMuc = hd_info.DanhMuc,
                    DonGia = hd_info.DonGia,
                    SoLuong = hd_info.SoLuong
                });           
            }
            return list_view;
        }
        public void SetView()
        {
            // set labels
            HoaDon hd = BLL_Bill.Instance.Get_Bill_by_ID(this.ID_hoadon);
            if (hd.Type == 0)
            {
                label_top.Text = "Thông tin chi tiết phiếu nhập";
                label_id.Text = "Mã phiếu nhập:";
                label_partner_name.Text = "Nhà cung cấp:";
            }
            else
            {
                label_top.Text = "Thông tin chi tiết hóa đơn";
                label_id.Text = "Mã hóa đơn:";
                label_partner_name.Text = "Tên khách hàng:";
            }

            // set text boxes
            txt_id.Text = hd.id.ToString();
            txt_date.Text = hd.MakeDate.ToShortDateString();
            txt_ten_partner.Text = hd.TenKhachHang;
            txt_phone.Text = hd.Phone;
            txt_ten_nv.Text = hd.TenNhanVien;
            txt_cmnd.Text = hd.CMND;
            txt_tongtien.Text = hd.TongTien.ToString();

            // set dtgv
            bill_info_dtgv.DataSource = To_View(BLL_Bill.Instance.Get_Bill_Infoes(this.ID_hoadon));

        }

        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
