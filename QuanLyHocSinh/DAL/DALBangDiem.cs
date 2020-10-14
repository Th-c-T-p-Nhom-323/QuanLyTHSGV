using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALBangDiem:ClassConnection
    {
        public DataTable GetData()
        {
            return (DataTable)ShowDataInGridView("SELECT c.MaHS, c.Ten,b.MaMH,b.Ten AS tenmh, a.DMieng,a.D15Phut,a.D1Tiet,a.DCuoiKy FROM dbo.BangDiem AS a, dbo.MonHoc AS b, dbo.HocSinh AS c WHERE a.MaHS = c.MaHS AND a.MaMH = b.MaMH");
        }
        public DataTable GetDataComHS()
        {
            return (DataTable)ShowDataInGridView("select mahs,ten from hocsinh");
        }
        public DataTable GetDataComMH()
        {
            return (DataTable)ShowDataInGridView("select mamh,ten from monhoc");
        }
        public bool Them(BangDiem bd)
        {
            try
            {
                string query = @"INSERT INTO dbo.BangDiem
                        ( MaHS ,
                          MaMH ,
                          DMieng ,
                          D15Phut ,
                          D1Tiet ,
                          DCuoiKy
                        )
                VALUES  ( '" + bd.MaHS + "' ,'" + bd.MaMH + "' , '" + bd.DiemMieng + "' ,'" + bd.Diem15Phut + "' ,'" + bd.Diem1Tiet + "' ,'" + bd.DiemCK + "')";
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
        public bool Sua(BangDiem bd, string mahs, string mamh)
        {
            try
            {
                string query = @" UPDATE dbo.Bangdiem SET mamh = '" + bd.MaMH + "' ,mahs = '" + bd.MaHS + "',DMieng ='" + bd.DiemMieng + "', D15Phut = '" + bd.Diem15Phut + "' ,D1Tiet = '" + bd.Diem1Tiet + "' ,DCuoiKy = '" + bd.DiemCK + "' where mahs ='" + mahs + "' and mamh = '" + mamh + "'";
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
        public bool Xoa(string mahs, string mamh)
        {
            try
            {

                string query = @"DELETE FROM dbo.bangdiem WHERE Mahs='" + mahs + "' and mamh = '" + mamh + "'";
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
                string query = @"SELECT c.MaHS, c.Ten,b.MaMH,b.Ten AS tenmh, a.DMieng,a.D15Phut,a.D1Tiet,a.DCuoiKy FROM dbo.BangDiem AS a, dbo.MonHoc AS b, dbo.HocSinh AS c WHERE a.MaHS = c.MaHS AND a.MaMH = b.MaMH and (a.mahs like '%" + chuoi + "%' or a.mamh like '%" + chuoi + "%') ";
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
