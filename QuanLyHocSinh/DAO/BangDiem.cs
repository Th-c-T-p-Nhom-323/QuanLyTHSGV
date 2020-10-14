using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class BangDiem
    {
        private string maHS;

        public string MaHS
        {
            get { return maHS; }
            set { maHS = value; }
        }
        private string maMH;

        public string MaMH
        {
            get { return maMH; }
            set { maMH = value; }
        }
        private float diemMieng;

        public float DiemMieng
        {
            get { return diemMieng; }
            set { diemMieng = value; }
        }
        private float diem15Phut;

        public float Diem15Phut
        {
            get { return diem15Phut; }
            set { diem15Phut = value; }
        }
        private float diem1Tiet;

        public float Diem1Tiet
        {
            get { return diem1Tiet; }
            set { diem1Tiet = value; }
        }
        private float diemCK;

        public float DiemCK
        {
            get { return diemCK; }
            set { diemCK = value; }
        }
        public BangDiem(string maHS,string maMH, float diemMieng,float diem15Phut,float diem1Tiet, float diemCK)
        {
            this.maHS = maHS;
            this.maMH = maMH;
            this.diemMieng = diemMieng;
            this.diem15Phut = diem15Phut;
            this.diem1Tiet = diem1Tiet;
            this.diemCK = diemCK;
        }

    }
}
