using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class Widthdraw : UserControl
    {


        private static Widthdraw _instance;
        public static Widthdraw Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Widthdraw();
                }
                return _instance;
            }
        }

        public Widthdraw()
        {
            InitializeComponent();
        }
    }
}
