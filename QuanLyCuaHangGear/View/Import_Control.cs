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
using QuanLyCuaHangGear.View;

namespace QuanLyCuaHangGear
{
    public partial class Import_Control : UserControl
    {
        DataTable dt = new DataTable();
        int id_NV;
        private static Import_Control _instance;
        public static Import_Control Instance
        {
            get
            {
                if (_instance == null || _instance.IsDisposed)
                    _instance = new Import_Control();
                return _instance;
            }
        }

        public int Id_NV { get => id_NV; set => id_NV = value; }

        public Import_Control()
        {
            InitializeComponent();
            dateTimePicker1.Value = DateTime.Now;
            Create_Datatable();
            SetCBB();
            txt_Total.Text = "0";
        }
        // methods
        public void Create_Datatable()
        {
            dt.Columns.Add("Mã hàng", typeof(String));
            dt.Columns.Add("Tên hàng", typeof(String));
            dt.Columns.Add("Số lượng", typeof(int));
            dt.Columns.Add("Đơn giá", typeof(int));
        }
        public void SetCBB()
        {
            if (cbb_provider.Items != null)
            {
                cbb_provider.Items.Clear();
            }
            cbb_provider.Items.Add(new CBBItems
            {
                Value = 0,
                Text = "(Nhà cung cấp)"
            });
            foreach (KhachHang i in BLL_Customer.Instance.Get_Providers())
            {
                cbb_provider.Items.Add(new CBBItems
                {
                    Value = i.id,
                    Text = i.Name
                });
            }
            cbb_provider.SelectedIndex = 0;
        }
        public int update_tongtien()
        {
            int tongtien = 0;
            foreach (DataRow row in dt.Rows)
            {
                tongtien += (Convert.ToInt32(row["Số lượng"])
                              * Convert.ToInt32(row["Đơn giá"]));
            }

            return tongtien;
        }
        public bool check_HangHoa_info()
        {
            bool check = true;
            if (txt_id_hang.Text == "")
            {
                label_id_null.Visible = true;
                check = false;
            }
            if (txt_tenhang.Text == "")
            {
                label_tenhang_null.Visible = true;
                check = false;
            }
            if (txt_danhmuc.Text == "")
            {
                label_category_null.Visible = true;
                check = false;
            }
            //if (numUpDown_count.Value == 0)
            //{
            //    label_soldout.Visible = true;
            //    check = false;
            //}
            return check;
        }
        public bool check_NhaCungCap_info()
        {
            if (cbb_provider.SelectedIndex == 0)
            {
                label_ten_provi_null.Visible = true;
                return false;
            }

            return true;
        }
        public bool check_tongtien()
        {
            if (txt_Total.Text == "0")
            {
                label_bill_info_null.Visible = true;
                return false;
            }
            return true;
        }
        //events
        private void btn_SearchID_Click(object sender, EventArgs e)
        {
            if (txt_id_hang.Text == "")
            {
                return;
            }
            int id;
            try
            {
                id = Convert.ToInt32(txt_id_hang.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Sai định dạng mã hàng");
                return;
            }
            HangHoa h = BLL_Product.Instance.Get_HangHoa_by_ID(id);
            if (h == null)
            {
                MessageBox.Show("Không tìm thấy hàng hóa có mã: " + id);
                return;
            }
            label_tenhang_null.Visible = false;
            label_category_null.Visible = false;
            txt_danhmuc.Text = BLL_Product.Instance.Get_DanhMuc_by_ID(h.idDanhMuc).Name;
            txt_tenhang.Text = h.Name;
            numUpDown_count.Minimum = 1;
        }
     
        private void btn_Add_Import_Click(object sender, EventArgs e)
        {
            if (check_HangHoa_info())
            {
                label_bill_info_null.Visible = false;
                bool isExist = false;
                int id = Convert.ToInt32(txt_id_hang.Text);
                HangHoa h = BLL_Product.Instance.Get_HangHoa_by_ID(id);
                //dt null
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (h.id == Convert.ToInt32(dt.Rows[i]["Mã hàng"].ToString()))
                    {
                        dtgv_import.Rows[i].Selected = true;
                        int current_soluong = Convert.ToInt32(dt.Rows[i]["Số lượng"].ToString());
                        dt.Rows[i]["Số lượng"] = current_soluong + numUpDown_count.Value;
                        isExist = true;
                    }
                }

                if (isExist == false)
                {
                    DataRow dr = dt.NewRow();
                    dr["Mã hàng"] = id;
                    dr["Tên hàng"] = h.Name;
                    dr["Số lượng"] = numUpDown_count.Value;
                    dr["Đơn giá"] = h.DonGiaBan;
                    dt.Rows.Add(dr);
                    if (dtgv_import.Rows.Count > 0)
                        dtgv_import.Rows[dtgv_import.Rows.Count - 1].Selected = true;
                }

                dtgv_import.DataSource = dt;


                txt_Total.Text = update_tongtien() + "";
            }
            else
                return;
            
        }

