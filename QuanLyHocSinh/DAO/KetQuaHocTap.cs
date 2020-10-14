using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class KetQuaHocTap
    {
        private string maKQHT;

        public string MaKQHT
        {
            get { return maKQHT; }
            set { maKQHT = value; }
        }

        private string maHS;

        public string MaHS
        {
            get { return maHS; }
            set { maHS = value; }
        }
        private float tBHK1;

        public float TBHK1
        {
            get { return tBHK1; }
            set { tBHK1 = value; }
        }
        private string hocLuc1;

        public string HocLuc1
        {
            get { return hocLuc1; }
            set { hocLuc1 = value; }
        }
        private float tBHK2;

        public float TBHK2
        {
            get { return tBHK2; }
            set { tBHK2 = value; }
        }
        private string hocLuc2;

        public string HocLuc2
        {
            get { return hocLuc2; }
            set { hocLuc2 = value; }
        }
        private float tBCN;

        public float TBCN
        {
            get { return tBCN; }
            set { tBCN = value; }
        }
        private string hocLuc;

        public string HocLuc
        {
            get { return hocLuc; }
            set { hocLuc = value; }
        }
        public KetQuaHocTap(string makqht, string maHS, float tBHK1, string hocLuc1, float tBHK2, string hocLuc2, float tBCN, string hocLuc)
        {
            this.maKQHT = makqht;
            this.maHS = maHS;
            this.tBHK1 = tBHK1;
            this.tBHK2 = tBHK2;
            this.hocLuc1 = hocLuc1;
            this.hocLuc2 = hocLuc2;
            this.tBCN = tBCN;
            this.hocLuc = hocLuc;
        }
    }
}
