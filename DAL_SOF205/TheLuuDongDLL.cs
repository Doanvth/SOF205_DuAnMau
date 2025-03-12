using DTO_SOF205;
using UTIL_SOF205;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Text;

namespace DAL_SOF205
{
    internal class TheLuuDongDLL : SystemDLL<TheLuuDong, String>
    {
        public override void insert(TheLuuDong entity)
        {
            String sql = "INSERT INTO TheLuuDong (MaThe, ChuSoHuu, TrangThai) VALUE (@1, @2, @3)";
            List<Object> thamSo = new List<Object>();
            thamSo.Add(entity.MaThe);
            thamSo.Add(entity.ChuSoHuu);
            thamSo.Add(entity.TrangThai);
            DBUtil.Update(sql, thamSo);
        }

        public override void update(TheLuuDong entity)
        {
            String sql = "UPDATE TheLuuDong SET ChuSoHuu=@1, TrangThai=@2 WHERE MaThe=@3";
            List<Object> thamSo = new List<Object>();
            thamSo.Add(entity.ChuSoHuu);
            thamSo.Add(entity.TrangThai);
            thamSo.Add(entity.MaThe);
            DBUtil.Update(sql, thamSo);
        }

        public override void delete(string id)
        {
            String sql = "DELETE FROM TheLuuDong WHERE MaThe=@1";
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
            String sql = "SELECT * FROM TheLuuDong WHERE MaThe=@1";
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
