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

namespace QuanLyCuaHangGear
{
    public partial class Staff_Control : UserControl
    {
        private static Staff_Control _instance;
        public static Staff_Control Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Staff_Control();
                return _instance;
            }
        }
        // constructor
        public Staff_Control()
        {
            InitializeComponent();
            Load_dtgv();
        }
        //methods
        public List<NhanVien_View> To_View(List<NhanVien> list)
        {
            List<NhanVien_View> list_view = new List<NhanVien_View>();        
            foreach (NhanVien nv in list)
            {
                list_view.Add(new NhanVien_View
                {
                    ID = nv.id,
                    Name = nv.Name,
                    Gender = nv.Gender,
                    Phone = nv.Phone,
                    Email = nv.Email
                });
            }

            return list_view;
        }
        public void Load_dtgv()
        {
            Staff_dtgv.DataSource = To_View(BLL_Staff.Instance.Get_NhanViens());
        }
        // events
        private void btn_View_Click(object sender, EventArgs e)
        {
            int id_nv = Convert.ToInt32(Staff_dtgv.SelectedRows[0].Cells["id"].Value.ToString());
            NhanVien nv = BLL_Staff.Instance.Get_NhanVien_by_ID(id_nv);
            txt_id.Text = nv.id.ToString();
            txt_Name.Text = nv.Name;
            txt_GioiTinh.Text = nv.Gender;
            txt_NgaySinh.Text = nv.DOB.ToShortDateString();
            txt_CMND.Text = nv.CMND;
            txt_QueQuan.Text = nv.QueQuan;
            txt_DiaChi.Text = nv.DiaChi;
            txt_SDT.Text = nv.Phone;
            txt_Email.Text = nv.Email;
            txt_Username.Text = BLL_Staff.Instance.Get_Account_by_ID(id_nv).UserName;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            AE_Staff_Form ae_f = new AE_Staff_Form(0);
            ae_f.ShowDialog();
            Load_dtgv();
        }

       

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection r = Staff_dtgv.SelectedRows;
            if (r.Count == 1)
            {
                int id = Convert.ToInt32(Staff_dtgv.SelectedRows[0].Cells["id"].Value);
                AE_Staff_Form f = new AE_Staff_Form(id);
                f.ShowDialog();
                
            }
            Load_dtgv();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {

            DataGridViewSelectedRowCollection rows = Staff_dtgv.SelectedRows;
            List<int> list_id = new List<int>();
            if (rows.Count == 0)
            {
                MessageBox.Show("Chưa có hàng nào được chọn.");
                return;
            }
            foreach (DataGridViewRow i in rows)
            {
                list_id.Add(Convert.ToInt32(i.Cells["ID"].Value.ToString()));
            }
            foreach (int id_nv in list_id)
            {
                BLL_Staff.Instance.Delete_Account(id_nv);
                BLL_Staff.Instance.Delete_Staff(id_nv);
            }

            Load_dtgv();
        }

        private void txt_Search_Click(object sender, EventArgs e)
        {
            txt_Search.Clear();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            string name = txt_Search.Text;
            Staff_dtgv.DataSource= To_View(BLL_Staff.Instance.Search_by_Name(name));
        }

        private void btn_Sort_AZ_Click(object sender, EventArgs e)
        {
            List<int> current_id = new List<int>();
            List<NhanVien> list_sort = new List<NhanVien>();

            foreach (DataGridViewRow i in Staff_dtgv.Rows)
            {
                current_id.Add(Convert.ToInt32(i.Cells["ID"].Value.ToString()));
            }
            foreach (int id in current_id)
            {
                list_sort.Add(BLL_Staff.Instance.Get_NhanVien_by_ID(id));
            }
            BLL_Staff.Instance.CompCond += new BLL_Staff.Compare_Condition(BLL_Staff.Instance.A_to_Z);
            BLL_Staff.Instance.Sort(list_sort);
            Staff_dtgv.DataSource = To_View(list_sort);
        }

    }
}
