using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class HanhKiem
    {
        private string maHK;

        public string MaHK
        {
            get { return maHK; }
            set { maHK = value; }
        }
        private string ten;

        public string Ten
        {
            get { return ten; }
            set { ten = value; }
        }
        public HanhKiem(string maHK, string ten)
        {
            this.maHK = maHK;
            this.ten = ten;
        }
    }
}
