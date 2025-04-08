namespace GUI_SOF205
{
    partial class QuanLyLoaiSanPham
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabCapNhat;
        private System.Windows.Forms.TabPage tabDanhSach;
        private System.Windows.Forms.TextBox txtMaLoai;
        private System.Windows.Forms.TextBox txtTenLoai;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label lblMaLoai, lblTenLoai, lblGhiChu;
        private System.Windows.Forms.DataGridView dgvLoaiSanPham;

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
            lblTheLuuDong = new Label();
            btnMoi = new Button();
            lblMaLoai = new Label();
            txtMaLoai = new TextBox();
            lblTenLoai = new Label();
            txtTenLoai = new TextBox();
            lblGhiChu = new Label();
            txtGhiChu = new TextBox();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            tabDanhSach = new TabPage();
            dgvLoaiSanPham = new DataGridView();
            tabControl.SuspendLayout();
            tabCapNhat.SuspendLayout();
            tabDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLoaiSanPham).BeginInit();
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
            // 
            // tabCapNhat
            // 
            tabCapNhat.Controls.Add(lblTheLuuDong);
            tabCapNhat.Controls.Add(btnMoi);
            tabCapNhat.Controls.Add(lblMaLoai);
            tabCapNhat.Controls.Add(txtMaLoai);
            tabCapNhat.Controls.Add(lblTenLoai);
            tabCapNhat.Controls.Add(txtTenLoai);
            tabCapNhat.Controls.Add(lblGhiChu);
            tabCapNhat.Controls.Add(txtGhiChu);
            tabCapNhat.Controls.Add(btnThem);
            tabCapNhat.Controls.Add(btnSua);
            tabCapNhat.Controls.Add(btnXoa);
            tabCapNhat.Location = new Point(4, 37);
            tabCapNhat.Name = "tabCapNhat";
            tabCapNhat.Size = new Size(1295, 653);
            tabCapNhat.TabIndex = 0;
            tabCapNhat.Text = "CẬP NHẬT";
            tabCapNhat.UseVisualStyleBackColor = true;
            // 
            // lblTheLuuDong
            // 
            lblTheLuuDong.AutoSize = true;
            lblTheLuuDong.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTheLuuDong.ForeColor = SystemColors.Highlight;
            lblTheLuuDong.Location = new Point(493, 46);
            lblTheLuuDong.Name = "lblTheLuuDong";
            lblTheLuuDong.Size = new Size(275, 45);
            lblTheLuuDong.TabIndex = 22;
            lblTheLuuDong.Text = "LOẠI SẢN PHẨM";
            // 
            // btnMoi
            // 
            btnMoi.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMoi.ForeColor = SystemColors.Highlight;
            btnMoi.Location = new Point(781, 432);
            btnMoi.Name = "btnMoi";
            btnMoi.Size = new Size(129, 50);
            btnMoi.TabIndex = 10;
            btnMoi.Text = "Làm Mới";
            // 
            // lblMaLoai
            // 
            lblMaLoai.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMaLoai.Location = new Point(297, 137);
            lblMaLoai.Name = "lblMaLoai";
            lblMaLoai.Size = new Size(122, 32);
            lblMaLoai.TabIndex = 0;
            lblMaLoai.Text = "Mã loại:";
            // 
            // txtMaLoai
            // 
            txtMaLoai.Location = new Point(532, 212);
            txtMaLoai.Name = "txtMaLoai";
            txtMaLoai.Size = new Size(400, 34);
            txtMaLoai.TabIndex = 1;
            // 
            // lblTenLoai
            // 
            lblTenLoai.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTenLoai.Location = new Point(297, 215);
            lblTenLoai.Name = "lblTenLoai";
            lblTenLoai.Size = new Size(122, 35);
            lblTenLoai.TabIndex = 2;
            lblTenLoai.Text = "Tên loại:";
            // 
            // txtTenLoai
            // 
            txtTenLoai.Location = new Point(532, 134);
            txtTenLoai.Name = "txtTenLoai";
            txtTenLoai.Size = new Size(400, 34);
            txtTenLoai.TabIndex = 3;
            // 
            // lblGhiChu
            // 
            lblGhiChu.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGhiChu.Location = new Point(297, 298);
            lblGhiChu.Name = "lblGhiChu";
            lblGhiChu.Size = new Size(124, 26);
            lblGhiChu.TabIndex = 4;
            lblGhiChu.Text = "Ghi chú:";
            // 
            // txtGhiChu
            // 
            txtGhiChu.Location = new Point(539, 295);
            txtGhiChu.Multiline = true;
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.Size = new Size(400, 80);
            txtGhiChu.TabIndex = 5;
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThem.ForeColor = Color.Green;
            btnThem.Location = new Point(319, 432);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(129, 50);
            btnThem.TabIndex = 6;
            btnThem.Text = "Thêm";
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Enabled = false;
            btnSua.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSua.ForeColor = Color.DarkOrange;
            btnSua.Location = new Point(475, 432);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(129, 50);
            btnSua.TabIndex = 7;
            btnSua.Text = "Sửa";
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Enabled = false;
            btnXoa.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXoa.ForeColor = Color.Red;
            btnXoa.Location = new Point(627, 432);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(129, 50);
            btnXoa.TabIndex = 8;
            btnXoa.Text = "Xóa";
            btnXoa.Click += btnXoa_Click;
            // 
            // tabDanhSach
            // 
            tabDanhSach.Controls.Add(dgvLoaiSanPham);
            tabDanhSach.Location = new Point(4, 37);
            tabDanhSach.Name = "tabDanhSach";
            tabDanhSach.Size = new Size(1295, 653);
            tabDanhSach.TabIndex = 1;
            tabDanhSach.Text = "DANH SÁCH";
            tabDanhSach.UseVisualStyleBackColor = true;
            // 
            // dgvLoaiSanPham
            // 
            dgvLoaiSanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLoaiSanPham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLoaiSanPham.Dock = DockStyle.Fill;
            dgvLoaiSanPham.Location = new Point(0, 0);
            dgvLoaiSanPham.Name = "dgvLoaiSanPham";
            dgvLoaiSanPham.RowHeadersWidth = 62;
            dgvLoaiSanPham.Size = new Size(1295, 653);
            dgvLoaiSanPham.TabIndex = 0;
            // 
            // QuanLyLoaiSanPham
            // 
            ClientSize = new Size(1303, 694);
            Controls.Add(tabControl);
            Name = "QuanLyLoaiSanPham";
            Text = "Quản Lý Loại Sản Phẩm";
            tabControl.ResumeLayout(false);
            tabCapNhat.ResumeLayout(false);
            tabCapNhat.PerformLayout();
            tabDanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvLoaiSanPham).EndInit();
            ResumeLayout(false);
        }

        private Button btnMoi;
        private Label lblTheLuuDong;
    }
}
