namespace QuanLyHocSinh
{
    partial class frmGiaoVien
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
            this.dtgvGiaoVien = new System.Windows.Forms.DataGridView();
            this.magv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sodt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaysinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.luong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbKhac = new System.Windows.Forms.RadioButton();
            this.rbNu = new System.Windows.Forms.RadioButton();
            this.rbNam = new System.Windows.Forms.RadioButton();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtLuong = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtMaGV = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btThoat = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btHienThi = new System.Windows.Forms.Button();
            this.lbTenPhong = new System.Windows.Forms.Label();
            this.btXoa = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.grbChucNang = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btTimKiem = new System.Windows.Forms.Button();
            this.grbNhanVien = new System.Windows.Forms.GroupBox();
            this.txtSoDT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btCancel = new System.Windows.Forms.Button();
            this.btOk = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvGiaoVien)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.grbChucNang.SuspendLayout();
            this.grbNhanVien.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgvGiaoVien
            // 
            this.dtgvGiaoVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvGiaoVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.magv,
            this.ten,
            this.sodt,
            this.ngaysinh,
            this.gioitinh,
            this.luong,
            this.diachi});
            this.dtgvGiaoVien.Location = new System.Drawing.Point(28, 338);
            this.dtgvGiaoVien.Name = "dtgvGiaoVien";
            this.dtgvGiaoVien.RowHeadersVisible = false;
            this.dtgvGiaoVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvGiaoVien.Size = new System.Drawing.Size(669, 179);
            this.dtgvGiaoVien.TabIndex = 12;
            this.dtgvGiaoVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvGiaoVien_CellClick);
            // 
            // magv
            // 
            this.magv.DataPropertyName = "magv";
            this.magv.HeaderText = "Mã giáo viên";
            this.magv.Name = "magv";
            this.magv.Width = 50;
            // 
            // ten
            // 
            this.ten.DataPropertyName = "ten";
            this.ten.HeaderText = "Họ tên";
            this.ten.Name = "ten";
            this.ten.Width = 150;
            // 
            // sodt
            // 
            this.sodt.DataPropertyName = "sodt";
            this.sodt.HeaderText = "Số diện thoại";
            this.sodt.Name = "sodt";
            // 
            // ngaysinh
            // 
            this.ngaysinh.DataPropertyName = "ngaysinh";
            this.ngaysinh.HeaderText = "Ngày sinh";
            this.ngaysinh.Name = "ngaysinh";
            this.ngaysinh.Width = 80;
            // 
            // gioitinh
            // 
            this.gioitinh.DataPropertyName = "gioitinh";
            this.gioitinh.HeaderText = "Giói tính";
            this.gioitinh.Name = "gioitinh";
            this.gioitinh.Width = 50;
            // 
            // luong
            // 
            this.luong.DataPropertyName = "luong";
            this.luong.HeaderText = "Lương";
            this.luong.Name = "luong";
            this.luong.Width = 80;
            // 
            // diachi
            // 
            this.diachi.DataPropertyName = "diachi";
            this.diachi.HeaderText = "Địa chỉ";
            this.diachi.Name = "diachi";
            this.diachi.Width = 150;
            // 
            // dtNgaySinh
            // 
            this.dtNgaySinh.Location = new System.Drawing.Point(138, 131);
            this.dtNgaySinh.Name = "dtNgaySinh";
            this.dtNgaySinh.Size = new System.Drawing.Size(260, 20);
            this.dtNgaySinh.TabIndex = 3;
            this.dtNgaySinh.Value = new System.DateTime(1997, 10, 1, 0, 0, 0, 0);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbKhac);
            this.groupBox1.Controls.Add(this.rbNu);
            this.groupBox1.Controls.Add(this.rbNam);
            this.groupBox1.Location = new System.Drawing.Point(139, 152);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 43);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // rbKhac
            // 
            this.rbKhac.AutoSize = true;
            this.rbKhac.Location = new System.Drawing.Point(189, 16);
            this.rbKhac.Name = "rbKhac";
            this.rbKhac.Size = new System.Drawing.Size(50, 17);
            this.rbKhac.TabIndex = 0;
            this.rbKhac.TabStop = true;
            this.rbKhac.Text = "Khác";
            this.rbKhac.UseVisualStyleBackColor = true;
            // 
            // rbNu
            // 
            this.rbNu.AutoSize = true;
            this.rbNu.Location = new System.Drawing.Point(107, 16);
            this.rbNu.Name = "rbNu";
            this.rbNu.Size = new System.Drawing.Size(39, 17);
            this.rbNu.TabIndex = 0;
            this.rbNu.TabStop = true;
            this.rbNu.Text = "Nữ";
            this.rbNu.UseVisualStyleBackColor = true;
            // 
            // rbNam
            // 
            this.rbNam.AutoSize = true;
            this.rbNam.Location = new System.Drawing.Point(6, 18);
            this.rbNam.Name = "rbNam";
            this.rbNam.Size = new System.Drawing.Size(47, 17);
            this.rbNam.TabIndex = 0;
            this.rbNam.TabStop = true;
            this.rbNam.Text = "Nam";
            this.rbNam.UseVisualStyleBackColor = true;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(138, 235);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(260, 20);
            this.txtDiaChi.TabIndex = 6;
            // 
            // txtLuong
            // 
            this.txtLuong.Location = new System.Drawing.Point(138, 204);
            this.txtLuong.Name = "txtLuong";
            this.txtLuong.Size = new System.Drawing.Size(260, 20);
            this.txtLuong.TabIndex = 5;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(139, 57);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(259, 20);
            this.txtTen.TabIndex = 1;
            // 
            // txtMaGV
            // 
            this.txtMaGV.Location = new System.Drawing.Point(139, 26);
            this.txtMaGV.Name = "txtMaGV";
            this.txtMaGV.Size = new System.Drawing.Size(259, 20);
            this.txtMaGV.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 242);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Địa chỉ:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Lương:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ngày sinh:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Họ tên:";
            // 
            // btThoat
            // 
            this.btThoat.Location = new System.Drawing.Point(739, 491);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(75, 23);
            this.btThoat.TabIndex = 8;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Giới tính:";
            // 
            // btHienThi
            // 
            this.btHienThi.Enabled = false;
            this.btHienThi.Location = new System.Drawing.Point(687, 309);
            this.btHienThi.Name = "btHienThi";
            this.btHienThi.Size = new System.Drawing.Size(91, 23);
            this.btHienThi.TabIndex = 14;
            this.btHienThi.Text = "Hiện thị dữ liệu";
            this.btHienThi.UseVisualStyleBackColor = true;
            this.btHienThi.Click += new System.EventHandler(this.btHienThi_Click);
            // 
            // lbTenPhong
            // 
            this.lbTenPhong.AutoSize = true;
            this.lbTenPhong.Location = new System.Drawing.Point(136, 149);
            this.lbTenPhong.Name = "lbTenPhong";
            this.lbTenPhong.Size = new System.Drawing.Size(0, 13);
            this.lbTenPhong.TabIndex = 0;
            // 
            // btXoa
            // 
            this.btXoa.Location = new System.Drawing.Point(44, 172);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(75, 23);
            this.btXoa.TabIndex = 0;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btSua
            // 
            this.btSua.Location = new System.Drawing.Point(44, 99);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(75, 23);
            this.btSua.TabIndex = 0;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btThem
            // 
            this.btThem.Location = new System.Drawing.Point(44, 33);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(75, 23);
            this.btThem.TabIndex = 0;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // grbChucNang
            // 
            this.grbChucNang.Controls.Add(this.btXoa);
            this.grbChucNang.Controls.Add(this.btSua);
            this.grbChucNang.Controls.Add(this.btThem);
            this.grbChucNang.Location = new System.Drawing.Point(631, 25);
            this.grbChucNang.Name = "grbChucNang";
            this.grbChucNang.Size = new System.Drawing.Size(167, 238);
            this.grbChucNang.TabIndex = 11;
            this.grbChucNang.TabStop = false;
            this.grbChucNang.Text = "Chức năng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã giáo viên";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(542, 276);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(155, 20);
            this.txtTimKiem.TabIndex = 13;
            // 
            // btTimKiem
            // 
            this.btTimKiem.Location = new System.Drawing.Point(703, 273);
            this.btTimKiem.Name = "btTimKiem";
            this.btTimKiem.Size = new System.Drawing.Size(75, 23);
            this.btTimKiem.TabIndex = 9;
            this.btTimKiem.Text = "Tìm kiếm";
            this.btTimKiem.UseVisualStyleBackColor = true;
            this.btTimKiem.Click += new System.EventHandler(this.btTimKiem_Click);
            // 
            // grbNhanVien
            // 
            this.grbNhanVien.Controls.Add(this.dtNgaySinh);
            this.grbNhanVien.Controls.Add(this.groupBox1);
            this.grbNhanVien.Controls.Add(this.txtDiaChi);
            this.grbNhanVien.Controls.Add(this.txtLuong);
            this.grbNhanVien.Controls.Add(this.txtSoDT);
            this.grbNhanVien.Controls.Add(this.txtTen);
            this.grbNhanVien.Controls.Add(this.txtMaGV);
            this.grbNhanVien.Controls.Add(this.label7);
            this.grbNhanVien.Controls.Add(this.label5);
            this.grbNhanVien.Controls.Add(this.label6);
            this.grbNhanVien.Controls.Add(this.label4);
            this.grbNhanVien.Controls.Add(this.label3);
            this.grbNhanVien.Controls.Add(this.label2);
            this.grbNhanVien.Controls.Add(this.lbTenPhong);
            this.grbNhanVien.Controls.Add(this.label1);
            this.grbNhanVien.Location = new System.Drawing.Point(61, 8);
            this.grbNhanVien.Name = "grbNhanVien";
            this.grbNhanVien.Size = new System.Drawing.Size(423, 267);
            this.grbNhanVien.TabIndex = 10;
            this.grbNhanVien.TabStop = false;
            this.grbNhanVien.Text = "Thông tin giáo viên";
            // 
            // txtSoDT
            // 
            this.txtSoDT.Location = new System.Drawing.Point(139, 93);
            this.txtSoDT.Name = "txtSoDT";
            this.txtSoDT.Size = new System.Drawing.Size(259, 20);
            this.txtSoDT.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Số điện thoại";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btCancel);
            this.panel1.Controls.Add(this.btOk);
            this.panel1.Location = new System.Drawing.Point(239, 281);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 51);
            this.panel1.TabIndex = 15;
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(121, 13);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 13;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Visible = false;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btOk
            // 
            this.btOk.Location = new System.Drawing.Point(3, 13);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(75, 23);
            this.btOk.TabIndex = 13;
            this.btOk.Text = "Ok";
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Visible = false;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // frmGiaoVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(833, 519);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtgvGiaoVien);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btHienThi);
            this.Controls.Add(this.grbChucNang);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.btTimKiem);
            this.Controls.Add(this.grbNhanVien);
            this.Name = "frmGiaoVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giáo viên";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvGiaoVien)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grbChucNang.ResumeLayout(false);
            this.grbNhanVien.ResumeLayout(false);
            this.grbNhanVien.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvGiaoVien;
        private System.Windows.Forms.DateTimePicker dtNgaySinh;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbKhac;
        private System.Windows.Forms.RadioButton rbNu;
        private System.Windows.Forms.RadioButton rbNam;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtLuong;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtMaGV;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btHienThi;
        private System.Windows.Forms.Label lbTenPhong;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.GroupBox grbChucNang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btTimKiem;
        private System.Windows.Forms.GroupBox grbNhanVien;
        private System.Windows.Forms.TextBox txtSoDT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn magv;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn sodt;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaysinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn luong;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachi;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btOk;
    }
}