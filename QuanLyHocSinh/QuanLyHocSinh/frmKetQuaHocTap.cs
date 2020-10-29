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
            if (type == "Them")
            {
                float diem1 = float.Parse(txtTBHK1.Text.Trim());
                if (diem1 >= 0 && diem1 < 3.5f)
                {
                    hocLuc1 = "Yếu";
                }
                else if (diem1 >= 3.5f && diem1 < 5.5f)
                    hocLuc1 = "Trung Bình";
                else if (diem1 >= 5.5f && diem1 < 8.0f)
                    hocLuc1 = "Khá";
                else
                    hocLuc1 = "Giỏi";


                float diem2 = float.Parse(txtTBHK2.Text.Trim());
                if (diem2 >= 0 && diem2 < 3.5f)
                    hocLuc2 = "Yếu";
                else if (diem2 >= 3.5f && diem2 < 5.5f)
                    hocLuc2 = "Trung Bình";
                else if (diem2 >= 5.5f && diem2 < 8.0f)
                    hocLuc2 = "Khá";
                else
                    hocLuc2 = "Giỏi";

                diemTB = (diem1 + diem2) / 2;
                if (diemTB >= 0 && diemTB < 3.5f)
                    hocLuc = "Yếu";
                else if (diemTB >= 3.5f && diemTB < 5.5f)
                    hocLuc = "Trung Bình";
                else if (diemTB >= 5.5f && diemTB < 8.0f)
                    hocLuc = "Khá";
                else
                    hocLuc = "Giỏi";

                if (txtTBHK1.Text != "" && txtTBHK2.Text != "")
                {
                    KetQuaHocTap kqht = new KetQuaHocTap(txtMaKQHT.Text.Trim(), txtMaHS.Text.Trim(), diem1, hocLuc1.Trim(), diem2, hocLuc2.Trim(), diemTB, hocLuc.Trim());
                    if (dal_kqht.Them(kqht) == true)
                    {
                        FormatData();
                        ShowData();
                        EnableMethod(true);
                        MessageBox.Show("Thêm thành công");
                    }
                    else
                    {
                        Exception ex = dal_kqht.GetEx();
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                    MessageBox.Show("Bạn cần nhập đủ thông tin ");

            }
            else if (type == "Sua")
            {
                float diem1 = float.Parse(txtTBHK1.Text.Trim());
                if (diem1 >= 0 && diem1 < 3.5f)
                {
                    hocLuc1 = "Yếu";
                }
                else if (diem1 >= 3.5f && diem1 < 5.5f)
                    hocLuc1 = "Trung Bình";
                else if (diem1 >= 5.5f && diem1 < 8.0f)
                    hocLuc1 = "Khá";
                else
                    hocLuc1 = "Giỏi";


                float diem2 = float.Parse(txtTBHK2.Text.Trim());
                if (diem2 >= 0 && diem2 < 3.5f)
                    hocLuc2 = "Yếu";
                else if (diem2 >= 3.5f && diem2 < 5.5f)
                    hocLuc2 = "Trung Bình";
                else if (diem2 >= 5.5f && diem2 < 8.0f)
                    hocLuc2 = "Khá";
                else
                    hocLuc2 = "Giỏi";

                diemTB = (diem1 + diem2) / 2;
                if (diemTB >= 0 && diemTB < 3.5f)
                    hocLuc = "Yếu";
                else if (diemTB >= 3.5f && diemTB < 5.5f)
                    hocLuc = "Trung Bình";
                else if (diemTB >= 5.5f && diemTB < 8.0f)
                    hocLuc = "Khá";
                else
                    hocLuc = "Giỏi";

                if (txtTBHK1.Text != "" && txtTBHK2.Text != "")
                {
                    KetQuaHocTap kqht = new KetQuaHocTap(txtMaKQHT.Text.Trim(), txtMaHS.Text.Trim(), diem1, hocLuc1.Trim(), diem2, hocLuc2.Trim(), diemTB, hocLuc.Trim());
                    if (dal_kqht.Sua(kqht) == true)
                    {
                        FormatData();
                        ShowData();
                        MessageBox.Show("Sửa thành công");
                        EnableMethod(true);
                    }
                    else
                    {
                        Exception ex = dal_kqht.GetEx();
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                    MessageBox.Show("Bạn cần nhập đủ thông tin phòng ban");
            }
            else if (type == "Xoa")
            {
                if (txtTBHK1.Text != "" && txtTBHK2.Text != "")
                {
                    DialogResult dr = MessageBox.Show("Bạn có muốn xóa khồng?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (dr == DialogResult.OK)
                    {
                        dal_kqht.Xoa(txtMaKQHT.Text);
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
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dtgvKetQuaHocTap.Rows[e.RowIndex];
                txtMaKQHT.Text = row.Cells[0].Value.ToString().Trim();
                txtMaHS.Text = row.Cells[1].Value.ToString().Trim();
                cbTenHS.Text = row.Cells[2].Value.ToString().Trim();
                txtTBHK1.Text = row.Cells[3].Value.ToString().Trim();
                txtTBHK2.Text = row.Cells[5].Value.ToString().Trim();
            }
            catch (Exception ex)
            {
                ex = dal_kqht.GetEx();
                MessageBox.Show(ex.Message);
            }
        }

        private void cbTenHS_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtMaHS.Text = cbTenHS.SelectedValue.ToString();
        }
    }
}
