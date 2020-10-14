using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ThongTinGiangDay
    {
        private string maGV;

        public string MaGV
        {
            get { return maGV; }
            set { maGV = value; }
        }
        private string maLH;

        public string MaLH
        {
            get { return maLH; }
            set { maLH = value; }
        }
        private string thu;

        public string Thu
        {
            get { return thu; }
            set { thu = value; }
        }
        private string tiet;

        public string Tiet
        {
            get { return tiet; }
            set { tiet = value; }
        }
        private string maMH;

        public string MaMH
        {
            get { return maMH; }
            set { maMH = value; }
        }
        public ThongTinGiangDay(string maGV, string maLH, string thu, string tiet, string maMH)
        {
            this.maGV = maGV;
            this.maLH = maLH;
            this.thu = thu;
            this.tiet = tiet;
            this.maMH = maMH;
        }
    }
}
