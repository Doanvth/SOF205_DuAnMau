using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DTO_SOF205;
using DAL_SOF205;
using UTIL_SOF205;

namespace GUI_SOF205
{
    public partial class QuanLyPhieuBanHang : Form
    {
        private PhieuBanHangDAL phieuBanHangDAL = new PhieuBanHangDAL();
        private ChiTietPhieuDAL chiTietPhieuDAL = new ChiTietPhieuDAL();
        private SanPhamDLL sanPhamDAL = new SanPhamDLL(); // Thêm DAL sản phẩm
        private NhanVienDAL nhanVienDAL = new NhanVienDAL();

        //Load danh sách phiếu bán hàng
        private void LoadPhieuBanHang()
        {
            dgvPhieuBanHang.DataSource = phieuBanHangDAL.selectAll();
        }

        public QuanLyPhieuBanHang()
        {
            InitializeComponent();
            LoadForm();
        }

        //Hàm load lại form
        private void LoadForm()
        {
            LoadPhieuBanHang();  // Load danh sách phiếu bán hàng
            LoadComboboxData();  // Load dữ liệu combobox
            ClearPhieuBanHang();  // Xóa dữ liệu nhập phiếu
            ClearChiTietPhieu();  // Xóa dữ liệu nhập chi tiết phiếu
        }

        //Load dữ liệu lên ComboBox
        private void LoadComboboxData()
        {
            //Lấy danh sách từ database
            List<NhanVien> danhSachNhanVien = nhanVienDAL.selectAll();

            //Gán vào ComboBox
            cboMaNhanVien.DataSource = danhSachNhanVien;
            cboMaNhanVien.DisplayMember = "TenNhanVien";  // Hiển thị tên
            cboMaNhanVien.ValueMember = "MaNhanVien";    // Giá trị ẩn

            //Load danh sách thẻ thành viên
            cboMaThe.DataSource = phieuBanHangDAL.getAllThe();
            cboMaThe.DisplayMember = "ChuSoHuu";  // Hiển thị tên chủ sở hữu
            cboMaThe.ValueMember = "MaThe";       // Lưu giá trị mã thẻ

            //Load danh sách nhân viên
            cboMaNhanVien.DataSource = phieuBanHangDAL.getAllNhanVien();
            cboMaNhanVien.DisplayMember = "HoTen";        // Hiển thị họ tên nhân viên
            cboMaNhanVien.ValueMember = "MaNhanVien";     // Lưu giá trị mã nhân viên

            //Load danh sách sản phẩm
            cboMaSanPham.DataSource = phieuBanHangDAL.getAllSanPham();
            cboMaSanPham.DisplayMember = "TenSanPham";    // Hiển thị tên sản phẩm
            cboMaSanPham.ValueMember = "MaSanPham";       // Lưu giá trị mã sản phẩm
        }

        // Chọn phiếu trong DataGridView
        private void dgvPhieuBanHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvPhieuBanHang.Rows[e.RowIndex];
                txtMaPhieu.Text = row.Cells["MaPhieu"].Value.ToString();
                cboMaThe.SelectedValue = row.Cells["MaThe"].Value.ToString();
                cboMaNhanVien.SelectedValue = row.Cells["MaNhanVien"].Value.ToString();
                dtpNgayTao.Value = Convert.ToDateTime(row.Cells["NgayTao"].Value);

