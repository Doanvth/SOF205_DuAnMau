using DTO_SOF205;
using UTIL_SOF205;
using System.Data;
using Microsoft.Data.SqlClient;

namespace DAL_SOF205
{
    public class NhanVienDAL : SystemDAL<NhanVien, String>
    {
        public override void insert(NhanVien entity)
        {
            String sql = "INSERT INTO NhanVien (MaNhanVien, HoTen, Email, MatKhau, VaiTro ,TrangThai) VALUES (@0, @1, @2, @3, @4, @5)";
            List<Object> thamSo = new List<Object>();
            thamSo.Add(entity.MaNhanVien);
            thamSo.Add(entity.HoTen);
            thamSo.Add(entity.Email);
            thamSo.Add(entity.MatKhau);
            thamSo.Add(entity.VaiTro);
            thamSo.Add(entity.TrangThai);
            DBUtil.Update(sql, thamSo);
        }

        public override void update(NhanVien entity)
        {
            String sql = "UPDATE NhanVien SET HoTen=@0, MatKhau=@1,  Email=@2, VaiTro=@3, TrangThai=@4 WHERE MaNhanVien=@5";
            List<Object> thamSo = new List<Object>();
            thamSo.Add(entity.HoTen);      
            thamSo.Add(entity.MatKhau);    
            thamSo.Add(entity.Email);      
            thamSo.Add(entity.VaiTro);     
            thamSo.Add(entity.TrangThai);  
            thamSo.Add(entity.MaNhanVien); 
            DBUtil.Update(sql, thamSo);
        }

        public override void delete(string id)
        {
            String sql = "DELETE FROM NhanVien WHERE MaNhanVien=@0";
            List<Object> thamSo = new List<Object>();
            thamSo.Add(id);
            DBUtil.Update(sql, thamSo);
        }

        public override List<NhanVien> selectAll()
        {
            String sql = "SELECT * FROM NhanVien";
            return selectBySql(sql, new List<Object>());
        }

        public override NhanVien selectById(string id)
        {
            String sql = "SELECT * FROM NhanVien WHERE MaNhanVien=@0";
            List<Object> thamSo = new List<Object>();
            thamSo.Add(id);
            List<NhanVien> list = selectBySql(sql, thamSo);
            return list.Count > 0 ? list[0] : null;
        }

        public override List<NhanVien> selectBySql(string sql, List<Object> args, CommandType cmdType = CommandType.Text)
        {
            List<NhanVien> list = new List<NhanVien>();
            try
            {
                SqlDataReader reader = DBUtil.Query(sql, args);
                while (reader.Read())
                {
                    NhanVien entity = new NhanVien();
                    entity.MaNhanVien = reader.GetString("MaNhanVien");
                    entity.HoTen = reader.GetString("HoTen");
                    entity.Email = reader.GetString("Email");
                    entity.MatKhau = reader.GetString("MatKhau");
                    entity.VaiTro = reader.GetBoolean("VaiTro");
                    entity.TrangThai = reader.GetBoolean("TrangThai");
                    list.Add(entity);
                }
            } catch (Exception) {
                throw;
            }
            return list;
        }
    }
}
