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
    public partial class Form_Admin : Form
    {
        // fields
        
        // constuctor
        public Form_Admin()
        {
            InitializeComponent();
            panel_Slide.Visible = false;
            // welcome_Control1.BringToFront();
                panel_Main.Controls.Add(Welcome_Control.Instance);
                Welcome_Control.Instance.Dock = DockStyle.Fill;
                Welcome_Control.Instance.BringToFront();

        }

        // methods

        public void Reset_Button_Effect()
        {
            btn_Staff.ForeColor = Color.White;
            btn_Product.ForeColor = Color.White;
            btn_Report.ForeColor = Color.White;
            btn_Account.ForeColor = Color.White;
            btn_Bill.ForeColor = Color.White;
            btn_Import.ForeColor = Color.White;

            btn_Staff.BackColor = Color.FromArgb(40, 42, 65);
            btn_Product.BackColor = Color.FromArgb(40, 42, 65);
            btn_Report.BackColor = Color.FromArgb(40, 42, 65);
            btn_Account.BackColor = Color.FromArgb(40, 42, 65);
            btn_Bill.BackColor = Color.FromArgb(40, 42, 65);
            btn_Import.BackColor = Color.FromArgb(40, 42, 65);

            btn_Staff.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Staff.ImageAlign = ContentAlignment.MiddleLeft;

            btn_Product.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Product.ImageAlign = ContentAlignment.MiddleLeft;


            btn_Report.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Report.ImageAlign = ContentAlignment.MiddleLeft;

            btn_Account.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Account.ImageAlign = ContentAlignment.MiddleLeft;

            btn_Bill.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Bill.ImageAlign = ContentAlignment.MiddleLeft;

            btn_Import.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Import.ImageAlign = ContentAlignment.MiddleLeft;

            btn_Staff.Image = Properties.Resources.Staff;
            btn_Product.Image = Properties.Resources.Product;
            btn_Report.Image = Properties.Resources.money;
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
      
        private void pic_StoreLogo_Click(object sender, EventArgs e)
        {
            Reset_Button_Effect();
            panel_Slide.Visible = false;
            label_UpperLogo.Text = "";
            pic_UpperLogo.Image = Properties.Resources.Store_Logo;
            //  welcome_Control1.BringToFront();
            Welcome_Control.Instance.BringToFront();
        }
        private void btn_Staff_Click(object sender, EventArgs e)
        {
            Active_Effect((Button)sender);
            btn_Staff.Image = Properties.Resources.Blue_Staff;
            pic_UpperLogo.Image = Properties.Resources.Blue_Staff;
            //  staff_Control1.BringToFront();
            if (!panel_Main.Controls.Contains(Staff_Control.Instance))
            {
                panel_Main.Controls.Add(Staff_Control.Instance);
                Staff_Control.Instance.Dock = DockStyle.Fill;
                Staff_Control.Instance.BringToFront();
            }
            else
                Staff_Control.Instance.BringToFront();

        }

        private void btn_Product_Click(object sender, EventArgs e)
        {
            Active_Effect((Button)sender);
            btn_Product.Image = Properties.Resources.Product_blue;
            pic_UpperLogo.Image = Properties.Resources.Product_blue;
            //product_Control1.BringToFront();    
            if (!panel_Main.Controls.Contains(Product_Control.Instance))
            {
                panel_Main.Controls.Add(Product_Control.Instance);
                Product_Control.Instance.Dock = DockStyle.Fill;
                Product_Control.Instance.BringToFront();
            }
            else
                Product_Control.Instance.BringToFront();
        }

        private void btn_Report_Click(object sender, EventArgs e)
        {
            Active_Effect((Button)sender);
            btn_Report.Image = Properties.Resources.Blue_money;
            pic_UpperLogo.Image = Properties.Resources.Blue_money;
            // report_Control1.BringToFront();
            if (!panel_Main.Controls.Contains(Report_Control.Instance))
            {
                panel_Main.Controls.Add(Report_Control.Instance);
                Report_Control.Instance.Dock = DockStyle.Fill;
                Report_Control.Instance.BringToFront();
            }
            else
                Report_Control.Instance.BringToFront();
        }
           
        private void btn_Bill_Click(object sender, EventArgs e)
        {
            Active_Effect((Button)sender);
            btn_Bill.Image = Properties.Resources.blue_bill;
            pic_UpperLogo.Image = Properties.Resources.blue_bill;
            //bill_Control1.BringToFront();
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
            //import_Control1.BringToFront();
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
            //account_Control1.BringToFront();
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
        private void Form_Admin_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void Form_Admin_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Form_Login f_Log = new Form_Login();
            //f_Log.Show();
            this.DialogResult = DialogResult.OK;
            //this.Dispose();
        }
    }
}
