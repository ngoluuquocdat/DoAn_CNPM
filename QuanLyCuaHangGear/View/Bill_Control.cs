﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyCuaHangGear.DTO;
using QuanLyCuaHangGear.BLL;

namespace QuanLyCuaHangGear
{
    public partial class Bill_Control : UserControl
    {
        DataTable dt;
        int id_NV;
        private static Bill_Control _instance;
        public static Bill_Control Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Bill_Control();
                return _instance;
            }
        }

        public int Id_NV { get => id_NV; set => id_NV = value; }

        // constructor
        private Bill_Control()
        {
            InitializeComponent();
            dateTimePicker1.Value = DateTime.Now;
            Create_Datatable();
        }
        // methods
        public void Create_Datatable()
        {
            dt = new DataTable();
            dt.Columns.Add("Mã hàng", typeof(String));
            dt.Columns.Add("Tên hàng", typeof(String));
            dt.Columns.Add("Số lượng", typeof(int));
            dt.Columns.Add("Đơn giá", typeof(int));
        }
        public int update_tongtien()
        {
            int tongtien = 0;
            foreach(DataRow row in dt.Rows)
            {
                tongtien += (Convert.ToInt32(row["Số lượng"]) 
                              * Convert.ToInt32(row["Đơn giá"]));
            }

            return tongtien;
        }
        // events
        private void btn_SearchID_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txt_id_hang.Text);
            HangHoa h = BLL_Product.Instance.Get_HangHoa_by_ID(id);
            txt_danhmuc.Text = BLL_Product.Instance.Get_DanhMuc_by_ID(h.idDanhMuc).Name;
            txt_tenhang.Text = h.Name;
            numUpDown_count.Maximum = h.SoLuong;
        }

        private void btn_SearchPhone_Click(object sender, EventArgs e)
        {
            string phone = txt_phone.Text;
            KhachHang provider = BLL_Customer.Instance.Get_Customer(phone);
            if (provider == null)
            {
                MessageBox.Show("Khách hàng này chưa được lưu.");
                btn_Add_Customer.Visible = true;
            }
            else
            {
                txt_name_customer.Text = provider.Name;
                txt_email.Text = provider.Email;
            }
        }

        private void btn_Add_Customer_Click(object sender, EventArgs e)
        {
            string name = txt_name_customer.Text;
            string phone = txt_phone.Text;
            string email = txt_email.Text;
            BLL_Customer.Instance.Add_Customer(name, phone, email);
        }

        

        private void btn_add_to_bill_Click(object sender, EventArgs e)
        {
            DataRow dr = dt.NewRow();
            int id = Convert.ToInt32(txt_id_hang.Text);
            HangHoa h = BLL_Product.Instance.Get_HangHoa_by_ID(id);

            dr["Mã hàng"] = id;
            dr["Tên hàng"] = h.Name;
            dr["Số lượng"] = numUpDown_count.Value;
            dr["Đơn giá"] = h.DonGiaBan;

            dt.Rows.Add(dr);
            dtgv_buy.DataSource = dt;


            txt_Total.Text = update_tongtien() + "";
        }

        private void btn_del_from_bill_Click(object sender, EventArgs e)
        {
            int index = dtgv_buy.SelectedRows[0].Index;
            int soluong = Convert.ToInt32(dt.Rows[index]["Số lượng"]);
            if (soluong > 1)
            {
                dt.Rows[index]["Số lượng"] = --soluong;
            }
            else
            {
                dt.Rows.Remove(dt.Rows[index]);
            }
            
            txt_Total.Text = update_tongtien() + "";
        }

        private void txt_id_hang_Click(object sender, EventArgs e)
        {
            txt_id_hang.Clear();
            txt_danhmuc.Clear();
            txt_tenhang.Clear();
            numUpDown_count.Value=0;
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            string customer_name;
            string phone;
            string staff_name;
            string cmnd;
            DateTime date = dateTimePicker1.Value;
            if (this.Id_NV == 0)
            {
                staff_name = "Ngô Lưu Quốc Đạt";
                cmnd = "206282345";
            }
            else
            {
                NhanVien nv = BLL_Staff.Instance.Get_NhanVien_by_ID(this.Id_NV);               
                staff_name = nv.Name;
                cmnd = nv.CMND;
            }

            customer_name = txt_name_customer.Text;
            phone = txt_phone.Text;
            
            BLL_Bill.Instance.Add_Bill(date, customer_name, phone, staff_name,cmnd, 1, update_tongtien());

            int id_bill = BLL_Bill.Instance.Get_Lastest_Bill().id;
            
            foreach (DataRow row in dt.Rows)
            {
                int id_hanghoa = Convert.ToInt32(row["Mã hàng"]);
                HangHoa h = BLL_Product.Instance.Get_HangHoa_by_ID(id_hanghoa);
                string danhmuc = BLL_Product.Instance.Get_DanhMuc_by_ID(h.idDanhMuc).Name;
                int soluong = Convert.ToInt32(row["Số lượng"]);
                BLL_Bill.Instance.Add_Bill_Info(id_bill, h.Name, danhmuc,h.DonGiaBan,soluong);
                BLL_Product.Instance.Update_SoLuong(id_hanghoa, -soluong);
            }

        }

        private void txt_phone_Click(object sender, EventArgs e)
        {
            txt_phone.Clear();
            txt_name_customer.Clear();
            txt_email.Clear();
            btn_Add_Customer.Visible = false;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            txt_id_hang.Clear();
            txt_danhmuc.Clear();
            txt_tenhang.Clear();
            numUpDown_count.Value = 0;

            txt_name_customer.Clear();
            txt_phone.Clear();
            txt_email.Clear();

            txt_Total.Clear();
            dt = null;
            dtgv_buy.DataSource = dt;
        }

        
    }
}
