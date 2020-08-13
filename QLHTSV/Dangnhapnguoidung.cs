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
    public partial class Dangnhapnguoidung : Form
    {
        public Dangnhapnguoidung()
        {
            InitializeComponent();
        }
        public int kiemtra()
        {
            string sql = "select * from dangnhap where Username = '" + txtUsernameND.Text + "' and Password = '" + txtPasswordND.Text + "'";
            DataTable Nguoidung = Ketnoi.ExecuteDataTable_SQL(sql);
            if (Nguoidung.Rows.Count >= 1 )
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        private void btnDangnhapND_Click(object sender, EventArgs e)
        {
            int kt = kiemtra();
            if (kt == 1)
            {
                Nguoidung nd = new Nguoidung();
                nd.Show();
            }
            else
            {
                MessageBox.Show("Dang nhap that bai");
            }
        }
    }
}
