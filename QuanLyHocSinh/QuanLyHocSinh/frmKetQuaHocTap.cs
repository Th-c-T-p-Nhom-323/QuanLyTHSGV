using DAL;
using DAO;
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
    public partial class frmKetQuaHocTap : Form
    {
        public frmKetQuaHocTap()
        {
            InitializeComponent();
            ShowData();
            if (frmLogin.quyen == 1)
            {
                PhanQuyen(true);
            }
            else
                PhanQuyen(false);
            LoadComHocSinh();
            txtMaHS.Text = cbTenHS.SelectedValue.ToString();
        }
        DALKetQuaHocTap dal_kqht = new DALKetQuaHocTap();
        bool check = false;

        private void FormatData()
        {
            txtTBHK1.Text = "";
            txtTBHK2.Text = "";
            txtMaKQHT.Text = "";
        }
        void PhanQuyen(bool b)
        {
            btThem.Enabled = b;
            btSua.Enabled = b;
            btXoa.Enabled = b;
        }
        private void EnabledData(bool b)
        {
            txtTBHK1.Enabled = b;
            txtTBHK2.Enabled = b;
            txtMaKQHT.Enabled = b;
            btOk.Visible = b;
            btCancel.Visible = b;
        }
        private void EnableMethod(bool b)
        {
            if (frmLogin.quyen == 1)
            {
                btThem.Enabled = b;
                btSua.Enabled = b;
                btXoa.Enabled = b;
            }
        }
        string type;
        private void ShowData()
        {
            dtgvKetQuaHocTap.DataSource = dal_kqht.GetData();
            EnabledData(check);
        }
        void LoadComHocSinh()
        {
            cbTenHS.DataSource = dal_kqht.GetDataComHocSinh();
            cbTenHS.DisplayMember = "ten";
            cbTenHS.ValueMember = "mahs";
        }
        string hocLuc1, hocLuc2, hocLuc;
        private void btThem_Click(object sender, EventArgs e)
        {
            type = "Them";
            EnabledData(true);
            EnableMethod(false);
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            type = "Sua";
            EnabledData(true);
            EnableMethod(false);
            txtMaKQHT.Enabled = false;
        }
        float diemTB;
        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
            frmMain fmain = new frmMain();
            fmain.Show();
        }
        private void btOk_Click(object sender, EventArgs e)
        {
           
        }

        private void cbHocLuc1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            EnabledData(false);
            EnableMethod(true);
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            type = "Xoa";
            EnabledData(false);
            EnableMethod(false);
            btOk.Visible = true;
            btCancel.Visible = true;
        }

        private void btHienThi_Click(object sender, EventArgs e)
        {
            btHienThi.Enabled = false;
            txtTimKiem.Text = "";
            ShowData();
        }

        private void btTimKiem_Click(object sender, EventArgs e)
        {
            if (txtTimKiem.Text != "")
            {
                btHienThi.Enabled = true;
                if (dal_kqht.GetDataTimKiem(txtTimKiem.Text.Trim()) != null)
                {
                    dtgvKetQuaHocTap.DataSource = dal_kqht.GetDataTimKiem(txtTimKiem.Text.Trim());
                    MessageBox.Show("Tìm thành công");
                }
                else
                {
                    Exception ex = dal_kqht.GetEx();
                    MessageBox.Show(ex.Message);
                }
            }
            else
                MessageBox.Show("Bạn cần nhập thông tin để tìm kiếm !");
        }

        private void dtgvKetQuaHocTap_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void cbTenHS_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtMaHS.Text = cbTenHS.SelectedValue.ToString();
        }
    }
}
