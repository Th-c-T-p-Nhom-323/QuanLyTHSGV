using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class HocSinh
    {
        private string maHS;

        public string MaHS
        {
            get { return maHS; }
            set { maHS = value; }
        }
        private string ten;

        public string Ten
        {
            get { return ten; }
            set { ten = value; }
        }
        private string diaChi;

        public string DiaChi
        {
            get { return diaChi; }
            set { diaChi = value; }
        }
        private string gioiTinh;

        public string GioiTinh
        {
            get { return gioiTinh; }
            set { gioiTinh = value; }
        }
        private DateTime ngaySinh;

        public DateTime NgaySinh
        {
            get { return ngaySinh; }
            set { ngaySinh = value; }
        }
        private string tenNguoiThan;

        public string TenNguoiThan
        {
            get { return tenNguoiThan; }
            set { tenNguoiThan = value; }
        }
        private string maLH;

        public string MaLH
        {
            get { return maLH; }
            set { maLH = value; }
        }
        public HocSinh(string maHS, string ten, string diaChi, string gioiTinh, DateTime ngaySinh, string tenNguoiThan, string maLH)
        {
            this.maHS = maHS;
            this.ten = ten;
            this.diaChi = diaChi;
            this.gioiTinh = gioiTinh;
            this.ngaySinh = ngaySinh;
            this.tenNguoiThan = tenNguoiThan;
            this.maLH = maLH;
        }
    }
}
