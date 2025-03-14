using UTIL_SOF205;

namespace GUI_SOF205
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
            Init();
            CheckRole();
        }

        private void Init()
        {
            Welcome formWelcome = new Welcome();
            formWelcome.ShowDialog();
            Login formLogin = new Login();
            formLogin.ShowDialog();
        }

        private void CheckRole()
        {
            if (!AuthUtil.IsLogin())
            {
                Login formLogin = new Login();
                formLogin.ShowDialog();
            }
            else
            {
                lblTaiKhoan.Text = AuthUtil.user.HoTen;
                if (!AuthUtil.IsManager()) 
                {
                    MenuQLLoaiSanPham.Enabled = false;
                    MenuQLSanPham.Enabled = false;
                    MenuQLNhanVien.Enabled = false;
                    MenuQLTheLuuDong.Enabled = false;
                    MenuQLPhieuBanHang.Enabled = false;
                    MenuTKTheoLoaiSP.Enabled = false;
                    MenuTKTheoNhanVien.Enabled = false;
                }
                else
                {
                    MenuQLLoaiSanPham.Enabled = true;
                    MenuQLSanPham.Enabled = true;
                    MenuQLNhanVien.Enabled = true;
                    MenuQLTheLuuDong.Enabled = true;
                    MenuQLPhieuBanHang.Enabled = true;
                    MenuTKTheoLoaiSP.Enabled = true;
                    MenuTKTheoNhanVien.Enabled = true;
                }
            }
        }

        private void LoadForm(Form form)
        {
            form.TopLevel = false;
            pnlFormContainer.Controls.Add(form);
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            form.Show();
        }

        private void Logout()
        {
            AuthUtil.Logout();
            this.Hide();
            Login formLogin = new Login();
            formLogin.ShowDialog();
            this.Show();
            CheckRole();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Xác nhận đăng xuất tài khoản?",
                                          "Đăng xuất",
                                          MessageBoxButtons.YesNo,
                                          MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Logout();
            }
        }

        private void MenuDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Xác nhận đăng xuất tài khoản?",
                                          "Đăng xuất",
                                          MessageBoxButtons.YesNo,
                                          MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Logout();
            }
        }
    }
}
