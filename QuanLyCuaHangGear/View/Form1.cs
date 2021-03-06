﻿using QuanLyCuaHangGear.BLL;
using QuanLyCuaHangGear.DTO;
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

        
        public void Reset_TextBoxes()
        {
            txt_Username.Text = "Username";
            txt_Password.Text = "Password";
            txt_Password.PasswordChar = '\0';   // '/0' is a 'null character'. 1 cách hợp lệ để diễn đạt 1 kí tự 'trống'
            // txt_Password.PasswordChar = new char();
            label_Warning.Visible = false;
        }

        // events
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

            string UserName = txt_Username.Text;
            string PassWord = BLL_Account.Instance.MaHoa(txt_Password.Text);
            Account ac = BLL_Account.Instance.Get_Account(UserName);
            if (ac != null)
            {

                if (ac.PassWord != PassWord)
                {
                    pic_Password.Image = Properties.Resources.Red_Password;
                    label_Warning.Visible = true;
                }
                else
                {
                    if (ac.Type == 0)
                    {
                        Form_Admin f_admin = new Form_Admin(Convert.ToInt32(ac.idNhanVien));
                        this.Hide();
                        f_admin.ShowDialog();

                        this.Show();
                        Reset_TextBoxes();
                    }
                    else
                    {
                        Form_Staff f_staff = new Form_Staff(Convert.ToInt32(ac.idNhanVien));
                        this.Hide();
                        f_staff.ShowDialog();

                        this.Show();
                        Reset_TextBoxes();
                    }
                }
            }
            else
            {
                MessageBox.Show("Sai ussername");
                pic_Username.Image = Properties.Resources.Red_Username;
                pic_Password.Image = Properties.Resources.Red_Password;
                label_Warning.Visible = true;
                return;
            }
        }
    }
}
