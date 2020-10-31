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
    public partial class frmHanhKiemHS : Form
    {
        public frmHanhKiemHS()
        {
            InitializeComponent();
            ShowData();
            if (frmLogin.quyen == 1)
            {
                PhanQuyen(true);
            }
            else
                PhanQuyen(false);
            LoadComHK();
            LoadComHS();
            txtMaHK.Text = cbTenHK.SelectedValue.ToString();
            txtMaHS.Text = cbTenHS.SelectedValue.ToString();
            maHK = txtMaHK.Text;
            maHS = txtMaHS.Text;
        }
        DALHanhKIemHS dal_hkhs = new DALHanhKIemHS();
        bool check = false;

        private void FormatData()
        {
            txtNamHoc.Text = "";
        }
        void PhanQuyen(bool b)
        {
            btThem.Enabled = b;
            btSua.Enabled = b;
            btXoa.Enabled = b;
        }
        private void EnabledData(bool b)
        {
            txtNamHoc.Enabled = b;
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
            dtgvHanhKiemHS.DataSource = dal_hkhs.GetData();
            EnabledData(check);
        }
        void LoadComHK()
        {
            cbTenHK.DataSource = dal_hkhs.GetDataComHK();
            cbTenHK.DisplayMember = "Ten";
            cbTenHK.ValueMember = "mahk";

        }
        void LoadComHS()
        {
            cbTenHS.DataSource = dal_hkhs.GetDataComHS();
            cbTenHS.DisplayMember = "Ten";
            cbTenHS.ValueMember = "mahs";
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            type = "Them";
            EnabledData(true);
            EnableMethod(false);
        }
        string maHK, maHS;
        private void dtgvHanhKiemHS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dtgvHanhKiemHS.Rows[e.RowIndex];
                cbTenHK.Text = row.Cells[1].Value.ToString().Trim();
                txtMaHK.Text = row.Cells[0].Value.ToString().Trim();
                maHK = txtMaHK.Text;
                cbTenHS.Text = row.Cells[3].Value.ToString().Trim();
                txtMaHS.Text = row.Cells[2].Value.ToString().Trim();
                maHS = txtMaHS.Text;
                txtNamHoc.Text = row.Cells[4].Value.ToString().Trim();
                cbHocKy.Text = row.Cells[5].Value.ToString().Trim();
            }
            catch (Exception ex)
            {
                ex = dal_hkhs.GetEx();
                MessageBox.Show(ex.Message);
            }
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            if (type == "Them")
            {
                if (txtNamHoc.Text != "" && cbHocKy.Text != "")
                {
                    HanhKiemHS hkhs = new HanhKiemHS(cbTenHK.SelectedValue.ToString().Trim(), cbTenHS.SelectedValue.ToString().Trim(), txtNamHoc.Text.ToString().Trim(), int.Parse(cbHocKy.SelectedItem.ToString()));
                    if (dal_hkhs.Them(hkhs) == true)
                    {
                        FormatData();
                        ShowData();
                        EnableMethod(true);
                        MessageBox.Show("Thêm thành công");
                    }
                    else
                    {
                        Exception ex = dal_hkhs.GetEx();
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                    MessageBox.Show("Bạn cần nhập đủ thông tin phòng ban");

            }
            else if (type == "Sua")
            {
                if (txtNamHoc.Text != "" && cbHocKy.Text != "")
                {
                    HanhKiemHS hkhs = new HanhKiemHS(cbTenHK.SelectedValue.ToString().Trim().ToString(), cbTenHS.SelectedValue.ToString().Trim().ToString(), txtNamHoc.Text.Trim(), int.Parse(cbHocKy.SelectedItem.ToString().Trim()));
                    if (dal_hkhs.Sua(hkhs, maHK, maHS) == true)
                    {
                        FormatData();
                        ShowData();
                        MessageBox.Show("Sửa thành công");
                        EnableMethod(true);
                    }
                    else
                    {
                        Exception ex = dal_hkhs.GetEx();
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                    MessageBox.Show("Bạn cần nhập đủ thông tin phòng ban");
            }
            else if (type == "Xoa")
            {
                if (txtMaHK.Text != "" && txtMaHS.Text != "")
                {
                    DialogResult dr = MessageBox.Show("Bạn có muốn xóa khồng?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (dr == DialogResult.OK)
                    {
                        dal_hkhs.Xoa(txtMaHK.Text, txtMaHS.Text);
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

        private void btSua_Click(object sender, EventArgs e)
        {
            type = "Sua";
            EnabledData(true);
            EnableMethod(false);
        }

        private void btThoat_Click(object sender, EventArgs e)
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

        private void btXoa_Click(object sender, EventArgs e)
        {
            type = "Xoa";
            EnabledData(false);
            EnableMethod(false);
            btOk.Visible = true;
            btCancel.Visible = true;
        }

        private void cbTenHK_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtMaHK.Text = cbTenHK.SelectedValue.ToString();
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
                if (dal_hkhs.GetDataTimKiem(txtTimKiem.Text.Trim()) != null)
                {
                    dtgvHanhKiemHS.DataSource = dal_hkhs.GetDataTimKiem(txtTimKiem.Text.Trim());
                    MessageBox.Show("Tìm thành công");
                }
                else
                {
                    Exception ex = dal_hkhs.GetEx();
                    MessageBox.Show(ex.Message);
                }
            }
            else
                MessageBox.Show("Bạn cần nhập thông tin để tìm kiếm !");
        }

        private void cbTenHS_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtMaHS.Text = cbTenHS.SelectedValue.ToString();
        }
    }
}
