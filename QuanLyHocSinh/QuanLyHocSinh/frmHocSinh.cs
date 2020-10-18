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
    public partial class frmHocSinh : Form
    {
        public frmHocSinh()
        {
            InitializeComponent();
            ShowData();
            if (frmLogin.quyen == 1)
            {
                PhanQuyen(true);
            }
            else
                PhanQuyen(false);
            LoadCom();
            txtMaLH.Text = cbTenLH.SelectedValue.ToString();
        }
        DALHocSinh dal_hs = new DALHocSinh();
        bool check = false;

        private void FormatData()
        {
            txtMaHS.Text = "";
            txtTen.Text = "";
            txtTenNguoiThan.Text = "";
            txtDiaChi.Text = "";
        }
        void PhanQuyen(bool b)
        {
            btThem.Enabled = b;
            btSua.Enabled = b;
            btXoa.Enabled = b;
        }
        private void EnabledData(bool b)
        {
            txtMaHS.Enabled = b;
            txtTen.Enabled = b;
            txtTenNguoiThan.Enabled = b;
            txtDiaChi.Enabled = b;
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
            dtgvHocSinh.DataSource = dal_hs.GetData();
            EnabledData(check);
        }
        void LoadCom()
        {
            cbTenLH.DataSource = dal_hs.GetDataCom();
            cbTenLH.DisplayMember = "TenLH";
            cbTenLH.ValueMember = "malh";
        }
        private void btThem_Click(object sender, EventArgs e)
        {
            type = "Them";
            cbTenLH.DataSource = dal_hs.GetDataCom();
            EnabledData(true);
            EnableMethod(false);
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            type = "Sua";
            cbTenLH.DataSource = dal_hs.GetDataCom();
            EnabledData(true);
            EnableMethod(false);
            txtMaHS.Enabled = false;
        }

        private void dtgvHocSinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dtgvHocSinh.Rows[e.RowIndex];
                txtMaHS.Text = row.Cells[0].Value.ToString().Trim();
                txtTen.Text = row.Cells[1].Value.ToString().Trim();
                txtMaLH.Text = row.Cells[6].Value.ToString().Trim();
                dtNgaySinh.Text = row.Cells[4].Value.ToString().Trim();
                //cbTenLH.Text = (string)dal_hs.GetTenLH(txtMaLH.Text);
                cbTenLH.DataSource = dal_hs.GetTenLH(txtMaLH.Text);
                cbTenLH.DisplayMember = "TenLH";
                cbTenLH.ValueMember = "malh";
                if (row.Cells[3].Value.ToString().Trim() == "Nam")
                {
                    rbNam.Checked = true;
                }
                else if (row.Cells[3].Value.ToString().Trim() == "Nữ")
                    rbNu.Checked = true;
                else
                    rbKhac.Checked = true;
                txtTenNguoiThan.Text = row.Cells[5].Value.ToString().Trim();
                txtDiaChi.Text = row.Cells[2].Value.ToString().Trim();
            }
            catch (Exception ex)
            {
                ex = dal_hs.GetEx();
                MessageBox.Show(ex.Message);
            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
            frmMain fmain = new frmMain();
            fmain.Show();
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            if (type == "Them")
            {
                if (txtMaHS.Text != "" && txtTen.Text != "" && txtTenNguoiThan.Text != "" && txtDiaChi.Text != "")
                {
                    string gioitinh = "";
                    if (rbNam.Checked)
                    {
                        gioitinh = "Nam";
                    }
                    else if (rbNu.Checked)
                    {
                        gioitinh = "Nữ";
                    }
                    else
                    {
                        gioitinh = "Khác";
                    }
                    HocSinh hs = new HocSinh(txtMaHS.Text.Trim().ToString(), txtTen.Text.Trim().ToString(), txtDiaChi.Text.Trim(), gioitinh, DateTime.Parse(dtNgaySinh.Text), txtTenNguoiThan.Text.Trim(), txtMaLH.Text.Trim());
                    if (dal_hs.Them(hs) == true)
                    {
                        FormatData();
                        ShowData();
                        EnableMethod(true);
                        MessageBox.Show("Thêm thành công");
                    }
                    else
                    {
                        Exception ex = dal_hs.GetEx();
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
                    string gioitinh = "";
                    if (rbNam.Checked)
                    {
                        gioitinh = "Nam";
                    }
                    else if (rbNu.Checked)
                    {
                        gioitinh = "Nữ";
                    }
                    else
                    {
                        gioitinh = "Khác";
                    }
                    HocSinh hs = new HocSinh(txtMaHS.Text.Trim().ToString(), txtTen.Text.Trim().ToString(), txtDiaChi.Text.Trim(), gioitinh, DateTime.Parse(dtNgaySinh.Text), txtTenNguoiThan.Text.Trim(), txtMaLH.Text.Trim());
                    if (dal_hs.Sua(hs) == true)
                    {
                        FormatData();
                        ShowData();
                        MessageBox.Show("Sửa thành công");
                        EnableMethod(true);
                    }
                    else
                    {
                        Exception ex = dal_hs.GetEx();
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                    MessageBox.Show("Bạn cần nhập đủ thông tin phòng ban");
            }
            else if (type == "Xoa")
            {
                if (txtMaHS.Text != "" && txtTen.Text != "" && txtTenNguoiThan.Text != "" && txtDiaChi.Text != "")
                {
                    DialogResult dr = MessageBox.Show("Bạn có muốn xóa khồng?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (dr == DialogResult.OK)
                    {
                        dal_hs.Xoa(txtMaHS.Text);
                        EnableMethod(true);
                        ShowData();
                        FormatData();
                    }
                    else
                    {
                        EnabledData(false);
                        EnableMethod(true);
                    }
                }
            }
        }

        private void cbTenLH_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtMaLH.Text = cbTenLH.SelectedValue.ToString();
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
                if (dal_hs.GetDataTimKiem(txtTimKiem.Text.Trim()) != null)
                {
                    dtgvHocSinh.DataSource = dal_hs.GetDataTimKiem(txtTimKiem.Text.Trim());
                    MessageBox.Show("Tìm thành công");
                }
                else
                {
                    Exception ex = dal_hs.GetEx();
                    MessageBox.Show(ex.Message);
                }
            }
            else
                MessageBox.Show("Bạn cần nhập thông tin để tìm kiếm !");
        }
    }
}
