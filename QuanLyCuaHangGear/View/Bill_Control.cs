using System;
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
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;

namespace QuanLyCuaHangGear
{
    public partial class Bill_Control : UserControl
    {

        System.Data.DataTable dt = new System.Data.DataTable();
        int id_NV;
        
        private static Bill_Control _instance;
        public static Bill_Control Instance
        {
            get
            {
                if (_instance == null || _instance.IsDisposed)
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
            if (numUpDown_count.Value == 0)
            {
                check = false;
            }
            return check;
        }
        public bool check_KhachHang_info()
        {
            bool check = true;
            if (txt_phone.Text == "")
            {
                label_phone_null.Visible = true;
                check = false;
            }
            if (txt_name_customer.Text == "")
            {
                label_tenkhach_null.Visible = true;
                check = false;
            }

            return check;
        }
        public bool check_tongtien()
        {
            if(txt_Total.Text == "0")
            {
                label_bill_info_null.Visible = true;
                return false;
            }
            return true;
        }
        private static void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                obj = null;
            }
            finally
            { GC.Collect(); }
        }
        public bool Xuat_Hoa_Don(int ma_hd, string ten_kh, string sdt, string email, string ten_nv, string cmnd,
                                  string ngaylap, int tongtien)
        {
            try
            {
                string saveExcelFile = @"D:\Hoa_Don_Ban_Hang.xlsx";

                Excel.Application xlApp = new Excel.Application();

                if (xlApp == null)
                {
                    MessageBox.Show("Lỗi không thể sử dụng được thư viện EXCEL");
                    return false;
                }
                xlApp.Visible = false;

                object misValue = System.Reflection.Missing.Value;

                Workbook wb = xlApp.Workbooks.Add(misValue);

                Worksheet ws = (Worksheet)wb.Worksheets[1];

                if (ws == null)
                {
                    MessageBox.Show("Không thể tạo được WorkSheet");
                    return false;
                }

                string fontName = "Times New Roman";
                int fontSizeTitle = 20;
                int fontSizeColumnName = 14;
                int fontSizeText = 12;

                //Xuất dòng Tên cửa hàng 
                Range row_StoreName = ws.get_Range("A1", "B1"); // từ ô A1 đến ô B1
                row_StoreName.Merge();
                row_StoreName.Font.Size = fontSizeColumnName;
                row_StoreName.Font.Name = fontName;
                row_StoreName.Cells.HorizontalAlignment = XlHAlign.xlHAlignLeft;
                row_StoreName.Value2 = "Cửa hàng Quốc An";
               // row_StoreName.ColumnWidth = 20;

                //Xuất dòng sđt cửa hàng 
                Range row_StorePhone = ws.get_Range("A2", "B2"); //ô A2 và B2
                row_StorePhone.Merge();
                row_StorePhone.Font.Size = fontSizeColumnName;
                row_StorePhone.Font.Name = fontName;
                row_StorePhone.Cells.HorizontalAlignment = XlHAlign.xlHAlignLeft;
                row_StorePhone.Value2 = "Điện thoại: 18008566";


                //Xuất dòng địa chỉ cửa hàng
                Range row_StoreAddress = ws.get_Range("A3", "B3"); //ô A3 và B3
                row_StoreAddress.Merge();
                row_StoreAddress.Font.Size = fontSizeColumnName;
                row_StoreAddress.Font.Name = fontName;
                row_StoreAddress.Cells.HorizontalAlignment = XlHAlign.xlHAlignLeft;
                row_StoreAddress.Value2 = "7 Phan Văn Định, Đà Nẵng";


                ////Tạo ô Điện thoại:
                //Range row_DienThoai = ws.get_Range("B8", "B8");//Ô B8
                //row_DienThoai.Font.Size = fontSizeColumnName;
                //row_DienThoai.Font.Name = fontName;
                //row_DienThoai.Cells.HorizontalAlignment = XlHAlign.xlHAlignLeft;
                //row_DienThoai.ColumnWidth = 16;
                //row_DienThoai.Value2 = "Điện thoại:";

                //Xuất dòng title HÓA ĐƠN BÁN HÀNG :
                Range row_Title = ws.get_Range("C4", "D4");// Ô C4 và D4
                row_Title.Merge();
                row_Title.Font.Size = fontSizeTitle;
                row_Title.Font.Name = fontName;
                row_Title.Font.Bold = true;
                row_Title.Cells.HorizontalAlignment = XlHAlign.xlHAlignLeft;
                row_Title.Value2 = "HÓA ĐƠN BÁN HÀNG";

                //Tạo ô Mã hóa đơn:
                Range row_IDHoaDon = ws.get_Range("B6", "B6");//Ô B6
                row_IDHoaDon.Font.Size = fontSizeColumnName;
                row_IDHoaDon.Font.Name = fontName;
                row_IDHoaDon.Cells.HorizontalAlignment = XlHAlign.xlHAlignLeft;
                row_IDHoaDon.ColumnWidth = 16;
                row_IDHoaDon.Value2 = "Mã hóa đơn:";

                // Điền vào mã hóa đơn
                Range row_ID_2 = ws.get_Range("C6", "C6");
                row_ID_2.Font.Size = fontSizeText;
                row_ID_2.Font.Name = fontName;
                row_ID_2.Cells.HorizontalAlignment = XlHAlign.xlHAlignLeft;
                row_ID_2.ColumnWidth = 20;
                row_ID_2.Value2 = ma_hd;

                //Tạo ô Ngày lập:
                Range row_NgayLap = ws.get_Range("B7", "B7");//Ô B7
                row_NgayLap.Font.Size = fontSizeColumnName;
                row_NgayLap.Font.Name = fontName;
                row_NgayLap.Cells.HorizontalAlignment = XlHAlign.xlHAlignLeft;
                row_NgayLap.ColumnWidth = 16;
                row_NgayLap.Value2 = "Ngày lập:";

                // Điền vào ngày lập
                Range row_NgayLap2 = ws.get_Range("C7", "C7");//Ô C7
                row_NgayLap2.Font.Size = fontSizeText;
                row_NgayLap2.Font.Name = fontName;
                row_NgayLap2.Cells.HorizontalAlignment = XlHAlign.xlHAlignLeft;
                row_NgayLap2.ColumnWidth = 16;
                row_NgayLap2.Value2 = ngaylap;

                //Tạo ô Khách hàng:
                Range row_KhachHang = ws.get_Range("B8", "B8");//Ô B8
                row_KhachHang.Font.Size = fontSizeColumnName;
                row_KhachHang.Font.Name = fontName;
                row_KhachHang.Cells.HorizontalAlignment = XlHAlign.xlHAlignLeft;
                row_KhachHang.ColumnWidth = 16;
                row_KhachHang.Value2 = "Khách hàng:";

                //Điền vào Khách hàng:
                Range row_KhachHang2 = ws.get_Range("C8", "C8");//Ô C8
                row_KhachHang2.Font.Size = fontSizeColumnName;
                row_KhachHang2.Font.Name = fontName;
                row_KhachHang2.Cells.HorizontalAlignment = XlHAlign.xlHAlignLeft;
                row_KhachHang2.ColumnWidth = 16;
                row_KhachHang2.Value2 = ten_kh;

                //Tạo ô Điện thoại:
                Range row_DienThoai = ws.get_Range("B9", "B9");//Ô B9
                row_DienThoai.Font.Size = fontSizeColumnName;
                row_DienThoai.Font.Name = fontName;
                row_DienThoai.Cells.HorizontalAlignment = XlHAlign.xlHAlignLeft;
                row_DienThoai.ColumnWidth = 16;
                row_DienThoai.Value2 = "Điện thoại:";

                //Điền vào Điện thoại:
                Range row_DienThoai2 = ws.get_Range("C9", "C9");//Ô C9
                row_DienThoai2.Font.Size = fontSizeColumnName;
                row_DienThoai2.Font.Name = fontName;
                row_DienThoai2.Cells.HorizontalAlignment = XlHAlign.xlHAlignLeft;
                row_DienThoai2.ColumnWidth = 16;
                row_DienThoai2.Value2 = "'"+sdt;

                ////Tạo ô Email:
                //Range row_Email = ws.get_Range("B9", "B9");//Ô B9
                //row_Email.Font.Size = fontSizeColumnName;
                //row_Email.Font.Name = fontName;
                //row_Email.Cells.HorizontalAlignment = XlHAlign.xlHAlignLeft;
                //row_Email.ColumnWidth = 16;
                //row_Email.Value2 = "Email:";

                //// Điền vào email:
                //Range row_Email2 = ws.get_Range("C9", "C9");//Ô C9
                //row_Email2.Font.Size = fontSizeColumnName;
                //row_Email2.Font.Name = fontName;
                //row_Email2.Cells.HorizontalAlignment = XlHAlign.xlHAlignLeft;
                //row_Email2.ColumnWidth = 16;
                //row_Email2.Value2 = email;


                //Tạo Ô STT:
                Range row_STT = ws.get_Range("A12", "A12");//Ô A12
                row_STT.Font.Size = fontSizeColumnName;
                row_STT.Font.Name = fontName;
                row_STT.Font.Bold = true;
                row_STT.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                row_STT.Value2 = "STT";
                row_STT.ColumnWidth = 13;

                //Tạo Ô Tên hàng:
                Range row_tenhang = ws.get_Range("B12", "C12");//Ô B12 và C12
                row_tenhang.Merge();
                row_tenhang.Font.Size = fontSizeColumnName;
                row_tenhang.Font.Name = fontName;
                row_tenhang.Font.Bold = true;
                row_tenhang.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                row_tenhang.Value2 = "Tên hàng";

                //Tạo Ô Số lượng:
                Range row_SoLuong = ws.get_Range("D12", "D12");//Ô D12
                row_SoLuong.Font.Size = fontSizeColumnName;
                row_SoLuong.Font.Name = fontName;
                row_SoLuong.Font.Bold = true;
                row_SoLuong.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                row_SoLuong.Value2 = "Số lượng";

                //Tạo Ô Đơn giá:
                Range row_DonGia = ws.get_Range("E12", "E12");//Ô E12
                row_DonGia.Font.Size = fontSizeColumnName;
                row_DonGia.Font.Name = fontName;
                row_DonGia.Font.Bold = true;
                row_DonGia.Cells.HorizontalAlignment = XlHAlign.xlHAlignRight;
                row_DonGia.Value2 = "Đơn giá";
                row_DonGia.ColumnWidth = 13;

                //Tạo Ô Thành tiền:
                Range row_ThanhTien = ws.get_Range("F12", "F12");//Ô F12
                row_ThanhTien.Font.Size = fontSizeColumnName;
                row_ThanhTien.Font.Name = fontName;
                row_ThanhTien.Font.Bold = true;
                row_ThanhTien.Cells.HorizontalAlignment = XlHAlign.xlHAlignRight;
                row_ThanhTien.Value2 = "Thành tiền";
                row_ThanhTien.ColumnWidth = 13;

                // điền danh sách hàng hóa được mua:
                int row = 13;
                int stt = 1;
                List<HoaDonInfo> list = BLL_Bill.Instance.Get_Bill_Infoes(ma_hd);
                foreach (HoaDonInfo i in list)
                {
                    // STT
                    Range row_STT2 = ws.get_Range("A" + row, "A" + row);
                    row_STT2.Font.Size = fontSizeColumnName;
                    row_STT2.Font.Name = fontName;
                    row_STT2.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                    row_STT2.Value2 = stt;
                    row_STT2.ColumnWidth = 13;
                    // Tên hàng
                    Range row_tenhang2 = ws.get_Range("B" + row, "C" + row);
                    row_tenhang2.Merge();
                    row_tenhang2.Font.Size = fontSizeColumnName;
                    row_tenhang2.Font.Name = fontName;
                    row_tenhang2.Cells.HorizontalAlignment = XlHAlign.xlHAlignLeft;
                    row_tenhang2.Value2 = i.TenHangHoa;
                    //Số lượng
                    Range row_SoLuong2 = ws.get_Range("D" + row, "D" + row);
                    row_SoLuong2.Font.Size = fontSizeColumnName;
                    row_SoLuong2.Font.Name = fontName;
                    row_SoLuong2.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                    row_SoLuong2.Value2 = i.SoLuong;
                    row_SoLuong2.ColumnWidth = 13;
                    //Đơn giá
                    Range row_DonGia2 = ws.get_Range("E" + row, "E" + row);
                    row_DonGia2.Font.Size = fontSizeColumnName;
                    row_DonGia2.Font.Name = fontName;
                    row_DonGia2.Cells.HorizontalAlignment = XlHAlign.xlHAlignRight;
                    row_DonGia2.Value2 = i.DonGia;
                    row_DonGia2.ColumnWidth = 13;
                    // Thành tiền
                    Range row_ThanhTien2 = ws.get_Range("F" + row, "F" + row);
                    row_ThanhTien2.Font.Size = fontSizeColumnName;
                    row_ThanhTien2.Font.Name = fontName;
                    row_ThanhTien2.Cells.HorizontalAlignment = XlHAlign.xlHAlignRight;
                    row_ThanhTien2.Value2 = i.DonGia * i.SoLuong;
                    row_ThanhTien2.ColumnWidth = 13;

                    stt++;
                    row++;
                }

                // Tạo ô tổng tiền
                Range row_TongTien = ws.get_Range("E" + (row + 2), "E" + (row + 2));
                row_TongTien.Font.Size = fontSizeColumnName;
                row_TongTien.Font.Name = fontName;
                row_TongTien.Font.Bold = true;
                row_TongTien.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                row_TongTien.Value2 = "Tổng tiền";
                row_TongTien.ColumnWidth = 13;
                // Điền vào tổng tiền
                Range row_TongTien2 = ws.get_Range("F" + (row + 2), "F" + (row + 2));
                row_TongTien2.Font.Size = fontSizeColumnName;
                row_TongTien2.Font.Name = fontName;
                row_TongTien2.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                row_TongTien2.Value2 = tongtien;
                row_TongTien2.ColumnWidth = 13;

                // Tạo ô nhân viên lập
                Range row_NhanVien = ws.get_Range("E" + (row + 5), "F" + (row + 5));
                row_NhanVien.Merge();
                row_NhanVien.Font.Size = fontSizeColumnName;
                row_NhanVien.Font.Name = fontName;
                row_NhanVien.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                row_NhanVien.Value2 = "Nhân viên lập";

                // Tạo ô Họ tên nhân viên
                Range row_TenNhanVien = ws.get_Range("E" + (row + 9), "F" + (row + 9));
                row_TenNhanVien.Merge();
                row_TenNhanVien.Font.Size = fontSizeColumnName;
                row_TenNhanVien.Font.Name = fontName;
                row_TenNhanVien.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                row_TenNhanVien.Value2 = ten_nv;

                // lưu file
                if (!System.IO.File.Exists(saveExcelFile))
                {
                    wb.SaveAs(saveExcelFile);
                }
                else
                {
                    System.IO.File.Delete(saveExcelFile);
                    wb.SaveAs(saveExcelFile);
                }

                //đóng file để hoàn tất quá trình lưu trữ
                wb.Close(true, misValue, misValue);
                //thoát và thu hồi bộ nhớ cho COM
                xlApp.Quit();

                releaseObject(ws);
                releaseObject(wb);
                releaseObject(xlApp);

                //Mở File excel sau khi Xuất thành công
                System.Diagnostics.Process.Start(saveExcelFile);
            }                 
            catch (System.IO.IOException)
            {
                MessageBox.Show("Một cửa sổ hóa đơn đang mở.\nHãy tắt đi và thử lại.");
                return false;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return true;
        }
            

        
        // events
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
            catch(FormatException)
            {
                MessageBox.Show("Sai định dạng mã hàng");
                return;
            }
            HangHoa h = BLL_Product.Instance.Get_HangHoa_by_ID(id);
            if(h == null)
            {
                MessageBox.Show("Không tìm thấy hàng hóa có mã: " + id);
                return;
            }
            label_tenhang_null.Visible = false;
            label_category_null.Visible = false;
            txt_danhmuc.Text = BLL_Product.Instance.Get_DanhMuc_by_ID(h.idDanhMuc).Name;
            txt_tenhang.Text = h.Name;
            numUpDown_count.Maximum = h.SoLuong;
            if (numUpDown_count.Maximum == 0)
            {
                numUpDown_count.Minimum = 0;
                label_soldout.Visible = true;
            }
            else
            {
                numUpDown_count.Minimum = 1; 
            }
                
        }

