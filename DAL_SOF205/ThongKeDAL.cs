using DTO_SOF205;
using Microsoft.Data.SqlClient;
using System.Data;
using UTIL_SOF205;

namespace DAL_SOF205
{
    public class ThongKeDAL
    {
        public List<TKDoanhThuTheoLoaiSP> DoanhThuTheoLoaiSP(
            String maLoaiSP, 
            DateTime tuNgay, 
            DateTime denNgay)
        {
            String sql = "TKDoanhThuTheoLoaiSP";
            List<Object> thamSo = new List<Object>();
            thamSo.Add(maLoaiSP);
            thamSo.Add(DateUtil.ToString(tuNgay, "yyyy-MM-dd"));
            thamSo.Add(DateUtil.ToString(denNgay, "yyyy-MM-dd"));
            
            List<TKDoanhThuTheoLoaiSP> list = new List<TKDoanhThuTheoLoaiSP>();
            try
            {
                SqlDataReader reader = DBUtil.Query(sql, thamSo, CommandType.StoredProcedure);
                while (reader.Read())
                {
                    TKDoanhThuTheoLoaiSP entity = new TKDoanhThuTheoLoaiSP();
                    entity.MaSanPham = reader.GetString("MaSanPham");
                    entity.TenSanPham = reader.GetString("TenSanPham");
                    entity.TongTien = reader.GetDecimal("TongTien");
                    entity.SoLy = reader.GetInt32("SoLy");
                    entity.NgayBan = reader.GetDateTime("NgayBan");
                    entity.SoLuongPhieu = reader.GetInt32("SoLuongPhieu");
                    entity.DaThanhToan = reader.GetBoolean("DaThanhToan");
                    list.Add(entity);
                }
            }
            catch (Exception)
            {
                throw;
            }
            return list;
        }

        public List<TKDoanhThuTheoNhanVien> DoanhThuTheoNhanVien(
            String maNhanVien, 
            DateTime tuNgay, 
            DateTime denNgay)
        {
            String sql = "TKDoanhThuTheoNhanVien";
            List<Object> thamSo = new List<Object>();
            thamSo.Add(maNhanVien);
            thamSo.Add(DateUtil.ToString(tuNgay, "yyyy-MM-dd"));
            thamSo.Add(DateUtil.ToString(denNgay, "yyyy-MM-dd"));

            List<TKDoanhThuTheoNhanVien> list = new List<TKDoanhThuTheoNhanVien>();
            try
            {
                SqlDataReader reader = DBUtil.Query(sql, thamSo, CommandType.StoredProcedure);
                while (reader.Read())
                {
                    TKDoanhThuTheoNhanVien entity = new TKDoanhThuTheoNhanVien();
                    entity.MaNhanVien = reader.GetString("MaNhanVien");
                    entity.HoTen = reader.GetString("HoTen");
                    entity.TongTien = reader.GetDecimal("TongTien");
                    entity.SoLy = reader.GetInt32("SoLy");
                    entity.NgayBan = reader.GetDateTime("NgayBan");
                    entity.SoLuongPhieu = reader.GetInt32("SoLuongPhieu");
                    entity.DaThanhToan = reader.GetBoolean("DaThanhToan");
                    list.Add(entity);
                }
            }
            catch (Exception)
            {
                throw;
            }
            return list;
        }
    }
}
