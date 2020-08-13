using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLHTSV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void maychuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Maychu frm = new Maychu();
            frm.Show();
        }

        private void nguoidungToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dangnhapnguoidung dnnd = new Dangnhapnguoidung();
            dnnd.Show();
        }
    }
}
