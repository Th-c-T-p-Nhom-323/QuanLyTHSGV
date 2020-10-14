using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class MonHoc
    {
        private string maMH;

        public string MaMH
        {
            get { return maMH; }
            set { maMH = value; }
        }
        private string ten;

        public string Ten
        {
            get { return ten; }
            set { ten = value; }
        }
        private int heSo;

        public int HeSo
        {
            get { return heSo; }
            set { heSo = value; }
        }
        public MonHoc(string maMH, string ten, int heSo)
        {
            this.maMH = maMH;
            this.ten = ten;
            this.heSo = heSo;
        }

    }
}
