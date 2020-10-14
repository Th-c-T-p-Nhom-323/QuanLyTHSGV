using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALHocSinh:ClassConnection
    {
        public DataTable GetData()
        {
            return (DataTable)ShowDataInGridView("SELECT *from hocsinh" );
        }
        //public string GetTenLH(string malh)
        //{
        //    SqlCommand cmd = new SqlCommand("select tenlh from lophoc where malh = '" + malh + "'", GetCon());

        //    // 2. Call ExecuteNonQuery to send command
        //    string tenlh = (string)cmd.ExecuteScalar();
        //    return tenlh;
        //}
        public DataTable GetDataCom()
        {
            return (DataTable)ShowDataInGridView("select malh,tenlh from lophoc");
        }
        public DataTable GetTenLH(string malh)
        {
            return (DataTable)ShowDataInGridView("select malh,tenlh from lophoc where malh = '"+malh+"'");
        }
        public bool Them(HocSinh hs)
        {
            try
            {
                string query = @"INSERT INTO dbo.HocSinh
                    ( MaHS ,
                      Ten ,
                      DiaChi ,
                      GioiTinh ,
                      NgaySinh ,
                      TenNguoiThan ,
                      MaLH
                    )
            VALUES  ( '" + hs.MaHS + "' ,N'" + hs.Ten + "' ,N'" + hs.DiaChi + "' ,N'" + hs.GioiTinh + "' ,'" + hs.NgaySinh + "' ,N'" + hs.TenNguoiThan + "' ,'" + hs.MaLH + "')";
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
        public bool Sua(HocSinh hs)
        {
            try
            {
                string query = @" UPDATE dbo.HocSinh SET Ten = N'" + hs.Ten + "' ,diachi = N'" + hs.DiaChi + "' , gioitinh = N'" + hs.GioiTinh + "' ,ngaysinh = '" + hs.NgaySinh + "' ,tennguoithan = N'" + hs.TenNguoiThan + "' ,malh = '" + hs.MaLH + "' where mahs ='" + hs.MaHS + "'";
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

                string query = @"DELETE FROM dbo.hocsinh WHERE Mahs='" + ma + "'";
                OpenConection();
                ExecuteQueries(@"DELETE FROM dbo.bangdiem WHERE Mahs  = '" + ma + "'");
                ExecuteQueries(@"DELETE FROM dbo.hanhkiemhs WHERE Mahs  = '" + ma + "'");
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
                string query = @"select * from hocsinh where (diachi like N'%" + chuoi + "%' or ten like N'%" + chuoi + "%' or gioitinh like N'%" + chuoi + "%' or tennguoithan like N'%" + chuoi + "%' or mahs like '%" + chuoi + "%' or malh like '%" + chuoi + "%' )";
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
