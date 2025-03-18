using DAL_SOF205;
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
using UTIL_SOF205;

namespace GUI_SOF205
{
    public partial class QuanLySanPham : Form
    {
        public QuanLySanPham()
        {
            InitializeComponent();
        }
        private void ClearForm()
        {
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;

        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy dữ liệu từ form
                string maSP = txtMaSanPham.Text.Trim();
                string tenSP = txtTenSanPham.Text.Trim();
                string donGiaText = txtDonGia.Text.Trim();
                string maLoai = cboLoaiSanPham.SelectedValue?.ToString(); // Lấy MaLoai từ combobox
                bool trangThai = rbHoatDong.Checked; // Nếu chọn "Hoạt động" thì true, ngược lại false

                // Kiểm tra dữ liệu nhập vào
                if (string.IsNullOrEmpty(maSP) || string.IsNullOrEmpty(tenSP) || string.IsNullOrEmpty(donGiaText) || string.IsNullOrEmpty(maLoai))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Chuyển đổi đơn giá
                if (!decimal.TryParse(donGiaText, out decimal donGia))
                {
                    MessageBox.Show("Đơn giá không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Xử lý ảnh sản phẩm

                string savedImageName = "";
                if (pbHinhAnh.Tag != null) // Kiểm tra xem người dùng đã chọn ảnh chưa
                {
                    string selectedImagePath = pbHinhAnh.Tag.ToString();

                    // Mở hộp thoại chọn ảnh
                    OpenFileDialog openFileDialog = new OpenFileDialog
                    {
                        FileName = selectedImagePath
                    };

                    // Kiểm tra và lưu ảnh bằng ImageUtil
                    try
                    {
                        ImageUtil imageUtil = new ImageUtil();
                         savedImageName = imageUtil.save(openFileDialog);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi xử lý ảnh: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                // Tạo đối tượng sản phẩm
                SanPham sp = new SanPham
                {
                    MaSanPham = maSP,
                    TenSanPham = tenSP,
                    DonGia = donGia,
                    MaLoai = maLoai,
                    TrangThai = trangThai, // Mặc định là trạng thái đã chọn
                    HinhAnh = savedImageName // Lưu đường dẫn ảnh
                };

                // Gọi DAL để thêm sản phẩm vào database
                SanPhamDLL sanPhamDLL = new SanPhamDLL();
                sanPhamDLL.insert(sp);
                MessageBox.Show("Thêm sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Làm mới form sau khi thêm thành công
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void QuanLySanPham_Load(object sender, EventArgs e)
        {
            try
            {
                LoaiSanPhamDLL loaiSanPhamDLL = new LoaiSanPhamDLL();
                List<LoaiSanPham> dsLoai = loaiSanPhamDLL.selectAll(); // Lấy danh sách loại sản phẩm
                cboLoaiSanPham.DataSource = dsLoai;
                cboLoaiSanPham.DisplayMember = "TenLoai"; // Hiển thị tên loại
                cboLoaiSanPham.ValueMember = "MaLoai"; // Giá trị thực là MaLoai
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách loại sản phẩm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra nếu click vào header thì không làm gì
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvSanPham.Rows[e.RowIndex];

            // Đổ dữ liệu vào các ô nhập liệu trên form
            txtMaSanPham.Text = row.Cells["MaSanPham"].Value.ToString();
            txtTenSanPham.Text = row.Cells["TenSanPham"].Value.ToString();
            txtDonGia.Text = row.Cells["DonGia"].Value.ToString();
            cboLoaiSanPham.Text = row.Cells["MaLoai"].Value.ToString();

            // Kiểm tra trạng thái checkbox
            bool trangThai = Convert.ToBoolean(row.Cells["TrangThai"].Value);
            rbHoatDong.Checked = trangThai;

            // Xử lý hiển thị hình ảnh
            // Đặt SizeMode để hình ảnh tự động fit vào ô
            pbHinhAnh.SizeMode = PictureBoxSizeMode.StretchImage; // hoặc PictureBoxSizeMode.Zoom
            // Lấy đường dẫn ảnh từ cột HinhAnh (vì DataGridView đang lưu dạng Image)
            if (row.Cells["HinhAnh"].Value != null && row.Cells["HinhAnh"].Value is Image)
            {
                pbHinhAnh.Image = (Image)row.Cells["HinhAnh"].Value; // Set trực tiếp hình ảnh
            }
            else
            {
                pbHinhAnh.Image = null;
            }
            // Chuyển sang tab "CẬP NHẬT"
            tabControl.SelectedTab = tabCapNhat;
            // Bật nút "Sửa" & "Xóa", tắt "Thêm"
            btnThem.Enabled = false;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            // Tắt chỉnh sửa mã sản phẩm
            txtMaSanPham.Enabled = false;
        }

        private void LoadDanhSachSanPham()
        {
            SanPhamDLL sanPhamDLL = new SanPhamDLL();
            List<SanPham> danhSach = sanPhamDLL.selectAll();

            // Khởi tạo đối tượng ImageUtil
            ImageUtil imageUtil = new ImageUtil();

            dgvSanPham.DataSource = null;

            // Tạo danh sách sản phẩm với hình ảnh
            var danhSachHinhAnh = danhSach.Select(sp => new
            {
                sp.MaSanPham,
                sp.TenSanPham,
                sp.DonGia,
                sp.MaLoai,
                sp.TrangThai,
                HinhAnh = imageUtil.load(sp.HinhAnh) // Sử dụng hàm load ảnh từ ImageUtil
            }).ToList();

            // Xóa dữ liệu cũ và thiết lập DataSource
            dgvSanPham.DataSource = danhSachHinhAnh;

            // Thiết lập cột hình ảnh
            DataGridViewImageColumn imageColumn = (DataGridViewImageColumn)dgvSanPham.Columns["HinhAnh"];
            if (imageColumn != null)
            {
                imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom; // Ảnh vừa ô, không bị méo
            }

            // Tự động điều chỉnh hàng theo nội dung
            dgvSanPham.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl.SelectedTab == tabDanhSach)
            {
                LoadDanhSachSanPham();
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                // 1️ Lấy dữ liệu từ form
                string maSP = txtMaSanPham.Text.Trim();
                string tenSP = txtTenSanPham.Text.Trim();
                string donGiaText = txtDonGia.Text.Trim();
                string maLoai = cboLoaiSanPham.SelectedValue?.ToString(); // Lấy mã loại từ combobox
                bool trangThai = rbHoatDong.Checked; // Nếu chọn "Hoạt động" thì true, ngược lại false
                // 2️ Kiểm tra dữ liệu nhập vào
                if (string.IsNullOrEmpty(maSP) || string.IsNullOrEmpty(tenSP) || string.IsNullOrEmpty(donGiaText) || string.IsNullOrEmpty(maLoai))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                // Chuyển đổi đơn giá
                if (!decimal.TryParse(donGiaText, out decimal donGia))
                {
                    MessageBox.Show("Đơn giá không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                // 3️ Xử lý ảnh sản phẩm (nếu có cập nhật)
                string savedImageName = "";
                if (pbHinhAnh.Tag != null) // Kiểm tra xem người dùng đã chọn ảnh chưa
                {
                    string selectedImagePath = pbHinhAnh.Tag.ToString();

                    // Mở hộp thoại chọn ảnh
                    OpenFileDialog openFileDialog = new OpenFileDialog
                    {
                        FileName = selectedImagePath
                    };

                    // Kiểm tra và lưu ảnh bằng ImageUtil
                    try
                    {
                        ImageUtil imageUtil = new ImageUtil();
                        savedImageName = imageUtil.save(openFileDialog);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi xử lý ảnh: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                // 4️ Tạo đối tượng sản phẩm
                SanPham sp = new SanPham
                {
                    MaSanPham = maSP,
                    TenSanPham = tenSP,
                    DonGia = donGia,
                    MaLoai = maLoai,
                    TrangThai = trangThai,
                    HinhAnh = savedImageName // Lưu đường dẫn ảnh mới (nếu có)
                };
                // 5️ Gọi DAL để cập nhật sản phẩm trong database
                SanPhamDLL sanPhamDLL = new SanPhamDLL();
                sanPhamDLL.update(sp);
                MessageBox.Show("Cập nhật sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // 1️ Lấy mã sản phẩm từ textbox
            string maSP = txtMaSanPham.Text.Trim();
            // 2️ Kiểm tra nếu không có mã sản phẩm
            if (string.IsNullOrEmpty(maSP))
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // 3️ Hỏi xác nhận trước khi xóa
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa sản phẩm này?", "Xác nhận xóa",
                                                  MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    // 4️ Gọi phương thức xóa sản phẩm
                    SanPhamDLL sanPhamDLL = new SanPhamDLL();
                    sanPhamDLL.delete(maSP);

                    // 5️ Làm mới form sau khi xóa
                    ClearForm();

                    // Chuyển về tab "DANH SÁCH"
                    tabControl.SelectedTab = tabDanhSach;

                    MessageBox.Show("Xóa sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa sản phẩm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