        private void btn_SearchPhone_Click(object sender, EventArgs e)
        {
            string phone = txt_phone.Text;
            if(phone == "")
            {
                label_phone_null.Visible = true;
                return;
            }
            if(BLL.Validation.isPhone(phone))
            {
                KhachHang provider = BLL_Customer.Instance.Get_Customer(phone);
                if (provider == null)
                {
                    MessageBox.Show("Khách hàng này chưa được lưu.");
                    txt_name_customer.ReadOnly = false;
                    txt_email.ReadOnly = false;
                    btn_Add_Customer.Visible = true;
                }
                else
                {
                    txt_name_customer.Text = provider.Name;
                    txt_email.Text = provider.Email;
                }
            }
            else
            {
                label_phone_invalid.Visible = true;
                
            }
            
        }

        private void btn_Add_Customer_Click(object sender, EventArgs e)
        {
            string name = txt_name_customer.Text;
            string phone = txt_phone.Text;
            string email = txt_email.Text;
            if(name == "")
            {
                label_tenkhach_null.Visible = true;
                return;
            }
            if(!BLL.Validation.isPhone(phone))
            {
                label_phone_null.Visible = true;
                return;
            }
            if(email != "")
            {
                if (!BLL.Validation.isEmail(email))
                {
                    label_email_invalid.Visible = true;
                    return;
                }
            }
            
            BLL_Customer.Instance.Add_Customer(name, phone, email);
            MessageBox.Show("Đã thêm thông tin khách hàng.");
            btn_Add_Customer.Visible = false;           
            txt_name_customer.ReadOnly = true;
            txt_email.ReadOnly = true;
        }

        

