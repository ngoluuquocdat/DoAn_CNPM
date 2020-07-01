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

namespace QuanLyCuaHangGear.View
{
    public partial class AE_Product_Form : Form
    {
        public delegate void MyDelegate();
        public MyDelegate D { get; set; }
        public int ID { get; set; }
        

        //Constructor
        public AE_Product_Form(int id)
        {
            this.ID = id;
            InitializeComponent();
            SetCBB(BLL_Product.Instance.Get_DanhMucs());
            SetView();          
        }
        //method
        public void SetCBB(List<DanhMuc> danhMucs)
        {
            if (cbb_danhMuc.Items != null)
            {
                cbb_danhMuc.Items.Clear();
            }
            foreach (DanhMuc i in danhMucs)
            {
                cbb_danhMuc.Items.Add(new CBBItems
                {
                    Value = i.id,
                    Text = i.Name
                });
            }
            cbb_danhMuc.SelectedIndex = 0;
        }
        
        public bool Check_Product_Info()
        {
            bool check = true;
            // check ten
            if (txt_tenPr.Text == "")
            {
                label_name_null.Visible = true;
                check = false;
            }
            // check don gia

            if (txt_giaNhap.Text == "")
            {
                    label_dgNhap_null.Visible = true;
                    check = false;
            }
            else
            {
                if(!Validation.is_Price(txt_giaNhap.Text))
                {
                    label_dgNhap_invalid.Visible = true;
                    check = false;
                }
            }

            if (txt_giaBan.Text == "")
            {
                label_dgBan_null.Visible = true;
               check = false;
            }
            else
            {
                if (!Validation.is_Price(txt_giaBan.Text))
                {
                    label_dgBan_invalid.Visible = true;
                    check = false;
                }
            }
            if (Validation.is_Price(txt_giaBan.Text) && Validation.is_Price(txt_giaNhap.Text))
            {
                if (Convert.ToInt32(txt_giaBan.Text) < Convert.ToInt32(txt_giaNhap.Text))
                {
                    label_dgBan_invalid.Visible = true;
                    check = false;
                }
            }

            return check;
        }


        public void SetView()
        {
            if (ID == 0)
            {

            }
            else
            {
                HangHoa hh = BLL_Product.Instance.Get_HangHoa_by_ID(ID);
                txt_tenPr.Text = hh.Name;
                txt_giaNhap.Text = hh.DonGiaNhap.ToString();
                txt_giaBan.Text = hh.DonGiaBan.ToString();
                int id_dm = hh.idDanhMuc;

                CBBItems temp = new CBBItems();

                foreach (CBBItems i in cbb_danhMuc.Items)
                {
                    if (i.Value == id_dm)
                    {
                        temp = i;
                    }
                }

                cbb_danhMuc.SelectedIndex = cbb_danhMuc.Items.IndexOf(temp);
            }
        }
        //event
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            if (ID == 0)
            {
                if (Check_Product_Info())
                {
                    string TenPr = txt_tenPr.Text;
                    string GiaBan = txt_giaBan.Text;
                    string GiaNhap = txt_giaNhap.Text;
                    int idPr = ((CBBItems)cbb_danhMuc.SelectedItem).Value;
                    BLL_Product.Instance.AddProduct(TenPr, GiaBan, GiaNhap, idPr);
                    this.Close();
                    MessageBox.Show("Đã thêm mặt hàng!");
                    this.D();
                    this.Close();
                }
                else
                {

                }
            }
            else
            {
                if (Check_Product_Info())
                {
                    string TenPr = txt_tenPr.Text;
                    string GiaBan = txt_giaBan.Text;
                    string GiaNhap = txt_giaNhap.Text;
                    int idPr = ((CBBItems)cbb_danhMuc.SelectedItem).Value;
                    BLL_Product.Instance.EditProduct(ID, TenPr, GiaBan, GiaNhap, idPr);
                    
                    MessageBox.Show("Đã cập nhật thông tin!");
                    this.D();
                    this.Close();
                }
                else
                {
                    
                }
            }
            
        }

        private void txt_tenPr_Click(object sender, EventArgs e)
        {
            label_name_null.Visible = false;
        }

        private void txt_giaNhap_Click(object sender, EventArgs e)
        {
            label_dgNhap_invalid.Visible = false;
            label_dgNhap_null.Visible = false;
        }

        private void txt_giaBan_Click(object sender, EventArgs e)
        {
            label_dgBan_invalid.Visible = false;
            label_dgBan_null.Visible = false;
        }
    }
}
