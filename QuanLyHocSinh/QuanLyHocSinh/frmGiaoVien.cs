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
    public partial class frmGiaoVien : Form
    {
        public frmGiaoVien()
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
        DALGiaoVien dal_gv = new DALGiaoVien();
        private void FormatData()
        {
            txtMaGV.Text = "";
            txtTen.Text = "";
            txtSoDT.Text = "";
            txtDiaChi.Text = "";
            txtLuong.Text = "";
        }
        void PhanQuyen(bool b)
        {
            btThem.Enabled = b;
            btSua.Enabled = b;
            btXoa.Enabled = b;
        }
        private void EnabledData(bool b)
        {
            txtMaGV.Enabled = b;
            txtTen.Enabled = b;
            txtSoDT.Enabled = b;
            txtDiaChi.Enabled = b;
            txtLuong.Enabled = b;
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
            dtgvGiaoVien.DataSource = dal_gv.GetData();
            EnabledData(false);
        }
        private void btThem_Click(object sender, EventArgs e)
        {
            //type = "Them";
            //EnabledData(true);
            //EnableMethod(false);
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            if (type == "Them")
            {
                if (txtMaGV.Text != "" && txtTen.Text != "" && txtSoDT.Text != "" && txtLuong.Text != "" && txtDiaChi.Text != "")
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
                    GiaoVien gv = new GiaoVien(txtMaGV.Text.Trim().ToString(), txtTen.Text.Trim().ToString(), gioitinh, txtSoDT.Text.Trim(), txtDiaChi.Text.Trim(), DateTime.Parse(dtNgaySinh.Text), float.Parse(txtLuong.Text.Trim()));
                    if (dal_gv.Them(gv) == true)
                    {
                        FormatData();
                        ShowData();
                        EnableMethod(true);
                        MessageBox.Show("Thêm thành công");
                    }
                    else
                    {
                        Exception ex = dal_gv.GetEx();
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                    MessageBox.Show("Bạn cần nhập đủ thông tin phòng ban");

            }
            else if (type == "Sua")
            {
                if (txtMaGV.Text != "" && txtTen.Text != "" && txtSoDT.Text != "" && txtLuong.Text != "" && txtDiaChi.Text != "")
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
                    GiaoVien gv = new GiaoVien(txtMaGV.Text.Trim().ToString(), txtTen.Text.Trim().ToString(), gioitinh, txtSoDT.Text.Trim(), txtDiaChi.Text.Trim(), DateTime.Parse(dtNgaySinh.Text), float.Parse(txtLuong.Text.Trim()));
                    if (dal_gv.Sua(gv) == true)
                    {
                        FormatData();
                        ShowData();
                        MessageBox.Show("Sửa thành công");
                        EnableMethod(true);
                    }
                    else
                    {
                        Exception ex = dal_gv.GetEx();
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                    MessageBox.Show("Bạn cần nhập đủ thông tin phòng ban");
            }
            else if (type == "Xoa")
            {
                if (txtMaGV.Text != "" && txtTen.Text != "" && txtSoDT.Text != "" && txtLuong.Text != "" && txtDiaChi.Text != "")
                {
                    DialogResult dr = MessageBox.Show("Bạn có muốn xóa khồng?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (dr == DialogResult.OK)
                    {
                        dal_gv.Xoa(txtMaGV.Text);
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

        private void dtgvGiaoVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dtgvGiaoVien.Rows[e.RowIndex];
                txtMaGV.Text = row.Cells[0].Value.ToString().Trim();
                txtTen.Text = row.Cells[1].Value.ToString().Trim();
                if (row.Cells[2].Value.ToString().Trim() == "Nam")
                {
                    rbNam.Checked = true;
                }
                else if (row.Cells[2].Value.ToString().Trim() == "Nữ")
                    rbNu.Checked = true;
                else
                    rbKhac.Checked = true;
                txtSoDT.Text = row.Cells[3].Value.ToString().Trim();
                txtDiaChi.Text = row.Cells[4].Value.ToString().Trim();
                dtNgaySinh.Text = row.Cells[5].Value.ToString().Trim();
                txtLuong.Text = row.Cells[6].Value.ToString().Trim();

            }
            catch (Exception ex)
            {
                ex = dal_gv.GetEx();
                MessageBox.Show(ex.Message);
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            type = "Sua";
            EnabledData(true);
            EnableMethod(false);
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

        private void btTimKiem_Click(object sender, EventArgs e)
        {
            if (txtTimKiem.Text != "")
            {
                btHienThi.Enabled = true;
                if (dal_gv.GetDataTimKiem(txtTimKiem.Text.Trim()) != null)
                {
                    dtgvGiaoVien.DataSource = dal_gv.GetDataTimKiem(txtTimKiem.Text.Trim());
                    MessageBox.Show("Tìm thành công");
                }
                else
                {
                    Exception ex = dal_gv.GetEx();
                    MessageBox.Show(ex.Message);
                }
            }
            else
                MessageBox.Show("Bạn cần nhập thông tin để tìm kiếm !");
        }

        private void btHienThi_Click(object sender, EventArgs e)
        {
            btHienThi.Enabled = false;
            txtTimKiem.Text = "";
            ShowData();
        }
    }
}
