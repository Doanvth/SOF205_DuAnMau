namespace GUI_SOF205
{
    partial class QuanLySanPham
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabCapNhat;
        private System.Windows.Forms.TabPage tabDanhSach;
        private System.Windows.Forms.DataGridView dgvSanPham;

        private System.Windows.Forms.TextBox txtMaSanPham;
        private System.Windows.Forms.TextBox txtTenSanPham;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.ComboBox cboLoaiSanPham;
        private System.Windows.Forms.RadioButton rbHoatDong;
        private System.Windows.Forms.RadioButton rbNgungBan;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnMoi;
        private System.Windows.Forms.Label lblMaSanPham, lblTenSanPham, lblDonGia, lblLoaiSanPham, lblTrangThai;


        //Hình ảnh
        private System.Windows.Forms.PictureBox pbHinhAnh;
        private System.Windows.Forms.Button btnChonAnh;
        private System.Windows.Forms.OpenFileDialog openFileDialog;

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
            lblMaSanPham = new Label();
            txtMaSanPham = new TextBox();
            lblTenSanPham = new Label();
            txtTenSanPham = new TextBox();
            lblDonGia = new Label();
            txtDonGia = new TextBox();
            lblLoaiSanPham = new Label();
            cboLoaiSanPham = new ComboBox();
            lblTrangThai = new Label();
            rbHoatDong = new RadioButton();
            rbNgungBan = new RadioButton();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnMoi = new Button();
            pbHinhAnh = new PictureBox();
            btnChonAnh = new Button();
            tabDanhSach = new TabPage();
            dgvSanPham = new DataGridView();
            openFileDialog = new OpenFileDialog();
            tabControl.SuspendLayout();
            tabCapNhat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbHinhAnh).BeginInit();
            tabDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSanPham).BeginInit();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabCapNhat);
            tabControl.Controls.Add(tabDanhSach);
            tabControl.Dock = DockStyle.Fill;
            tabControl.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabControl.Location = new Point(0, 0);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(1303, 694);
            tabControl.TabIndex = 0;
            tabControl.SelectedIndexChanged += tabControl_SelectedIndexChanged;
            // 
            // tabCapNhat
            // 
            tabCapNhat.Controls.Add(lblMaSanPham);
            tabCapNhat.Controls.Add(txtMaSanPham);
            tabCapNhat.Controls.Add(lblTenSanPham);
            tabCapNhat.Controls.Add(txtTenSanPham);
            tabCapNhat.Controls.Add(lblDonGia);
            tabCapNhat.Controls.Add(txtDonGia);
            tabCapNhat.Controls.Add(lblLoaiSanPham);
            tabCapNhat.Controls.Add(cboLoaiSanPham);
            tabCapNhat.Controls.Add(lblTrangThai);
            tabCapNhat.Controls.Add(rbHoatDong);
            tabCapNhat.Controls.Add(rbNgungBan);
            tabCapNhat.Controls.Add(btnThem);
            tabCapNhat.Controls.Add(btnSua);
            tabCapNhat.Controls.Add(btnXoa);
            tabCapNhat.Controls.Add(btnMoi);
            tabCapNhat.Controls.Add(pbHinhAnh);
            tabCapNhat.Controls.Add(btnChonAnh);
            tabCapNhat.Location = new Point(4, 26);
            tabCapNhat.Name = "tabCapNhat";
            tabCapNhat.Size = new Size(1295, 664);
            tabCapNhat.TabIndex = 0;
            tabCapNhat.Text = "CẬP NHẬT";
            tabCapNhat.UseVisualStyleBackColor = true;
            // 
            // lblMaSanPham
            // 
            lblMaSanPham.Font = new Font("Segoe UI", 10F);
            lblMaSanPham.Location = new Point(8, 19);
            lblMaSanPham.Name = "lblMaSanPham";
            lblMaSanPham.Size = new Size(111, 35);
            lblMaSanPham.TabIndex = 0;
            lblMaSanPham.Text = "Mã sản phẩm:";
            // 
            // txtMaSanPham
            // 
            txtMaSanPham.Location = new Point(125, 19);
            txtMaSanPham.Name = "txtMaSanPham";
            txtMaSanPham.Size = new Size(400, 25);
            txtMaSanPham.TabIndex = 1;
            // 
            // lblTenSanPham
            // 
            lblTenSanPham.Font = new Font("Segoe UI", 10F);
            lblTenSanPham.Location = new Point(267, 140);
            lblTenSanPham.Name = "lblTenSanPham";
            lblTenSanPham.Size = new Size(177, 29);
            lblTenSanPham.TabIndex = 2;
            lblTenSanPham.Text = "Tên sản phẩm:";
            // 
            // txtTenSanPham
            // 
            txtTenSanPham.Location = new Point(125, 65);
            txtTenSanPham.Name = "txtTenSanPham";
            txtTenSanPham.Size = new Size(400, 25);
            txtTenSanPham.TabIndex = 3;
            // 
            // lblDonGia
            // 
            lblDonGia.Font = new Font("Segoe UI", 10F);
            lblDonGia.Location = new Point(267, 208);
            lblDonGia.Name = "lblDonGia";
            lblDonGia.Size = new Size(66, 32);
            lblDonGia.TabIndex = 4;
            lblDonGia.Text = "Đơn giá:";
            // 
            // txtDonGia
            // 
            txtDonGia.Location = new Point(125, 109);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.Size = new Size(400, 25);
            txtDonGia.TabIndex = 5;
            // 
            // lblLoaiSanPham
            // 
            lblLoaiSanPham.Font = new Font("Segoe UI", 10F);
            lblLoaiSanPham.Location = new Point(267, 287);
            lblLoaiSanPham.Name = "lblLoaiSanPham";
            lblLoaiSanPham.Size = new Size(188, 33);
            lblLoaiSanPham.TabIndex = 6;
            lblLoaiSanPham.Text = "Loại sản phẩm:";
            // 
            // cboLoaiSanPham
            // 
            cboLoaiSanPham.Location = new Point(571, 284);
            cboLoaiSanPham.Name = "cboLoaiSanPham";
            cboLoaiSanPham.Size = new Size(400, 25);
            cboLoaiSanPham.TabIndex = 7;
            // 
            // lblTrangThai
            // 
            lblTrangThai.Font = new Font("Segoe UI", 10F);
            lblTrangThai.Location = new Point(8, 202);
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(99, 34);
            lblTrangThai.TabIndex = 8;
            lblTrangThai.Text = "Trạng thái:";
            // 
            // rbHoatDong
            // 
            rbHoatDong.Checked = true;
            rbHoatDong.Font = new Font("Segoe UI", 10F);
            rbHoatDong.Location = new Point(125, 202);
            rbHoatDong.Name = "rbHoatDong";
            rbHoatDong.Size = new Size(154, 33);
            rbHoatDong.TabIndex = 9;
            rbHoatDong.TabStop = true;
            rbHoatDong.Text = "Hoạt động";
            // 
            // rbNgungBan
            // 
            rbNgungBan.Font = new Font("Segoe UI", 10F);
            rbNgungBan.Location = new Point(754, 366);
            rbNgungBan.Name = "rbNgungBan";
            rbNgungBan.Size = new Size(163, 33);
            rbNgungBan.TabIndex = 10;
            rbNgungBan.Text = "Ngừng bán";
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Segoe UI", 10F);
            btnThem.Location = new Point(161, 282);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(129, 50);
            btnThem.TabIndex = 11;
            btnThem.Text = "Thêm";
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Enabled = false;
            btnSua.Font = new Font("Segoe UI", 10F);
            btnSua.Location = new Point(317, 282);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(129, 50);
            btnSua.TabIndex = 12;
            btnSua.Text = "Sửa";
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Enabled = false;
            btnXoa.Font = new Font("Segoe UI", 10F);
            btnXoa.Location = new Point(475, 282);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(129, 50);
            btnXoa.TabIndex = 13;
            btnXoa.Text = "Xóa";
            btnXoa.Click += btnXoa_Click;
            // 
            // btnMoi
            // 
            btnMoi.Font = new Font("Segoe UI", 10F);
            btnMoi.Location = new Point(2, 282);
            btnMoi.Name = "btnMoi";
            btnMoi.Size = new Size(129, 50);
            btnMoi.TabIndex = 14;
            btnMoi.Text = "Mới";
            // 
            // pbHinhAnh
            // 
            pbHinhAnh.BorderStyle = BorderStyle.FixedSingle;
            pbHinhAnh.Location = new Point(1052, 63);
            pbHinhAnh.Name = "pbHinhAnh";
            pbHinhAnh.Size = new Size(211, 186);
            pbHinhAnh.TabIndex = 15;
            pbHinhAnh.TabStop = false;
            // 
            // btnChonAnh
            // 
            btnChonAnh.Location = new Point(1092, 270);
            btnChonAnh.Name = "btnChonAnh";
            btnChonAnh.Size = new Size(129, 50);
            btnChonAnh.TabIndex = 16;
            btnChonAnh.Text = "Chọn Ảnh";
            btnChonAnh.Click += BtnChonAnh_Click;
            // 
            // tabDanhSach
            // 
            tabDanhSach.Controls.Add(dgvSanPham);
            tabDanhSach.Location = new Point(4, 26);
            tabDanhSach.Name = "tabDanhSach";
            tabDanhSach.Size = new Size(1295, 664);
            tabDanhSach.TabIndex = 1;
            tabDanhSach.Text = "DANH SÁCH";
            tabDanhSach.UseVisualStyleBackColor = true;
            // 
            // dgvSanPham
            // 
            dgvSanPham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSanPham.Dock = DockStyle.Fill;
            dgvSanPham.Location = new Point(0, 0);
            dgvSanPham.Name = "dgvSanPham";
            dgvSanPham.RowHeadersWidth = 62;
            dgvSanPham.Size = new Size(1295, 664);
            dgvSanPham.TabIndex = 0;
            dgvSanPham.CellClick += dgvSanPham_CellClick;
            // 
            // QuanLySanPham
            // 
            ClientSize = new Size(1303, 694);
            Controls.Add(tabControl);
            Name = "QuanLySanPham";
            Text = "Quản Lý Sản Phẩm";
            Load += QuanLySanPham_Load;
            tabControl.ResumeLayout(false);
            tabCapNhat.ResumeLayout(false);
            tabCapNhat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbHinhAnh).EndInit();
            tabDanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSanPham).EndInit();
            ResumeLayout(false);
        }

        private void BtnChonAnh_Click(object sender, EventArgs e)
        {
            // Mở hộp thoại chọn file ảnh
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Title = "Chọn ảnh sản phẩm",
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif",
                Multiselect = false // Chỉ cho phép chọn một ảnh
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Lấy đường dẫn file ảnh đã chọn
                string filePath = openFileDialog.FileName;

                // Hiển thị ảnh trong PictureBox
                pbHinhAnh.Image = Image.FromFile(filePath);
                pbHinhAnh.SizeMode = PictureBoxSizeMode.Zoom; // Hiển thị ảnh vừa khung

                // Lưu đường dẫn ảnh vào Tag để sử dụng sau này
                pbHinhAnh.Tag = filePath;
            }
        }
    }
}
