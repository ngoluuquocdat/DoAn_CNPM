using QuanLyCuaHangGear.BLL;
using QuanLyCuaHangGear.DTO;
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
    public partial class AE_Product_Form : Form
    {
        public int ID { get; set; }
        //Constructor
        public AE_Product_Form(int id)
        {
            this.ID = id;
            InitializeComponent();
            SetView();
            SetCBB(BLL_Product.Instance.Get_DanhMuc());
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
                int id_Dm = hh.idDanhMuc;
                DanhMuc dm = BLL_Product.Instance.Get_DanhMuc_by_ID(id_Dm);
                CBBItems temp = new CBBItems();
                foreach (CBBItems i in cbb_danhMuc.Items)
                {
                    if (i.Value == dm.id)
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
                string TenPr = txt_tenPr.Text;
                string GiaBan = txt_giaBan.Text;
                string GiaNhap = txt_giaNhap.Text;
                int idPr = ((CBBItems)cbb_danhMuc.SelectedItem).Value;
                BLL_Product.Instance.AddProduct(TenPr, GiaBan, GiaNhap, idPr);
                this.Close();
                MessageBox.Show("Add to success!");
            }
            else
            {
                string TenPr = txt_tenPr.Text;
                string GiaBan = txt_giaBan.Text;
                string GiaNhap = txt_giaNhap.Text;
                int idPr = ((CBBItems)cbb_danhMuc.SelectedItem).Value;
                BLL_Product.Instance.EditProduct(ID,TenPr, GiaBan, GiaNhap, idPr);
                this.Close();
                MessageBox.Show("Edit to success!");
            }
        }
    }
}
