using DTO_SOF205;
using UTIL_SOF205;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Text;

namespace DAL_SOF205
{
    public class TheLuuDongDAL : SystemDAL<TheLuuDong, String>
    {
        public string generateAutoMaThe()
        {
            string prefix = "THE"; // Tiền tố của mã thẻ
            string sql = "SELECT TOP 1 MaThe FROM TheLuuDong ORDER BY MaThe DESC"; // Lấy mã phiếu mới nhất

            try
            {
                object result = DBUtil.ScalarQuery(sql, new List<object>()); // Truy vấn lấy giá trị đầu tiên

                if (result != null && result.ToString().StartsWith(prefix))
                {
                    string lastMaPhieu = result.ToString();

                    // Tách phần số trong mã phiếu
                    string numberPart = new string(lastMaPhieu.Skip(3).ToArray()); // Bỏ "PBH", lấy phần số

                    if (int.TryParse(numberPart, out int nextNumber))
                    {
                        nextNumber++; // Tăng số
                        return $"{prefix}{nextNumber:D3}"; // Định dạng 4 chữ số (0001, 0002, ...)
                    }
                }

                return $"{prefix}001"; // Nếu chưa có mã nào, bắt đầu từ THE0001
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi tạo mã phiếu tự động: " + ex.Message);
            }
        }


        public override void insert(TheLuuDong entity)
        {
            string sql = "INSERT INTO TheLuuDong (MaThe, ChuSoHuu, TrangThai) VALUES (@0, @1, @2)";
            entity.TrangThai = false;

            List<Object> thamSo = new List<Object>
            {
                entity.MaThe,
                entity.ChuSoHuu,
                entity.TrangThai,
            };
            DBUtil.Update(sql, thamSo);
        }


        public override void update(TheLuuDong entity)
        {
            String sql = "UPDATE TheLuuDong SET ChuSoHuu=@0, TrangThai=@1 WHERE MaThe=@2";
            List<Object> thamSo = new List<Object>();
            thamSo.Add(entity.ChuSoHuu);
            thamSo.Add(entity.TrangThai);
            thamSo.Add(entity.MaThe);
            DBUtil.Update(sql, thamSo);
        }

        public override void delete(string id)
        {
            String sql = "DELETE FROM TheLuuDong WHERE MaThe=@0";
            List<Object> thamSo = new List<Object>();
            thamSo.Add(id);
            DBUtil.Update(sql, thamSo);
        }

        public override List<TheLuuDong> selectAll()
        {
            String sql = "SELECT * FROM TheLuuDong";
            return selectBySql(sql, new List<Object>());
        }

        public override TheLuuDong selectById(string id)
        {
            String sql = "SELECT * FROM TheLuuDong WHERE MaThe=@0";
            List<Object> thamSo = new List<Object>();
            thamSo.Add(id);
            List<TheLuuDong> list = selectBySql(sql, thamSo);
            return list.Count > 0 ? list[0] : null;
        }

        public override List<TheLuuDong> selectBySql(string sql, List<Object> args, CommandType cmdType = CommandType.Text)
        {
            List<TheLuuDong> list = new List<TheLuuDong>();
            try
            {
                SqlDataReader reader = DBUtil.Query(sql, new List<Object>());
                while (reader.Read())
                {
                    TheLuuDong entity = new TheLuuDong();
                    entity.MaThe = reader.GetString("MaThe");
                    entity.ChuSoHuu = reader.GetString("ChuSoHuu");
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
