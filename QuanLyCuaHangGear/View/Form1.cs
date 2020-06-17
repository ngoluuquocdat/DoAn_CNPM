using QuanLyCuaHangGear.View;
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
    public partial class Form_Login : Form
    {
        // 

        // constuctor
        public Form_Login()
        {
            InitializeComponent();
        }

        // methods

        public bool Check_Username(string username)
        {
            if (username != "1" && username != "2")
            {
                label_Warning.Visible = true;
                return false;
            }          
            return true;
        }
        public bool Check_Password(string password)
        {
            if (password != "1" && password != "2")
            {
                label_Warning.Visible = true;
                
                return false;
            }
            return true;
        }
        public void Reset_TextBoxes()
        {
            txt_Username.Text = "Username";
            txt_Password.Text = "Password";
            txt_Password.PasswordChar = '\0';   // '/0' is a 'null character'. 1 cách hợp lệ để diễn đạt 1 kí tự 'trống'
            // txt_Password.PasswordChar = new char();
            label_Warning.Visible = false;
        }

        // event 
        private void txt_Username_Click(object sender, EventArgs e)
        {
            txt_Username.Clear();
            pic_Username.Image = Properties.Resources.user;
            
        }

        private void txt_Password_Click(object sender, EventArgs e)
        {
            txt_Password.Clear();
            pic_Password.Image = Properties.Resources.pass;
            
            txt_Password.PasswordChar = '*';
        }

        private void label_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form_Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("             Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;    // thuộc tính cancel của event, set = true thì không thực hiện.
            }
        }

        
        private void btn_SignUp_Click(object sender, EventArgs e)
        {
            if (txt_Username.Text == "Username")
            {
                txt_Username.Clear();
            }
            if (txt_Password.Text == "Password")
            {
                txt_Password.Clear();
            }
            if (!Check_Username(txt_Username.Text))
            {
                pic_Username.Image = Properties.Resources.Red_Username;
                pic_Password.Image = Properties.Resources.Red_Password;
                return;
            }
            if (!Check_Password(txt_Password.Text))
            {
                pic_Password.Image = Properties.Resources.Red_Password;
                return;
            }
            if(txt_Username.Text == "1" && txt_Password.Text == "1")
            {
                Form_Admin f_admin = new Form_Admin();
                this.Hide();
                f_admin.ShowDialog();

                this.Show();
                Reset_TextBoxes();                                    
            }
            if (txt_Username.Text == "2" && txt_Password.Text == "2")
            {
                Form_Staff f_staff = new Form_Staff();
                this.Hide();
                f_staff.ShowDialog();

                this.Show();
                Reset_TextBoxes();
            }
        }
    }
}
