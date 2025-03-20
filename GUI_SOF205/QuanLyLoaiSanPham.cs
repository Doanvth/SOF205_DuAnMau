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

                // Gọi DAL để thêm nhân viên vào database
                LoaiSanPhamDAL loaiSanPhamDLL = new LoaiSanPhamDAL();
                loaiSanPhamDLL.insert(loaiSP);
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
    }
}
