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
    public partial class Account_Control : UserControl
    {
        private static Account_Control _instance;
        public static Account_Control Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Account_Control();
                return _instance;
            }
        }
        public Account_Control()
        {
            InitializeComponent();
        }
    }
}
