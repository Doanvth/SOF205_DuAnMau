using System.Data;
using Microsoft.Data.SqlClient;
using System.Reflection;

namespace UTIL_SOF205
{
    public class DBUtil
    {
        private static string connString = "server=localhost; database=PolyCafe; uid=sa;pwd=123456";

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
                cmd.Transaction.Rollback();
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
                        PropertyInfo propertyInfo = result.GetType().GetProperty(columnName);

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
    }
}