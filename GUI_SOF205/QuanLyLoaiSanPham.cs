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
    public partial class QuanLyLoaiSanPham : Form
    {
        public QuanLyLoaiSanPham()
        {
            InitializeComponent();
        }
        private void ClearForm()
        {
            txtMaLoai.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            txtMaLoai.Clear();
            txtTenLoai.Clear();
            txtGhiChu.Clear();
        }
        private void btnMoi_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                // 1️ Lấy dữ liệu từ form
                string maLoai = txtMaLoai.Text.Trim();
                string tenLoai = txtTenLoai.Text.Trim();
                string ghiChu = txtGhiChu.Text.Trim();

                // 2️ Kiểm tra dữ liệu nhập vào
                if (string.IsNullOrEmpty(maLoai) || string.IsNullOrEmpty(tenLoai) || string.IsNullOrEmpty(ghiChu))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 3️ Tạo đối tượng loại sản phẩm
                LoaiSanPham loaiSP = new LoaiSanPham
                {
                    MaLoai = maLoai,
                    TenLoai = tenLoai,
                    GhiChu = ghiChu,
                };

                // 4️ Gọi DAL để thêm nhân viên vào database
                LoaiSanPhamDAL loaiSanPhamDAL = new LoaiSanPhamDAL();
                loaiSanPhamDAL.insert(loaiSP);
                MessageBox.Show("Thêm loại sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);


                // 5️ Làm mới form sau khi thêm thành công
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void QuanLyLoaiSanPham_Load(object sender, EventArgs e)
        {
            try
            {
                LoaiSanPhamDAL loaiSanPhamDAL = new LoaiSanPhamDAL();
                List<LoaiSanPham> dsLoai = loaiSanPhamDAL.selectAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách loại sản phẩm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl.SelectedTab == tabDanhSach)
            {
                LoadDanhSachLoaiSanPham();
            }
        }

        private void LoadDanhSachLoaiSanPham()
        {
            LoaiSanPhamDAL loaiSanPhamDAL = new LoaiSanPhamDAL();
            List<LoaiSanPham> danhSach = loaiSanPhamDAL.selectAll();

            // Khởi tạo đối tượng ImageUtil
            ImageUtil imageUtil = new ImageUtil();

            dgvLoaiSanPham.DataSource = null;

            var danhSachLoaiSP = danhSach.Select(lsp => new
            {
                lsp.MaLoai,
                lsp.TenLoai,
                lsp.GhiChu
            }).ToList();

            // Xóa dữ liệu cũ và thiết lập DataSource
            dgvLoaiSanPham.DataSource = danhSachLoaiSP;


            // Tự động điều chỉnh hàng theo nội dung
            dgvLoaiSanPham.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void dgvLoaiSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra nếu click vào header thì không làm gì
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvLoaiSanPham.Rows[e.RowIndex];

            txtMaLoai.Text = row.Cells["MaLoai"].Value.ToString();
            txtTenLoai.Text = row.Cells["TenLoai"].Value.ToString();
            txtGhiChu.Text = row.Cells["GhiChu"].Value.ToString();

            // Chuyển sang tab "CẬP NHẬT"
            tabControl.SelectedTab = tabCapNhat;
            // Bật nút "Sửa" & "Xóa", tắt "Thêm"
            btnThem.Enabled = false;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            // Tắt chỉnh sửa mã sản phẩm
            txtMaLoai.Enabled = false;
        }
    }
}
