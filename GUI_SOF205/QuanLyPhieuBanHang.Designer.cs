namespace GUI_SOF205
{
    partial class QuanLyPhieuBanHang
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPhieuBanHang;
        private System.Windows.Forms.TabPage tabChiTietPhieu;
        private System.Windows.Forms.DataGridView dgvPhieuBanHang;

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

        // Buttons
        private System.Windows.Forms.Button btnThemPhieu, btnSuaPhieu, btnXoaPhieu, btnMoiPhieu;
        private System.Windows.Forms.Button btnThemChiTiet, btnXoaChiTietPhieu;

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
            tabPhieuBanHang = new TabPage();
            lblPhieuBanHang = new Label();
            btnThanhToan = new Button();
            btnXoaCTP = new Button();
            btnSuaChiTietPhieu = new Button();
            btnXoaPhieuBH = new Button();
            btnLamMoi = new Button();
            btnThemChiTietPhieu = new Button();
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
            lblSanPham = new Label();
            txtThanhTien = new TextBox();
            lblThanhTien = new Label();
            lblSoLuong = new Label();
            txtSoLuong = new TextBox();
            lblDonGia = new Label();
            txtDonGia = new TextBox();
            cboMaSanPham = new ComboBox();
            dgvPhieuBanHang = new DataGridView();
            btnThemPhieu = new Button();
            btnSuaPhieu = new Button();
            tabChiTietPhieu = new TabPage();
            dgvChiTietPhieu = new DataGridView();
            tabControl.SuspendLayout();
            tabPhieuBanHang.SuspendLayout();
            grpThongTinPhieu.SuspendLayout();
            grpChiTietPhieu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPhieuBanHang).BeginInit();
            tabChiTietPhieu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvChiTietPhieu).BeginInit();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabPhieuBanHang);
            tabControl.Controls.Add(tabChiTietPhieu);
            tabControl.Dock = DockStyle.Fill;
            tabControl.Location = new Point(0, 0);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(1318, 694);
            tabControl.TabIndex = 0;
            // 
            // tabPhieuBanHang
            // 
            tabPhieuBanHang.Controls.Add(lblPhieuBanHang);
            tabPhieuBanHang.Controls.Add(btnThanhToan);
            tabPhieuBanHang.Controls.Add(btnXoaCTP);
            tabPhieuBanHang.Controls.Add(btnSuaChiTietPhieu);
            tabPhieuBanHang.Controls.Add(btnXoaPhieuBH);
            tabPhieuBanHang.Controls.Add(btnLamMoi);
            tabPhieuBanHang.Controls.Add(btnThemChiTietPhieu);
            tabPhieuBanHang.Controls.Add(grpThongTinPhieu);
            tabPhieuBanHang.Controls.Add(grpChiTietPhieu);
            tabPhieuBanHang.Controls.Add(dgvPhieuBanHang);
            tabPhieuBanHang.Controls.Add(btnThemPhieu);
            tabPhieuBanHang.Controls.Add(btnSuaPhieu);
            tabPhieuBanHang.Location = new Point(4, 34);
            tabPhieuBanHang.Name = "tabPhieuBanHang";
            tabPhieuBanHang.Size = new Size(1310, 656);
            tabPhieuBanHang.TabIndex = 0;
            tabPhieuBanHang.Text = "PHIẾU BÁN HÀNG";
            // 
            // lblPhieuBanHang
            // 
            lblPhieuBanHang.AutoSize = true;
            lblPhieuBanHang.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPhieuBanHang.ForeColor = SystemColors.Highlight;
            lblPhieuBanHang.Location = new Point(496, 18);
            lblPhieuBanHang.Name = "lblPhieuBanHang";
            lblPhieuBanHang.Size = new Size(298, 45);
            lblPhieuBanHang.TabIndex = 11;
            lblPhieuBanHang.Text = "PHIẾU BÁN HÀNG";
            // 
            // btnThanhToan
            // 
            btnThanhToan.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnThanhToan.ForeColor = Color.Aqua;
            btnThanhToan.Location = new Point(618, 343);
            btnThanhToan.Name = "btnThanhToan";
            btnThanhToan.Size = new Size(138, 40);
            btnThanhToan.TabIndex = 10;
            btnThanhToan.Text = "Thanh Toán";
            btnThanhToan.UseVisualStyleBackColor = true;
            btnThanhToan.Click += btnThanhToan_Click;
            // 
            // btnXoaCTP
            // 
            btnXoaCTP.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnXoaCTP.ForeColor = Color.Red;
            btnXoaCTP.Location = new Point(1099, 343);
            btnXoaCTP.Name = "btnXoaCTP";
            btnXoaCTP.Size = new Size(138, 40);
            btnXoaCTP.TabIndex = 9;
            btnXoaCTP.Text = "Xóa Chi Tiết";
            btnXoaCTP.UseVisualStyleBackColor = true;
            btnXoaCTP.Click += btnXoaCTP_Click;
            // 
            // btnSuaChiTietPhieu
            // 
            btnSuaChiTietPhieu.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSuaChiTietPhieu.ForeColor = Color.DarkOrange;
            btnSuaChiTietPhieu.Location = new Point(955, 343);
            btnSuaChiTietPhieu.Name = "btnSuaChiTietPhieu";
            btnSuaChiTietPhieu.Size = new Size(138, 40);
            btnSuaChiTietPhieu.TabIndex = 8;
            btnSuaChiTietPhieu.Text = "Sửa Chi Tiết";
            btnSuaChiTietPhieu.Click += btnSuaChiTietPhieu_Click;
            // 
            // btnXoaPhieuBH
            // 
            btnXoaPhieuBH.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnXoaPhieuBH.ForeColor = Color.Red;
            btnXoaPhieuBH.Location = new Point(329, 343);
            btnXoaPhieuBH.Name = "btnXoaPhieuBH";
            btnXoaPhieuBH.Size = new Size(138, 40);
            btnXoaPhieuBH.TabIndex = 7;
            btnXoaPhieuBH.Text = "Xóa Phiếu";
            btnXoaPhieuBH.Click += btnXoaPhieuBH_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnLamMoi.ForeColor = SystemColors.Highlight;
            btnLamMoi.Location = new Point(473, 343);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(138, 40);
            btnLamMoi.TabIndex = 6;
            btnLamMoi.Text = "Làm Mới";
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnThemChiTietPhieu
            // 
            btnThemChiTietPhieu.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnThemChiTietPhieu.ForeColor = Color.Green;
            btnThemChiTietPhieu.Location = new Point(811, 343);
            btnThemChiTietPhieu.Name = "btnThemChiTietPhieu";
            btnThemChiTietPhieu.Size = new Size(138, 40);
            btnThemChiTietPhieu.TabIndex = 5;
            btnThemChiTietPhieu.Text = "Thêm Chi Tiết";
            btnThemChiTietPhieu.Click += btnThemChiTietPhieu_Click;
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
            grpThongTinPhieu.Location = new Point(41, 82);
            grpThongTinPhieu.Name = "grpThongTinPhieu";
            grpThongTinPhieu.Size = new Size(753, 245);
            grpThongTinPhieu.TabIndex = 0;
            grpThongTinPhieu.TabStop = false;
            grpThongTinPhieu.Text = "Thông tin Phiếu";
            // 
            // lblMaPhieu
            // 
            lblMaPhieu.Location = new Point(22, 56);
            lblMaPhieu.Name = "lblMaPhieu";
            lblMaPhieu.Size = new Size(100, 23);
            lblMaPhieu.TabIndex = 0;
            lblMaPhieu.Text = "Mã Phiếu:";
            // 
            // txtMaPhieu
            // 
            txtMaPhieu.Location = new Point(159, 53);
            txtMaPhieu.Name = "txtMaPhieu";
            txtMaPhieu.ReadOnly = true;
            txtMaPhieu.Size = new Size(215, 31);
            txtMaPhieu.TabIndex = 1;
            // 
            // lblMaThe
            // 
            lblMaThe.Location = new Point(394, 56);
            lblMaThe.Name = "lblMaThe";
            lblMaThe.Size = new Size(78, 23);
            lblMaThe.TabIndex = 2;
            lblMaThe.Text = "Mã Thẻ:";
            // 
            // cboMaThe
            // 
            cboMaThe.Location = new Point(498, 53);
            cboMaThe.Name = "cboMaThe";
            cboMaThe.Size = new Size(215, 33);
            cboMaThe.TabIndex = 3;
            // 
            // lblMaNhanVien
            // 
            lblMaNhanVien.Location = new Point(22, 114);
            lblMaNhanVien.Name = "lblMaNhanVien";
            lblMaNhanVien.Size = new Size(131, 23);
            lblMaNhanVien.TabIndex = 4;
            lblMaNhanVien.Text = "Mã Nhân Viên:";
            // 
            // cboMaNhanVien
            // 
            cboMaNhanVien.Location = new Point(159, 104);
            cboMaNhanVien.Name = "cboMaNhanVien";
            cboMaNhanVien.Size = new Size(215, 33);
            cboMaNhanVien.TabIndex = 5;
            // 
            // lblNgayTao
            // 
            lblNgayTao.Location = new Point(394, 114);
            lblNgayTao.Name = "lblNgayTao";
            lblNgayTao.Size = new Size(100, 26);
            lblNgayTao.TabIndex = 6;
            lblNgayTao.Text = "Ngày Tạo:";
            // 
            // dtpNgayTao
            // 
            dtpNgayTao.Location = new Point(500, 109);
            dtpNgayTao.Name = "dtpNgayTao";
            dtpNgayTao.Size = new Size(215, 31);
            dtpNgayTao.TabIndex = 7;
            // 
            // lblTrangThai
            // 
            lblTrangThai.Location = new Point(22, 176);
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(100, 32);
            lblTrangThai.TabIndex = 8;
            lblTrangThai.Text = "Trạng Thái:";
            // 
            // rbHoanThanh
            // 
            rbHoanThanh.Enabled = false;
            rbHoanThanh.Location = new Point(334, 178);
            rbHoanThanh.Name = "rbHoanThanh";
            rbHoanThanh.Size = new Size(160, 24);
            rbHoanThanh.TabIndex = 9;
            rbHoanThanh.Text = "Đã thanh toán";
            // 
            // rbChoXacNhan
            // 
            rbChoXacNhan.Checked = true;
            rbChoXacNhan.Enabled = false;
            rbChoXacNhan.Location = new Point(159, 176);
            rbChoXacNhan.Name = "rbChoXacNhan";
            rbChoXacNhan.Size = new Size(145, 26);
            rbChoXacNhan.TabIndex = 10;
            rbChoXacNhan.TabStop = true;
            rbChoXacNhan.Text = "Chờ xác nhận";
            // 
            // grpChiTietPhieu
            // 
            grpChiTietPhieu.Controls.Add(lblSanPham);
            grpChiTietPhieu.Controls.Add(txtThanhTien);
            grpChiTietPhieu.Controls.Add(lblThanhTien);
            grpChiTietPhieu.Controls.Add(lblSoLuong);
            grpChiTietPhieu.Controls.Add(txtSoLuong);
            grpChiTietPhieu.Controls.Add(lblDonGia);
            grpChiTietPhieu.Controls.Add(txtDonGia);
            grpChiTietPhieu.Controls.Add(cboMaSanPham);
            grpChiTietPhieu.Location = new Point(811, 82);
            grpChiTietPhieu.Name = "grpChiTietPhieu";
            grpChiTietPhieu.Size = new Size(447, 245);
            grpChiTietPhieu.TabIndex = 1;
            grpChiTietPhieu.TabStop = false;
            grpChiTietPhieu.Text = "Chi Tiết Phiếu";
            // 
            // lblSanPham
            // 
            lblSanPham.Location = new Point(23, 48);
            lblSanPham.Name = "lblSanPham";
            lblSanPham.Size = new Size(100, 23);
            lblSanPham.TabIndex = 10;
            lblSanPham.Text = "Sản Phẩm:";
            // 
            // txtThanhTien
            // 
            txtThanhTien.ForeColor = Color.YellowGreen;
            txtThanhTien.Location = new Point(176, 193);
            txtThanhTien.Name = "txtThanhTien";
            txtThanhTien.Size = new Size(240, 31);
            txtThanhTien.TabIndex = 9;
            // 
            // lblThanhTien
            // 
            lblThanhTien.AutoSize = true;
            lblThanhTien.Location = new Point(22, 199);
            lblThanhTien.Name = "lblThanhTien";
            lblThanhTien.Size = new Size(101, 25);
            lblThanhTien.TabIndex = 8;
            lblThanhTien.Text = "Thành Tiền:";
            // 
            // lblSoLuong
            // 
            lblSoLuong.Location = new Point(23, 143);
            lblSoLuong.Name = "lblSoLuong";
            lblSoLuong.Size = new Size(100, 31);
            lblSoLuong.TabIndex = 4;
            lblSoLuong.Text = "Số Lượng:";
            // 
            // txtSoLuong
            // 
            txtSoLuong.ForeColor = Color.YellowGreen;
            txtSoLuong.Location = new Point(176, 140);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(240, 31);
            txtSoLuong.TabIndex = 5;
            txtSoLuong.TextChanged += txtSoLuong_TextChanged;
            // 
            // lblDonGia
            // 
            lblDonGia.Location = new Point(23, 97);
            lblDonGia.Name = "lblDonGia";
            lblDonGia.Size = new Size(100, 23);
            lblDonGia.TabIndex = 6;
            lblDonGia.Text = "Đơn Giá:";
            // 
            // txtDonGia
            // 
            txtDonGia.Location = new Point(176, 89);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.ReadOnly = true;
            txtDonGia.Size = new Size(240, 31);
            txtDonGia.TabIndex = 7;
            txtDonGia.TabStop = false;
            // 
            // cboMaSanPham
            // 
            cboMaSanPham.Location = new Point(176, 38);
            cboMaSanPham.Name = "cboMaSanPham";
            cboMaSanPham.Size = new Size(240, 33);
            cboMaSanPham.TabIndex = 1;
            cboMaSanPham.SelectedIndexChanged += cboMaSanPham_SelectedIndexChanged;
            // 
            // dgvPhieuBanHang
            // 
            dgvPhieuBanHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPhieuBanHang.ColumnHeadersHeight = 34;
            dgvPhieuBanHang.Location = new Point(41, 398);
            dgvPhieuBanHang.Name = "dgvPhieuBanHang";
            dgvPhieuBanHang.RowHeadersWidth = 62;
            dgvPhieuBanHang.Size = new Size(1217, 241);
            dgvPhieuBanHang.TabIndex = 2;
            dgvPhieuBanHang.CellClick += dgvPhieuBanHang_CellClick;
            // 
            // btnThemPhieu
            // 
            btnThemPhieu.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnThemPhieu.ForeColor = Color.Green;
            btnThemPhieu.Location = new Point(41, 343);
            btnThemPhieu.Name = "btnThemPhieu";
            btnThemPhieu.Size = new Size(138, 40);
            btnThemPhieu.TabIndex = 3;
            btnThemPhieu.Text = "Thêm Phiếu";
            btnThemPhieu.Click += btnThemPhieu_Click;
            // 
            // btnSuaPhieu
            // 
            btnSuaPhieu.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSuaPhieu.ForeColor = Color.DarkOrange;
            btnSuaPhieu.Location = new Point(185, 343);
            btnSuaPhieu.Name = "btnSuaPhieu";
            btnSuaPhieu.Size = new Size(138, 40);
            btnSuaPhieu.TabIndex = 4;
            btnSuaPhieu.Text = "Sửa Phiếu";
            btnSuaPhieu.Click += btnSuaPhieu_Click;
            // 
            // tabChiTietPhieu
            // 
            tabChiTietPhieu.Controls.Add(dgvChiTietPhieu);
            tabChiTietPhieu.Location = new Point(4, 34);
            tabChiTietPhieu.Name = "tabChiTietPhieu";
            tabChiTietPhieu.Size = new Size(1310, 656);
            tabChiTietPhieu.TabIndex = 1;
            tabChiTietPhieu.Text = "CHI TIẾT PHIẾU";
            // 
            // dgvChiTietPhieu
            // 
            dgvChiTietPhieu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvChiTietPhieu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvChiTietPhieu.Location = new Point(8, 12);
            dgvChiTietPhieu.Name = "dgvChiTietPhieu";
            dgvChiTietPhieu.RowHeadersWidth = 62;
            dgvChiTietPhieu.Size = new Size(1285, 510);
            dgvChiTietPhieu.TabIndex = 1;
            dgvChiTietPhieu.CellClick += dgvChiTietPhieu_CellClick_1;
            // 
            // QuanLyPhieuBanHang
            // 
            ClientSize = new Size(1318, 694);
            Controls.Add(tabControl);
            Name = "QuanLyPhieuBanHang";
            Text = "Quản Lý Phiếu Bán Hàng";
            tabControl.ResumeLayout(false);
            tabPhieuBanHang.ResumeLayout(false);
            tabPhieuBanHang.PerformLayout();
            grpThongTinPhieu.ResumeLayout(false);
            grpThongTinPhieu.PerformLayout();
            grpChiTietPhieu.ResumeLayout(false);
            grpChiTietPhieu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPhieuBanHang).EndInit();
            tabChiTietPhieu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvChiTietPhieu).EndInit();
            ResumeLayout(false);
        }

        private DataGridView dgvChiTietPhieu;
        private Button btnThemChiTietPhieu;
        private Button btnLamMoi;
        private TextBox txtThanhTien;
        private Label lblThanhTien;
        private Label lblSoLuong;
        private TextBox txtSoLuong;
        private Label lblDonGia;
        private TextBox txtDonGia;
        private Label lblSanPham;
        private Button btnXoaPhieuBH;
        private Button btnSuaChiTietPhieu;
        private Button btnXoaCTP;
        private Button btnThanhToan;
        private Label lblPhieuBanHang;
    }
}
