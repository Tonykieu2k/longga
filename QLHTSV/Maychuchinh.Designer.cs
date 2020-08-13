namespace QLHTSV
{
    partial class Maychuchinh
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtMasinhvien = new System.Windows.Forms.TextBox();
            this.txtTensinhvien = new System.Windows.Forms.TextBox();
            this.txtSodienthoai = new System.Windows.Forms.TextBox();
            this.txtGioitinh = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNgaysinh = new System.Windows.Forms.DateTimePicker();
            this.txtNgayra = new System.Windows.Forms.DateTimePicker();
            this.txtNgayvao = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.masvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tensvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaysinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioitinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sodienthoaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayvaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maychuchinhBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLSVDataSet = new QLHTSV.QLSVDataSet();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.maychuchinhTableAdapter = new QLHTSV.QLSVDataSetTableAdapters.MaychuchinhTableAdapter();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnTimkiem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maychuchinhBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSVDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMasinhvien
            // 
            this.txtMasinhvien.Location = new System.Drawing.Point(161, 32);
            this.txtMasinhvien.Name = "txtMasinhvien";
            this.txtMasinhvien.Size = new System.Drawing.Size(171, 22);
            this.txtMasinhvien.TabIndex = 0;
            // 
            // txtTensinhvien
            // 
            this.txtTensinhvien.Location = new System.Drawing.Point(161, 94);
            this.txtTensinhvien.Name = "txtTensinhvien";
            this.txtTensinhvien.Size = new System.Drawing.Size(171, 22);
            this.txtTensinhvien.TabIndex = 1;
            // 
            // txtSodienthoai
            // 
            this.txtSodienthoai.Location = new System.Drawing.Point(504, 94);
            this.txtSodienthoai.Name = "txtSodienthoai";
            this.txtSodienthoai.Size = new System.Drawing.Size(178, 22);
            this.txtSodienthoai.TabIndex = 2;
            // 
            // txtGioitinh
            // 
            this.txtGioitinh.FormattingEnabled = true;
            this.txtGioitinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.txtGioitinh.Location = new System.Drawing.Point(504, 32);
            this.txtGioitinh.Name = "txtGioitinh";
            this.txtGioitinh.Size = new System.Drawing.Size(178, 24);
            this.txtGioitinh.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mã sinh viên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tên sinh viên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ngày sinh:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(416, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Giới tính:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(385, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Số điện thoại:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(714, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Ngày ra:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(714, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Ngày vào:";
            // 
            // txtNgaysinh
            // 
            this.txtNgaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtNgaysinh.Location = new System.Drawing.Point(161, 150);
            this.txtNgaysinh.Name = "txtNgaysinh";
            this.txtNgaysinh.Size = new System.Drawing.Size(200, 22);
            this.txtNgaysinh.TabIndex = 11;
            // 
            // txtNgayra
            // 
            this.txtNgayra.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtNgayra.Location = new System.Drawing.Point(832, 35);
            this.txtNgayra.Name = "txtNgayra";
            this.txtNgayra.Size = new System.Drawing.Size(200, 22);
            this.txtNgayra.TabIndex = 12;
            // 
            // txtNgayvao
            // 
            this.txtNgayvao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtNgayvao.Location = new System.Drawing.Point(832, 94);
            this.txtNgayvao.Name = "txtNgayvao";
            this.txtNgayvao.Size = new System.Drawing.Size(200, 22);
            this.txtNgayvao.TabIndex = 13;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.masvDataGridViewTextBoxColumn,
            this.tensvDataGridViewTextBoxColumn,
            this.ngaysinhDataGridViewTextBoxColumn,
            this.gioitinhDataGridViewTextBoxColumn,
            this.sodienthoaiDataGridViewTextBoxColumn,
            this.ngayraDataGridViewTextBoxColumn,
            this.ngayvaoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.maychuchinhBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(49, 212);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(983, 263);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgSinhvien_CellClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // masvDataGridViewTextBoxColumn
            // 
            this.masvDataGridViewTextBoxColumn.DataPropertyName = "masv";
            this.masvDataGridViewTextBoxColumn.HeaderText = "masv";
            this.masvDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.masvDataGridViewTextBoxColumn.Name = "masvDataGridViewTextBoxColumn";
            this.masvDataGridViewTextBoxColumn.Width = 125;
            // 
            // tensvDataGridViewTextBoxColumn
            // 
            this.tensvDataGridViewTextBoxColumn.DataPropertyName = "tensv";
            this.tensvDataGridViewTextBoxColumn.HeaderText = "tensv";
            this.tensvDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tensvDataGridViewTextBoxColumn.Name = "tensvDataGridViewTextBoxColumn";
            this.tensvDataGridViewTextBoxColumn.Width = 125;
            // 
            // ngaysinhDataGridViewTextBoxColumn
            // 
            this.ngaysinhDataGridViewTextBoxColumn.DataPropertyName = "ngaysinh";
            this.ngaysinhDataGridViewTextBoxColumn.HeaderText = "ngaysinh";
            this.ngaysinhDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngaysinhDataGridViewTextBoxColumn.Name = "ngaysinhDataGridViewTextBoxColumn";
            this.ngaysinhDataGridViewTextBoxColumn.Width = 125;
            // 
            // gioitinhDataGridViewTextBoxColumn
            // 
            this.gioitinhDataGridViewTextBoxColumn.DataPropertyName = "gioitinh";
            this.gioitinhDataGridViewTextBoxColumn.HeaderText = "gioitinh";
            this.gioitinhDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.gioitinhDataGridViewTextBoxColumn.Name = "gioitinhDataGridViewTextBoxColumn";
            this.gioitinhDataGridViewTextBoxColumn.Width = 125;
            // 
            // sodienthoaiDataGridViewTextBoxColumn
            // 
            this.sodienthoaiDataGridViewTextBoxColumn.DataPropertyName = "sodienthoai";
            this.sodienthoaiDataGridViewTextBoxColumn.HeaderText = "sodienthoai";
            this.sodienthoaiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sodienthoaiDataGridViewTextBoxColumn.Name = "sodienthoaiDataGridViewTextBoxColumn";
            this.sodienthoaiDataGridViewTextBoxColumn.Width = 125;
            // 
            // ngayraDataGridViewTextBoxColumn
            // 
            this.ngayraDataGridViewTextBoxColumn.DataPropertyName = "ngayra";
            this.ngayraDataGridViewTextBoxColumn.HeaderText = "ngayra";
            this.ngayraDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngayraDataGridViewTextBoxColumn.Name = "ngayraDataGridViewTextBoxColumn";
            this.ngayraDataGridViewTextBoxColumn.Width = 125;
            // 
            // ngayvaoDataGridViewTextBoxColumn
            // 
            this.ngayvaoDataGridViewTextBoxColumn.DataPropertyName = "ngayvao";
            this.ngayvaoDataGridViewTextBoxColumn.HeaderText = "ngayvao";
            this.ngayvaoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngayvaoDataGridViewTextBoxColumn.Name = "ngayvaoDataGridViewTextBoxColumn";
            this.ngayvaoDataGridViewTextBoxColumn.Width = 125;
            // 
            // maychuchinhBindingSource
            // 
            this.maychuchinhBindingSource.DataMember = "Maychuchinh";
            this.maychuchinhBindingSource.DataSource = this.qLSVDataSet;
            // 
            // qLSVDataSet
            // 
            this.qLSVDataSet.DataSetName = "QLSVDataSet";
            this.qLSVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(405, 500);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 15;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(529, 500);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 16;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(667, 500);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 17;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(905, 500);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 18;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // maychuchinhTableAdapter
            // 
            this.maychuchinhTableAdapter.ClearBeforeFill = true;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(489, 166);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(171, 22);
            this.txtId.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(425, 169);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 17);
            this.label8.TabIndex = 20;
            this.label8.Text = "id:";
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Location = new System.Drawing.Point(798, 500);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimkiem.TabIndex = 21;
            this.btnTimkiem.Text = "Tìm kiếm";
            this.btnTimkiem.UseVisualStyleBackColor = true;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // Maychuchinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 535);
            this.Controls.Add(this.btnTimkiem);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtNgayvao);
            this.Controls.Add(this.txtNgayra);
            this.Controls.Add(this.txtNgaysinh);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtGioitinh);
            this.Controls.Add(this.txtSodienthoai);
            this.Controls.Add(this.txtTensinhvien);
            this.Controls.Add(this.txtMasinhvien);
            this.Name = "Maychuchinh";
            this.Text = "Maychuchinh";
            this.Load += new System.EventHandler(this.Maychuchinh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maychuchinhBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSVDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMasinhvien;
        private System.Windows.Forms.TextBox txtTensinhvien;
        private System.Windows.Forms.TextBox txtSodienthoai;
        private System.Windows.Forms.ComboBox txtGioitinh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker txtNgaysinh;
        private System.Windows.Forms.DateTimePicker txtNgayra;
        private System.Windows.Forms.DateTimePicker txtNgayvao;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private QLSVDataSet qLSVDataSet;
        private System.Windows.Forms.BindingSource maychuchinhBindingSource;
        private QLSVDataSetTableAdapters.MaychuchinhTableAdapter maychuchinhTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn masvDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tensvDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaysinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioitinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sodienthoaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayvaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnTimkiem;
    }
}