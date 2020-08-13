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
    public partial class Maychuchinh : Form
    {
        public Maychuchinh()
        {
            InitializeComponent();
        }

        private void Maychuchinh_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLSVDataSet.Maychuchinh' table. You can move, or remove it, as needed.
            this.maychuchinhTableAdapter.Fill(this.qLSVDataSet.Maychuchinh);

        }

        private void dgSinhvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dataGridView1.SelectedCells[0].RowIndex;
            txtId.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            txtMasinhvien.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            txtTensinhvien.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            txtNgaysinh.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            txtGioitinh.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
            txtSodienthoai.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
            txtNgayra.Text = dataGridView1.Rows[i].Cells[6].Value.ToString();
            txtNgayvao.Text = dataGridView1.Rows[i].Cells[7].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string sql = "insert into Maychuchinh (id, masv, tensv, ngaysinh, gioitinh, sodienthoai, ngayra, ngayvao) values ('" + txtId.Text + "','" + txtMasinhvien.Text + "', '" + txtTensinhvien.Text + "','" + txtNgaysinh.Text + "','" + txtGioitinh.Text + "','" + txtSodienthoai.Text + "','" + txtNgayra.Text + "','" + txtNgayvao.Text + "')";
            Ketnoi.ExecuteNonQuery_Pro(sql);
            string sql1 = "select * from Maychuchinh";
            DataTable mytable = Ketnoi.ExecuteDataTable_SQL(sql1);
            dataGridView1.DataSource = mytable;
            txtId.Focus();
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql = "update Maychuchinh set tensv= '" + txtTensinhvien.Text + "' where id = '"+txtId.Text+"'";
            Ketnoi.ExecuteNonQuery_Pro(sql);
            MessageBox.Show("Sửa dữ liệu thành công");
            txtId.Focus();
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql2 = "Delete from Maychuchinh where id= '" + txtId.Text + "'";
            Ketnoi.ExecuteNonQuery_Pro(sql2);
            string sql3 = "select * from Maychuchinh";
            DataTable data = Ketnoi.ExecuteDataTable_SQL(sql3);
            dataGridView1.DataSource = data;
            txtId.Focus();

        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            string sql = "select * from Maychuchinh where id= '" + txtId.Text + "'";
            DataTable dataTable = Ketnoi.ExecuteDataTable_SQL(sql);
            dataGridView1.DataSource = dataTable;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show("Bạn có muốn thoát", "Chú ý", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
                base.Close();
        }
    }
}
