namespace QuanLyHocSinh
{
    partial class frmLopHoc
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
            this.dtgvLopHoc = new System.Windows.Forms.DataGridView();
            this.malh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenlh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.magv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tengv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btXoa = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.grbChucNang = new System.Windows.Forms.GroupBox();
            this.cbTenGVCN = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.grbDeAn = new System.Windows.Forms.GroupBox();
            this.txtMaGV = new System.Windows.Forms.TextBox();
            this.txtTenLH = new System.Windows.Forms.TextBox();
            this.txtMaLH = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btCancel = new System.Windows.Forms.Button();
            this.btOk = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvLopHoc)).BeginInit();
            this.grbChucNang.SuspendLayout();
            this.grbDeAn.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btHienThi
            // 
            this.btHienThi.Enabled = false;
            this.btHienThi.Location = new System.Drawing.Point(546, 227);
            this.btHienThi.Name = "btHienThi";
            this.btHienThi.Size = new System.Drawing.Size(95, 23);
            this.btHienThi.TabIndex = 11;
            this.btHienThi.Text = "Hiện thị thông tin";
            this.btHienThi.UseVisualStyleBackColor = true;
            this.btHienThi.Click += new System.EventHandler(this.btHienThi_Click);
            // 
            // btThoat
            // 
            this.btThoat.Location = new System.Drawing.Point(552, 399);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(75, 23);
            this.btThoat.TabIndex = 5;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // btTiemKiem
            // 
            this.btTiemKiem.Location = new System.Drawing.Point(566, 198);
            this.btTiemKiem.Name = "btTiemKiem";
            this.btTiemKiem.Size = new System.Drawing.Size(75, 23);
            this.btTiemKiem.TabIndex = 6;
            this.btTiemKiem.Text = "Tìm kiếm";
            this.btTiemKiem.UseVisualStyleBackColor = true;
            this.btTiemKiem.Click += new System.EventHandler(this.btTiemKiem_Click);
            // 
            // dtgvLopHoc
            // 
            this.dtgvLopHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvLopHoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.malh,
            this.tenlh,
            this.magv,
            this.tengv});
            this.dtgvLopHoc.Location = new System.Drawing.Point(12, 282);
            this.dtgvLopHoc.Name = "dtgvLopHoc";
            this.dtgvLopHoc.RowHeadersVisible = false;
            this.dtgvLopHoc.Size = new System.Drawing.Size(528, 168);
            this.dtgvLopHoc.TabIndex = 10;
            this.dtgvLopHoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvLopHoc_CellClick);
            // 
            // malh
            // 
            this.malh.DataPropertyName = "malh";
            this.malh.HeaderText = "Mã lớp học";
            this.malh.Name = "malh";
            this.malh.Width = 120;
            // 
            // tenlh
            // 
            this.tenlh.DataPropertyName = "tenlh";
            this.tenlh.HeaderText = "Tên lớp học";
            this.tenlh.Name = "tenlh";
            this.tenlh.Width = 150;
            // 
            // magv
            // 
            this.magv.DataPropertyName = "magv";
            this.magv.HeaderText = "Mã giáo viên chủ nhiệm";
            this.magv.Name = "magv";
            // 
            // tengv
            // 
            this.tengv.DataPropertyName = "ten";
            this.tengv.HeaderText = "Giáo viên chủ nhiệm";
            this.tengv.Name = "tengv";
            this.tengv.Width = 150;
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
            this.grbChucNang.Location = new System.Drawing.Point(528, 33);
            this.grbChucNang.Name = "grbChucNang";
            this.grbChucNang.Size = new System.Drawing.Size(133, 144);
            this.grbChucNang.TabIndex = 9;
            this.grbChucNang.TabStop = false;
            this.grbChucNang.Text = "Chức năng";
            // 
            // cbTenGVCN
            // 
            this.cbTenGVCN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTenGVCN.FormattingEnabled = true;
            this.cbTenGVCN.Location = new System.Drawing.Point(164, 108);
            this.cbTenGVCN.Name = "cbTenGVCN";
            this.cbTenGVCN.Size = new System.Drawing.Size(122, 21);
            this.cbTenGVCN.TabIndex = 1;
            this.cbTenGVCN.SelectedIndexChanged += new System.EventHandler(this.cbTenGVCN_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Giáo viên chủ nhiệm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã lớp học";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(353, 198);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(207, 20);
            this.txtTimKiem.TabIndex = 7;
            // 
            // grbDeAn
            // 
            this.grbDeAn.Controls.Add(this.txtMaGV);
            this.grbDeAn.Controls.Add(this.txtTenLH);
            this.grbDeAn.Controls.Add(this.txtMaLH);
            this.grbDeAn.Controls.Add(this.cbTenGVCN);
            this.grbDeAn.Controls.Add(this.label1);
            this.grbDeAn.Controls.Add(this.label4);
            this.grbDeAn.Controls.Add(this.label2);
            this.grbDeAn.Location = new System.Drawing.Point(23, 12);
            this.grbDeAn.Name = "grbDeAn";
            this.grbDeAn.Size = new System.Drawing.Size(453, 180);
            this.grbDeAn.TabIndex = 8;
            this.grbDeAn.TabStop = false;
            this.grbDeAn.Text = "Thông tin lớp học";
            // 
            // txtMaGV
            // 
            this.txtMaGV.Enabled = false;
            this.txtMaGV.Location = new System.Drawing.Point(296, 109);
            this.txtMaGV.Name = "txtMaGV";
            this.txtMaGV.Size = new System.Drawing.Size(89, 20);
            this.txtMaGV.TabIndex = 2;
            // 
            // txtTenLH
            // 
            this.txtTenLH.Enabled = false;
            this.txtTenLH.Location = new System.Drawing.Point(164, 71);
            this.txtTenLH.Name = "txtTenLH";
            this.txtTenLH.Size = new System.Drawing.Size(221, 20);
            this.txtTenLH.TabIndex = 2;
            // 
            // txtMaLH
            // 
            this.txtMaLH.Enabled = false;
            this.txtMaLH.Location = new System.Drawing.Point(164, 42);
            this.txtMaLH.Name = "txtMaLH";
            this.txtMaLH.Size = new System.Drawing.Size(221, 20);
            this.txtMaLH.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tên lớp";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btCancel);
            this.panel1.Controls.Add(this.btOk);
            this.panel1.Location = new System.Drawing.Point(118, 212);
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
            // frmLopHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(686, 462);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btHienThi);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btTiemKiem);
            this.Controls.Add(this.dtgvLopHoc);
            this.Controls.Add(this.grbChucNang);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.grbDeAn);
            this.Name = "frmLopHoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLopHoc_cs";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvLopHoc)).EndInit();
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
        private System.Windows.Forms.DataGridView dtgvLopHoc;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.GroupBox grbChucNang;
        private System.Windows.Forms.ComboBox cbTenGVCN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.GroupBox grbDeAn;
        private System.Windows.Forms.TextBox txtTenLH;
        private System.Windows.Forms.TextBox txtMaLH;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaGV;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btOk;
        private System.Windows.Forms.DataGridViewTextBoxColumn malh;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenlh;
        private System.Windows.Forms.DataGridViewTextBoxColumn magv;
        private System.Windows.Forms.DataGridViewTextBoxColumn tengv;
    }
}