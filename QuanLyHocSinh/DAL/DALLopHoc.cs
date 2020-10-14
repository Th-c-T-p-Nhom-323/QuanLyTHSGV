using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALLopHoc : ClassConnection
    {
        public DataTable GetData()
        {
            return (DataTable)ShowDataInGridView("SELECT a.MaLH,a.tenlh,b.MaGV, b.Ten FROM dbo.LopHoc AS a, dbo.GiaoVien AS b WHERE a.MaGVCN = b.MaGV ");
        }
        public DataTable GetDataCom()
        {
            return (DataTable)ShowDataInGridView("select magv,ten from giaovien");
        }
        public bool Them(LopHoc lh)
        {
            try
            {
                string query = @"INSERT INTO dbo.LopHoc
                VALUES  ( '" + lh.MaLH + "', '" + lh.MaGVCN + "', N'" + lh.TenLH + "')";
                OpenConection();
                ExecuteQueries(query);
                CloseConnection();
                return true;
            }
            catch (Exception ex)
            {
                SetEx(ex);
                return false;
            }
        }
        public bool Sua(LopHoc lh)
        {
            try
            {
                string query = @" UPDATE dbo.LopHoc set magvcn = '" + lh.MaGVCN + "',tenlh = '" + lh.TenLH + "'  where malh = '" + lh.MaLH + "'";
                OpenConection();
                ExecuteQueries(query);
                CloseConnection();
                return true;
            }
            catch (Exception ex)
            {
                SetEx(ex);
                return false;
            }
        }
        public bool Xoa(String ma)
        {
            try
            {

                string query = @"DELETE FROM dbo.LopHoc WHERE Malh='" + ma + "'";
                OpenConection();
                ExecuteQueries(@"delete from thongtingiangday where malh = '" + ma + "'");
                ExecuteQueries(query);
                CloseConnection();
                return true;
            }
            catch (Exception ex)
            {
                SetEx(ex);
                return false;
            }
        }
        public DataTable GetDataTimKiem(string chuoi)
        {
            try
            {
                string query = @"SELECT a.MaLH,a.tenlh,b.MaGV, b.Ten FROM dbo.LopHoc AS a, dbo.GiaoVien AS b WHERE a.MaGVCN = b.MaGV and (a.malh like '%" + chuoi + "%' or a.magvcn like '%" + chuoi + "%' or a.tenlh like N'%" + chuoi + "%')";
                return (DataTable)ShowDataInGridView(query);
            }
            catch (Exception ex)
            {
                SetEx(ex);
                return null;
            }
        }
    }
}
