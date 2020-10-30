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
    public partial class frmHanhKiem : Form
    {
        public frmHanhKiem()
        {
            InitializeComponent();
            ShowData();
            if (frmLogin.quyen == 1)
            {
                PhanQuyen(true);
            }
            else
                PhanQuyen(false);
        }
        DALHanhKiem dal_hk = new DALHanhKiem();
        bool check = false;

        private void FormatData()
        {
            txtMaHK.Text = "";
            txtTen.Text = "";
        }
        void PhanQuyen(bool b)
        {
            btThem.Enabled = b;
            btSua.Enabled = b;
            btXoa.Enabled = b;
        }
        private void EnabledData(bool b)
        {
            txtMaHK.Enabled = b;
            txtTen.Enabled = b;
            btOk.Visible = b;
            btCancel.Visible = b;
        }
        private void EnableMethod(bool b)
        {
            if(frmLogin.quyen == 1)
            {
                btThem.Enabled = b;
                btSua.Enabled = b;
                btXoa.Enabled = b;
            }
        }
        string type;
        private void ShowData()
        {
            dtgvHanhKiem.DataSource = dal_hk.GetData();
            EnabledData(check);
        }
        //Chưa làm 
        private void btThem_Click(object sender, EventArgs e)
        {
            
        }

        private void dtgvHanhKiem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dtgvHanhKiem.Rows[e.RowIndex];
                txtMaHK.Text = row.Cells[0].Value.ToString().Trim();
                txtTen.Text = row.Cells[1].Value.ToString().Trim();
            }
            catch (Exception ex)
            {
                ex = dal_hk.GetEx();
                MessageBox.Show(ex.Message);
            }
        }
        //Chưa làm
        private void btOk_Click(object sender, EventArgs e)
        {
            
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
            frmMain fmain = new frmMain();
            fmain.Show();
        }
        //Chưa làm 
        private void btSua_Click(object sender, EventArgs e)
        {
            
        }
        //Chưa làm
        private void btTiemKiem_Click(object sender, EventArgs e)
        {
            
        }

        private void btHienThi_Click(object sender, EventArgs e)
        {
            btHienThi.Enabled = false;
            txtTimKiem.Text = "";
            ShowData();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            EnabledData(false);
            EnableMethod(true);
        }
        //Chưa làm
        private void btXoa_Click(object sender, EventArgs e)
        {
            
        }
    }
}
