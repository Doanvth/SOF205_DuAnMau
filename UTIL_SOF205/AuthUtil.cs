using DTO_SOF205;

namespace UTIL_SOF205
{
    public class AuthUtil
    {
        public static NhanVien? user = null;

        /// <summary>
        /// Đăng xuất người dùng hiện tại.
        /// </summary>
        public static void Logout()
        {
            user = null;
        }

        /// <summary>
        /// Kiểm tra trạng thái đăng nhập.
        /// </summary>
        public static Boolean IsLogin()
        {
            return user != null;
        }

        /// <summary>
        /// Kiểm tra quyền quản lý của tài khoản.
        /// </summary>
        public static Boolean IsManager()
        {
            return user != null && user.QuanLy;
        }
    }
}
