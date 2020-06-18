using QuanLyCuaHangGear.BLL;
using QuanLyCuaHangGear.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHangGear
{
    public partial class AE_Staff_Form : Form
    {
        public int ID { get; set; }
        public AE_Staff_Form(int id)
        {
            this.ID = id;
            InitializeComponent();
            SetView();
        }
        public void SetView()
        {
            if (ID == 0)
            {
                
            }
            else
            {
                NhanVien nv = BLL_Staff.Instance.Get_NhanVien_ById(ID);
                Account ac = BLL_Staff.Instance.Get_Account_ById(ID);
                txt_TenNV.Text = nv.Name;
                if (nv.Gender == "Nam")
                {
                    radioBtn_Male.Checked = true;
                }
                else
                {
                    radioBtn_Female.Checked = true;
                }
                dateTimePicker_DOB.Value = nv.DOB;
                txt_CMND.Text = nv.CMND;
                txt_QueNV.Text = nv.QueQuan;
                txt_DiaChi.Text = nv.DiaChi;
                txt_Email.Text = nv.Email;
                txt_Phone.Text = nv.Phone;
                txt_userName.Text = ac.UserName;
                txt_displayName.Text = ac.DisplayName;
            }
        }

        //events
        private void txt_TenNV_TextChanged(object sender, EventArgs e)
        {
            txt_userName.Text = BLL_Staff.Instance.Name_to_Username(txt_TenNV.Text)
                                    + (BLL_Staff.Instance.Get_Lastest_ID() + 1).ToString();
            txt_displayName.Text = txt_TenNV.Text;
        }
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_setPass_Click(object sender, EventArgs e)
        {
            txt_password.Text = BLL_Staff.Instance.Random();
        }

        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            if (ID == 0)
            {
                string gender = "";
                if (radioBtn_Male.Checked)
                {
                    gender = radioBtn_Male.Text;
                }
                else if (radioBtn_Female.Checked)
                {
                    gender = radioBtn_Female.Text;
                }
                DateTime dob = dateTimePicker_DOB.Value;
                string name = txt_TenNV.Text;
                string cmnd = txt_CMND.Text;
                string quequan = txt_QueNV.Text;
                string diachi = txt_DiaChi.Text;
                string email = txt_Email.Text;
                string phone = txt_Phone.Text;
                BLL_Staff.Instance.Add_Staff(name, gender, dob, cmnd, quequan, diachi, email, phone);

                string username = txt_userName.Text;
                string pass = txt_password.Text;
                string displayname = txt_displayName.Text;
                int id_nv = BLL.BLL_Staff.Instance.Get_Lastest_ID();
                BLL_Staff.Instance.Add_Account(username,id_nv, displayname, pass);

            }
            else
            {
                string gender = "";
                if (radioBtn_Male.Checked)
                {
                    gender = radioBtn_Male.Text;
                }
                else if (radioBtn_Female.Checked)
                {
                    gender = radioBtn_Female.Text;
                }
                DateTime dob = Convert.ToDateTime(dateTimePicker_DOB.Value);
                string name = txt_TenNV.Text;
                string cmnd = txt_CMND.Text;
                string quequan = txt_QueNV.Text;
                string diachi = txt_DiaChi.Text;
                string email = txt_Email.Text;
                string phone = txt_Phone.Text;
                string pass = txt_password.Text;
                BLL_Staff.Instance.Edit_Staff(ID, name, gender, dob, cmnd, quequan, diachi, email, phone, pass);
            }

            this.Close();
        }

       
    }
}
