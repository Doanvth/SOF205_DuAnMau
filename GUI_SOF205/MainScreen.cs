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

        private void ShowFormInPanel(Form form)
        {
            // Xóa form cũ trong panel
            pnlFormContainer.Controls.Clear();

            // Thiết lập form con
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            // Thêm form vào panel
            pnlFormContainer.Controls.Add(form);
            form.Show();
        }

        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new QuanLyNhanVien());
        }

        private void quảnLýLoạiSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new QuanLyLoaiSanPham());
        }

        private void quảnLýSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new QuanLySanPham());
        }

        private void quảnLýPhiếuBánHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new PhieuBanHang());
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
                lblAccount.Text = AuthUtil.user.HoTen;
                if (!AuthUtil.IsManager()) 
                {
                    itmQLLoaiSanPham.Enabled = false;
                    itmQLSanPham.Enabled = false;
                    itmQLNhanVien.Enabled = false;
                    itmQLTheLuuDong.Enabled = false;
                    itmQLPhieuBanHang.Enabled = false;
                    itmTKTheoLoaiSP.Enabled = false;
                    itmTKTheoNV.Enabled = false;
                }
                else
                {
                    itmQLLoaiSanPham.Enabled = true;
                    itmQLSanPham.Enabled = true;
                    itmQLNhanVien.Enabled = true;
                    itmQLTheLuuDong.Enabled = true;
                    itmQLPhieuBanHang.Enabled = true;
                    itmTKTheoLoaiSP.Enabled = true;
                    itmTKTheoNV.Enabled = true;
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

