
using DAL;
using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUSHanhKiem
    {
        DALHanhKiem dal_hk = new DALHanhKiem();
        public DataTable GetData()
        {
            return dal_hk.GetData();
        }
        public bool Them(HanhKiem hk)
        {
            return dal_hk.Them(hk);
        }
        public bool Sua(HanhKiem hk)
        {
            return dal_hk.Sua(hk);
        }
        public Exception GetEx()
        {
            return dal_hk.GetEx();
        }
        public void SetEx(Exception ex)
        {

        }
        public bool Xoa(string ma)
        {
            return dal_hk.Xoa(ma);
        }
        public DataTable GetDataTimKiem(string chuoi)
        {
            return dal_hk.GetDataTimKiem(chuoi);
        }
    }
}
