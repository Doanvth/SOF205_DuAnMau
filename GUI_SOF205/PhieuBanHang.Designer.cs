namespace GUI_SOF205
{
    partial class PhieuBanHang
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabCapNhat;
        private System.Windows.Forms.TabPage tabDanhSach;
        private System.Windows.Forms.DataGridView dgvPhieuBanHang;
        private System.Windows.Forms.DataGridView dgvChiTietPhieu;

        // GroupBox
        private System.Windows.Forms.GroupBox grpThongTinPhieu;
        private System.Windows.Forms.GroupBox grpChiTietPhieu;

        // Thông tin Phiếu Bán Hàng
        private System.Windows.Forms.TextBox txtMaPhieu;
        private System.Windows.Forms.ComboBox cboMaThe;
        private System.Windows.Forms.ComboBox cboMaNhanVien;
        private System.Windows.Forms.DateTimePicker dtpNgayTao;
        private System.Windows.Forms.RadioButton rbHoanThanh;
        private System.Windows.Forms.RadioButton rbChoXacNhan;
        private System.Windows.Forms.Label lblMaPhieu, lblMaThe, lblMaNhanVien, lblNgayTao, lblTrangThai;

        // Chi tiết Phiếu Bán Hàng
        private System.Windows.Forms.ComboBox cboMaSanPham;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Label lblMaSanPham, lblSoLuong, lblDonGia;

        // Buttons
        private System.Windows.Forms.Button btnThemPhieu, btnSuaPhieu, btnXoaPhieu, btnMoiPhieu;
        private System.Windows.Forms.Button btnThemChiTiet, btnXoaChiTiet;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            tabControl = new TabControl();
            tabCapNhat = new TabPage();
            grpThongTinPhieu = new GroupBox();
            lblMaPhieu = new Label();
            txtMaPhieu = new TextBox();
            lblMaThe = new Label();
            cboMaThe = new ComboBox();
            lblMaNhanVien = new Label();
            cboMaNhanVien = new ComboBox();
            lblNgayTao = new Label();
            dtpNgayTao = new DateTimePicker();
            lblTrangThai = new Label();
            rbHoanThanh = new RadioButton();
            rbChoXacNhan = new RadioButton();
            grpChiTietPhieu = new GroupBox();
            lblMaSanPham = new Label();
            cboMaSanPham = new ComboBox();
            lblSoLuong = new Label();
            txtSoLuong = new TextBox();
            lblDonGia = new Label();
            txtDonGia = new TextBox();
            dgvChiTietPhieu = new DataGridView();
            btnThemPhieu = new Button();
            btnSuaPhieu = new Button();
            tabDanhSach = new TabPage();
            tabControl.SuspendLayout();
            tabCapNhat.SuspendLayout();
            grpThongTinPhieu.SuspendLayout();
            grpChiTietPhieu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvChiTietPhieu).BeginInit();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabCapNhat);
            tabControl.Controls.Add(tabDanhSach);
            tabControl.Dock = DockStyle.Fill;
            tabControl.Location = new Point(0, 0);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(1318, 694);
            tabControl.TabIndex = 0;
            // 
            // tabCapNhat
            // 
            tabCapNhat.Controls.Add(grpThongTinPhieu);
            tabCapNhat.Controls.Add(grpChiTietPhieu);
            tabCapNhat.Controls.Add(dgvChiTietPhieu);
            tabCapNhat.Controls.Add(btnThemPhieu);
            tabCapNhat.Controls.Add(btnSuaPhieu);
            tabCapNhat.Location = new Point(4, 34);
            tabCapNhat.Name = "tabCapNhat";
            tabCapNhat.Size = new Size(1310, 656);
            tabCapNhat.TabIndex = 0;
            tabCapNhat.Text = "CẬP NHẬT";
            // 
            // grpThongTinPhieu
            // 
            grpThongTinPhieu.Controls.Add(lblMaPhieu);
            grpThongTinPhieu.Controls.Add(txtMaPhieu);
            grpThongTinPhieu.Controls.Add(lblMaThe);
            grpThongTinPhieu.Controls.Add(cboMaThe);
            grpThongTinPhieu.Controls.Add(lblMaNhanVien);
            grpThongTinPhieu.Controls.Add(cboMaNhanVien);
            grpThongTinPhieu.Controls.Add(lblNgayTao);
            grpThongTinPhieu.Controls.Add(dtpNgayTao);
            grpThongTinPhieu.Controls.Add(lblTrangThai);
            grpThongTinPhieu.Controls.Add(rbHoanThanh);
            grpThongTinPhieu.Controls.Add(rbChoXacNhan);
            grpThongTinPhieu.Location = new Point(45, 24);
            grpThongTinPhieu.Name = "grpThongTinPhieu";
            grpThongTinPhieu.Size = new Size(753, 218);
            grpThongTinPhieu.TabIndex = 0;
            grpThongTinPhieu.TabStop = false;
            grpThongTinPhieu.Text = "Thông tin Phiếu";
            // 
            // lblMaPhieu
            // 
            lblMaPhieu.Location = new Point(22, 41);
            lblMaPhieu.Name = "lblMaPhieu";
            lblMaPhieu.Size = new Size(100, 23);
            lblMaPhieu.TabIndex = 0;
            lblMaPhieu.Text = "Mã Phiếu:";
            // 
            // txtMaPhieu
            // 
            txtMaPhieu.Location = new Point(159, 38);
            txtMaPhieu.Name = "txtMaPhieu";
            txtMaPhieu.Size = new Size(215, 31);
            txtMaPhieu.TabIndex = 1;
            // 
            // lblMaThe
            // 
            lblMaThe.Location = new Point(394, 41);
            lblMaThe.Name = "lblMaThe";
            lblMaThe.Size = new Size(78, 23);
            lblMaThe.TabIndex = 2;
            lblMaThe.Text = "Mã Thẻ:";
            // 
            // cboMaThe
            // 
            cboMaThe.Location = new Point(498, 38);
            cboMaThe.Name = "cboMaThe";
            cboMaThe.Size = new Size(215, 33);
            cboMaThe.TabIndex = 3;
            // 
            // lblMaNhanVien
            // 
            lblMaNhanVien.Location = new Point(22, 99);
            lblMaNhanVien.Name = "lblMaNhanVien";
            lblMaNhanVien.Size = new Size(131, 23);
            lblMaNhanVien.TabIndex = 4;
            lblMaNhanVien.Text = "Mã Nhân Viên:";
            // 
            // cboMaNhanVien
            // 
            cboMaNhanVien.Location = new Point(159, 89);
            cboMaNhanVien.Name = "cboMaNhanVien";
            cboMaNhanVien.Size = new Size(215, 33);
            cboMaNhanVien.TabIndex = 5;
            // 
            // lblNgayTao
            // 
            lblNgayTao.Location = new Point(394, 99);
            lblNgayTao.Name = "lblNgayTao";
            lblNgayTao.Size = new Size(100, 26);
            lblNgayTao.TabIndex = 6;
            lblNgayTao.Text = "Ngày Tạo:";
            // 
            // dtpNgayTao
            // 
            dtpNgayTao.Location = new Point(500, 94);
            dtpNgayTao.Name = "dtpNgayTao";
            dtpNgayTao.Size = new Size(215, 31);
            dtpNgayTao.TabIndex = 7;
            // 
            // lblTrangThai
            // 
            lblTrangThai.Location = new Point(22, 161);
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(100, 23);
            lblTrangThai.TabIndex = 8;
            lblTrangThai.Text = "Trạng Thái:";
            // 
            // rbHoanThanh
            // 
            rbHoanThanh.Location = new Point(159, 160);
            rbHoanThanh.Name = "rbHoanThanh";
            rbHoanThanh.Size = new Size(110, 24);
            rbHoanThanh.TabIndex = 9;
            rbHoanThanh.Text = "Hoàn tất";
            // 
            // rbChoXacNhan
            // 
            rbChoXacNhan.Location = new Point(305, 158);
            rbChoXacNhan.Name = "rbChoXacNhan";
            rbChoXacNhan.Size = new Size(145, 26);
            rbChoXacNhan.TabIndex = 10;
            rbChoXacNhan.Text = "Chờ xác nhận";
            // 
            // grpChiTietPhieu
            // 
            grpChiTietPhieu.Controls.Add(lblMaSanPham);
            grpChiTietPhieu.Controls.Add(cboMaSanPham);
            grpChiTietPhieu.Controls.Add(lblSoLuong);
            grpChiTietPhieu.Controls.Add(txtSoLuong);
            grpChiTietPhieu.Controls.Add(lblDonGia);
            grpChiTietPhieu.Controls.Add(txtDonGia);
            grpChiTietPhieu.Location = new Point(835, 24);
            grpChiTietPhieu.Name = "grpChiTietPhieu";
            grpChiTietPhieu.Size = new Size(427, 218);
            grpChiTietPhieu.TabIndex = 1;
            grpChiTietPhieu.TabStop = false;
            grpChiTietPhieu.Text = "Chi Tiết Phiếu";
            // 
            // lblMaSanPham
            // 
            lblMaSanPham.Location = new Point(22, 41);
            lblMaSanPham.Name = "lblMaSanPham";
            lblMaSanPham.Size = new Size(134, 23);
            lblMaSanPham.TabIndex = 0;
            lblMaSanPham.Text = "Mã Sản Phẩm:";
            // 
            // cboMaSanPham
            // 
            cboMaSanPham.Location = new Point(176, 38);
            cboMaSanPham.Name = "cboMaSanPham";
            cboMaSanPham.Size = new Size(215, 33);
            cboMaSanPham.TabIndex = 1;
            // 
            // lblSoLuong
            // 
            lblSoLuong.Location = new Point(22, 99);
            lblSoLuong.Name = "lblSoLuong";
            lblSoLuong.Size = new Size(100, 31);
            lblSoLuong.TabIndex = 2;
            lblSoLuong.Text = "Số Lượng:";
            // 
            // txtSoLuong
            // 
            txtSoLuong.Location = new Point(176, 96);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(215, 31);
            txtSoLuong.TabIndex = 3;
            // 
            // lblDonGia
            // 
            lblDonGia.Location = new Point(22, 161);
            lblDonGia.Name = "lblDonGia";
            lblDonGia.Size = new Size(100, 23);
            lblDonGia.TabIndex = 4;
            lblDonGia.Text = "Đơn Giá:";
            // 
            // txtDonGia
            // 
            txtDonGia.Location = new Point(176, 156);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.Size = new Size(215, 31);
            txtDonGia.TabIndex = 5;
            // 
            // dgvChiTietPhieu
            // 
            dgvChiTietPhieu.ColumnHeadersHeight = 34;
            dgvChiTietPhieu.Location = new Point(45, 340);
            dgvChiTietPhieu.Name = "dgvChiTietPhieu";
            dgvChiTietPhieu.RowHeadersWidth = 62;
            dgvChiTietPhieu.Size = new Size(1217, 241);
            dgvChiTietPhieu.TabIndex = 2;
            // 
            // btnThemPhieu
            // 
            btnThemPhieu.Location = new Point(420, 275);
            btnThemPhieu.Name = "btnThemPhieu";
            btnThemPhieu.Size = new Size(150, 40);
            btnThemPhieu.TabIndex = 3;
            btnThemPhieu.Text = "Thêm Phiếu";
            // 
            // btnSuaPhieu
            // 
            btnSuaPhieu.Location = new Point(698, 275);
            btnSuaPhieu.Name = "btnSuaPhieu";
            btnSuaPhieu.Size = new Size(132, 40);
            btnSuaPhieu.TabIndex = 4;
            btnSuaPhieu.Text = "Sửa Phiếu";
            // 
            // tabDanhSach
            // 
            tabDanhSach.Location = new Point(4, 34);
            tabDanhSach.Name = "tabDanhSach";
            tabDanhSach.Size = new Size(1310, 801);
            tabDanhSach.TabIndex = 1;
            tabDanhSach.Text = "DANH SÁCH";
            // 
            // PhieuBanHang
            // 
            ClientSize = new Size(1318, 694);
            Controls.Add(tabControl);
            Name = "PhieuBanHang";
            Text = "Quản Lý Phiếu Bán Hàng";
            tabControl.ResumeLayout(false);
            tabCapNhat.ResumeLayout(false);
            grpThongTinPhieu.ResumeLayout(false);
            grpThongTinPhieu.PerformLayout();
            grpChiTietPhieu.ResumeLayout(false);
            grpChiTietPhieu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvChiTietPhieu).EndInit();
            ResumeLayout(false);
        }
    }
}
