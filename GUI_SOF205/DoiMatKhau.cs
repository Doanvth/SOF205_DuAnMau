using DAL_SOF205;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using UTIL_SOF205;
namespace GUI_SOF205
{
    public partial class DoiMatKhau : Form
    {
        NhanVienDAL nvDAL = new NhanVienDAL();

        public DoiMatKhau()
        {
            InitializeComponent();
        }

        private void DoiMatKhau_Load(object sender, EventArgs e)
        {
            if (AuthUtil.IsLogin())
            {
                txtMaNhanVien.Text = AuthUtil.user.MaNhanVien;
                txtHoTen.Text = AuthUtil.user.HoTen;
            }
        }

        private void chkMatKhauCu_CheckedChanged(object sender, EventArgs e)
        {
            txtMatKhauCu.PasswordChar = chkMatKhauCu.Checked ? '\0' : '*';
        }

        private void chkMatKhauMoi_CheckedChanged(object sender, EventArgs e)
        {
            txtMatKhauMoi.PasswordChar = chkMatKhauMoi.Checked ? '\0' : '*';
        }

        private void chkXacNhanMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            txtXacNhanMatKhau.PasswordChar = chkXacNhanMatKhau.Checked ? '\0' : '*';
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            if(!AuthUtil.user.MatKhau.Equals(txtMatKhauCu.Text))
            {
                MessageBox.Show(this, "Mật khẩu cũ chưa đúng");
            } else
            {
                if(!txtMatKhauMoi.Text.Equals(txtXacNhanMatKhau.Text))
                {
                    MessageBox.Show(this, "Xác nhận mật khẩu mới chưa trùng khớp");
                } else
                {
                    AuthUtil.user.MatKhau = txtMatKhauMoi.Text;
                    nvDAL.update(AuthUtil.user);
                    MessageBox.Show(this, "Đổi mật khẩu thành công");
                }
            }
        }
    }
}