        private void btn_add_to_bill_Click(object sender, EventArgs e)
        {
            if (check_HangHoa_info())
            {
                label_bill_info_null.Visible = false;
                bool isExist = false;
                int id = Convert.ToInt32(txt_id_hang.Text);
                HangHoa h = BLL_Product.Instance.Get_HangHoa_by_ID(id);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (h.id == Convert.ToInt32(dt.Rows[i]["Mã hàng"].ToString()))
                    {
                        dtgv_buy.Rows[i].Selected = true;
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
                    if(dtgv_buy.Rows.Count >0)
                        dtgv_buy.Rows[dtgv_buy.Rows.Count-1].Selected = true;
                }

                dtgv_buy.DataSource = dt;

                txt_Total.Text = update_tongtien() + "";
            }
            else
            {
                return;
            }
           
        }

        private void btn_del_from_bill_Click(object sender, EventArgs e)
        {
            if (dtgv_buy.SelectedRows.Count == 1)
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
        }

        private void txt_id_hang_Click(object sender, EventArgs e)
        {
            label_soldout.Visible = false;
            label_id_null.Visible = false;
            label_tenhang_null.Visible = false;
            label_category_null.Visible = false;

            txt_id_hang.Clear();
            txt_danhmuc.Clear();
            txt_tenhang.Clear();
            if (numUpDown_count.Maximum == 0)
                numUpDown_count.Value = 0;
            else
                numUpDown_count.Value = 1;

        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {    
            // thực hiện chức năng
            if (check_HangHoa_info() && check_KhachHang_info() && check_tongtien())
            {
                string ten_kh;
                string phone;
                string email;
                string ten_nv;
                string cmnd;
                int tongtien;
                DateTime date = dateTimePicker1.Value.Date;
                if (this.Id_NV == 0)
                {
                    ten_nv = "Ngô Lưu Quốc Đạt";
                    cmnd = "206282345";
                }
                else
                {
                    NhanVien nv = BLL_Staff.Instance.Get_NhanVien_by_ID(this.Id_NV);
                    ten_nv = nv.Name;
                    cmnd = nv.CMND;
                }

                ten_kh = txt_name_customer.Text;
                phone = txt_phone.Text;
                email = txt_email.Text; 
                tongtien = update_tongtien();
                BLL_Bill.Instance.Add_Bill(date, ten_kh, phone, ten_nv, cmnd, 1, tongtien);

                int id_bill = BLL_Bill.Instance.Get_Lastest_Bill().id;

                foreach (DataRow row in dt.Rows)
                {
                    int id_hanghoa = Convert.ToInt32(row["Mã hàng"]);
                    HangHoa h = BLL_Product.Instance.Get_HangHoa_by_ID(id_hanghoa);
                    string danhmuc = BLL_Product.Instance.Get_DanhMuc_by_ID(h.idDanhMuc).Name;
                    int soluong = Convert.ToInt32(row["Số lượng"]);
                    BLL_Bill.Instance.Add_Bill_Info(id_bill, h.Name, danhmuc, h.DonGiaBan, soluong);
                    BLL_Product.Instance.Update_SoLuong(id_hanghoa, -soluong);
                }
                
                MessageBox.Show("Đã tạo hoá đơn!");
                
                Product_Control.Instance.Load_dtgv();
                btn_Export_Bill.Visible = true;
            }
            else
            {
                
                
            }
            
        }

        private void txt_phone_Click(object sender, EventArgs e)
        {
            label_phone_null.Visible = false;
            label_tenkhach_null.Visible = false; 
            txt_phone.Clear();
            txt_name_customer.Clear();
            txt_email.Clear();
            label_phone_invalid.Visible = false;
            btn_Add_Customer.Visible = false;
            txt_email.ReadOnly = true;
            txt_name_customer.ReadOnly = true;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            txt_id_hang.Clear();
            txt_danhmuc.Clear();
            txt_tenhang.Clear();
            if (numUpDown_count.Maximum == 0)
            {
                numUpDown_count.Minimum = 0;
                label_soldout.Visible = true;
            }
            else
            {
                numUpDown_count.Minimum = 1;
            }
            txt_name_customer.Clear();
            txt_phone.Clear();
            txt_email.Clear();

            txt_Total.Clear();
            dt.Rows.Clear();
            dtgv_buy.DataSource = dt;

            btn_Export_Bill.Visible = false;
        }

        private void btn_Export_Bill_Click(object sender, EventArgs e)
        {
            HoaDon bill = BLL_Bill.Instance.Get_Lastest_Bill();
            DateTime date = bill.MakeDate;
            string ten_nv = bill.TenNhanVien;
            string cmnd = bill.CMND;
            int id_bill = bill.id;
            string ten_kh = bill.TenKhachHang;
            string phone = bill.Phone;
            string email = txt_email.Text;
            int tongtien = bill.TongTien;
            MessageBox.Show("Đang xuất hóa đơn");
            if(Xuat_Hoa_Don(id_bill, ten_kh, phone, email, ten_nv, cmnd, date.ToShortDateString(), tongtien))
            {
                btn_Export_Bill.Visible = false;
            }
            else
            {
                // do nothing
            }
        }
    }
}
