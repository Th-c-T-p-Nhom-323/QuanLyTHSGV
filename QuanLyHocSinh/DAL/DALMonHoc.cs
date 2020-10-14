using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALMonHoc : ClassConnection
    {
        public DataTable GetData()
        {
            return (DataTable)ShowDataInGridView("SELECT * FROM dbo.MonHoc ");
        }
        public bool Them(MonHoc mh)
        {
            try
            {
                string query = @"INSERT INTO dbo.MonHoc
            VALUES  ( '" + mh.MaMH + "',N'" + mh.Ten + "', '" + mh.HeSo + "')";
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
        public bool Sua(MonHoc mh)
        {
            try
            {
                string query = @" UPDATE dbo.MonHoc set Ten = N'" + mh.Ten + "', heso = '" + mh.HeSo + "' where mamh = '" + mh.MaMH + "'";
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

                string query = @"DELETE FROM dbo.monhoc WHERE Mamh='" + ma + "'";
                OpenConection();
                ExecuteQueries(@"DELETE FROM dbo.bangdiem WHERE Mamh  = '" + ma + "'");
                ExecuteQueries(@"DELETE FROM dbo.thongtingiangday WHERE Mamh  = '" + ma + "'");
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
                string query = @"select * from monhoc where (mamh like '%" + chuoi + "%' or ten like N'%" + chuoi + "%')";
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
