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
        
        private void btThem_Click(object sender, EventArgs e)
        {
            type = "Them";
            EnabledData(true);
            EnableMethod(false);
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
        
        private void btOk_Click(object sender, EventArgs e)
        {
            if (type == "Them")
            {
                if (txtMaHK.Text != "" && txtTen.Text != "")
                {
                    HanhKiem hk = new HanhKiem(txtMaHK.Text.Trim().ToString(), txtTen.Text.Trim().ToString());
                    if (dal_hk.Them(hk) == true)
                    {
                        FormatData();
                        ShowData();
                        EnableMethod(true);
                        MessageBox.Show("Thêm thành công");
                    }
                    else
                    {
                        Exception ex = dal_hk.GetEx();
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                    MessageBox.Show("Bạn cần nhập đủ thông tin phòng ban");

            }
            else if (type == "Sua")
            {
                if (txtTen.Text != "")
                {
                    HanhKiem hk = new HanhKiem(txtMaHK.Text.Trim().ToString(), txtTen.Text.Trim().ToString());
                    if (dal_hk.Sua(hk) == true)
                    {
                        FormatData();
                        ShowData();
                        MessageBox.Show("Sửa thành công");
                        EnableMethod(true);
                    }
                    else
                    {
                        Exception ex = dal_hk.GetEx();
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                    MessageBox.Show("Bạn cần nhập đủ thông tin phòng ban");
            }
            else if (type == "Xoa")
            {
                if (txtMaHK.Text != "" && txtTen.Text != "")
                {
                    DialogResult dr = MessageBox.Show("Bạn có muốn xóa khồng?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (dr == DialogResult.OK)
                    {
                        dal_hk.Xoa(txtMaHK.Text);
                        EnableMethod(true);
                        ShowData();
                    }
                    else
                    {
                        EnabledData(false);
                        EnableMethod(true);
                    }
                }
            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
            frmMain fmain = new frmMain();
            fmain.Show();
        }
        
        private void btSua_Click(object sender, EventArgs e)
        {
            type = "Sua";
            EnabledData(true);
            EnableMethod(false);
            txtMaHK.Enabled = false;
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
       
        private void btXoa_Click(object sender, EventArgs e)
        {
            type = "Xoa";
            EnabledData(false);
            EnableMethod(false);
            btOk.Visible = true;
            btCancel.Visible = true;
        }
    }
}
