﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyCuaHangGear.View;
using QuanLyCuaHangGear.DTO;
using QuanLyCuaHangGear.BLL;
using System.Threading;

namespace QuanLyCuaHangGear
{
    public partial class Product_Control : UserControl
    {
        private static Product_Control _instance;
        public static Product_Control Instance
        {
            get
            {
                if (_instance == null || _instance.IsDisposed)
                    _instance = new Product_Control();
                return _instance;
            }
        }
        public Product_Control()
        {
            InitializeComponent();

            /*
            Control.CheckForIllegalCrossThreadCalls = false;
            ThreadStart ts1 = new ThreadStart(Load_dtgv);
            ThreadStart ts2 = new ThreadStart(SetCBB);
            Thread thread1 = new Thread(ts1);
            thread1.Start();
            thread1 = new Thread(ts2);
            thread1.Start();

            thread1 = new Thread(SetCBB);
            thread1.Start();
            Thread thread2 = new Thread(SetCBB);
            thread2.Start();
            */
            SetCBB();           
            Load_dtgv();
            Check_SoLuong();
        }

        // methods
        // hàm này chép dữ liệu từ đối tượng HangHoa sang đối tượng HangHoa_view
        public List<HangHoa_View> To_View(List<HangHoa> list)
        {
            List<HangHoa_View> list_view = new List<HangHoa_View>();
            foreach (HangHoa h in list)
            {
                list_view.Add(new HangHoa_View
                {
                    ID = h.id,
                    Ten = h.Name,
                    DanhMuc = BLL_Product.Instance.Get_DanhMuc_by_ID(h.idDanhMuc).Name,
                    SoLuong = h.SoLuong,
                    DonGiaNhap=h.DonGiaNhap,
                    DonGiaBan=h.DonGiaBan
                }) ;
            }

            return list_view;
        }
        public void SetCBB()
        {
            if (cbb_Category.Items != null)
            {
                cbb_Category.Items.Clear();
            }
            cbb_Category.Items.Add(new CBBItems { Text = "All", Value = 0 });
            foreach (DanhMuc i in BLL_Product.Instance.Get_DanhMucs())
            {
                cbb_Category.Items.Add(new CBBItems
                {
                    Value = i.id,
                    Text = i.Name
                });
            }
            cbb_Category.SelectedIndex = 0;
            cbb_Sort.SelectedIndex = 0;
        }
        public void Load_dtgv()
        {
            Product_dtgv.DataSource = To_View(BLL_Product.Instance.Get_HangHoas());
            
        }
        public void Check_SoLuong()
        {
            foreach (DataGridViewRow row in Product_dtgv.Rows)
            {
                if (Convert.ToInt32(row.Cells["SoLuong"].Value) < 10)
                { 
                    row.DefaultCellStyle.BackColor = Color.FromArgb(255, 128, 128);
                }
            }
        }
        //events
        private void btn_Add_Click(object sender, EventArgs e)
        {
            AE_Product_Form ae_f = new AE_Product_Form(0);
            ae_f.ShowDialog();
            Load_dtgv();
            Check_SoLuong();
            if (Product_dtgv.Rows.Count > 0)
                Product_dtgv.Rows[Product_dtgv.Rows.Count - 1].Selected = true;
        }

        private void txt_Search_Click(object sender, EventArgs e)
        {
            txt_Search.Clear();
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection r = Product_dtgv.SelectedRows;
            if (r.Count == 1)
            {
                int index = Product_dtgv.SelectedRows[0].Index;
                int id = Convert.ToInt32(Product_dtgv.SelectedRows[0].Cells["id"].Value);
                AE_Product_Form f = new AE_Product_Form(id);
                f.ShowDialog();
                Load_dtgv();
                Check_SoLuong();
                Product_dtgv.Rows[index].Selected = true;
            }
            
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection rows = Product_dtgv.SelectedRows;
            if (rows.Count == 1)
            {
                int id_pr = Convert.ToInt32(Product_dtgv.SelectedRows[0].Cells["id"].Value);
                BLL_Product.Instance.Delete(id_pr);

                Load_dtgv();
                Check_SoLuong();
            }           
        }

