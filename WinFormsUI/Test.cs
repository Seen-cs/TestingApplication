using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsUI
{
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
        }
        public string userName { get; set; }
        public string password { get; set; }
    }
}
