using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class LopHoc
    {
        private string maLH;

        public string MaLH
        {
            get { return maLH; }
            set { maLH = value; }
        }
        private string tenLH;

        public string TenLH
        {
            get { return tenLH; }
            set { tenLH = value; }
        }
        private string maGVCN;

        public string MaGVCN
        {
            get { return maGVCN; }
            set { maGVCN = value; }
        }



        public LopHoc(string maLH, string maGVCN, string tenLH)
        {
            this.maLH = maLH;
            this.maGVCN = maGVCN;
            this.tenLH = tenLH;
        }
    }
}
