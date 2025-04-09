using System.Data;
using Microsoft.Data.SqlClient;
using System.Reflection;

namespace UTIL_SOF205
{
    public class DBUtil
    {
        private static string connString = "server=localhost;database=PolyCafe;uid=sa;pwd=123456;trustServerCertificate=true;";

        /// <summary>
        /// Xây dựng SqlCommand
        /// </summary>
        /// <param name="sql">Câu lệnh sql, có thể đính tham số hoặc không</param>
        /// <param name="args">Danh sách tham số đính vào command</param>
        /// <param name="cmdType">Kiểu lệnh là câu lệnh sql hay gọi StoredProcedure</param>
        /// <returns>SqlCommand đã xây dựng</returns>
        public static SqlCommand GetCommand(string sql, List<Object> args, CommandType cmdType)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd= new SqlCommand(sql, conn);
            cmd.CommandType = cmdType;
            for (int i = 0;i < args.Count; i++)
            {
                cmd.Parameters.AddWithValue($"@{i}", args[i]);
            }
            return cmd;
        }

        /// <summary>
        /// Thực hiện lệnh SQL thao tác Insert-Delete-Update
        /// </summary>
        /// <param name="sql">Câu lệnh sql, có thể đính tham số hoặc không</param>
        /// <param name="args">Danh sách tham số đính vào command</param>
        /// <param name="cmdType">Kiểu lệnh là câu lệnh sql hay gọi StoredProcedure</param>
        public static void Update(string sql, List<Object> args, CommandType cmdType = CommandType.Text)
        {
            SqlCommand cmd = GetCommand(sql, args, cmdType);
            cmd.Connection.Open();
            cmd.Transaction = cmd.Connection.BeginTransaction();
            try {
                cmd.ExecuteNonQuery();
                cmd.Transaction.Commit();
            } catch (Exception)
            {
                throw;
            }
            
        }

