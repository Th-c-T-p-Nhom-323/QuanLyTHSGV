using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALThongTinGangDay:ClassConnection
    {
        public DataTable GetData()
        {
            return (DataTable)ShowDataInGridView("SELECT b.MaGV, b.Ten,d.MaLH,d.TenLH,a.Thu,a.Tiet,c.MaMH,c.Ten AS tenmh FROM dbo.ThongTinGiangDay AS a, dbo.GiaoVien AS b, dbo.MonHoc AS c, dbo.LopHoc AS d WHERE b.MaGV = a.MaGV AND c.MaMH = a.MaMH AND d.MaLH = a.MaLH");
        }
        public DataTable GetDataComGV()
        {
            return (DataTable)ShowDataInGridView("select magv,ten from giaovien");
        }
        public DataTable GetDataComLH()
        {
            return (DataTable)ShowDataInGridView("select malh,tenlh from lophoc");
        }
        public DataTable GetDataComMH()
        {
            return (DataTable)ShowDataInGridView("select mamh,ten from monhoc");
        }
        public bool Them(ThongTinGiangDay ttgd)
        {
            try
            {
                string query = @"INSERT INTO dbo.ThongTinGiangDay
                        ( MaGV, MaLH, Thu, Tiet, MaMH )
                VALUES  ( '" + ttgd.MaGV + "', '" + ttgd.MaLH + "',N'" + ttgd.Thu + "',N'" + ttgd.Tiet + "','" + ttgd.MaMH + "')";
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
        public bool Sua(ThongTinGiangDay ttgd, string magv, string malh, string mamh)
        {
            try
            {
                string query = @" UPDATE dbo.Thongtingiangday SET magv ='" + ttgd.MaGV + "',MaLH = '" + ttgd.MaLH + "' , Thu = N'" + ttgd.Thu + "' ,Tiet = N'" + ttgd.Tiet + "',MaMH = '" + ttgd.MaMH + "' where magv ='" + magv + "' and malh = '" + malh + "' and mamh = '" + mamh + "'";
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
        public bool Xoa(string magv, string malh, string mamh)
        {
            try
            {

                string query = @"DELETE FROM dbo.thongtingiangday WHERE Magv='" + magv + "'and malh = '" + malh + "' and mamh = '" + mamh + "' ";
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
                string query = @"SELECT b.MaGV, b.Ten,d.MaLH,d.TenLH,a.Thu,a.Tiet,c.MaMH,c.Ten AS tenmh FROM dbo.ThongTinGiangDay AS a, dbo.GiaoVien AS b, dbo.MonHoc AS c, dbo.LopHoc AS d WHERE b.MaGV = a.MaGV AND c.MaMH = a.MaMH AND d.MaLH = a.MaLH and (a.magv like '%" + chuoi + "%' or a.malh like '%" + chuoi + "%' or a.thu like N'%" + chuoi + "%' or a.tiet like N'%" + chuoi + "%' or a.mamh like '%" + chuoi + "%')";
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
