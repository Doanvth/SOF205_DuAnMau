
﻿using DAL_SOF205;
using DTO_SOF205;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_SOF205
{
    public partial class QuanLyNhanVien : Form
    {
        public QuanLyNhanVien()
        {
            InitializeComponent();
        }
        private void btnMoi_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                //  Lấy dữ liệu từ form
                string maNV = txtMaNhanVien.Text.Trim();
                string hoTen = txtHoTen.Text.Trim();
                string email = txtEmail.Text.Trim();
                string matKhau = txtMatKhau.Text.Trim();
                string xacNhanMK = txtXacNhanMatKhau.Text.Trim();
                bool vaiTro;
                if (rdoNhanVien.Checked)
                {
                    vaiTro = true;  // Nhân viên
                }
                else
                {
                    vaiTro = false; // Quản lý
                }

                //  Kiểm tra dữ liệu nhập vào
                if (string.IsNullOrEmpty(maNV) || string.IsNullOrEmpty(hoTen) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(matKhau))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (matKhau != xacNhanMK)
                {
                    MessageBox.Show("Mật khẩu xác nhận không khớp!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                // Tạo đối tượng nhân viên
                NhanVien nv = new NhanVien
                {
                    MaNhanVien = maNV,
                    HoTen = hoTen,
                    Email = email,
                    MatKhau = matKhau,
                    VaiTro = vaiTro,
                    TrangThai = true // Mặc định là active
                };

                // Gọi DAL để thêm nhân viên vào database
                NhanVienDAL nhanVienDLL = new NhanVienDAL();
                nhanVienDLL.insert(nv);
                MessageBox.Show("Thêm nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);


                // Làm mới form sau khi thêm thành công
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                // 1️⃣ Lấy dữ liệu từ form
                string maNV = txtMaNhanVien.Text.Trim();
                string hoTen = txtHoTen.Text.Trim();
                string email = txtEmail.Text.Trim();
                string matKhau = txtMatKhau.Text.Trim();
                string xacNhanMK = txtXacNhanMatKhau.Text.Trim();
                bool vaiTro;
                if (rdoNhanVien.Checked)
                {
                    vaiTro = false;  // Nhân viên
                }
                else
                {
                    vaiTro = true; // Quản lý
                }

                // 2️ Kiểm tra dữ liệu nhập vào
                if (string.IsNullOrEmpty(maNV) || string.IsNullOrEmpty(hoTen) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(matKhau))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (matKhau != xacNhanMK)
                {
                    MessageBox.Show("Mật khẩu xác nhận không khớp!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // 3️ Tạo đối tượng nhân viên
                NhanVien nv = new NhanVien
                {
                    MaNhanVien = maNV,
                    HoTen = hoTen,
                    Email = email,
                    MatKhau = matKhau,
                    VaiTro = vaiTro,
                    TrangThai = true // Giữ trạng thái mặc định là active
                };

                // 4️ Gọi DAL để cập nhật nhân viên trong database
                NhanVienDAL nhanVienDLL = new NhanVienDAL();
                nhanVienDLL.update(nv);
                MessageBox.Show("Cập nhật nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Lấy mã nhân viên từ textbox
            string maNhanVien = txtMaNhanVien.Text.Trim();

            // Kiểm tra nếu không có mã nhân viên
            if (string.IsNullOrEmpty(maNhanVien))
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Hỏi xác nhận trước khi xóa
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này?", "Xác nhận xóa",
                                                  MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    // Gọi phương thức xóa
                    NhanVienDAL nhanVienDLL = new NhanVienDAL();
                    nhanVienDLL.delete(maNhanVien);
                    ClearForm();
                    // Chuyển về tab "DANH SÁCH"
                    tabControl.SelectedTab = tabDanhSach;

                    MessageBox.Show("Xóa nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa nhân viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void ClearForm()
        {
            txtMaNhanVien.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            txtMaNhanVien.Clear();
            txtHoTen.Clear();
            txtMatKhau.Clear();
            txtXacNhanMatKhau.Clear();
            txtEmail.Clear();
            rdoNhanVien.Checked = true; // Mặc định chọn "Nhân viên"
        }
        private void LoadDanhSachNhanVien()
        {
            NhanVienDAL nhanVienDLL = new NhanVienDAL();
            List<NhanVien> danhSach = nhanVienDLL.selectAll();
            dgvNhanVien.DataSource = null; // Xóa dữ liệu cũ
            dgvNhanVien.DataSource = danhSach;
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl.SelectedTab == tabDanhSach)
            {
                LoadDanhSachNhanVien();
            }
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvNhanVien.Rows[e.RowIndex];
            // Đổ dữ liệu vào các ô nhập liệu trên form
            txtMaNhanVien.Text = row.Cells["MaNhanVien"].Value.ToString();
            txtHoTen.Text = row.Cells["HoTen"].Value.ToString();
            txtEmail.Text = row.Cells["Email"].Value.ToString();
            txtMatKhau.Text = row.Cells["MatKhau"].Value.ToString();
            txtXacNhanMatKhau.Text = row.Cells["MatKhau"].Value.ToString(); // Có thể thay đổi nếu cần

            //        Kiểm tra VaiTrò(nếu là 1 thì là Quản lý, nếu là 0 thì là Nhân viên)
            bool vaiTro = Convert.ToBoolean(row.Cells["VaiTro"].Value);
            if (vaiTro==false)
            {
                rdoNhanVien.Checked = true;
            }
            else
            {
                rdoQuanly.Checked = true;
            }
            // Chuyển sang tab "CẬP NHẬT"
            tabControl.SelectedTab = tabCapNhat;
            // Bật nút "Sửa"
            btnThem.Enabled = false;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            // Tắt chỉnh sửa mã nhân viên
            txtMaNhanVien.Enabled = false;
        }
    }
}
