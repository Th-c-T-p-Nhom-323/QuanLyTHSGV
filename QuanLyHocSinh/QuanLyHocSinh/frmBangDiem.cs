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
    public partial class frmBangDiem : Form
    {
        public frmBangDiem()
        {
            InitializeComponent();
            ShowData();
            if (frmLogin.quyen == 1)
            {
                PhanQuyen(true);
            }
            else
                PhanQuyen(false);
            LoadComMH();
            LoadComHS();
            txtMaHS.Text = cbMaHS.SelectedValue.ToString();
            maHS = txtMaHS.Text;
            txtMaMH.Text = cbMaHS.SelectedValue.ToString();
            maMH = txtMaMH.Text;
        }
        DALBangDiem dal_bd = new DALBangDiem();
        bool check = false;

        private void FormatData()
        {
            txtDiemMieng.Text = "";
            txtDiem15.Text = "";
            txtDiem1.Text = "";
            txtDiemHK.Text = "";
        }
        void PhanQuyen(bool b)
        {
            btThem.Enabled = b;
            btSua.Enabled = b;
            btXoa.Enabled = b;
        }
        private void EnabledData(bool b)
        {
            txtDiemMieng.Enabled = b;
            txtDiem15.Enabled = b;
            txtDiem1.Enabled = b;
            txtDiemHK.Enabled = b;
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
            dtgvBangDiem.DataSource = dal_bd.GetData();
            EnabledData(check);
        }
        void LoadComHS()
        {
            cbMaHS.DataSource = dal_bd.GetDataComHS();
            cbMaHS.DisplayMember = "Ten";
            cbMaHS.ValueMember = "mahs";
        }
        void LoadComMH()
        {
            cbMaMH.DataSource = dal_bd.GetDataComMH();
            cbMaMH.DisplayMember = "Ten";
            cbMaMH.ValueMember = "mamh";
        }
        string maHS, maMH;
        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
            frmMain fmain = new frmMain();
            fmain.Show();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
           
        }

        private void btSua_Click(object sender, EventArgs e)
        {
           
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            
        }

        private void dtgvBangDiem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dtgvBangDiem.Rows[e.RowIndex];
                txtMaHS.Text = row.Cells[0].Value.ToString().Trim();
                cbMaHS.Text = row.Cells[1].Value.ToString().Trim();
                txtMaMH.Text = row.Cells[2].Value.ToString().Trim();
                cbMaMH.Text = row.Cells[3].Value.ToString().Trim();
                txtDiemMieng.Text = row.Cells[4].Value.ToString().Trim();
                txtDiem15.Text = row.Cells[5].Value.ToString().Trim();
                txtDiem1.Text = row.Cells[6].Value.ToString().Trim();
                txtDiemHK.Text = row.Cells[7].Value.ToString().Trim();
                maHS = txtMaHS.Text;
                maMH = txtMaMH.Text;
            }
            catch (Exception ex)
            {
                ex = dal_bd.GetEx();
                MessageBox.Show(ex.Message);
            }
        }

        private void cbMaHS_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtMaHS.Text = cbMaHS.SelectedValue.ToString();
        }

        private void cbMaMH_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtMaMH.Text = cbMaMH.SelectedValue.ToString();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {

            EnabledData(false);
            EnableMethod(true);
        }

        private void btTiemKiem_Click(object sender, EventArgs e)
        {
            
        }

        private void btHienThi_Click(object sender, EventArgs e)
        {
            btHienThi.Enabled = false;
            txtTimKiem.Text = "";
            ShowData();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
           
        }
    }
}
