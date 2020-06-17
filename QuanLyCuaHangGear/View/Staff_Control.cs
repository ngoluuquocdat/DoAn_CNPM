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
        public Staff_Control()
        {
            InitializeComponent();
            Staff_dataGridView.DataSource = BLL_Staff.Instance.Get_List();
        }

        private void btn_View_Click(object sender, EventArgs e)
        {
            string id = Staff_dataGridView.SelectedRows[0].Cells["id"].Value.ToString();
            NhanVien nv = BLL_Staff.Instance.Get_Inf_Nv(id);
            Account ac = BLL_Staff.Instance.Get_Account_NV(id);
            txt_id.Text = nv.id.ToString();
            txt_Name.Text = nv.Name;
            txt_GioiTinh.Text = nv.Gender;
            txt_NgaySinh.Text = nv.DOB.ToShortDateString();
            txt_CMND.Text = nv.CMND;
            txt_QueQuan.Text = nv.QueQuan;
            txt_DiaChi.Text = nv.DiaChi;
            txt_SDT.Text = nv.Phone;
            txt_Email.Text = nv.Email;
            txt_Username.Text = ac.UserName;
            txt_TenHT.Text = ac.DisplayName;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            AE_Staff_Form ae_f = new AE_Staff_Form(0);
            ae_f.ShowDialog();
            Staff_dataGridView.DataSource = BLL_Staff.Instance.Get_List();
        }

        private void btn_Sort_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection r = Staff_dataGridView.SelectedRows;
            if (r.Count == 1)
            {
                int id = Convert.ToInt32(Staff_dataGridView.SelectedRows[0].Cells["id"].Value);
                AE_Staff_Form f = new AE_Staff_Form(id);
                f.ShowDialog();
                Staff_dataGridView.DataSource = BLL_Staff.Instance.Get_List();
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Staff_dataGridView.SelectedRows[0].Cells["id"].Value);
            BLL_Staff.Instance.DelAccount(id);
            BLL_Staff.Instance.DelStaff(id);
            Staff_dataGridView.DataSource = BLL_Staff.Instance.Get_List();
        }

        private void txt_Search_Click(object sender, EventArgs e)
        {
            txt_Search.Clear();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            string StringSearch = txt_Search.Text;
            Staff_dataGridView.DataSource= BLL_Staff.Instance.Search(StringSearch);
        }
    }
}
