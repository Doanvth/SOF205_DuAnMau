using DTO_SOF205;
using UTIL_SOF205;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Text;

namespace DAL_SOF205
{
    public class SanPhamDLL : SystemDAL<SanPham, String>
   {
        public override void insert(SanPham entity)
        {
            String sql = "INSERT INTO SanPham (MaSanPham, TenSanPham, DonGia, MaLoai, HinhAnh, TrangThai) VALUES (@0, @1, @2, @3, @4, @5)";
            List<Object> thamSo = new List<Object>();
            thamSo.Add(entity.MaSanPham);
            thamSo.Add(entity.TenSanPham);
            thamSo.Add(entity.DonGia);
            thamSo.Add(entity.MaLoai);
            thamSo.Add(entity.HinhAnh);
            thamSo.Add(entity.TrangThai);
            DBUtil.Update(sql, thamSo);
        }

        public override void update(SanPham entity)
        {
            String sql = "UPDATE SanPham SET TenSanPham=@0, DonGia=@1, MaLoai=@2, HinhAnh=@3, TrangThai=@4 WHERE MaSanPham=@5";
            List<Object> thamSo = new List<Object>();
            thamSo.Add(entity.TenSanPham);
            thamSo.Add(entity.DonGia);
            thamSo.Add(entity.MaLoai);
            thamSo.Add(entity.HinhAnh);
            thamSo.Add(entity.TrangThai);
            thamSo.Add(entity.MaSanPham);
            DBUtil.Update(sql, thamSo);
        }

        public override void delete(string id)
        {
            String sql = "DELETE FROM SanPham WHERE MaSanPham=@0";
            List<Object> thamSo = new List<Object>();
            thamSo.Add(id);
            DBUtil.Update(sql, thamSo);
        }

        public override List<SanPham> selectAll()
        {
            String sql = "SELECT * FROM SanPham";
            return selectBySql(sql, new List<Object>());
        }

        public override SanPham selectById(string id)
        {
            String sql = "SELECT * FROM SanPham WHERE MaSanPham=@0";
            List<Object> thamSo = new List<Object>();
            thamSo.Add(id);
            List<SanPham> list = selectBySql(sql, thamSo);
            return list.Count > 0 ? list[0] : null;
        }

        public override List<SanPham> selectBySql(string sql, List<Object> args, CommandType cmdType = CommandType.Text)
        {
            List<SanPham> list = new List<SanPham>();
            try
            {
                SqlDataReader reader = DBUtil.Query(sql, new List<Object>());
                while (reader.Read())
                {
                    SanPham entity = new SanPham();
                    entity.MaSanPham = reader.GetString("MaSanPham");
                    entity.TenSanPham = reader.GetString("TenSanPham");
                    entity.DonGia = reader.GetDecimal("DonGia");
                    entity.MaLoai = reader.GetString("MaLoai");
                    entity.HinhAnh = reader.GetString("HinhAnh");
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
