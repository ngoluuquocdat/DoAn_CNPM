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
    public partial class Account_Control : UserControl
    {
        private static Account_Control _instance;
        public static Account_Control Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Account_Control();
                return _instance;
            }
        }
        public Account_Control()
        {
            InitializeComponent();

        }

        private void btn_changePass_Click(object sender, EventArgs e)
        {
            txt_OldPass.Clear();
            txt_NewPass.Clear();
            txt_ConfirmPass.Clear();
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            txt_OldPass.Visible = true;
            txt_NewPass.Visible = true;
            txt_ConfirmPass.Visible = true;
            btn_Confirm.Visible = true;
            btn_Cancel.Visible = true;
            btn_changePass.Visible = false;
            label_Success.Visible = false;
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            txt_OldPass.Clear();
            txt_NewPass.Clear();
            txt_ConfirmPass.Clear();
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            txt_OldPass.Visible = false;
            txt_NewPass.Visible = false;
            txt_ConfirmPass.Visible = false;
            btn_Confirm.Visible = false;
            btn_Cancel.Visible = false;
            btn_changePass.Visible = true;
            label_WarningNew.Visible = false;
            label_WarningCheck.Visible = false;
            label_WarningCf.Visible = false;
            label_WarningOld.Visible = false;
        }

        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            string oldpass = txt_OldPass.Text;
            string newpass = txt_NewPass.Text;
            string confirmpass = txt_ConfirmPass.Text;
            Account ac = BLL_Account.Instance.CheckOldPass(oldpass);
            if (ac != null)
            {
                if (ac.PassWord == oldpass)
                {
                    if (!BLL_Account.Instance.CheckNewPass(newpass))
                    {
                        label_WarningNew.Visible = true;
                    }
                    else
                    {
                        if (newpass == oldpass)
                        {
                            label_WarningCheck.Visible = true;
                        }
                        else
                        {
                            if (confirmpass != newpass)
                            {
                                label_WarningCf.Visible = true;
                            }
                            else
                            {
                                MessageBox.Show("ok");
                                label1.Visible = false;
                                label2.Visible = false;
                                label3.Visible = false;
                                txt_OldPass.Visible = false;
                                txt_NewPass.Visible = false;
                                txt_ConfirmPass.Visible = false;
                                btn_Confirm.Visible = false;
                                btn_Cancel.Visible = false;
                                btn_changePass.Visible = true;
                                label_Success.Visible = true;
                                BLL_Account.Instance.UpdatePass(Convert.ToInt32(ac.idNhanVien), newpass);
                            }
                        }
                    }
                }
                else
                {
                    label_WarningOld.Visible = true;
                }
            }
            else
            {
                label_WarningOld.Visible = true;
            }    
            
        }

        private void txt_NewPass_Click(object sender, EventArgs e)
        {
            label_WarningNew.Visible = false;
            label_WarningCheck.Visible = false;
        }

        private void txt_ConfirmPass_Click(object sender, EventArgs e)
        {
            label_WarningCf.Visible = false;
        }

        private void txt_OldPass_Click(object sender, EventArgs e)
        {
            label_WarningOld.Visible = false;
        }
    }
}
