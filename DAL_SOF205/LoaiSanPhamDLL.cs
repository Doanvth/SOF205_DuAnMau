using DTO_SOF205;
using UTIL_SOF205;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Text;

namespace DAL_SOF205
{
    public class LoaiSanPhamDLL : SystemDLL<LoaiSanPham, String>
    {
        public override void insert(LoaiSanPham entity)
        {
            String sql = "INSERT INTO LoaiSanPham (MaLoai, TenLoai, GhiChu) VALUES (@0, @1, @2)";
            List<Object> thamSo = new List<Object>();
            thamSo.Add(entity.MaLoai);
            thamSo.Add(entity.TenLoai);
            thamSo.Add(entity.GhiChu);
            DBUtil.Update(sql, thamSo);
        }

        public override void update(LoaiSanPham entity)
        {
            String sql = "UPDATE LoaiSanPham SET TenLoai=@0, GhiChu=@1 WHERE MaLoai=@2";
            List<Object> thamSo = new List<Object>();
            thamSo.Add(entity.TenLoai);
            thamSo.Add(entity.GhiChu);
            thamSo.Add(entity.MaLoai);
            DBUtil.Update(sql, thamSo);
        }

        public override void delete(string id)
        {
            String sql = "DELETE FROM LoaiSanPham WHERE MaLoai=@0";
            List<Object> thamSo = new List<Object>();
            thamSo.Add(id);
            DBUtil.Update(sql, thamSo);
        }

        public override List<LoaiSanPham> selectAll()
        {
            String sql = "SELECT * FROM LoaiSanPham";
            return selectBySql(sql, new List<Object>());
        }

        public override LoaiSanPham selectById(string id)
        {
            String sql = "SELECT * FROM LoaiSanPham WHERE MaLoai=@1";
            List<Object> thamSo = new List<Object>();
            thamSo.Add(id);
            List<LoaiSanPham> list = selectBySql(sql, thamSo);
            return list.Count > 0 ? list[0] : null;
        }

        public override List<LoaiSanPham> selectBySql(string sql, List<Object> args, CommandType cmdType = CommandType.Text)
        {
            List<LoaiSanPham> list = new List<LoaiSanPham>();
            try
            {
                SqlDataReader reader = DBUtil.Query(sql, new List<Object>());
                while (reader.Read())
                {
                    LoaiSanPham entity = new LoaiSanPham();
                    entity.MaLoai = reader.GetString("MaLoai");
                    entity.TenLoai = reader.GetString("TenLoai");
                    entity.GhiChu = reader.GetString("GhiChu");
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
