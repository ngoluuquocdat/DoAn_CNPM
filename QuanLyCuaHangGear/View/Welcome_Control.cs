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
    public partial class Welcome_Control : UserControl
    {
        private static Welcome_Control _instance;
        public static Welcome_Control Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Welcome_Control();
                return _instance;
            }
        }
        public Welcome_Control()
        {
            InitializeComponent();
        }

       
    }
}
