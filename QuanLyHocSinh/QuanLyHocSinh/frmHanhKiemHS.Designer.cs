namespace QuanLyHocSinh
{
    partial class frmHanhKiemHS
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
            this.dtgvHanhKiemHS = new System.Windows.Forms.DataGridView();
            this.mahk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mahs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenhs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namhoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hocky = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btXoa = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.grbChucNang = new System.Windows.Forms.GroupBox();
            this.txtNamHoc = new System.Windows.Forms.TextBox();
            this.txtMaHK = new System.Windows.Forms.TextBox();
            this.cbTenHS = new System.Windows.Forms.ComboBox();
            this.cbTenHK = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.grbDeAn = new System.Windows.Forms.GroupBox();
            this.txtMaHS = new System.Windows.Forms.TextBox();
            this.cbHocKy = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btCancel = new System.Windows.Forms.Button();
            this.btOk = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHanhKiemHS)).BeginInit();
            this.grbChucNang.SuspendLayout();
            this.grbDeAn.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btHienThi
            // 
            this.btHienThi.Enabled = false;
            this.btHienThi.Location = new System.Drawing.Point(503, 279);
            this.btHienThi.Name = "btHienThi";
            this.btHienThi.Size = new System.Drawing.Size(95, 23);
            this.btHienThi.TabIndex = 11;
            this.btHienThi.Text = "Hiện thị thông tin";
            this.btHienThi.UseVisualStyleBackColor = true;
            this.btHienThi.Click += new System.EventHandler(this.btHienThi_Click);
            // 
            // btThoat
            // 
            this.btThoat.Location = new System.Drawing.Point(509, 418);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(75, 23);
            this.btThoat.TabIndex = 5;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // btTiemKiem
            // 
            this.btTiemKiem.Location = new System.Drawing.Point(523, 250);
            this.btTiemKiem.Name = "btTiemKiem";
            this.btTiemKiem.Size = new System.Drawing.Size(75, 23);
            this.btTiemKiem.TabIndex = 6;
            this.btTiemKiem.Text = "Tìm kiếm";
            this.btTiemKiem.UseVisualStyleBackColor = true;
            this.btTiemKiem.Click += new System.EventHandler(this.btTiemKiem_Click);
            // 
            // dtgvHanhKiemHS
            // 
            this.dtgvHanhKiemHS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvHanhKiemHS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mahk,
            this.ten,
            this.mahs,
            this.tenhs,
            this.namhoc,
            this.hocky});
            this.dtgvHanhKiemHS.Location = new System.Drawing.Point(47, 279);
            this.dtgvHanhKiemHS.Name = "dtgvHanhKiemHS";
            this.dtgvHanhKiemHS.RowHeadersVisible = false;
            this.dtgvHanhKiemHS.Size = new System.Drawing.Size(450, 168);
            this.dtgvHanhKiemHS.TabIndex = 10;
            this.dtgvHanhKiemHS.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvHanhKiemHS_CellClick);
            // 
            // mahk
            // 
            this.mahk.DataPropertyName = "mahk";
            this.mahk.HeaderText = "Mã hạnh kiểm";
            this.mahk.Name = "mahk";
            // 
            // ten
            // 
            this.ten.DataPropertyName = "ten";
            this.ten.HeaderText = "Hạnh kiểm";
            this.ten.Name = "ten";
            this.ten.Width = 150;
            // 
            // mahs
            // 
            this.mahs.DataPropertyName = "mahs";
            this.mahs.HeaderText = "Mã học sinh";
            this.mahs.Name = "mahs";
            // 
            // tenhs
            // 
            this.tenhs.DataPropertyName = "tenhs";
            this.tenhs.HeaderText = "Học sinh";
            this.tenhs.Name = "tenhs";
            // 
            // namhoc
            // 
            this.namhoc.DataPropertyName = "namhoc";
            this.namhoc.HeaderText = "Năm học";
            this.namhoc.Name = "namhoc";
            // 
            // hocky
            // 
            this.hocky.DataPropertyName = "hocky";
            this.hocky.HeaderText = "Học Kỳ";
            this.hocky.Name = "hocky";
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
            this.grbChucNang.Location = new System.Drawing.Point(451, 13);
            this.grbChucNang.Name = "grbChucNang";
            this.grbChucNang.Size = new System.Drawing.Size(133, 144);
            this.grbChucNang.TabIndex = 9;
            this.grbChucNang.TabStop = false;
            this.grbChucNang.Text = "Chức năng";
            // 
            // txtNamHoc
            // 
            this.txtNamHoc.Enabled = false;
            this.txtNamHoc.Location = new System.Drawing.Point(113, 97);
            this.txtNamHoc.Name = "txtNamHoc";
            this.txtNamHoc.Size = new System.Drawing.Size(195, 20);
            this.txtNamHoc.TabIndex = 2;
            // 
            // txtMaHK
            // 
            this.txtMaHK.Enabled = false;
            this.txtMaHK.Location = new System.Drawing.Point(302, 21);
            this.txtMaHK.Name = "txtMaHK";
            this.txtMaHK.Size = new System.Drawing.Size(100, 20);
            this.txtMaHK.TabIndex = 2;
            // 
            // cbTenHS
            // 
            this.cbTenHS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTenHS.FormattingEnabled = true;
            this.cbTenHS.Location = new System.Drawing.Point(113, 57);
            this.cbTenHS.Name = "cbTenHS";
            this.cbTenHS.Size = new System.Drawing.Size(161, 21);
            this.cbTenHS.TabIndex = 1;
            this.cbTenHS.SelectedIndexChanged += new System.EventHandler(this.cbTenHS_SelectedIndexChanged);
            // 
            // cbTenHK
            // 
            this.cbTenHK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTenHK.FormattingEnabled = true;
            this.cbTenHK.Location = new System.Drawing.Point(113, 21);
            this.cbTenHK.Name = "cbTenHK";
            this.cbTenHK.Size = new System.Drawing.Size(161, 21);
            this.cbTenHK.TabIndex = 1;
            this.cbTenHK.SelectedIndexChanged += new System.EventHandler(this.cbTenHK_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Học sinh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Hạnh kiểm";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(310, 250);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(207, 20);
            this.txtTimKiem.TabIndex = 7;
            // 
            // grbDeAn
            // 
            this.grbDeAn.Controls.Add(this.txtNamHoc);
            this.grbDeAn.Controls.Add(this.txtMaHS);
            this.grbDeAn.Controls.Add(this.txtMaHK);
            this.grbDeAn.Controls.Add(this.cbHocKy);
            this.grbDeAn.Controls.Add(this.cbTenHS);
            this.grbDeAn.Controls.Add(this.cbTenHK);
            this.grbDeAn.Controls.Add(this.label4);
            this.grbDeAn.Controls.Add(this.label3);
            this.grbDeAn.Controls.Add(this.label1);
            this.grbDeAn.Controls.Add(this.label2);
            this.grbDeAn.Location = new System.Drawing.Point(38, 12);
            this.grbDeAn.Name = "grbDeAn";
            this.grbDeAn.Size = new System.Drawing.Size(407, 173);
            this.grbDeAn.TabIndex = 8;
            this.grbDeAn.TabStop = false;
            this.grbDeAn.Text = "Hạnh kiểm học sinh";
            // 
            // txtMaHS
            // 
            this.txtMaHS.Enabled = false;
            this.txtMaHS.Location = new System.Drawing.Point(302, 57);
            this.txtMaHS.Name = "txtMaHS";
            this.txtMaHS.Size = new System.Drawing.Size(100, 20);
            this.txtMaHS.TabIndex = 2;
            // 
            // cbHocKy
            // 
            this.cbHocKy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHocKy.FormattingEnabled = true;
            this.cbHocKy.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cbHocKy.Location = new System.Drawing.Point(113, 124);
            this.cbHocKy.Name = "cbHocKy";
            this.cbHocKy.Size = new System.Drawing.Size(161, 21);
            this.cbHocKy.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Học kỳ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Năm học";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btCancel);
            this.panel1.Controls.Add(this.btOk);
            this.panel1.Location = new System.Drawing.Point(90, 205);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 51);
            this.panel1.TabIndex = 16;
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
            // frmHanhKiemHS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(616, 463);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btHienThi);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btTiemKiem);
            this.Controls.Add(this.dtgvHanhKiemHS);
            this.Controls.Add(this.grbChucNang);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.grbDeAn);
            this.Name = "frmHanhKiemHS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HanhKiemHS";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHanhKiemHS)).EndInit();
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
        private System.Windows.Forms.DataGridView dtgvHanhKiemHS;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.GroupBox grbChucNang;
        private System.Windows.Forms.TextBox txtNamHoc;
        private System.Windows.Forms.TextBox txtMaHK;
        private System.Windows.Forms.ComboBox cbTenHS;
        private System.Windows.Forms.ComboBox cbTenHK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.GroupBox grbDeAn;
        private System.Windows.Forms.ComboBox cbHocKy;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaHS;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btOk;
        private System.Windows.Forms.DataGridViewTextBoxColumn mahk;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn mahs;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenhs;
        private System.Windows.Forms.DataGridViewTextBoxColumn namhoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn hocky;
    }
}