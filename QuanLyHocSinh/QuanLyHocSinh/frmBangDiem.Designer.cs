namespace QuanLyHocSinh
{
    partial class frmBangDiem
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
            this.dtgvBangDiem = new System.Windows.Forms.DataGridView();
            this.mahs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mamh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenmh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dmieng = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.d15phut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.d1tiet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dcuoiky = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btXoa = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.grbChucNang = new System.Windows.Forms.GroupBox();
            this.txtMaMH = new System.Windows.Forms.TextBox();
            this.txtMaHS = new System.Windows.Forms.TextBox();
            this.cbMaMH = new System.Windows.Forms.ComboBox();
            this.cbMaHS = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.grbDeAn = new System.Windows.Forms.GroupBox();
            this.txtDiemHK = new System.Windows.Forms.TextBox();
            this.txtDiem1 = new System.Windows.Forms.TextBox();
            this.txtDiem15 = new System.Windows.Forms.TextBox();
            this.txtDiemMieng = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btCancel = new System.Windows.Forms.Button();
            this.btOk = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBangDiem)).BeginInit();
            this.grbChucNang.SuspendLayout();
            this.grbDeAn.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btHienThi
            // 
            this.btHienThi.Enabled = false;
            this.btHienThi.Location = new System.Drawing.Point(551, 256);
            this.btHienThi.Name = "btHienThi";
            this.btHienThi.Size = new System.Drawing.Size(95, 23);
            this.btHienThi.TabIndex = 11;
            this.btHienThi.Text = "Hiện thị thông tin";
            this.btHienThi.UseVisualStyleBackColor = true;
            this.btHienThi.Click += new System.EventHandler(this.btHienThi_Click);
            // 
            // btThoat
            // 
            this.btThoat.Location = new System.Drawing.Point(557, 395);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(75, 23);
            this.btThoat.TabIndex = 5;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // btTiemKiem
            // 
            this.btTiemKiem.Location = new System.Drawing.Point(571, 227);
            this.btTiemKiem.Name = "btTiemKiem";
            this.btTiemKiem.Size = new System.Drawing.Size(75, 23);
            this.btTiemKiem.TabIndex = 6;
            this.btTiemKiem.Text = "Tìm kiếm";
            this.btTiemKiem.UseVisualStyleBackColor = true;
            this.btTiemKiem.Click += new System.EventHandler(this.btTiemKiem_Click);
            // 
            // dtgvBangDiem
            // 
            this.dtgvBangDiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvBangDiem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mahs,
            this.ten,
            this.mamh,
            this.tenmh,
            this.dmieng,
            this.d15phut,
            this.d1tiet,
            this.dcuoiky});
            this.dtgvBangDiem.Location = new System.Drawing.Point(24, 256);
            this.dtgvBangDiem.Name = "dtgvBangDiem";
            this.dtgvBangDiem.RowHeadersVisible = false;
            this.dtgvBangDiem.Size = new System.Drawing.Size(506, 168);
            this.dtgvBangDiem.TabIndex = 10;
            this.dtgvBangDiem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvBangDiem_CellClick);
            // 
            // mahs
            // 
            this.mahs.DataPropertyName = "mahs";
            this.mahs.HeaderText = "Mã học sinh";
            this.mahs.Name = "mahs";
            this.mahs.Width = 50;
            // 
            // ten
            // 
            this.ten.DataPropertyName = "ten";
            this.ten.HeaderText = "Tên học sinh";
            this.ten.Name = "ten";
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
            this.tenmh.HeaderText = "Tên môn học";
            this.tenmh.Name = "tenmh";
            // 
            // dmieng
            // 
            this.dmieng.DataPropertyName = "dmieng";
            this.dmieng.HeaderText = "Điểm miệng";
            this.dmieng.Name = "dmieng";
            this.dmieng.Width = 50;
            // 
            // d15phut
            // 
            this.d15phut.DataPropertyName = "d15phut";
            this.d15phut.HeaderText = "Điểm 15 phút";
            this.d15phut.Name = "d15phut";
            this.d15phut.Width = 50;
            // 
            // d1tiet
            // 
            this.d1tiet.DataPropertyName = "d1tiet";
            this.d1tiet.HeaderText = "Điểm 1  tiết";
            this.d1tiet.Name = "d1tiet";
            this.d1tiet.Width = 50;
            // 
            // dcuoiky
            // 
            this.dcuoiky.DataPropertyName = "dcuoiky";
            this.dcuoiky.HeaderText = "Điểm cuối kỳ";
            this.dcuoiky.Name = "dcuoiky";
            this.dcuoiky.Width = 50;
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
            this.grbChucNang.Location = new System.Drawing.Point(533, 33);
            this.grbChucNang.Name = "grbChucNang";
            this.grbChucNang.Size = new System.Drawing.Size(133, 144);
            this.grbChucNang.TabIndex = 9;
            this.grbChucNang.TabStop = false;
            this.grbChucNang.Text = "Chức năng";
            // 
            // txtMaMH
            // 
            this.txtMaMH.Enabled = false;
            this.txtMaMH.Location = new System.Drawing.Point(301, 58);
            this.txtMaMH.Name = "txtMaMH";
            this.txtMaMH.Size = new System.Drawing.Size(100, 20);
            this.txtMaMH.TabIndex = 2;
            // 
            // txtMaHS
            // 
            this.txtMaHS.Enabled = false;
            this.txtMaHS.Location = new System.Drawing.Point(302, 21);
            this.txtMaHS.Name = "txtMaHS";
            this.txtMaHS.Size = new System.Drawing.Size(100, 20);
            this.txtMaHS.TabIndex = 2;
            // 
            // cbMaMH
            // 
            this.cbMaMH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaMH.FormattingEnabled = true;
            this.cbMaMH.Location = new System.Drawing.Point(113, 57);
            this.cbMaMH.Name = "cbMaMH";
            this.cbMaMH.Size = new System.Drawing.Size(161, 21);
            this.cbMaMH.TabIndex = 1;
            this.cbMaMH.SelectedIndexChanged += new System.EventHandler(this.cbMaMH_SelectedIndexChanged);
            // 
            // cbMaHS
            // 
            this.cbMaHS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaHS.FormattingEnabled = true;
            this.cbMaHS.Location = new System.Drawing.Point(113, 21);
            this.cbMaHS.Name = "cbMaHS";
            this.cbMaHS.Size = new System.Drawing.Size(161, 21);
            this.cbMaHS.TabIndex = 1;
            this.cbMaHS.SelectedIndexChanged += new System.EventHandler(this.cbMaHS_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Môn học";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Học sinh";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(358, 227);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(207, 20);
            this.txtTimKiem.TabIndex = 7;
            // 
            // grbDeAn
            // 
            this.grbDeAn.Controls.Add(this.txtMaMH);
            this.grbDeAn.Controls.Add(this.txtDiemHK);
            this.grbDeAn.Controls.Add(this.txtDiem1);
            this.grbDeAn.Controls.Add(this.txtDiem15);
            this.grbDeAn.Controls.Add(this.txtDiemMieng);
            this.grbDeAn.Controls.Add(this.txtMaHS);
            this.grbDeAn.Controls.Add(this.cbMaMH);
            this.grbDeAn.Controls.Add(this.cbMaHS);
            this.grbDeAn.Controls.Add(this.label6);
            this.grbDeAn.Controls.Add(this.label5);
            this.grbDeAn.Controls.Add(this.label4);
            this.grbDeAn.Controls.Add(this.label3);
            this.grbDeAn.Controls.Add(this.label1);
            this.grbDeAn.Controls.Add(this.label2);
            this.grbDeAn.Location = new System.Drawing.Point(24, 12);
            this.grbDeAn.Name = "grbDeAn";
            this.grbDeAn.Size = new System.Drawing.Size(407, 196);
            this.grbDeAn.TabIndex = 8;
            this.grbDeAn.TabStop = false;
            this.grbDeAn.Text = "Thông tin bảng điểm học sinh";
            // 
            // txtDiemHK
            // 
            this.txtDiemHK.Enabled = false;
            this.txtDiemHK.Location = new System.Drawing.Point(113, 159);
            this.txtDiemHK.Name = "txtDiemHK";
            this.txtDiemHK.Size = new System.Drawing.Size(100, 20);
            this.txtDiemHK.TabIndex = 2;
            // 
            // txtDiem1
            // 
            this.txtDiem1.Enabled = false;
            this.txtDiem1.Location = new System.Drawing.Point(113, 136);
            this.txtDiem1.Name = "txtDiem1";
            this.txtDiem1.Size = new System.Drawing.Size(100, 20);
            this.txtDiem1.TabIndex = 2;
            // 
            // txtDiem15
            // 
            this.txtDiem15.Enabled = false;
            this.txtDiem15.Location = new System.Drawing.Point(113, 113);
            this.txtDiem15.Name = "txtDiem15";
            this.txtDiem15.Size = new System.Drawing.Size(100, 20);
            this.txtDiem15.TabIndex = 2;
            // 
            // txtDiemMieng
            // 
            this.txtDiemMieng.Enabled = false;
            this.txtDiemMieng.Location = new System.Drawing.Point(113, 87);
            this.txtDiemMieng.Name = "txtDiemMieng";
            this.txtDiemMieng.Size = new System.Drawing.Size(100, 20);
            this.txtDiemMieng.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Điểm học kỳ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Diểm 1 tiết";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Điểm 15 phút";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Điểm miệng";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btCancel);
            this.panel1.Controls.Add(this.btOk);
            this.panel1.Location = new System.Drawing.Point(551, 303);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(111, 73);
            this.panel1.TabIndex = 18;
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(3, 47);
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
            // frmBangDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(680, 430);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btHienThi);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btTiemKiem);
            this.Controls.Add(this.dtgvBangDiem);
            this.Controls.Add(this.grbChucNang);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.grbDeAn);
            this.Name = "frmBangDiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bảng điểm học sinh";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBangDiem)).EndInit();
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
        private System.Windows.Forms.DataGridView dtgvBangDiem;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.GroupBox grbChucNang;
        private System.Windows.Forms.TextBox txtMaMH;
        private System.Windows.Forms.TextBox txtMaHS;
        private System.Windows.Forms.ComboBox cbMaMH;
        private System.Windows.Forms.ComboBox cbMaHS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.GroupBox grbDeAn;
        private System.Windows.Forms.TextBox txtDiemHK;
        private System.Windows.Forms.TextBox txtDiem1;
        private System.Windows.Forms.TextBox txtDiem15;
        private System.Windows.Forms.TextBox txtDiemMieng;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btOk;
        private System.Windows.Forms.DataGridViewTextBoxColumn mahs;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn mamh;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenmh;
        private System.Windows.Forms.DataGridViewTextBoxColumn dmieng;
        private System.Windows.Forms.DataGridViewTextBoxColumn d15phut;
        private System.Windows.Forms.DataGridViewTextBoxColumn d1tiet;
        private System.Windows.Forms.DataGridViewTextBoxColumn dcuoiky;
    }
}