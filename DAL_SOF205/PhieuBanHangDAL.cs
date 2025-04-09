using DTO_SOF205;
using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Tokens;
using System.Data;
using System.Text;
using System.Windows.Forms;
using UTIL_SOF205;

namespace DAL_SOF205
{
    public class PhieuBanHangDAL : SystemDAL<PhieuBanHang, string>
    {
        public string generateAutoMaPhieu()
        {
            string prefix = "PBH"; // Tiền tố của mã phiếu bán hàng
            string sql = "SELECT TOP 1 MaPhieu FROM PhieuBanHang ORDER BY MaPhieu DESC"; // Lấy mã phiếu mới nhất

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
                        return $"{prefix}{nextNumber:D3}"; // Định dạng 3 chữ số (001, 002, ...)
                    }
                }

                return $"{prefix}001"; // Nếu chưa có mã nào, bắt đầu từ PBH0001
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi tạo mã phiếu tự động: " + ex.Message);
            }
        }

        public bool exists(string maPhieu)
        {
            string sql = "SELECT COUNT(*) FROM PhieuBanHang WHERE MaPhieu = @1";
            List<Object> thamSo = new List<Object> { maPhieu };

            try
            {
                object result = DBUtil.ScalarQuery(sql, thamSo);
                return Convert.ToInt32(result) > 0; // Nếu count > 0, mã phiếu đã tồn tại
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi kiểm tra mã phiếu: " + ex.Message);
            }
        }


        public override void insert(PhieuBanHang entity)
        {
            entity.TrangThai = false;

            String sql = "INSERT INTO PhieuBanHang (MaPhieu, MaThe, MaNhanVien, NgayTao, TrangThai) VALUES (@1, @2, @3, @4, @5)";
            List<Object> thamSo = new List<Object>
            {
                entity.MaPhieu,
                entity.MaThe,
                entity.MaNhanVien,
                entity.NgayTao,
                entity.TrangThai
            };
            DBUtil.Update(sql, thamSo);
        }


        public override void update(PhieuBanHang entity)
        {
            // Kiểm tra nếu phiếu đã có chi tiết => Chỉ cho phép sửa Trạng thái & Mã Nhân viên
            if (hasChiTietPhieu(entity.MaPhieu)) // Gọi từ DAL, không phải từ PhieuBanHang
            {
                // Chỉ cập nhật MaNhanVien và TrangThai nếu có chi tiết phiếu
                string sql = "UPDATE PhieuBanHang SET MaNhanVien=@1, TrangThai=@2 WHERE MaPhieu=@3";
                List<object> thamSo = new List<object> { entity.MaNhanVien, entity.TrangThai, entity.MaPhieu };

                DBUtil.Update(sql, thamSo);
            }
            else
            {
                // Nếu chưa có chi tiết phiếu, có thể cập nhật toàn bộ thông tin (trừ MaPhieu)
                string sql = "UPDATE PhieuBanHang SET MaThe=@1, MaNhanVien=@2, TrangThai=@3 WHERE MaPhieu=@4";
                List<object> thamSo = new List<object> { entity.MaThe, entity.MaNhanVien, entity.TrangThai, entity.MaPhieu };

                DBUtil.Update(sql, thamSo);
            }
        }


        public override void delete(string id)
        {
            // Kiểm tra xem PBH có chi tiết phiếu không
            string checkSql = "SELECT COUNT(*) FROM ChiTietPhieu WHERE MaPhieu = @1";
            List<Object> checkParams = new List<Object> { id };
            int count = Convert.ToInt32(DBUtil.ScalarQuery(checkSql, checkParams));

            if (count > 0)
            {
                throw new Exception("Không thể xóa phiếu bán hàng vì vẫn còn chi tiết phiếu. Hãy xóa hết chi tiết phiếu trước.");
            }

            // Nếu không có chi tiết phiếu, cho phép xóa
            string sql = "DELETE FROM PhieuBanHang WHERE MaPhieu=@1";
            List<Object> thamSo = new List<Object> { id };
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
            List<Object> thamSo = new List<Object>
            {
                id
            };
            List<PhieuBanHang> list = selectBySql(sql, thamSo);
            return list.Count > 0 ? list[0] : null;
        }

        public override List<PhieuBanHang> selectBySql(string sql, List<Object> args, CommandType cmdType = CommandType.Text)
        {
            List<PhieuBanHang> list = new List<PhieuBanHang>();
            try
            {
                SqlDataReader reader = DBUtil.Query(sql, args);
                while (reader.Read())
                {
                    PhieuBanHang entity = new PhieuBanHang
                    {
                        MaPhieu = reader.GetString("MaPhieu"),
                        MaThe = reader.GetString("MaThe"),
                        MaNhanVien = reader.GetString("MaNhanVien"),
                        NgayTao = reader.GetDateTime("NgayTao"),
                        TrangThai = reader.GetBoolean("TrangThai")
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

        // Hàm lấy danh sách phiếu bán hàng theo ngày tạo
        public List<PhieuBanHang> selectByDateRange(DateTime fromDate, DateTime toDate)
        {
            String sql = "SELECT * FROM PhieuBanHang WHERE NgayTao BETWEEN @1 AND @2";
            List<Object> thamSo = new List<Object>
            {
                fromDate,
                toDate
            };
            return selectBySql(sql, thamSo);
        }
       
        
        // Lấy danh sách thẻ thành viên từ database
        public List<TheLuuDong> getAllThe()
        {
            String sql = "SELECT * FROM TheLuuDong";  // Đảm bảo tên bảng đúng với DB
            List<TheLuuDong> danhSach = new List<TheLuuDong>();

            try
            {
                SqlDataReader reader = DBUtil.Query(sql, new List<Object>());
                while (reader.Read())
                {
                    TheLuuDong the = new TheLuuDong
                    {
                        MaThe = reader["MaThe"].ToString(),
                        ChuSoHuu = reader["ChuSoHuu"].ToString(),

                    };
                    danhSach.Add(the);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy danh sách thẻ thành viên: " + ex.Message);
            }

            return danhSach;
        }

        // Lấy danh sách nhân viên từ database
        public List<NhanVien> getAllNhanVien()
        {
            String sql = "SELECT * FROM NhanVien";  // Đảm bảo tên bảng đúng với DB
            List<NhanVien> danhSach = new List<NhanVien>();

            try
            {
                SqlDataReader reader = DBUtil.Query(sql, new List<Object>());
                while (reader.Read())
                {
                    NhanVien nv = new NhanVien
                    {
                        MaNhanVien = reader["MaNhanVien"].ToString(),
                        HoTen = reader["HoTen"].ToString(),

                    };
                    danhSach.Add(nv);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy danh sách nhân viên: " + ex.Message);
            }

            return danhSach;
        }

        // Lấy danh sách sản phẩm từ database
        public List<SanPham> getAllSanPham()
        {
            string sql = "SELECT MaSanPham, TenSanPham FROM SanPham";  
            // Truy vấn lấy danh sách sản phẩm
            List<SanPham> danhSachSanPham = new List<SanPham>();

            try
            {
                SqlDataReader reader = DBUtil.Query(sql, new List<Object>());
                while (reader.Read())
                {
                    SanPham sp = new SanPham
                    {
                        MaSanPham = reader["MaSanPham"].ToString(),
                        TenSanPham = reader["TenSanPham"].ToString()
                    };
                    danhSachSanPham.Add(sp);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy danh sách sản phẩm: " + ex.Message);
            }

            return danhSachSanPham;
        }

        public bool hasChiTietPhieu(string maPhieu)
        {
            string sql = "SELECT COUNT(*) FROM ChiTietPhieu WHERE MaPhieu = @1";
            List<object> thamSo = new List<object> { maPhieu };

            try
            {
                object result = DBUtil.ScalarQuery(sql, thamSo);
                return Convert.ToInt32(result) > 0; // Nếu count > 0, đã có chi tiết phiếu
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi kiểm tra chi tiết phiếu: " + ex.Message);
            }
        }
        public bool GetTrangThaiPhieu(string maPhieu)
        {
            string query = "SELECT TrangThai FROM PhieuBanHang WHERE MaPhieu = @1";
            var result = DBUtil.executeScalar(query, new List<object> { maPhieu });

            return result != null && Convert.ToBoolean(result);
        }

        public bool CheckChiTietSanPham(string maPhieu)
        {
            if (string.IsNullOrEmpty(maPhieu))
            {
                MessageBox.Show("Mã phiếu rỗng, vui lòng chọn phiếu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            string query = "SELECT COUNT(*) FROM ChiTietPhieu WHERE MaPhieu = @1"; // Kiểm tra ChiTietPhieu thay vì ChiTietSanPham

            try
            {
                var result = DBUtil.executeScalar(query, new List<object> { maPhieu });

                if (result == null || result == DBNull.Value)
                {
                    MessageBox.Show("Dữ liệu trống hoặc lỗi kết nối database!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                int count = 0;
                if (int.TryParse(result.ToString(), out count))
                {
                    if (count > 0)
                    {
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy chi tiết phiếu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("Lỗi khi chuyển đổi dữ liệu số!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi truy vấn database: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }


        public bool UpdateTrangThai(string maPhieu, bool trangThai)
        {
            if (trangThai && !CheckChiTietSanPham(maPhieu))
            {
                MessageBox.Show("Không thể thanh toán vì chưa có chi tiết sản phẩm.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            string query = "UPDATE PhieuBanHang SET TrangThai = @1 WHERE MaPhieu = @2";
            DBUtil.Update(query, new List<object> { trangThai, maPhieu });
            return true;
        }

    }
}
