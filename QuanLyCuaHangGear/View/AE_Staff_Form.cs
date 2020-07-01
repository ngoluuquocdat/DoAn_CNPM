using QuanLyCuaHangGear.BLL;
using QuanLyCuaHangGear.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
                // add
                btn_setPass.Visible = false;
                btn_done.Visible = false;
            }
            else
            {
                // edit
                btn_setPass.Visible = true;
                NhanVien nv = BLL_Staff.Instance.Get_NhanVien_by_ID(ID);
                Account ac = BLL_Account.Instance.Get_Account_by_ID(ID);
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
        public bool isEmail(string email)
        {
           // email = email ?? string.Empty;
            string strPattern = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                  @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                  @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            Regex re = new Regex(strPattern);
            if (re.IsMatch(email))
                return true;
            else
                return false;
        }
        public bool isPhone(string phone)
        {
            string strPattern = @"^[0-9]{10,11}$";
            Regex re = new Regex(strPattern);
            if (re.IsMatch(phone))
                return true;
            else
                return false;
        }
        public bool isCMND(string cmnd)
        {
            string strPattern = @"^[0-9]{9}$";
            Regex re = new Regex(strPattern);
            if (re.IsMatch(cmnd))
                return true;
            else
                return false;
        }
        public bool Check_Staff_Info()
        {
            bool check = true;
            // check ten
            if (txt_TenNV.Text == "")
            {
                label_name_null.Visible = true;
                check = false;
            }
            // check cmnd
            if (txt_CMND.Text == "")
            {
                label_cmnd_null.Visible = true;
                check = false;
            }
            else
            {
                if (!isCMND(txt_CMND.Text))
                {
                    label_CMND_invalid.Visible = true;
                    check = false;
                }
            }
            // check dia chi
            if (txt_DiaChi.Text == "")
            {
                label_diachi_null.Visible = true;
                check = false;
            }
            // check que quan
            if (txt_QueNV.Text == "")
            {
                label_que_null.Visible = true;
                check = false;
            }
            // check email
            if (txt_Email.Text == "")
            {
                label_email_null.Visible = true;
                check = false;
            }
            else
            {
                if(!isEmail(txt_Email.Text))
                {
                    label_email_invalid.Visible = true;
                    check = false;
                }
            }
            // check phone
            if (txt_Phone.Text == "")
            {
                label_phone_null.Visible = true;
                check = false;
            }
            else
            {
                if (!isPhone(txt_Phone.Text))
                {
                    label_phone_invalid.Visible = true;
                    check = false;
                }
            }
            return check;
        }
        //events
        private void txt_TenNV_TextChanged(object sender, EventArgs e)
        {
            //txt_userName.Text = BLL_Staff.Instance.Name_to_Username(txt_TenNV.Text)
            //                        + (BLL_Staff.Instance.Get_Lastest_ID() + 1).ToString();
            //txt_displayName.Text = txt_TenNV.Text;
        }
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_setPass_Click(object sender, EventArgs e)
        {
           // label_pass_null.Visible = false;
            txt_password.Text = BLL_Staff.Instance.Random();
        }

        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            btn_Confirm.Visible = true;
            btn_Cancel.Visible = true; 
            if (ID == 0)
            {
                // add
                if (Check_Staff_Info())
                {
                    // info nhan vien
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

                    // info tai khoan
                    string username = BLL_Staff.Instance.Name_to_Username(txt_TenNV.Text)
                                    + (BLL_Staff.Instance.Get_Lastest_ID()).ToString();
                    string pass = BLL_Staff.Instance.Random();
                    string pass_mahoa;                    
                    pass_mahoa = BLL_Account.Instance.MaHoa(pass);                   
                                      
                    string displayname = txt_TenNV.Text;
                    
                    int id_nv = BLL.BLL_Staff.Instance.Get_Lastest_ID();

                    
                    BLL_Account.Instance.Add_Account(username, id_nv, displayname, pass_mahoa);

                    MessageBox.Show("Đã thêm nhân viên!");
                    label_info_acc.Visible = true;
                    // show info tài khoản
                    txt_userName.Text = username;
                    txt_displayName.Text = displayname;
                    txt_password.Text = pass;
                    //MessageBox.Show("Đã thêm nhân viên mới!\n"+ 
                    //                "Tài khoản nhân viên:"+username+" \n"+
                    //                "Mật khẩu:" +pass+ " \n");
                    btn_Confirm.Visible = false;
                    btn_Cancel.Visible = false;
                    btn_done.Visible = true;
                }
                else
                {
                    
                }

            }
            else
            {
                // edit
                if (Check_Staff_Info())
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
                    string pass = BLL_Account.Instance.MaHoa(txt_password.Text);
                    BLL_Staff.Instance.Edit_Staff(ID, name, gender, dob, cmnd, quequan, diachi, email, phone, pass);
                    MessageBox.Show("Đã cập nhật thông tin!");
                    this.Close();
                }
                else
                {
                    
                }
            }           
        }

        private void txt_TenNV_Click(object sender, EventArgs e)
        {
            label_name_null.Visible = false;
        }

        private void txt_CMND_Click(object sender, EventArgs e)
        {
            label_cmnd_null.Visible = false;
            label_CMND_invalid.Visible = false;
        }

        private void txt_QueNV_Click(object sender, EventArgs e)
        {
            label_que_null.Visible = false;
        }

        private void txt_DiaChi_Click(object sender, EventArgs e)
        {
            label_diachi_null.Visible = false;
        }

        private void txt_Phone_Click(object sender, EventArgs e)
        {
            label_phone_null.Visible = false;
            label_phone_invalid.Visible = false;
        }

        private void txt_Email_Click(object sender, EventArgs e)
        {
            label_email_null.Visible = false;
            label_email_invalid.Visible = false;
        }

        private void panel_Down_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AE_Staff_Form_Load(object sender, EventArgs e)
        {
            
        }

        private void AE_Staff_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