                LoadChiTietPhieu(txtMaPhieu.Text);
            }
        }

        private void ClearPhieuBanHang()
        {
            txtMaPhieu.Clear();
            cboMaThe.SelectedIndex = -1;
            cboMaNhanVien.SelectedIndex = -1;
            dtpNgayTao.Value = DateTime.Now;
            rbChoXacNhan.Checked = true; // Mặc định là "Chưa xử lý"
        }

        private void ClearChiTietPhieu()
        {
            cboMaSanPham.SelectedIndex = -1; // Bỏ chọn sản phẩm
            txtDonGia.Text = "";
            txtSoLuong.Text = "";
            txtThanhTien.Text = "";
        }


        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LoadForm();
            ClearChiTietPhieu();
            ClearPhieuBanHang();
        }

        //Load danh sách chi tiết phiếu
        private void LoadChiTietPhieu(string maPhieu)
        {
            List<ChiTietPhieu> chiTietList = 
                chiTietPhieuDAL.selectBySql("SELECT * FROM ChiTietPhieu WHERE MaPhieu=@0", 
                new List<object> { maPhieu });
            dgvChiTietPhieu.DataSource = chiTietList;
        }

        // Chuyển dữ liệu sang tab tổng quan
        private void btnChuyenTab_Click(object sender, EventArgs e)
        {
            dgvChiTietPhieu.DataSource = phieuBanHangDAL.selectAll();
        }

        private void dgvChiTietPhieu_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvChiTietPhieu.Rows[e.RowIndex];

                // Lấy dữ liệu từ dòng được chọn
                cboMaSanPham.SelectedValue = row.Cells["MaSanPham"].Value.ToString();
                txtSoLuong.Text = row.Cells["SoLuong"].Value.ToString();
                txtDonGia.Text = row.Cells["DonGia"].Value.ToString();

                // Tính lại Thành Tiền khi chọn chi tiết phiếu
                TinhThanhTien();
            }
        }


        // Khi click vào DataGridView Chi Tiết Phiếu, đổ dữ liệu lên TextBox và ComboBox
        private void dgvChiTietPhieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvChiTietPhieu.Rows[e.RowIndex];

                cboMaSanPham.SelectedValue = row.Cells["MaSanPham"].Value.ToString();
                txtSoLuong.Text = row.Cells["SoLuong"].Value.ToString();
                txtDonGia.Text = row.Cells["DonGia"].Value.ToString();
            }
        }

        // Thêm phiếu bán hàng
        private void btnThemPhieu_Click(object sender, EventArgs e)
        {
            string maPhieu = phieuBanHangDAL.generateAutoMaPhieu();
            PhieuBanHang phieu = new PhieuBanHang
            {
                MaPhieu = maPhieu,
                MaThe = cboMaThe.SelectedValue.ToString(),  // Lấy giá trị từ ComboBox
                MaNhanVien = cboMaNhanVien.SelectedValue.ToString(),
                NgayTao = DateTime.Now,
                TrangThai = true
            };

            phieuBanHangDAL.insert(phieu);
            MessageBox.Show("Thêm phiếu bán hàng thành công!");
            LoadPhieuBanHang();
            LoadForm();
        }

        private void btnSuaPhieu_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy thông tin từ giao diện
                string maPhieu = txtMaPhieu.Text;
                string maNhanVien = cboMaNhanVien.SelectedValue.ToString();
                string maThe = cboMaThe.SelectedValue.ToString();
                bool trangThai = rbChoXacNhan.Checked;

                // Kiểm tra xem phiếu có tồn tại không
                if (!phieuBanHangDAL.exists(maPhieu))
                {
                    MessageBox.Show("Phiếu bán hàng không tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ClearPhieuBanHang();
                    return;
                }

                // Kiểm tra PBH có Chi Tiết Phiếu không
                bool coCTP = phieuBanHangDAL.hasChiTietPhieu(maPhieu);

                if (coCTP)
                {
                    MessageBox.Show(
                        "Phiếu bán hàng đã có chi tiết phiếu. Bạn chỉ có thể sửa Trạng thái và Mã Nhân Viên.",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    ClearPhieuBanHang();
                }

                // Tạo đối tượng PBH
                PhieuBanHang pbh = new PhieuBanHang
                {
                    MaPhieu = maPhieu,
                    MaNhanVien = maNhanVien,
                    TrangThai = trangThai
                };

                if (!coCTP)
                {
                    // Nếu không có CTP, cho phép sửa MaThe
                    pbh.MaThe = maThe;
                }

                // Gọi hàm update từ DAL
                phieuBanHangDAL.update(pbh);

                // **Chỉ hiển thị thông báo thành công nếu được cập nhật**
                MessageBox.Show("Cập nhật phiếu bán hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Load lại danh sách phiếu
                LoadPhieuBanHang();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa phiếu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoaPhieuBH_Click(object sender, EventArgs e)
        {
            try
            {
                string maPhieu = txtMaPhieu.Text;

                // Kiểm tra xem phiếu có tồn tại không
                if (!phieuBanHangDAL.exists(maPhieu))
                {
                    MessageBox.Show("Phiếu bán hàng không tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Hiển thị cảnh báo trước khi xóa
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa phiếu bán hàng này?", "Xác nhận",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    // Thực hiện xóa
                    phieuBanHangDAL.delete(maPhieu);

                    // Thông báo thành công
                    MessageBox.Show("Xóa phiếu bán hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Làm sạch form
                    ClearPhieuBanHang();

                    // Load lại danh sách phiếu
                    LoadPhieuBanHang();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa phiếu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       
        //Thêm chi tiết phiếu
        private void btnThemChiTietPhieu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaPhieu.Text))
            {
                MessageBox.Show("Vui lòng chọn phiếu bán hàng trước!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra trạng thái phiếu
            PhieuBanHang phieu = phieuBanHangDAL.selectById(txtMaPhieu.Text);
            if (phieu != null && phieu.TrangThai == true) // Giả sử `TrangThai == true` nghĩa là đã thanh toán
            {
                MessageBox.Show("Phiếu bán hàng đã thanh toán, không thể thêm chi tiết!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Nếu phiếu chưa thanh toán, tiếp tục thêm chi tiết
            ChiTietPhieu chiTiet = new ChiTietPhieu
            {
                MaPhieu = txtMaPhieu.Text,
                MaSanPham = cboMaSanPham.SelectedValue.ToString(),
                SoLuong = int.Parse(txtSoLuong.Text),
                DonGia = decimal.Parse(txtDonGia.Text)
            };

            chiTietPhieuDAL.insert(chiTiet);
            MessageBox.Show("Thêm chi tiết phiếu thành công!");
            LoadChiTietPhieu(txtMaPhieu.Text);
            ClearChiTietPhieu();
            ClearPhieuBanHang();
        }

        
        private void TinhThanhTien()
        {
            try
            {
                decimal donGia = string.IsNullOrEmpty(txtDonGia.Text) ? 0 : Convert.ToDecimal(txtDonGia.Text);
                int soLuong = string.IsNullOrEmpty(txtSoLuong.Text) ? 0 : Convert.ToInt32(txtSoLuong.Text);

                decimal thanhTien = donGia * soLuong;
                txtThanhTien.Text = thanhTien.ToString("N0"); // Hiển thị số có dấu phân cách
            }
            catch
            {
                txtThanhTien.Text = "0"; // Nếu có lỗi, đặt giá trị về 0
            }
        }


        //Khi chọn sản phẩm, tự động lấy Đơn Giá từ database
        private void cboMaSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMaSanPham.SelectedValue != null)
            {
                string maSanPham = cboMaSanPham.SelectedValue.ToString();
                decimal donGia = sanPhamDAL.getDonGiaByMa(maSanPham);
                txtDonGia.Text = donGia.ToString("N0");

                TinhThanhTien(); // Cập nhật thành tiền ngay khi chọn sản phẩm
            }
        }

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {
            TinhThanhTien();
        }

        private void btnSuaChiTietPhieu_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra nhập liệu
                if (string.IsNullOrEmpty(txtMaPhieu.Text))
                {
                    MessageBox.Show("Vui lòng chọn phiếu bán hàng trước!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ClearChiTietPhieu();
                    ClearPhieuBanHang();
                    return;
                }

                if (dgvChiTietPhieu.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn chi tiết phiếu để sửa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ClearChiTietPhieu();
                    ClearPhieuBanHang();
                    return;
                }

                // Lấy thông tin từ giao diện
                string maPhieu = txtMaPhieu.Text;
                string maSanPham = cboMaSanPham.SelectedValue.ToString();
                int soLuong = int.Parse(txtSoLuong.Text);
                decimal donGia = decimal.Parse(txtDonGia.Text);

                // Lấy Id từ dòng đang chọn
                int id = Convert.ToInt32(dgvChiTietPhieu.SelectedRows[0].Cells["Id"].Value);

                // Kiểm tra nếu phiếu đã xác nhận, không cho sửa
                bool trangThaiPhieu = phieuBanHangDAL.GetTrangThaiPhieu(maPhieu);
                if (trangThaiPhieu)
                {
                    MessageBox.Show("Phiếu bán hàng đã được xác nhận. Không thể chỉnh sửa chi tiết phiếu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ClearChiTietPhieu();
                    ClearPhieuBanHang();
                    return;
                }

                // Kiểm tra chi tiết phiếu có tồn tại không
                if (!chiTietPhieuDAL.exists(id))
                {
                    MessageBox.Show("Chi tiết phiếu không tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ClearChiTietPhieu();
                    ClearPhieuBanHang();
                    return;
                }

                // Cập nhật chi tiết phiếu
                ChiTietPhieu chiTiet = new ChiTietPhieu
                {
                    Id = id,
                    MaPhieu = maPhieu, // Không sửa được
                    MaSanPham = maSanPham,
                    SoLuong = soLuong,
                    DonGia = donGia,
                };

                chiTietPhieuDAL.update(chiTiet); // Gọi hàm update (không trả về giá trị)

                // Nếu không có exception, coi như cập nhật thành công
                MessageBox.Show("Sửa chi tiết phiếu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadChiTietPhieu(maPhieu);
                ClearChiTietPhieu();
                ClearPhieuBanHang();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa chi tiết phiếu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoaCTP_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvChiTietPhieu.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn chi tiết phiếu để xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string maPhieu = txtMaPhieu.Text;

                // Kiểm tra trạng thái phiếu bán hàng
                bool trangThai = phieuBanHangDAL.GetTrangThaiPhieu(maPhieu);
                if (trangThai == true)
                {
                    MessageBox.Show("Phiếu bán hàng đã hoàn thành, không thể xóa chi tiết phiếu!", "Lỗi", 
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Lấy ID của CTP từ dòng đang chọn
                int id = Convert.ToInt32(dgvChiTietPhieu.SelectedRows[0].Cells["Id"].Value);

                // Xóa chi tiết phiếu bằng ID
                chiTietPhieuDAL.delete(id);  //Gọi delete(int id) đúng với DAL

                // Hiển thị thông báo sau khi xóa
                MessageBox.Show("Xóa chi tiết phiếu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadChiTietPhieu(maPhieu);
                ClearChiTietPhieu();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa chi tiết phiếu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaPhieu.Text))
            {
                MessageBox.Show("Vui lòng chọn phiếu bán hàng trước khi thanh toán!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maPhieu = txtMaPhieu.Text.Trim();

            PhieuBanHangDAL dal = new PhieuBanHangDAL();

            bool trangThaiHienTai = dal.GetTrangThaiPhieu(maPhieu);
            if (trangThaiHienTai)
            {
                MessageBox.Show("Phiếu bán hàng đã được thanh toán trước đó!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!dal.CheckChiTietSanPham(maPhieu))
            {
                MessageBox.Show("Không thể thanh toán vì chưa có chi tiết sản phẩm!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dal.UpdateTrangThai(maPhieu, true))
            {
                MessageBox.Show("Thanh toán thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadPhieuBanHang();
                LoadChiTietPhieu(maPhieu);

                if (rbHoanThanh != null && rbChoXacNhan != null)
                {
                    rbHoanThanh.Checked = true;
                    rbChoXacNhan.Checked = false;
                }
            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra khi cập nhật trạng thái phiếu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