        /// <summary>
        /// Thực hiện lệnh SQL truy vấn (select) dữ liệu
        /// </summary>
        /// <param name="sql">Câu truy vấn, có thể đính tham số hoặc không</param>
        /// <param name="args">Danh sách tham số đính vào command</param>
        /// <param name="cmdType">Kiểu truy vấn là câu lệnh sql hay gọi StoredProcedure</param>
        /// <returns>SqlDataReader kết quả truy vấn</returns>
        public static SqlDataReader Query(string sql, List<Object> args, CommandType cmdType = CommandType.Text)
        {
            try
            {
                SqlCommand cmd = GetCommand(sql, args, cmdType);
                cmd.Connection.Open();
                return cmd.ExecuteReader();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static object ScalarQuery(string sql, List<object> parameters)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    // Thêm tham số vào câu lệnh SQL
                    for (int i = 0; i < parameters.Count; i++)
                    {
                        cmd.Parameters.AddWithValue($"@{i + 1}", parameters[i] ?? DBNull.Value);
                    }

                    object result = cmd.ExecuteScalar(); // Thực hiện truy vấn và lấy giá trị đầu tiên
                    return result;
                }
            }
        }

        /// <summary>
        /// Thực hiện lệnh SQL truy vấn (select) dữ liệu
        /// </summary>
        /// <param name="sql">Câu lệnh sql, có thể đính tham số hoặc không</param>
        /// <param name="args">Danh sách tham số đính vào command</param>
        /// <param name="cmdType">Kiểu lệnh là câu lệnh sql hay gọi StoredProcedure</param>
        /// <returns>Object-đối tượng đầu tiên sau khi truy vấn</returns>
        public static Object Value(string sql, List<Object> args, CommandType cmdType = CommandType.Text)
        {
            try
            {
                SqlCommand cmd = GetCommand(sql, args, cmdType);
                cmd.Connection.Open();
                SqlDataReader reader =  cmd.ExecuteReader();
                Object result = new object();
                if (reader.HasRows)
                {
                    for(int i = 0; i < reader.FieldCount; i++)
                    {
                        string columnName = reader.GetName(i);
                        PropertyInfo? propertyInfo = result.GetType().GetProperty(columnName);

                        if (propertyInfo != null)
                        {
                            var value = reader.IsDBNull(i) ? null : reader[columnName];
                            propertyInfo.SetValue(result, value);
                        }
                    }
                }
                return result;
            } catch(Exception) {
                throw;
            }
        }

        public DataTable QueryDataTable()
        {
            string query = @"
            SELECT 
                pb.MaPhieu, 
                pb.MaThe, 
                pb.MaNhanVien, 
                pb.NgayTao, 
                pb.TrangThai, 
                ct.Id AS ChiTietId, 
                ct.MaSanPham, 
                ct.SoLuong, 
                ct.DonGia 
            FROM PhieuBanHang pb
            JOIN ChiTietPhieu ct ON pb.MaPhieu = ct.MaPhieu";

            DataTable dataTable = new DataTable();

            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dataTable);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi truy vấn dữ liệu: " + ex.Message);
                }
            }

            return dataTable;
        }

        public static DataTable QueryDataTable(string sql, List<object> parameters)
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        // Thêm tham số vào SQL nếu có
                        for (int i = 0; i < parameters.Count; i++)
                        {
                            cmd.Parameters.AddWithValue($"@{i + 1}", parameters[i] ?? DBNull.Value);
                        }

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        adapter.Fill(dataTable);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi truy vấn dữ liệu: " + ex.Message);
                }
            }

            return dataTable;
        }

        public static DataTable GetPhieuBanHang()
        {
            string query = @"
            SELECT 
                pb.MaPhieu, 
                pb.MaThe, 
                n.TenNhanVien AS NhanVien,  -- Lấy tên nhân viên thay vì mã
                pb.NgayTao, 
                pb.TrangThai, 
                ct.MaSanPham, 
                sp.TenSanPham AS SanPham,  -- Lấy tên sản phẩm thay vì mã
                ct.SoLuong, 
                ct.DonGia 
            FROM PhieuBanHang pb
            JOIN NhanVien n ON pb.MaNhanVien = n.MaNhanVien  -- Liên kết bảng Nhân Viên
            JOIN ChiTietPhieu ct ON pb.MaPhieu = ct.MaPhieu  -- Liên kết bảng Chi Tiết Phiếu
            JOIN SanPham sp ON ct.MaSanPham = sp.MaSanPham"; 

            DataTable dataTable = new DataTable();

            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dataTable);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi truy vấn dữ liệu: " + ex.Message);
                }
            }

            return dataTable;
        }

        /// <summary>
        /// Hàm thực thi lệnh SQL và trả về một giá trị đơn (executeScalar)
        /// </summary>
        public static object executeScalar(string sql, List<object> parameters)
        {
            object result = null;

            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        // Thêm tham số vào câu lệnh SQL
                        for (int i = 0; i < parameters.Count; i++)
                        {
                            cmd.Parameters.AddWithValue($"@{i + 1}", parameters[i]);
                        }

                        // Thực thi và lấy giá trị đơn
                        result = cmd.ExecuteScalar();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Lỗi executeScalar: " + ex.Message);
                }
            }

            return result; // Trả về kết quả (có thể là null)
        }
        // 🟢 Hàm thực thi lệnh INSERT, UPDATE, DELETE
        //public int ExecuteNonQuery(string query, List<object> parameters = null)
        //{
        //    using (SqlConnection conn = new SqlConnection(connString))
        //    {
        //        try
        //        {
        //            conn.Open();
        //            using (SqlCommand cmd = new SqlCommand(query, conn))
        //            {
        //                if (parameters != null)
        //                {
        //                    for (int i = 0; i < parameters.Count; i++)
        //                    {
        //                        cmd.Parameters.AddWithValue($"@{i + 1}", parameters[i]);
        //                    }
        //                }

        //                return cmd.ExecuteNonQuery(); // Trả về số dòng bị ảnh hưởng
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            Console.WriteLine("Lỗi khi thực thi câu lệnh: " + ex.Message);
        //            return -1; // Trả về -1 nếu có lỗi xảy ra
        //        }
        //    }
        //}
    }
}
