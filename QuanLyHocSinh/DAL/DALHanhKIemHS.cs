using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALHanhKIemHS:ClassConnection
    {
        public DataTable GetData()
        {
            return (DataTable)ShowDataInGridView("SELECT a.mahk,a.ten,b.mahs, b.ten as tenhs,c.namhoc,c.hocky from hanhkiem as a, hocsinh as b, hanhkiemhs as c where a.mahk = c.mahk and b.mahs = c.mahs  ");
        }
        public DataTable GetDataComHK()
        {
            return (DataTable)ShowDataInGridView("select mahk,ten from hanhkiem");
        }
        public DataTable GetDataComHS()
        {
            return (DataTable)ShowDataInGridView("select mahs,ten from hocsinh");
        }
        public bool Them(HanhKiemHS hkhs)
        {
            try
            {
                string query = @"INSERT INTO dbo.HanhKiemHS( MaHK, MaHS, NamHoc, HocKy ) VALUES  ( '" + hkhs.MaHK + "','" + hkhs.MaHS + "', N'" + hkhs.NamHoc + "','" + hkhs.HocKy + "')";
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
        public bool Sua(HanhKiemHS hkhs, string mahk, string mahs)
        {
            try
            {
                string query = @" UPDATE dbo.HanhKiemHS set mahs = '" + hkhs.MaHS + "' ,mahk = '" + hkhs.MaHK + "',namhoc = '" + hkhs.NamHoc + "', hocky = '" + hkhs.HocKy + "' where mahs = '" + mahs + "' and mahk = '" + mahk + "'";
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
        public bool Xoa(string mahk, string mahs)
        {
            try
            {

                string query = @"DELETE FROM dbo.HanhKiemHS WHERE Mahk='" + mahk + "' and mahs = '" + mahs + "'";
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
        public DataTable GetDataTimKiem(string chuoi)
        {
            try
            {
                string query = @"SELECT a.mahk,a.ten,b.mahs, b.ten as tenhs,c.namhoc,c.hocky from hanhkiem as a, hocsinh as b, hanhkiemhs as c where a.mahk = c.mahk and b.mahs = c.mahs and (c.namhoc like N'%" + chuoi + "%' or c.mahk like '%" + chuoi + "%' or c.mahs like '%" + chuoi + "%')";
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
