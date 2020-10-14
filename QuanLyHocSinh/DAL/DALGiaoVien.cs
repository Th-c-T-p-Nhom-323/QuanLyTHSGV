using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALGiaoVien:ClassConnection
    {
        public DataTable GetData()
        {
            return (DataTable)ShowDataInGridView("SELECT * FROM dbo.GiaoVien ");
        }
        public bool Them(GiaoVien gv)
        {
            try
            {
                string query = @"INSERT INTO dbo.GiaoVien
                                ( MaGV ,
                                  Ten ,
                                  GioiTinh ,
                                  SoDT ,
                                  DiaChi ,
                                  NgaySinh ,
                                  Luong
                                )
                        VALUES  ( '" + gv.MaGV + "', N'" + gv.Ten + "' ,N'" + gv.GioiTinh + "','" + gv.SoDT + "',N'" + gv.DiaChi + "','" + gv.NgaySinh + "', '" + gv.Luong + "')";
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
        public bool Sua(GiaoVien gv)
        {
            try
            {
                string query = @" UPDATE dbo.GiaoVien SET Ten = N'" + gv.Ten + "', GioiTinh = N'" + gv.GioiTinh + "',sodt = '" + gv.SoDT + "', diachi = N'" + gv.DiaChi + "',ngaysinh = '" + gv.NgaySinh + "', luong = '" + gv.Luong + "' where magv = '" + gv.MaGV + "'";
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

                string query = @"DELETE FROM dbo.giaovien WHERE Magv='" + ma + "'";
                OpenConection();
                ExecuteQueries(@"DELETE FROM dbo.thongtingiangday WHERE Magv  = '" + ma + "'");
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
                string query = @"select * from giaovien where (ten like '%" + chuoi + "%' or gioitinh like N'%" + chuoi + "%' or diachi like N'%" + chuoi + "%' or magv like '%" + chuoi + "%' or sodt like '%" + chuoi + "%' )";
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
