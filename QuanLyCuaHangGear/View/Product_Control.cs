using System;
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
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;


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
                if (Convert.ToInt32(row.Cells["SoLuong"].Value) <= 5)
                { 
                    row.DefaultCellStyle.BackColor = Color.FromArgb(255, 128, 128);
                }
            }
        }
        //Hàm thu hồi bộ nhớ cho COM Excel
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
    //events
    private void btn_Add_Click(object sender, EventArgs e)
        {
            AE_Product_Form ae_f = new AE_Product_Form(0);
            ae_f.D += new AE_Product_Form.MyDelegate(Load_dtgv);
            ae_f.ShowDialog();
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
                AE_Product_Form ae_f = new AE_Product_Form(id);
                ae_f.D += new AE_Product_Form.MyDelegate(Load_dtgv);
                ae_f.ShowDialog();
                Product_dtgv.Rows[index].Selected = true;
            }
            
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection rows = Product_dtgv.SelectedRows;
            
            if (rows.Count == 1)
            {
                int id_pr = Convert.ToInt32(Product_dtgv.SelectedRows[0].Cells["id"].Value);
                if (MessageBox.Show("          Bạn có muốn xóa hàng hóa có mã: "+id_pr, "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    BLL_Product.Instance.Delete(id_pr);
                    Load_dtgv();
                }             
            }           
        }

        

        private void btn_Search_Click(object sender, EventArgs e)
        {
            string StringSearch = txt_Search.Text;
            int id_dm = ((CBBItems)cbb_Category.SelectedItem).Value;
            Product_dtgv.DataSource = To_View(BLL_Product.Instance.Search_by_DanhMuc(StringSearch, id_dm));
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
        }

        private void cbb_Category_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id_dm = ((CBBItems)cbb_Category.SelectedItem).Value;
            if (id_dm == 0)
            {
                Load_dtgv();
            }
            else
            {
                Product_dtgv.DataSource = To_View(BLL_Product.Instance.Get_HangHoa_by_IdDanhMuc(id_dm));
            }
        }

        private void Product_Control_Click(object sender, EventArgs e)
        {
            txt_Search.Text = "Nhập tên hàng";
        }

        private void btn_Export_list_Click(object sender, EventArgs e)
        {
            try
            {
                string saveExcelFile = @"D:\DS_HangHoa.xlsx";

                Excel.Application xlApp = new Excel.Application();
               
                if (xlApp == null)
                {
                    MessageBox.Show("Lỗi không thể sử dụng được thư viện EXCEL");
                    return;
                }
                xlApp.Visible = false;

                object misValue = System.Reflection.Missing.Value;

                Workbook wb = xlApp.Workbooks.Add(misValue);

                Worksheet ws = (Worksheet)wb.Worksheets[1];

                if (ws == null)
                {
                    MessageBox.Show("Không thể tạo được WorkSheet");
                    return;
                }

                string fontName = "Times New Roman";
                int fontSizeTitle = 18;
                int fontSizeColumnName = 14;
                int fontSizeText = 12;

                //Xuất dòng Tiêu đề 
                Range row_Title = ws.get_Range("A1", "E1"); // từ ô A1 đến ô E1
                row_Title.Merge();
                row_Title.Font.Size = fontSizeTitle;
                row_Title.Font.Name = fontName;
                row_Title.Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                row_Title.Value2 = "THỐNG KÊ HÀNG HÓA";

                //Tạo Ô Mã hàng 
                Range row_ID = ws.get_Range("A2", "A2"); //Ô A2
                row_ID.Font.Size = fontSizeColumnName;
                row_ID.Font.Name = fontName;
                row_ID.Cells.HorizontalAlignment = XlHAlign.xlHAlignRight;
                row_ID.Value2 = "Mã hàng";
                row_ID.ColumnWidth = 20;

                //Tạo Ô Tên hàng :
                Range row_TenHang = ws.get_Range("B2", "B2");//Ô B2
                row_TenHang.Font.Size = fontSizeColumnName;
                row_TenHang.Font.Name = fontName;
                row_TenHang.Cells.HorizontalAlignment = XlHAlign.xlHAlignLeft;
                row_TenHang.Value2 = "Tên hàng";
                row_TenHang.ColumnWidth = 40;

                //Tạo Ô Danh mục:
                Range row_DanhMuc = ws.get_Range("C2", "C2");//Ô C2
                row_DanhMuc.Font.Size = fontSizeColumnName;
                row_DanhMuc.Font.Name = fontName;
                row_DanhMuc.Cells.HorizontalAlignment = XlHAlign.xlHAlignLeft;
                row_DanhMuc.ColumnWidth = 15;
                row_DanhMuc.Value2 = "Danh mục";

                //Tạo Ô Đơn Giá Nhập:
                Range row_GiaNhap = ws.get_Range("D2", "D2");//Ô D2
                row_GiaNhap.Font.Size = fontSizeColumnName;
                row_GiaNhap.Font.Name = fontName;
                row_GiaNhap.Cells.HorizontalAlignment = XlHAlign.xlHAlignRight;
                row_GiaNhap.Value2 = "Đơn giá nhập";
                row_GiaNhap.ColumnWidth = 20;

                //Tạo Ô Đơn giá bán:
                Range row_GiaBan = ws.get_Range("E2", "E2");//Ô E2
                row_GiaBan.Font.Size = fontSizeColumnName;
                row_GiaBan.Font.Name = fontName;
                row_GiaBan.Cells.HorizontalAlignment = XlHAlign.xlHAlignRight;
                row_GiaBan.Value2 = "Đơn giá bán";
                row_GiaBan.ColumnWidth = 20;

                ////Tô nền vàng các cột tiêu đề:
                //Range row23_CotTieuDe = ws.get_Range("A2", "E3");
                ////nền vàng
                //row23_CotTieuDe.Interior.Color = ColorTranslator.ToOle(System.Drawing.Color.Yellow);
                ////in đậm
                row_Title.Font.Bold = true;
                ////chữ đen
                //row23_CotTieuDe.Font.Color = ColorTranslator.ToOle(System.Drawing.Color.Black);

               
                List<HangHoa_View> list = To_View(BLL_Product.Instance.Get_HangHoas());
                for (int i = 0; i < list.Count; i++)
                {
                    Range rowData = ws.get_Range("A" + (i+3), "E" + (i+3));
                    dynamic[] arr = {list[i].ID, list[i].Ten, list[i].DanhMuc, list[i].DonGiaNhap, list[i].DonGiaBan };
                    rowData.Font.Size = fontSizeText;
                    rowData.Font.Name = fontName;
                    rowData.Value2 = arr;
                }
                //Kẻ khung toàn bộ
                // BorderAround(ws.get_Range("A2", "E" + row));

                //Lưu file excel xuống Ổ cứng
                // wb.SaveAs(saveExcelFile);

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
                MessageBox.Show("Một cửa sổ danh sách hàng hóa đang mở.\nHãy tắt đi và thử lại.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Check_Amount_Click(object sender, EventArgs e)
        {
            Check_SoLuong();
        }
    }
    
}
