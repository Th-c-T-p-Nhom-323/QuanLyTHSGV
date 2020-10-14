using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALKetQuaHocTap : ClassConnection
    {
        public DataTable GetData()
        {
            return (DataTable)ShowDataInGridView("SELECT a.makqht, b.MaHS, b.Ten, a.TBHK1, a.HocLuc1, a.TBHK2, a.HocLuc2, a.TBCN, a.HocLuc  FROM dbo.KetQuaHocTap AS a, dbo.HocSinh AS b WHERE a.MaHS = b.MaHS");
        }
        public DataTable GetDataComHocSinh()
        {
            return (DataTable)ShowDataInGridView("select mahs,ten from hocsinh");
        }
        public bool Them(KetQuaHocTap kqht)
        {
            try
            {
                string query = @"INSERT INTO dbo.KetQuaHocTap
                VALUES  ( '" + kqht.MaKQHT + "' , '" + kqht.MaHS + "' , '" + kqht.TBHK1 + "' ,N'" + kqht.HocLuc1 + "' ,'" + kqht.TBHK2 + "' , N'" + kqht.HocLuc2 + "'  ,  '" + kqht.TBCN + "', N'" + kqht.HocLuc + "')";
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
        public bool Sua(KetQuaHocTap kqht)
        {
            try
            {
                string query = @" UPDATE dbo.Ketquahoctap SET mahs = '" + kqht.MaHS + "', TBHK1 = '" + kqht.TBHK1 + "' ,HocLuc1 = N'" + kqht.HocLuc1 + "' , TBHK2  = '" + kqht.TBHK2 + "',HocLuc2  = N'" + kqht.HocLuc2 + "', tbcn = '" + kqht.TBCN + "', hocluc = '" + kqht.HocLuc + "' where makqht = '" + kqht.MaKQHT + "'";
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

                string query = @"DELETE FROM dbo.KetQuaHoctap WHERE Makqht='" + ma + "'";
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
                string query = @"SELECT a.makqht, b.MaHS, b.Ten, a.TBHK1, a.HocLuc1, a.TBHK2, a.HocLuc2, a.TBCN, a.HocLuc FROM dbo.KetQuaHocTap AS a, dbo.HocSinh AS b WHERE a.MaHS = b.MaHS and (a.makqht like '%" + chuoi + "%' or a.hocluc1 like N'%" + chuoi + "%' or a.hocluc2 like N'%" + chuoi + "%' or a.hocluc like N'%" + chuoi + "%' or a.mahs like '%" + chuoi + "%')";
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
