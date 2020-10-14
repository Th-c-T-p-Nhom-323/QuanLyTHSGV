using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class GiaoVien
    {
        private string maGV;

        public string MaGV
        {
            get { return maGV; }
            set { maGV = value; }
        }
        private string ten;

        public string Ten
        {
            get { return ten; }
            set { ten = value; }
        }
        private string gioiTinh;

        public string GioiTinh
        {
            get { return gioiTinh; }
            set { gioiTinh = value; }
        }
        private string soDT;

        public string SoDT
        {
            get { return soDT; }
            set { soDT = value; }
        }
        private string diaChi;

        public string DiaChi
        {
            get { return diaChi; }
            set { diaChi = value; }
        }
        private DateTime ngaySinh;

        public DateTime NgaySinh
        {
            get { return ngaySinh; }
            set { ngaySinh = value; }
        }
        private float luong;

        public float Luong
        {
            get { return luong; }
            set { luong = value; }
        }

        public GiaoVien(string maGV, string ten, string gioiTinh, string soDT, string diaChi,DateTime ngaySinh, float luong)
        {
            this.maGV = maGV;
            this.ten = ten;
            this.gioiTinh = gioiTinh;
            this.soDT = soDT;
            this.diaChi = diaChi;
            this.ngaySinh = ngaySinh;
            this.luong = luong;
        }
    }
}