        private void btn_del_from_imp_Click(object sender, EventArgs e)
        {
            if (dtgv_import.SelectedRows.Count == 1)
            {
                int index = dtgv_import.SelectedRows[0].Index;
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
        }

        private void txt_id_hang_Click(object sender, EventArgs e)
        {
            //label_soldout.Visible = false;
            label_id_null.Visible = false;
            label_tenhang_null.Visible = false;
            label_category_null.Visible = false;

            txt_id_hang.Clear();
            txt_danhmuc.Clear();
            txt_tenhang.Clear();
            //if (numUpDown_count.Maximum == 0)
            //    numUpDown_count.Value = 0;
            //else
            numUpDown_count.Value = 1;
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            if (check_NhaCungCap_info() && check_tongtien() )
            {
                string provider_name;
                string phone;
                string staff_name;
                string cmnd;
                DateTime date = dateTimePicker1.Value.Date;
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

                provider_name = ((CBBItems)cbb_provider.SelectedItem).Text;
                phone = txt_phone_provi.Text;

                BLL_Bill.Instance.Add_Bill(date, provider_name, phone, staff_name, cmnd, 0, update_tongtien());

                int id_bill = BLL_Bill.Instance.Get_Lastest_Import().id;

                foreach (DataRow row in dt.Rows)
                {
                    int id_hanghoa = Convert.ToInt32(row["Mã hàng"]);
                    HangHoa h = BLL_Product.Instance.Get_HangHoa_by_ID(id_hanghoa);
                    string danhmuc = BLL_Product.Instance.Get_DanhMuc_by_ID(h.idDanhMuc).Name;
                    int soluong = Convert.ToInt32(row["Số lượng"]);
                    BLL_Bill.Instance.Add_Bill_Info(id_bill, h.Name, danhmuc, h.DonGiaBan, soluong);
                    BLL_Product.Instance.Update_SoLuong(id_hanghoa, soluong);
                }
                //txt_id_hang.Clear();
                //txt_danhmuc.Clear();
                //txt_tenhang.Clear();
                //numUpDown_count.Value = 1;

                //txt_name_provi.Clear();
                //txt_phone_provi.Clear();
                //txt_email.Clear();

                //txt_Total.Clear();
                //dt = null;
                //dtgv_import.DataSource = dt;
                MessageBox.Show("Đã nhập hàng thành công!");
                Product_Control.Instance.Load_dtgv();
            }
            else
            {

            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            txt_id_hang.Clear();
            txt_danhmuc.Clear();
            txt_tenhang.Clear();
            numUpDown_count.Value = 1;

            cbb_provider.SelectedIndex = 0;
            txt_phone_provi.Clear();
            txt_email.Clear();
            txt_Total.Text = "0";
            dt.Rows.Clear();
            dtgv_import.DataSource = dt;

            label_bill_info_null.Visible = false;
            label_category_null.Visible = false;
            label_id_null.Visible = false;
            label_phone_null.Visible = false;
            label_phone_null.Visible = false;            
            label_tenhang_null.Visible = false;
            label_ten_provi_null.Visible = false;
        }

        private void cbb_provider_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbb_provider.SelectedIndex != 0)
            {
                label_ten_provi_null.Visible = false;
                int id_provider = ((CBBItems)cbb_provider.SelectedItem).Value;
                KhachHang provider = BLL_Customer.Instance.Get_Provider_by_id(id_provider);

                txt_phone_provi.Text = provider.Phone;
                txt_email.Text = provider.Email;
            }
            else
            {
                txt_phone_provi.Text = "";
                txt_email.Text = "";
            }
            
        }
    }
}
