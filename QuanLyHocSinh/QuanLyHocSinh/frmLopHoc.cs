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
    public partial class frmLopHoc : Form
    {
        public frmLopHoc()
        {
            InitializeComponent();
            if (frmLogin.quyen == 1)
            {
                PhanQuyen(true);
            }
            else
                PhanQuyen(false);
            ShowData();
            LoadCom();
            txtMaGV.Text = cbTenGVCN.SelectedValue.ToString();
        }
        void LoadCom()
        {
            cbTenGVCN.DataSource = dal_lh.GetDataCom();
            cbTenGVCN.DisplayMember = "Ten";
            cbTenGVCN.ValueMember = "magv";
        }
        DALLopHoc dal_lh = new DALLopHoc();
        bool check = false;

        private void FormatData()
        {
            txtMaLH.Text = "";
            txtTenLH.Text = "";
        }
        void PhanQuyen(bool b)
        {
            btThem.Enabled = b;
            btSua.Enabled = b;
            btXoa.Enabled = b;
        }
        private void EnabledData(bool b)
        {
            txtMaLH.Enabled = b;
            txtTenLH.Enabled = b;
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
            dtgvLopHoc.DataSource = dal_lh.GetData();
            EnabledData(check);
        }

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
            txtMaLH.Enabled = false;
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            if (type == "Them")
            {
                if (txtMaLH.Text != "" && txtTenLH.Text != "")
                {
                    LopHoc lh = new LopHoc(txtMaLH.Text.Trim(), cbTenGVCN.SelectedValue.ToString(), txtTenLH.Text.Trim());
                    if (dal_lh.Them(lh) == true)
                    {
                        FormatData();
                        ShowData();
                        EnableMethod(true);
                        MessageBox.Show("Thêm thành công");
                    }
                    else
                    {
                        Exception ex = dal_lh.GetEx();
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                    MessageBox.Show("Bạn cần nhập đủ thông tin phòng ban");

            }
            else if (type == "Sua")
            {
                if (txtMaLH.Text != "" && txtTenLH.Text != "")
                {
                    LopHoc lh = new LopHoc(txtMaLH.Text.Trim(), cbTenGVCN.SelectedValue.ToString(), txtTenLH.Text.Trim());
                    if (dal_lh.Sua(lh) == true)
                    {
                        FormatData();
                        ShowData();
                        MessageBox.Show("Sửa thành công");
                        EnableMethod(true);
                    }
                    else
                    {
                        Exception ex = dal_lh.GetEx();
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                    MessageBox.Show("Bạn cần nhập đủ thông tin phòng ban");
            }
            else if (type == "Xoa")
            {
                if (txtMaLH.Text != "" && txtTenLH.Text != "" && txtMaGV.Text != "")
                {
                    DialogResult dr = MessageBox.Show("Bạn có muốn xóa khồng?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (dr == DialogResult.OK)
                    {
                        dal_lh.Xoa(txtMaLH.Text);
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
        }

        private void cbTenGVCN_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void dtgvLopHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
           
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
           
        }

        private void btHienThi_Click(object sender, EventArgs e)
        {
           
        }

        private void btTiemKiem_Click(object sender, EventArgs e)
        {
           
        }
    }
}