        private void btn_View_Click(object sender, EventArgs e)
        {
            int id_pr = Convert.ToInt32(Product_dtgv.SelectedRows[0].Cells["id"].Value.ToString());
            HangHoa hh = BLL_Product.Instance.Get_HangHoa_by_ID(id_pr);
            int id_Dm = hh.idDanhMuc;
            DanhMuc dm = BLL_Product.Instance.Get_DanhMuc_by_ID(id_Dm);
            
            txt_idHangHoa.Text = hh.id.ToString();
            txt_tenHang.Text = hh.Name;
            txt_danhMuc.Text = dm.Name.ToString();
            txt_soLuong.Text = hh.SoLuong.ToString();
            txt_donGiaNhap.Text = hh.DonGiaNhap.ToString();
            txt_donGiaBan.Text = hh.DonGiaBan.ToString();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            string StringSearch = txt_Search.Text;
            int id_dm = ((CBBItems)cbb_Category.SelectedItem).Value;
            Product_dtgv.DataSource = To_View(BLL_Product.Instance.Search_by_DanhMuc(StringSearch, id_dm));
            Check_SoLuong();
        }

        private void btn_priceUp_Click(object sender, EventArgs e)
        {
            List<int> current_id = new List<int>();
            List<HangHoa> list_sort = new List<HangHoa>();
            

            foreach (DataGridViewRow i in Product_dtgv.Rows)
            {
                current_id.Add(Convert.ToInt32(i.Cells["ID"].Value.ToString()));
            }
            foreach (int id in current_id)
            {
                list_sort.Add(BLL_Product.Instance.Get_HangHoa_by_ID(id));
            }
            BLL_Product.Instance.CompCond += new BLL_Product.Compare_Condition(BLL_Product.Instance.Ascending);

            if (cbb_Sort.SelectedIndex == 0)
            {
                BLL_Product.Instance.Sort_GiaNhap(list_sort);
            }
            if(cbb_Sort.SelectedIndex == 1)
            {
                BLL_Product.Instance.Sort_GiaBan(list_sort);
            }
            
            Product_dtgv.DataSource = To_View(list_sort);
            Check_SoLuong();
        }

        private void btn_priceDown_Click(object sender, EventArgs e)
        {
            List<int> current_id = new List<int>();
            List<HangHoa> list_sort = new List<HangHoa>();

            foreach (DataGridViewRow i in Product_dtgv.Rows)
            {
                current_id.Add(Convert.ToInt32(i.Cells["ID"].Value.ToString()));
            }
            foreach (int id in current_id)
            {
                list_sort.Add(BLL_Product.Instance.Get_HangHoa_by_ID(id));
            }

            BLL_Product.Instance.CompCond += new BLL_Product.Compare_Condition(BLL_Product.Instance.Decrease);

            if (cbb_Sort.SelectedIndex == 0)
            {
                BLL_Product.Instance.Sort_GiaNhap(list_sort);
            }
            if (cbb_Sort.SelectedIndex == 1)
            {
                BLL_Product.Instance.Sort_GiaBan(list_sort);
            }

            Product_dtgv.DataSource = To_View(list_sort);
            Check_SoLuong();
        }

        private void cbb_Category_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id_dm = ((CBBItems)cbb_Category.SelectedItem).Value;
            if (id_dm == 0)
            {
                Load_dtgv();
                Check_SoLuong();

            }
            else
            {
                Product_dtgv.DataSource = To_View(BLL_Product.Instance.Get_HangHoa_by_IdDanhMuc(id_dm));
                Check_SoLuong();
            }
        }

        private void Product_Control_Click(object sender, EventArgs e)
        {
            txt_Search.Text = "Nhập tên hàng";
        }
    }
}
