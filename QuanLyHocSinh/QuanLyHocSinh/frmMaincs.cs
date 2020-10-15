using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyHocSinh
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void tsHanhKiem_Click(object sender, EventArgs e)
        {
            this.Close();
            frmHanhKiem frmHK = new frmHanhKiem();
            frmHK.Show();
        }

        private void tsGiaoVien_Click(object sender, EventArgs e)
        {
            this.Close();
            frmGiaoVien frmGV = new frmGiaoVien();
            frmGV.Show();
        }

        private void tsHanhKiemHS_Click(object sender, EventArgs e)
        {
            this.Close();
            frmHanhKiemHS frmHKHS = new frmHanhKiemHS();
            frmHKHS.Show();
        }

        private void tsHocSinh_Click(object sender, EventArgs e)
        {
            this.Close();
            frmHocSinh frmHS = new frmHocSinh();
            frmHS.Show();
        }

        private void tsLopHoc_Click(object sender, EventArgs e)
        {
            this.Close();
            frmLopHoc frmLh = new frmLopHoc();
            frmLh.Show();
        }

        private void tsMonHoc_Click(object sender, EventArgs e)
        {
            this.Close();
            frmMonHoc frmMH = new frmMonHoc();
            frmMH.Show();
        }

        private void tsKetQuaHocTap_Click(object sender, EventArgs e)
        {
            this.Close();
            frmKetQuaHocTap frmKQHT = new frmKetQuaHocTap();
            frmKQHT.Show();
        }

        private void tsThongTinGiangDay_Click(object sender, EventArgs e)
        {
            this.Close();
            frmThongTinGiangDay frmTTGD = new frmThongTinGiangDay();
            frmTTGD.Show();
        }

        private void tsBangDiem_Click(object sender, EventArgs e)
        {
            this.Close();
            frmBangDiem frmBD = new frmBangDiem();
            frmBD.Show();
        }

        private void tsLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            frmLogin frm = new frmLogin();
            frm.Show();
        }

       
    }
}
