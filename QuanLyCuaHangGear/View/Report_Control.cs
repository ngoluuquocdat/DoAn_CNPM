using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyCuaHangGear.BLL;
using QuanLyCuaHangGear.DTO;
using QuanLyCuaHangGear.View;

namespace QuanLyCuaHangGear
{
    public partial class Report_Control : UserControl
    {
        private static Report_Control _instance;
        public static Report_Control Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Report_Control();
                return _instance;
            }
        }
        public Report_Control()
        {
            InitializeComponent();
        }

        // methods
        public List<HoaDon_View> To_View(List <HoaDon> list)
        {
            List<HoaDon_View> list_view = new List<HoaDon_View>();
            foreach (HoaDon hd in list)
            {
                HoaDon_View hd_view = new HoaDon_View();
                hd_view.ID = hd.id;
                hd_view.Date = hd.MakeDate;
                hd_view.Partner = hd.TenKhachHang;
                hd_view.Phone = hd.Phone;
                if(hd.Type == 0)
                    hd_view.Type = "Phiếu nhập hàng";
                else
                    hd_view.Type = "Hóa đơn bán hàng";
                hd_view.Total = hd.TongTien;
                list_view.Add(hd_view);
            }
            return list_view;
        }

        // events
        private void btn_View_Click(object sender, EventArgs e)
        {
            DateTime d1 = dateTimePicker_From.Value.Date;
            DateTime d2 = dateTimePicker_To.Value.Date;
            MessageBox.Show(d1.ToString());
            Report_dtgv.DataSource = To_View(BLL_Bill.Instance.Get_Bill_by_Date(d1,d2));
        }

        private void btn_details_Click(object sender, EventArgs e)
        {           
            DataGridViewSelectedRowCollection r = Report_dtgv.SelectedRows;
            if (r.Count == 1)
            {
                int id_hoadon = Convert.ToInt32(Report_dtgv.SelectedRows[0].Cells[0].Value);
                Bill_Details_Form f = new Bill_Details_Form(id_hoadon);
                f.ShowDialog();
            }
        }


    }
}
