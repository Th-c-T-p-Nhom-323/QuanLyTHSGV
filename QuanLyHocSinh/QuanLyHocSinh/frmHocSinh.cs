﻿using DAL;
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
            
        }

        private void btHienThi_Click(object sender, EventArgs e)
        {
            btHienThi.Enabled = false;
            txtTimKiem.Text = "";
            ShowData();
        }

        private void btTimKiem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
