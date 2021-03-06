﻿using QuanLyCuaHangGear.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHangGear
{
    public partial class Form_Admin : Form
    {
        // fields

        // constuctor

        public int Id_nv { get; set; }
        public Form_Admin(int id_nv)
        {
            this.Id_nv = id_nv;
            InitializeComponent();        
            
            panel_Slide.Visible = false;
            panel_Main.Controls.Add(Welcome_Control.Instance);
            Welcome_Control.Instance.Dock = DockStyle.Fill;
            Welcome_Control.Instance.BringToFront();

        }

        // methods

        public void Reset_Button_Effect()
        {
            btn_Staff.ForeColor = Color.White;
            btn_Staff.Font = new Font(btn_Staff.Font.FontFamily, 12);

            btn_Product.ForeColor = Color.White;
            btn_Product.Font = new Font(btn_Product.Font.FontFamily, 12);

            btn_Report.ForeColor = Color.White;
            btn_Report.Font = new Font(btn_Report.Font.FontFamily, 12);

            btn_Account.ForeColor = Color.White;
            btn_Account.Font = new Font(btn_Account.Font.FontFamily, 12);

            btn_Bill.ForeColor = Color.White;
            btn_Bill.Font = new Font(btn_Bill.Font.FontFamily, 12);

            btn_Import.ForeColor = Color.White;
            btn_Import.Font = new Font(btn_Import.Font.FontFamily, 12);


            btn_Staff.BackColor = Color.FromArgb(40, 42, 75);
            btn_Product.BackColor = Color.FromArgb(40, 42, 75);
            btn_Report.BackColor = Color.FromArgb(40, 42, 75);
            btn_Account.BackColor = Color.FromArgb(40, 42, 75);
            btn_Bill.BackColor = Color.FromArgb(40, 42, 75);
            btn_Import.BackColor = Color.FromArgb(40, 42, 75);

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
            btn.Font = new Font(btn.Font.FontFamily, 14);
            btn.BackColor = Color.FromArgb(52, 54, 87);
            btn.ForeColor = Color.FromArgb(98, 225, 225);
            btn.TextImageRelation = TextImageRelation.TextBeforeImage;
            btn.ImageAlign = ContentAlignment.MiddleRight;
            
            panel_Slide.Top = btn.Top;
            panel_Slide.Visible = true;
            label_UpperLogo.Text = btn.Text;
        }


        // events
      
        private void pic_StoreLogo_Click(object sender, EventArgs e)
        {
            Reset_Button_Effect();
            panel_Slide.Visible = false;
            label_UpperLogo.Text = "";
            pic_UpperLogo.Image = Properties.Resources.Store_Logo;
            
            Welcome_Control.Instance.BringToFront();
        }
        private void btn_Staff_Click(object sender, EventArgs e)
        {
            Active_Effect((Button)sender);
            btn_Staff.Image = Properties.Resources.Blue_Staff;
            pic_UpperLogo.Image = Properties.Resources.Blue_Staff;

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
            
            if (!panel_Main.Controls.Contains(Bill_Control.Instance))
            {               
                panel_Main.Controls.Add(Bill_Control.Instance);
                Bill_Control.Instance.Dock = DockStyle.Fill;
                Bill_Control.Instance.BringToFront();

                Bill_Control.Instance.Id_NV = Convert.ToInt32(Id_nv);
            }
            else
                Bill_Control.Instance.BringToFront();
        }

        private void btn_Import_Click(object sender, EventArgs e)
        {
            Active_Effect((Button)sender);
            btn_Import.Image = Properties.Resources.blue_import;
            pic_UpperLogo.Image = Properties.Resources.blue_import;
            
            if (!panel_Main.Controls.Contains(Import_Control.Instance))
            {
                panel_Main.Controls.Add(Import_Control.Instance);
                Import_Control.Instance.Dock = DockStyle.Fill;
                Import_Control.Instance.BringToFront();

                Import_Control.Instance.Id_NV = Convert.ToInt32(Id_nv);
            }
            else
                Import_Control.Instance.BringToFront();
        }

        private void btn_Account_Click(object sender, EventArgs e)
        {
            Active_Effect((Button)sender);
            btn_Account.Image = Properties.Resources.blue_user;
            pic_UpperLogo.Image = Properties.Resources.blue_user;
            Account_Control.Instance.Id_NV = Convert.ToInt32(Id_nv);
            Account_Control.Instance.SetView();
            if (!panel_Main.Controls.Contains(Account_Control.Instance))
            {
                panel_Main.Controls.Add(Account_Control.Instance);
                Account_Control.Instance.Dock = DockStyle.Fill;
                Account_Control.Instance.BringToFront();
            }
            else {
                Account_Control.Instance.BringToFront();
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void Form_Admin_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void Form_Admin_FormClosed(object sender, FormClosedEventArgs e)
        {
            
           // this.DialogResult = DialogResult.OK;
            //this.Dispose();
        }
    }
}
