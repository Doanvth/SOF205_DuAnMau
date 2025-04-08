using DTO_SOF205;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Text;
using UTIL_SOF205;

namespace DAL_SOF205
{
    public class ChiTietPhieuDAL : SystemDAL<ChiTietPhieu, int>
    {
        public bool exists(int id)
        {
            string sql = "SELECT COUNT(*) FROM ChiTietPhieu WHERE Id = @1";
            List<object> thamSo = new List<object> { id };

            int count = Convert.ToInt32(DBUtil.ScalarQuery(sql, thamSo));
            return count > 0;
        }


        public override void insert(ChiTietPhieu entity)
        {
            String sql = "INSERT INTO ChiTietPhieu (MaPhieu, MaSanPham, SoLuong, DonGia) VALUES (@1, @2, @3, @4)";
            List<Object> thamSo = new List<Object>
            {
                entity.MaPhieu,
                entity.MaSanPham,
                entity.SoLuong,
                entity.DonGia
            };
            DBUtil.Update(sql, thamSo);
        }

        //public override void update(ChiTietPhieu entity)
        //{
        //    String sql = "UPDATE ChiTietPhieu SET MaSanPham=@1, SoLuong=@2, DonGia=@3 WHERE Id=@4";
        //    List<Object> thamSo = new List<Object>
        //    {
        //        entity.MaSanPham,
        //        entity.SoLuong,
        //        entity.DonGia,
        //        entity.Id
        //    };
        //    DBUtil.Update(sql, thamSo);
        //}

        public override void update(ChiTietPhieu entity)
        {
            String sql = "UPDATE ChiTietPhieu SET MaSanPham=@1, SoLuong=@2, DonGia=@3 WHERE Id=@4";
            List<Object> thamSo = new List<Object>
            {
                entity.MaSanPham,
                entity.SoLuong,
                entity.DonGia,
                entity.Id
            };
            DBUtil.Update(sql, thamSo); // Không cần return, chỉ cập nhật
        }

        public override void delete(int id)
        {
            String sql = "DELETE FROM ChiTietPhieu WHERE Id=@1";
            List<Object> thamSo = new List<Object>
            {
                id
            };
            DBUtil.Update(sql, thamSo);
        }

        public override List<ChiTietPhieu> selectAll()
        {
            String sql = "SELECT * FROM ChiTietPhieu";
            return selectBySql(sql, new List<Object>());
        }

        public override ChiTietPhieu selectById(int id)
        {
            String sql = "SELECT * FROM ChiTietPhieu WHERE Id=@1";
            List<Object> thamSo = new List<Object>
            {
                id
            };
            List<ChiTietPhieu> list = selectBySql(sql, thamSo);
            return list.Count > 0 ? list[0] : null;
        }

        public override List<ChiTietPhieu> selectBySql(string sql, List<Object> args, CommandType cmdType = CommandType.Text)
        {
            List<ChiTietPhieu> list = new List<ChiTietPhieu>();
            try
            {
                SqlDataReader reader = DBUtil.Query(sql, args);
                while (reader.Read())
                {
                    ChiTietPhieu entity = new ChiTietPhieu
                    {
                        Id = reader.GetInt32("Id"),
                        MaPhieu = reader.GetString("MaPhieu"),
                        MaSanPham = reader.GetString("MaSanPham"),
                        SoLuong = reader.GetInt32("SoLuong"),
                        DonGia = reader.GetDecimal("DonGia")
                    };
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
