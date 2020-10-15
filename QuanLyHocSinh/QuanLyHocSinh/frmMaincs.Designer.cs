namespace QuanLyHocSinh
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsHome = new System.Windows.Forms.ToolStripMenuItem();
            this.tsQuanLyHocSinh = new System.Windows.Forms.ToolStripMenuItem();
            this.tsGiaoVien = new System.Windows.Forms.ToolStripMenuItem();
            this.tsHanhKiemHS = new System.Windows.Forms.ToolStripMenuItem();
            this.tsHocSinh = new System.Windows.Forms.ToolStripMenuItem();
            this.tsLopHoc = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMonHoc = new System.Windows.Forms.ToolStripMenuItem();
            this.tsKetQuaHocTap = new System.Windows.Forms.ToolStripMenuItem();
            this.tsThongTinGiangDay = new System.Windows.Forms.ToolStripMenuItem();
            this.tsBangDiem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsHuongDan = new System.Windows.Forms.ToolStripMenuItem();
            this.tsLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsHome,
            this.tsQuanLyHocSinh,
            this.tsHuongDan,
            this.tsLogout});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(687, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsHome
            // 
            this.tsHome.Name = "tsHome";
            this.tsHome.Size = new System.Drawing.Size(66, 24);
            this.tsHome.Text = "HOME";
            // 
            // tsQuanLyHocSinh
            // 
            this.tsQuanLyHocSinh.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsGiaoVien,
            this.tsHanhKiemHS,
            this.tsHocSinh,
            this.tsLopHoc,
            this.tsMonHoc,
            this.tsKetQuaHocTap,
            this.tsThongTinGiangDay,
            this.tsBangDiem});
            this.tsQuanLyHocSinh.Name = "tsQuanLyHocSinh";
            this.tsQuanLyHocSinh.Size = new System.Drawing.Size(156, 24);
            this.tsQuanLyHocSinh.Text = "QUẢN LÝ HỌC SINH";
            // 
            // tsGiaoVien
            // 
            this.tsGiaoVien.Name = "tsGiaoVien";
            this.tsGiaoVien.Size = new System.Drawing.Size(252, 26);
            this.tsGiaoVien.Text = "GIÁO VIÊN";
            this.tsGiaoVien.Click += new System.EventHandler(this.tsGiaoVien_Click);
            // 
            // tsHanhKiemHS
            // 
            this.tsHanhKiemHS.Name = "tsHanhKiemHS";
            this.tsHanhKiemHS.Size = new System.Drawing.Size(252, 26);
            this.tsHanhKiemHS.Text = "HẠNH KIỂM HỌC SINH";
            this.tsHanhKiemHS.Click += new System.EventHandler(this.tsHanhKiemHS_Click);
            // 
            // tsHocSinh
            // 
            this.tsHocSinh.Name = "tsHocSinh";
            this.tsHocSinh.Size = new System.Drawing.Size(252, 26);
            this.tsHocSinh.Text = "HỌC SINH";
            this.tsHocSinh.Click += new System.EventHandler(this.tsHocSinh_Click);
            // 
            // tsLopHoc
            // 
            this.tsLopHoc.Name = "tsLopHoc";
            this.tsLopHoc.Size = new System.Drawing.Size(252, 26);
            this.tsLopHoc.Text = "LỚP HỌC";
            this.tsLopHoc.Click += new System.EventHandler(this.tsLopHoc_Click);
            // 
            // tsMonHoc
            // 
            this.tsMonHoc.Name = "tsMonHoc";
            this.tsMonHoc.Size = new System.Drawing.Size(252, 26);
            this.tsMonHoc.Text = "MÔN HỌC";
            this.tsMonHoc.Click += new System.EventHandler(this.tsMonHoc_Click);
            // 
            // tsKetQuaHocTap
            // 
            this.tsKetQuaHocTap.Name = "tsKetQuaHocTap";
            this.tsKetQuaHocTap.Size = new System.Drawing.Size(252, 26);
            this.tsKetQuaHocTap.Text = "KẾT QUẢ HỌC TẬP";
            this.tsKetQuaHocTap.Click += new System.EventHandler(this.tsKetQuaHocTap_Click);
            // 
            // tsThongTinGiangDay
            // 
            this.tsThongTinGiangDay.Name = "tsThongTinGiangDay";
            this.tsThongTinGiangDay.Size = new System.Drawing.Size(252, 26);
            this.tsThongTinGiangDay.Text = "THÔNG TIN GIẢNG DẠY";
            this.tsThongTinGiangDay.Click += new System.EventHandler(this.tsThongTinGiangDay_Click);
            // 
            // tsBangDiem
            // 
            this.tsBangDiem.Name = "tsBangDiem";
            this.tsBangDiem.Size = new System.Drawing.Size(252, 26);
            this.tsBangDiem.Text = "BẢNG ĐIỂM";
            this.tsBangDiem.Click += new System.EventHandler(this.tsBangDiem_Click);
            // 
            // tsHuongDan
            // 
            this.tsHuongDan.Name = "tsHuongDan";
            this.tsHuongDan.Size = new System.Drawing.Size(113, 24);
            this.tsHuongDan.Text = "HƯỚNG DẪN";
            // 
            // tsLogout
            // 
            this.tsLogout.Name = "tsLogout";
            this.tsLogout.Size = new System.Drawing.Size(79, 24);
            this.tsLogout.Text = "LOGOUT";
            this.tsLogout.Click += new System.EventHandler(this.tsLogout_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(687, 385);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý học sinh";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsHome;
        private System.Windows.Forms.ToolStripMenuItem tsQuanLyHocSinh;
        private System.Windows.Forms.ToolStripMenuItem tsHuongDan;
        private System.Windows.Forms.ToolStripMenuItem tsLogout;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsGiaoVien;
        private System.Windows.Forms.ToolStripMenuItem tsHanhKiemHS;
        private System.Windows.Forms.ToolStripMenuItem tsHocSinh;
        private System.Windows.Forms.ToolStripMenuItem tsLopHoc;
        private System.Windows.Forms.ToolStripMenuItem tsMonHoc;
        private System.Windows.Forms.ToolStripMenuItem tsKetQuaHocTap;
        private System.Windows.Forms.ToolStripMenuItem tsThongTinGiangDay;
        private System.Windows.Forms.ToolStripMenuItem tsBangDiem;
    }
}