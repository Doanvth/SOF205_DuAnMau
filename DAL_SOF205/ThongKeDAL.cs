using DTO_SOF205;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Data;
using UTIL_SOF205;

namespace DAL_SOF205
{
    public class ThongKeDAL
    {
        public List<TKDoanhThuTheoLoaiSP> DoanhThuTheoLoaiSP(String maLoaiSP, DateTime tuNgay, DateTime denNgay)
        {
            String sql = "TKDoanhThuTheoLoaiSP";
            List<Object> thamSo = new List<Object>();
            thamSo.Add(maLoaiSP);
            thamSo.Add(DateUtil.ToString(tuNgay, "yyyy-MM-dd"));
            thamSo.Add(DateUtil.ToString(denNgay, "yyyy-MM-dd"));
            
            List<TKDoanhThuTheoLoaiSP> list = new List<TKDoanhThuTheoLoaiSP>();
            try
            {
                SqlDataReader reader = DBUtil.Query(sql, thamSo, System.Data.CommandType.StoredProcedure);
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
    }
}
