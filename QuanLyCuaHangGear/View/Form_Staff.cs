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
    public partial class Form_Staff : Form
    {
        // fields

        // constuctor
        public Form_Staff()
        {
            InitializeComponent();
            panel_Slide.Visible = false;
            //welcome_Control1.BringToFront();
                panel_Main.Controls.Add(Welcome_Control.Instance);
                Welcome_Control.Instance.Dock = DockStyle.Fill;
                Welcome_Control.Instance.BringToFront();
            
        }
        // methods

        public void Reset_Button_Effect()
        {          
            btn_Account.ForeColor = Color.White;
            btn_Bill.ForeColor = Color.White;
            btn_Import.ForeColor = Color.White;
          
            btn_Account.BackColor = Color.FromArgb(40, 42, 65);
            btn_Bill.BackColor = Color.FromArgb(40, 42, 65);
            btn_Import.BackColor = Color.FromArgb(40, 42, 65);

            btn_Account.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Account.ImageAlign = ContentAlignment.MiddleLeft;

            btn_Bill.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Bill.ImageAlign = ContentAlignment.MiddleLeft;

            btn_Import.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Import.ImageAlign = ContentAlignment.MiddleLeft;
           
            btn_Account.Image = Properties.Resources.user;
            btn_Bill.Image = Properties.Resources.bill;
            btn_Import.Image = Properties.Resources.import;

        }

        public void Active_Effect(Button btn)
        {
            Reset_Button_Effect();
            btn.BackColor = Color.FromArgb(52, 54, 77);
            btn.ForeColor = Color.FromArgb(98, 225, 225);
            btn.TextImageRelation = TextImageRelation.TextBeforeImage;
            btn.ImageAlign = ContentAlignment.MiddleRight;
            panel_Slide.Visible = true;
            panel_Slide.Top = btn.Top;
            label_UpperLogo.Text = btn.Text;
        }

        // events
        private void btn_Bill_Click(object sender, EventArgs e)
        {
            Active_Effect((Button)sender);
            btn_Bill.Image = Properties.Resources.blue_bill;
            pic_UpperLogo.Image = Properties.Resources.blue_bill;
            // bill_Control1.BringToFront();
            if (!panel_Main.Controls.Contains(Bill_Control.Instance))
            {
                panel_Main.Controls.Add(Bill_Control.Instance);
                Bill_Control.Instance.Dock = DockStyle.Fill;
                Bill_Control.Instance.BringToFront();
            }
            else
                Bill_Control.Instance.BringToFront();
        }

        private void btn_Import_Click(object sender, EventArgs e)
        {
            Active_Effect((Button)sender);
            btn_Import.Image = Properties.Resources.blue_import;
            pic_UpperLogo.Image = Properties.Resources.blue_import;
            // import_Control1.BringToFront();
            if (!panel_Main.Controls.Contains(Import_Control.Instance))
            {
                panel_Main.Controls.Add(Import_Control.Instance);
                Import_Control.Instance.Dock = DockStyle.Fill;
                Import_Control.Instance.BringToFront();
            }
            else
                Import_Control.Instance.BringToFront();
        }

        private void btn_Account_Click(object sender, EventArgs e)
        {
            Active_Effect((Button)sender);
            btn_Account.Image = Properties.Resources.blue_user;
            pic_UpperLogo.Image = Properties.Resources.blue_user;
            // account_Control1.BringToFront();
            if (!panel_Main.Controls.Contains(Account_Control.Instance))
            {
                panel_Main.Controls.Add(Account_Control.Instance);
                Account_Control.Instance.Dock = DockStyle.Fill;
                Account_Control.Instance.BringToFront();
            }
            else
                Account_Control.Instance.BringToFront();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_Staff_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;          
        }

        private void pic_StoreLogo_Click(object sender, EventArgs e)
        {
            Welcome_Control.Instance.BringToFront();
        }
    }
}
