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

namespace QuanLyCuaHangGear
{
    public partial class Product_Control : UserControl
    {
        private static Product_Control _instance;
        public static Product_Control Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Product_Control();
                return _instance;
            }
        }
        public Product_Control()
        {
            InitializeComponent();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            A_Product_Form ae_f = new A_Product_Form();
            ae_f.ShowDialog();
        }
    }
}
