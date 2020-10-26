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
    public partial class frmThongTinGiangDay : Form
    {
        public frmThongTinGiangDay()
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
            LoadComGV();
            LoadComLH();
            txtMaGV.Text = cbTenGV.SelectedValue.ToString();
            maGV = txtMaGV.Text;
            txtMaLH.Text = cbTenLH.SelectedValue.ToString();
            maLH = txtMaLH.Text;
            txtMaMH.Text = cbTenMH.SelectedValue.ToString();
            maMH = txtMaMH.Text;
        }
        DALThongTinGangDay dal_ttgd = new DALThongTinGangDay();
        bool check = false;

        private void FormatData()
        {
            txtThu.Text = "";
            txtTiet.Text = "";
        }
        void PhanQuyen(bool b)
        {
            btThem.Enabled = b;
            btSua.Enabled = b;
            btXoa.Enabled = b;
        }
        private void EnabledData(bool b)
        {
            txtThu.Enabled = b;
            txtTiet.Enabled = b;
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
            dtgvThongTinGD.DataSource = dal_ttgd.GetData();
            EnabledData(check);
        }
        void LoadComGV()
        {
            cbTenGV.DataSource = dal_ttgd.GetDataComGV();
            cbTenGV.DisplayMember = "Ten";
            cbTenGV.ValueMember = "magv";
        }
        void LoadComLH()
        {
            cbTenLH.DataSource = dal_ttgd.GetDataComLH();
            cbTenLH.DisplayMember = "Tenlh";
            cbTenLH.ValueMember = "malh";
        }
        void LoadComMH()
        {
            cbTenMH.DataSource = dal_ttgd.GetDataComMH();
            cbTenMH.DisplayMember = "Ten";
            cbTenMH.ValueMember = "mamh";
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
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            type = "Xoa";
            EnabledData(false);
            EnableMethod(false);
            btOk.Visible = true;
            btCancel.Visible = true;
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
            frmMain fmain = new frmMain();
            fmain.Show();
        }
        string maGV, maLH, maMH;
        private void btOk_Click(object sender, EventArgs e)
        {
            if (type == "Them")
            {
                if (txtThu.Text != "" && txtTiet.Text != "")
                {
                    ThongTinGiangDay ttgd = new ThongTinGiangDay(cbTenGV.SelectedValue.ToString(), cbTenLH.SelectedValue.ToString(), txtThu.Text.Trim(), txtTiet.Text.Trim(), cbTenMH.SelectedValue.ToString());
                    if (dal_ttgd.Them(ttgd) == true)
                    {
                        FormatData();
                        ShowData();
                        EnableMethod(true);
                        MessageBox.Show("Thêm thành công");
                    }
                    else
                    {
                        Exception ex = dal_ttgd.GetEx();
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                    MessageBox.Show("Bạn cần nhập đủ thông tin phòng ban");

            }
            else if (type == "Sua")
            {
                if (txtThu.Text != "" && txtTiet.Text != "")
                {
                    ThongTinGiangDay ttgd = new ThongTinGiangDay(cbTenGV.SelectedValue.ToString(), cbTenLH.SelectedValue.ToString(), txtThu.Text.Trim(), txtTiet.Text.Trim(), cbTenMH.SelectedValue.ToString());
                    if (dal_ttgd.Sua(ttgd, maGV, maLH, maMH) == true)
                    {
                        FormatData();
                        ShowData();
                        MessageBox.Show("Sửa thành công");
                        EnableMethod(true);
                    }
                    else
                    {
                        Exception ex = dal_ttgd.GetEx();
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                    MessageBox.Show("Bạn cần nhập đủ thông tin phòng ban");
            }
            else if (type == "Xoa")
            {
                if (txtThu.Text != "" && txtTiet.Text != "")
                {
                    DialogResult dr = MessageBox.Show("Bạn có muốn xóa khồng?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (dr == DialogResult.OK)
                    {
                        dal_ttgd.Xoa(txtMaGV.Text, txtMaLH.Text, txtMaMH.Text);
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

        private void dtgvThongTinGD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dtgvThongTinGD.Rows[e.RowIndex];
                cbTenGV.Text = row.Cells[1].Value.ToString().Trim();
                txtMaGV.Text = row.Cells[0].Value.ToString().Trim();
                maGV = txtMaGV.Text;
                cbTenLH.Text = row.Cells[3].Value.ToString().Trim();
                txtMaLH.Text = row.Cells[2].Value.ToString().Trim();
                maLH = txtMaLH.Text;
                txtThu.Text = row.Cells[4].Value.ToString().Trim();
                txtTiet.Text = row.Cells[5].Value.ToString().Trim();
                txtMaMH.Text = row.Cells[6].Value.ToString().Trim();
                cbTenMH.Text = row.Cells[7].Value.ToString().Trim();
                maMH = txtMaMH.Text;
            }
            catch (Exception ex)
            {
                ex = dal_ttgd.GetEx();
                MessageBox.Show(ex.Message);
            }
        }

        private void btThoat_Click_1(object sender, EventArgs e)
        {
            this.Close();
            frmMain fmain = new frmMain();
            fmain.Show();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            EnabledData(false);
            EnableMethod(true);
        }

        private void cbTenGV_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtMaGV.Text = cbTenGV.SelectedValue.ToString();
        }

        private void btHienThi_Click(object sender, EventArgs e)
        {
            btHienThi.Enabled = false;
            txtTimKiem.Text = "";
            ShowData();
        }

        private void btTiemKiem_Click(object sender, EventArgs e)
        {
            if (txtTimKiem.Text != "")
            {
                btHienThi.Enabled = true;
                if (dal_ttgd.GetDataTimKiem(txtTimKiem.Text.Trim()) != null)
                {
                    dtgvThongTinGD.DataSource = dal_ttgd.GetDataTimKiem(txtTimKiem.Text.Trim());
                    MessageBox.Show("Tìm thành công");
                }
                else
                {
                    Exception ex = dal_ttgd.GetEx();
                    MessageBox.Show(ex.Message);
                }
            }
            else
                MessageBox.Show("Bạn cần nhập thông tin để tìm kiếm !");
        }

        private void cbTenLH_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtMaLH.Text = cbTenLH.SelectedValue.ToString();
        }

        private void cbTenMH_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtMaMH.Text = cbTenMH.SelectedValue.ToString();
        }
    }
}
