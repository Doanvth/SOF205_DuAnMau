using DAL_SOF205;
using DTO_SOF205;
using UTIL_SOF205;

namespace GUI_SOF205
{
    public partial class Login : Form
    {
        NhanVienDAL nvDAL = new NhanVienDAL();

        public Login()
        {
            InitializeComponent();
        }

        private void chkShowPass_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = chkShowPass.Checked ? '\0' : '*';
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String username = txtUsername.Text;
            String password = txtPassword.Text;
            NhanVien nhanVien = nvDAL.selectById(username);
            if (nhanVien == null)
            {
                MessageBox.Show(this, "Tài khoản không tồn tại");
            }
            else if (!nhanVien.MatKhau.Equals(password))
            {
                MessageBox.Show(this, "Mật khẩu chưa đúng");
            }
            else
            {
                AuthUtil.user = nhanVien;
                this.Dispose();
            }
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Xác nhận thoát chương trình?",
                                          "Thoát",
                                          MessageBoxButtons.YesNo,
                                          MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
