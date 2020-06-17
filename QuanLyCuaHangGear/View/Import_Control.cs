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
    public partial class Import_Control : UserControl
    {
        private static Import_Control _instance;
        public static Import_Control Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Import_Control();
                return _instance;
            }
        }
        public Import_Control()
        {
            InitializeComponent();
        }
    }
}
