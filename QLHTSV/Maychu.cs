using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLHTSV
{
    public partial class Maychu : Form
    {
        public Maychu()
        {
            InitializeComponent();
        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            int kt = kiemtra();
            if(kt == 1)
            {
                Maychuchinh frm = new Maychuchinh();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu");
            }
            txtUsername.Text = "";
            txtPassword.Text = "";
        }
        public int kiemtra()
        {
            string sql = "select * from Maychu where username = '" + txtUsername.Text + "' and password = '"+ txtPassword.Text+ "'";
            DataTable Maychu = Ketnoi.ExecuteDataTable_SQL(sql);
            if (Maychu.Rows.Count >= 1)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = MessageBox.Show("Bạn có muốn thoát", "Chú ý", MessageBoxButtons.YesNo);
            if (thongbao == DialogResult.Yes)
                base.Close();
        }
    }
}
