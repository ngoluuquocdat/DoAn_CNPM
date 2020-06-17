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
    public partial class Report_Control : UserControl
    {
        private static Report_Control _instance;
        public static Report_Control Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Report_Control();
                return _instance;
            }
        }
        public Report_Control()
        {
            InitializeComponent();
        }
    }
}
