using DTO_SOF205;
using UTIL_SOF205;
using System.Data;
using GUI_SOF205;
using System.Collections;
using System.Reflection.PortableExecutable;
using Microsoft.Data.SqlClient;

namespace DAL_SOF205
{
    public class NhanVienDLL : SystemDLL<NhanVien, String>
    {
        public override void insert(NhanVien entity)
        {
            String sql = "INSERT INTO NhanVien (MaNhanVien, HoTen, MatKhau, QuanLy) VALUE (@1, @2, @3, @4)";
            List<Object> thamSo = new List<Object>();
            thamSo.Add(entity.MaNhanVien);
            thamSo.Add(entity.HoTen);
            thamSo.Add(entity.MaKhau);
            thamSo.Add(entity.QuanLy);
            DBUtil.Update(sql, thamSo);
        }

        public override void update(NhanVien entity)
        {
            String sql = "UPDATE NhanVien SET HoTen=@1, MatKhau=@2, QuanLy=@3 WHERE MaNhanVien=@4";
            List<Object> thamSo = new List<Object>();
            thamSo.Add(entity.HoTen);
            thamSo.Add(entity.MaKhau);
            thamSo.Add(entity.QuanLy);
            thamSo.Add(entity.MaNhanVien);
            DBUtil.Update(sql, thamSo);
        }

        public override void delete(string id)
        {
            String sql = "DELETE FROM NhanVien WHERE MaNV=@1";
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
            String sql = "SELECT * FROM NhanVien WHERE MaNhanVien=@1";
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
                SqlDataReader reader = DBUtil.Query(sql, new List<Object>());
                while (reader.Read())
                {
                    NhanVien entity = new NhanVien();
                    entity.MaNhanVien = reader.GetString("MaNhanVien");
                    entity.HoTen = reader.GetString("HoTen");
                    entity.MaKhau = reader.GetString("MatKhau");
                    entity.QuanLy = reader.GetBoolean("QuanLy");
                    list.Add(entity);
                }
            } catch (Exception) {
                throw;
            }
            return list;
        }
    }
}
