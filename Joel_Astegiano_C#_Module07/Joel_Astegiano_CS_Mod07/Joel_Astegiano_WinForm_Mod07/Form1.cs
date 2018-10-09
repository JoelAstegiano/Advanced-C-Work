using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Joel_Astegiano_WinForm_Mod07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Click += Button1_ClickOther;
        }

        private void Button1_ClickOther(object sender, EventArgs e)
        {
            label2.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
        }
    }
}
