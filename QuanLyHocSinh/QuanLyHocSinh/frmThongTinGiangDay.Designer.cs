namespace QuanLyHocSinh
{
    partial class frmThongTinGiangDay
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
            this.btHienThi = new System.Windows.Forms.Button();
            this.btThoat = new System.Windows.Forms.Button();
            this.btTiemKiem = new System.Windows.Forms.Button();
            this.dtgvThongTinGD = new System.Windows.Forms.DataGridView();
            this.magv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.malh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenlh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mamh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenmh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btXoa = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.grbChucNang = new System.Windows.Forms.GroupBox();
            this.txtMaLH = new System.Windows.Forms.TextBox();
            this.txtMaGV = new System.Windows.Forms.TextBox();
            this.cbTenLH = new System.Windows.Forms.ComboBox();
            this.cbTenGV = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.grbDeAn = new System.Windows.Forms.GroupBox();
            this.txtTiet = new System.Windows.Forms.TextBox();
            this.txtThu = new System.Windows.Forms.TextBox();
            this.txtMaMH = new System.Windows.Forms.TextBox();
            this.cbTenMH = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btCancel = new System.Windows.Forms.Button();
            this.btOk = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvThongTinGD)).BeginInit();
            this.grbChucNang.SuspendLayout();
            this.grbDeAn.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btHienThi
            // 
            this.btHienThi.Enabled = false;
            this.btHienThi.Location = new System.Drawing.Point(587, 228);
            this.btHienThi.Name = "btHienThi";
            this.btHienThi.Size = new System.Drawing.Size(95, 23);
            this.btHienThi.TabIndex = 11;
            this.btHienThi.Text = "Hiện thị thông tin";
            this.btHienThi.UseVisualStyleBackColor = true;
            this.btHienThi.Click += new System.EventHandler(this.btHienThi_Click);
            // 
            // btThoat
            // 
            this.btThoat.Location = new System.Drawing.Point(593, 419);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(75, 23);
            this.btThoat.TabIndex = 5;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click_1);
            // 
            // btTiemKiem
            // 
            this.btTiemKiem.Location = new System.Drawing.Point(607, 199);
            this.btTiemKiem.Name = "btTiemKiem";
            this.btTiemKiem.Size = new System.Drawing.Size(75, 23);
            this.btTiemKiem.TabIndex = 6;
            this.btTiemKiem.Text = "Tìm kiếm";
            this.btTiemKiem.UseVisualStyleBackColor = true;
            this.btTiemKiem.Click += new System.EventHandler(this.btTiemKiem_Click);
            // 
            // dtgvThongTinGD
            // 
            this.dtgvThongTinGD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvThongTinGD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.magv,
            this.ten,
            this.malh,
            this.tenlh,
            this.thu,
            this.tiet,
            this.mamh,
            this.tenmh});
            this.dtgvThongTinGD.Location = new System.Drawing.Point(12, 293);
            this.dtgvThongTinGD.Name = "dtgvThongTinGD";
            this.dtgvThongTinGD.RowHeadersVisible = false;
            this.dtgvThongTinGD.Size = new System.Drawing.Size(569, 168);
            this.dtgvThongTinGD.TabIndex = 10;
            this.dtgvThongTinGD.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvThongTinGD_CellClick);
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
            this.ten.HeaderText = "Giáo viên";
            this.ten.Name = "ten";
            this.ten.Width = 120;
            // 
            // malh
            // 
            this.malh.DataPropertyName = "malh";
            this.malh.HeaderText = "Mã lớp học";
            this.malh.Name = "malh";
            this.malh.Width = 50;
            // 
            // tenlh
            // 
            this.tenlh.DataPropertyName = "tenlh";
            this.tenlh.HeaderText = "Lớp học";
            this.tenlh.Name = "tenlh";
            // 
            // thu
            // 
            this.thu.DataPropertyName = "thu";
            this.thu.HeaderText = "Thứ";
            this.thu.Name = "thu";
            // 
            // tiet
            // 
            this.tiet.DataPropertyName = "tiet";
            this.tiet.HeaderText = "Tiết";
            this.tiet.Name = "tiet";
            // 
            // mamh
            // 
            this.mamh.DataPropertyName = "mamh";
            this.mamh.HeaderText = "Mã môn học";
            this.mamh.Name = "mamh";
            this.mamh.Width = 50;
            // 
            // tenmh
            // 
            this.tenmh.DataPropertyName = "tenmh";
            this.tenmh.HeaderText = "Môn học";
            this.tenmh.Name = "tenmh";
            // 
            // btXoa
            // 
            this.btXoa.Location = new System.Drawing.Point(38, 99);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(75, 23);
            this.btXoa.TabIndex = 0;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btSua
            // 
            this.btSua.Location = new System.Drawing.Point(38, 59);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(75, 23);
            this.btSua.TabIndex = 0;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btThem
            // 
            this.btThem.Location = new System.Drawing.Point(38, 24);
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
            this.grbChucNang.Location = new System.Drawing.Point(549, 21);
            this.grbChucNang.Name = "grbChucNang";
            this.grbChucNang.Size = new System.Drawing.Size(133, 144);
            this.grbChucNang.TabIndex = 9;
            this.grbChucNang.TabStop = false;
            this.grbChucNang.Text = "Chức năng";
            // 
            // txtMaLH
            // 
            this.txtMaLH.Enabled = false;
            this.txtMaLH.Location = new System.Drawing.Point(301, 58);
            this.txtMaLH.Name = "txtMaLH";
            this.txtMaLH.Size = new System.Drawing.Size(100, 20);
            this.txtMaLH.TabIndex = 2;
            // 
            // txtMaGV
            // 
            this.txtMaGV.Enabled = false;
            this.txtMaGV.Location = new System.Drawing.Point(302, 21);
            this.txtMaGV.Name = "txtMaGV";
            this.txtMaGV.Size = new System.Drawing.Size(100, 20);
            this.txtMaGV.TabIndex = 2;
            // 
            // cbTenLH
            // 
            this.cbTenLH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTenLH.FormattingEnabled = true;
            this.cbTenLH.Location = new System.Drawing.Point(113, 57);
            this.cbTenLH.Name = "cbTenLH";
            this.cbTenLH.Size = new System.Drawing.Size(161, 21);
            this.cbTenLH.TabIndex = 1;
            this.cbTenLH.SelectedIndexChanged += new System.EventHandler(this.cbTenLH_SelectedIndexChanged);
            // 
            // cbTenGV
            // 
            this.cbTenGV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTenGV.FormattingEnabled = true;
            this.cbTenGV.Location = new System.Drawing.Point(113, 21);
            this.cbTenGV.Name = "cbTenGV";
            this.cbTenGV.Size = new System.Drawing.Size(161, 21);
            this.cbTenGV.TabIndex = 1;
            this.cbTenGV.SelectedIndexChanged += new System.EventHandler(this.cbTenGV_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lớp học";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Giáo viên";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(394, 199);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(207, 20);
            this.txtTimKiem.TabIndex = 7;
            // 
            // grbDeAn
            // 
            this.grbDeAn.Controls.Add(this.txtTiet);
            this.grbDeAn.Controls.Add(this.txtThu);
            this.grbDeAn.Controls.Add(this.txtMaLH);
            this.grbDeAn.Controls.Add(this.txtMaMH);
            this.grbDeAn.Controls.Add(this.txtMaGV);
            this.grbDeAn.Controls.Add(this.cbTenLH);
            this.grbDeAn.Controls.Add(this.cbTenMH);
            this.grbDeAn.Controls.Add(this.cbTenGV);
            this.grbDeAn.Controls.Add(this.label4);
            this.grbDeAn.Controls.Add(this.label3);
            this.grbDeAn.Controls.Add(this.label5);
            this.grbDeAn.Controls.Add(this.label1);
            this.grbDeAn.Controls.Add(this.label2);
            this.grbDeAn.Location = new System.Drawing.Point(55, 9);
            this.grbDeAn.Name = "grbDeAn";
            this.grbDeAn.Size = new System.Drawing.Size(407, 183);
            this.grbDeAn.TabIndex = 8;
            this.grbDeAn.TabStop = false;
            this.grbDeAn.Text = "Thông tin giảng dạy";
            // 
            // txtTiet
            // 
            this.txtTiet.Enabled = false;
            this.txtTiet.Location = new System.Drawing.Point(113, 121);
            this.txtTiet.Name = "txtTiet";
            this.txtTiet.Size = new System.Drawing.Size(161, 20);
            this.txtTiet.TabIndex = 2;
            // 
            // txtThu
            // 
            this.txtThu.Enabled = false;
            this.txtThu.Location = new System.Drawing.Point(113, 89);
            this.txtThu.Name = "txtThu";
            this.txtThu.Size = new System.Drawing.Size(161, 20);
            this.txtThu.TabIndex = 2;
            // 
            // txtMaMH
            // 
            this.txtMaMH.Enabled = false;
            this.txtMaMH.Location = new System.Drawing.Point(302, 146);
            this.txtMaMH.Name = "txtMaMH";
            this.txtMaMH.Size = new System.Drawing.Size(100, 20);
            this.txtMaMH.TabIndex = 2;
            // 
            // cbTenMH
            // 
            this.cbTenMH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTenMH.FormattingEnabled = true;
            this.cbTenMH.Location = new System.Drawing.Point(113, 146);
            this.cbTenMH.Name = "cbTenMH";
            this.cbTenMH.Size = new System.Drawing.Size(161, 21);
            this.cbTenMH.TabIndex = 1;
            this.cbTenMH.SelectedIndexChanged += new System.EventHandler(this.cbTenMH_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tiết";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Thứ ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Môn học";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btCancel);
            this.panel1.Controls.Add(this.btOk);
            this.panel1.Location = new System.Drawing.Point(129, 214);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 51);
            this.panel1.TabIndex = 17;
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
            // frmThongTinGiangDay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(697, 473);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btHienThi);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btTiemKiem);
            this.Controls.Add(this.dtgvThongTinGD);
            this.Controls.Add(this.grbChucNang);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.grbDeAn);
            this.Name = "frmThongTinGiangDay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin giảng dạy";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvThongTinGD)).EndInit();
            this.grbChucNang.ResumeLayout(false);
            this.grbDeAn.ResumeLayout(false);
            this.grbDeAn.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btHienThi;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Button btTiemKiem;
        private System.Windows.Forms.DataGridView dtgvThongTinGD;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.GroupBox grbChucNang;
        private System.Windows.Forms.TextBox txtMaLH;
        private System.Windows.Forms.TextBox txtMaGV;
        private System.Windows.Forms.ComboBox cbTenLH;
        private System.Windows.Forms.ComboBox cbTenGV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.GroupBox grbDeAn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTiet;
        private System.Windows.Forms.TextBox txtThu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaMH;
        private System.Windows.Forms.ComboBox cbTenMH;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btOk;
        private System.Windows.Forms.DataGridViewTextBoxColumn magv;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn malh;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenlh;
        private System.Windows.Forms.DataGridViewTextBoxColumn thu;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiet;
        private System.Windows.Forms.DataGridViewTextBoxColumn mamh;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenmh;
    }
}