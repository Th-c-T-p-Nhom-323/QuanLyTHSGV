using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALHanhKiem:ClassConnection
    {
        public DataTable GetData()
        {
            return (DataTable)ShowDataInGridView("SELECT * FROM dbo.HanhKiem ");
        }
        public bool Them(HanhKiem hk)
        {
            try
            {
                string query = @"INSERT INTO dbo.HanhKiem ( MaHK, Ten ) VALUES  ( '" + hk.MaHK + "',  N'" + hk.Ten + "')";
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
        public bool Sua(HanhKiem hk)
        {
            try
            {
                string query = @" UPDATE dbo.HanhKiem set Ten = N'" + hk.Ten + "' where mahk = '" + hk.MaHK + "'";
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

                string query = @"DELETE FROM dbo.HanhKiem WHERE Mahk='" + ma + "'";
                OpenConection();
                ExecuteQueries(@"delete from HanhKiemHS WHERE Mahk='" + ma + "'");
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
                string query = @"select * from hanhkiem where (ten like N'%" + chuoi + "%' or mahk like '%" + chuoi + "%')";
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
