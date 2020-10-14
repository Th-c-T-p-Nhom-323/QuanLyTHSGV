using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class HanhKiemHS
    {
        private string maHK;

        public string MaHK
        {
            get { return maHK; }
            set { maHK = value; }
        }
        private string maHS;

        public string MaHS
        {
            get { return maHS; }
            set { maHS = value; }
        }
        private string namHoc;

        public string NamHoc
        {
            get { return namHoc; }
            set { namHoc = value; }
        }
        private int hocKy;

        public int HocKy
        {
            get { return hocKy; }
            set { hocKy = value; }
        }
        public HanhKiemHS(string maHK, string maHS, string namHoc, int hocKy)
        {
            this.maHK = maHK;
            this.maHS = maHS;
            this.namHoc = namHoc;
            this.hocKy = hocKy;
        }
    }
}
