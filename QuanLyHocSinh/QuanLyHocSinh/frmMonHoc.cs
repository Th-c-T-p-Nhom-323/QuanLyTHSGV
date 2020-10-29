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
    public partial class frmMonHoc : Form
    {
        public frmMonHoc()
        {
            InitializeComponent();
            if (frmLogin.quyen == 1)
            {
                PhanQuyen(true);
            }
            else
                PhanQuyen(false);
            ShowData();
        }
        DALMonHoc dal_mh = new DALMonHoc();
        bool check = false;

        private void FormatData()
        {
            txtMaMH.Text = "";
            txtTenMH.Text = "";
        }
        void PhanQuyen(bool b)
        {
            btThem.Enabled = b;
            btSua.Enabled = b;
            btXoa.Enabled = b;
        }
        private void EnabledData(bool b)
        {
            txtMaMH.Enabled = b;
            txtTenMH.Enabled = b;
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
            dtgvMonHoc.DataSource = dal_mh.GetData();
            EnabledData(check);
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
            frmMain fmain = new frmMain();
            fmain.Show();
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
            txtMaMH.Enabled = false;
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            if (type == "Them")
            {
                if (txtMaMH.Text != "" && txtTenMH.Text != "")
                {
                    MonHoc mh = new MonHoc(txtMaMH.Text.Trim(), txtTenMH.Text.Trim(), int.Parse(cbHeSo.SelectedItem.ToString()));
                    if (dal_mh.Them(mh) == true)
                    {
                        FormatData();
                        ShowData();
                        EnableMethod(true);
                        MessageBox.Show("Thêm thành công");
                    }
                    else
                    {
                        Exception ex = dal_mh.GetEx();
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                    MessageBox.Show("Bạn cần nhập đủ thông tin phòng ban");

            }
            else if (type == "Sua")
            {
                if (txtMaMH.Text != "" && txtTenMH.Text != "")
                {
                    MonHoc mh = new MonHoc(txtMaMH.Text.Trim(), txtTenMH.Text.Trim(), int.Parse(cbHeSo.SelectedItem.ToString()));
                    if (dal_mh.Sua(mh) == true)
                    {
                        FormatData();
                        ShowData();
                        MessageBox.Show("Sửa thành công");
                        EnableMethod(true);
                    }
                    else
                    {
                        Exception ex = dal_mh.GetEx();
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                    MessageBox.Show("Bạn cần nhập đủ thông tin phòng ban");
            }
            else if (type == "Xoa")
            {
                if (txtMaMH.Text != "" && txtTenMH.Text != "")
                {
                    DialogResult dr = MessageBox.Show("Lớp học liên quan đến Bảng điểm và Thông tin giảng dạy, bạn vẫn muốn xóa?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (dr == DialogResult.OK)
                    {
                        dal_mh.Xoa(txtMaMH.Text);
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

        private void dtgvMonHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dtgvMonHoc.Rows[e.RowIndex];
                txtMaMH.Text = row.Cells[0].Value.ToString().Trim();
                txtTenMH.Text = row.Cells[1].Value.ToString().Trim();
                cbHeSo.Text = row.Cells[2].Value.ToString().Trim();
            }
            catch (Exception ex)
            {
                ex = dal_mh.GetEx();
                MessageBox.Show(ex.Message);
            }
        }
        private int GetHeSo(int heSo)
        {
            return heSo;
        }
        private void cbHeSo_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetHeSo(int.Parse(cbHeSo.SelectedItem.ToString().Trim()));
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

        private void btTiemKiem_Click(object sender, EventArgs e)
        {
            if (txtTimKiem.Text != "")
            {
                btHienThi.Enabled = true;
                if (dal_mh.GetDataTimKiem(txtTimKiem.Text.Trim()) != null)
                {
                    dtgvMonHoc.DataSource = dal_mh.GetDataTimKiem(txtTimKiem.Text.Trim());
                    MessageBox.Show("Tìm thành công");
                }
                else
                {
                    Exception ex = dal_mh.GetEx();
                    MessageBox.Show(ex.Message);
                }
            }
            else
                MessageBox.Show("Bạn cần nhập thông tin để tìm kiếm !");
        }
    }
}
