using DTO_SOF205;
using UTIL_SOF205;
using Microsoft.Data.SqlClient;
using System.Data;

namespace DAL_SOF205
{
    public class ChiTietPhieuDAL : SystemDAL<ChiTietPhieu, Int32>
    {
        public override void insert(ChiTietPhieu entity)
        {
            String sql = "INSERT INTO ChiTietPhieu (MaPhieu, MaSanPham, SoLuong, DonGia) VALUE (@1, @2, @3, @4)";
            List<Object> thamSo = new List<Object>();
            thamSo.Add(entity.MaPhieu);
            thamSo.Add(entity.MaSanPham);
            thamSo.Add(entity.SoLuong);
            thamSo.Add(entity.DonGia);
            DBUtil.Update(sql, thamSo);
        }

        public override void update(ChiTietPhieu entity)
        {
            String sql = "UPDATE ChiTietPhieu SET SoLuong=@1, DonGia=@2 WHERE Id=@3";
            List<Object> thamSo = new List<Object>();
            thamSo.Add(entity.SoLuong);
            thamSo.Add(entity.DonGia);
            thamSo.Add(entity.Id);
            DBUtil.Update(sql, thamSo);
        }

        public override void delete(Int32 id)
        {
            String sql = "DELETE FROM ChiTietPhieu WHERE Id=@1";
            List<Object> thamSo = new List<Object>();
            thamSo.Add(id);
            DBUtil.Update(sql, thamSo);
        }

        public override List<ChiTietPhieu> selectAll()
        {
            String sql = "SELECT * FROM ChiTietPhieu";
            return selectBySql(sql, new List<Object>());
        }

        public override ChiTietPhieu selectById(Int32 id)
        {
            String sql = "SELECT * FROM ChiTietPhieu WHERE Id=@1";
            List<Object> thamSo = new List<Object>();
            thamSo.Add(id);
            List<ChiTietPhieu> list = selectBySql(sql, thamSo);
            return list.Count > 0 ? list[0] : null;
        }

        public override List<ChiTietPhieu> selectBySql(string sql, List<Object> args, CommandType cmdType = CommandType.Text)
        {
            List<ChiTietPhieu> list = new List<ChiTietPhieu>();
            try
            {
                SqlDataReader reader = DBUtil.Query(sql, new List<Object>());
                while (reader.Read())
                {
                    ChiTietPhieu entity = new ChiTietPhieu();
                    entity.Id = reader.GetInt32("Id");
                    entity.MaPhieu = reader.GetString("MaPhieu");
                    entity.MaSanPham = reader.GetString("MaSanPham");
                    entity.SoLuong = reader.GetInt32("SoLuong");
                    entity.DonGia = reader.GetInt32("DonGia");
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
