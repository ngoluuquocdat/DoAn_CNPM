using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHangGear
{
    public partial class Bill_Control : UserControl
    {
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
        public Bill_Control()
        {
            InitializeComponent();
        }
    }
}
