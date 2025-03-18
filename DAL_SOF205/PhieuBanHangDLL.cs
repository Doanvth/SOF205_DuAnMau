using DTO_SOF205;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Text;
using UTIL_SOF205;

namespace DAL_SOF205
{
    public class PhieuBanHangDLL : SystemDLL<PhieuBanHang, String>
    {
        public override void insert(PhieuBanHang entity)
        {
            String sql = "INSERT INTO PhieuBanHang (MaPhieu, MaThe, MaNhanVien, TrangThai) VALUE (@1, @2, @3, @4)";
            List<Object> thamSo = new List<Object>();
            thamSo.Add(entity.MaPhieu);
            thamSo.Add(entity.MaThe);
            thamSo.Add(entity.MaNhanVien);
            thamSo.Add(entity.TrangThai);
            DBUtil.Update(sql, thamSo);
        }

        public override void update(PhieuBanHang entity)
        {
            String sql = "UPDATE PhieuBanHang SET MaThe=@1, MaNhanVien=@2, TrangThai=@3 WHERE MaPhieu=@4";
            List<Object> thamSo = new List<Object>();
            thamSo.Add(entity.MaThe);
            thamSo.Add(entity.MaNhanVien);
            thamSo.Add(entity.TrangThai);
            thamSo.Add(entity.MaPhieu);
            DBUtil.Update(sql, thamSo);
        }

        public override void delete(string id)
        {
            String sql = "DELETE FROM PhieuBanHang WHERE MaPhieu=@1";
            List<Object> thamSo = new List<Object>();
            thamSo.Add(id);
            DBUtil.Update(sql, thamSo);
        }

        public override List<PhieuBanHang> selectAll()
        {
            String sql = "SELECT * FROM PhieuBanHang";
            return selectBySql(sql, new List<Object>());
        }

        public override PhieuBanHang selectById(string id)
        {
            String sql = "SELECT * FROM PhieuBanHang WHERE MaPhieu=@1";
            List<Object> thamSo = new List<Object>();
            thamSo.Add(id);
            List<PhieuBanHang> list = selectBySql(sql, thamSo);
            return list.Count > 0 ? list[0] : null;
        }

        public override List<PhieuBanHang> selectBySql(string sql, List<Object> args, CommandType cmdType = CommandType.Text)
        {
            List<PhieuBanHang> list = new List<PhieuBanHang>();
            try
            {
                SqlDataReader reader = DBUtil.Query(sql, new List<Object>());
                while (reader.Read())
                {
                    PhieuBanHang entity = new PhieuBanHang();
                    entity.MaPhieu = reader.GetString("MaPhieu");
                    entity.MaThe = reader.GetString("MaThe");
                    entity.MaNhanVien = reader.GetString("MaNhanVien");
                    entity.NgayTao = reader.GetDateTime("NgayTao");
                    entity.TrangThai = reader.GetBoolean("TrangThai");
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
