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
        private System.Windows.Forms.Button btnMoi;
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
            lblMaLoai = new Label();
            txtMaLoai = new TextBox();
            lblTenLoai = new Label();
            txtTenLoai = new TextBox();
            lblGhiChu = new Label();
            txtGhiChu = new TextBox();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnMoi = new Button();
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
            tabCapNhat.Controls.Add(lblMaLoai);
            tabCapNhat.Controls.Add(txtMaLoai);
            tabCapNhat.Controls.Add(lblTenLoai);
            tabCapNhat.Controls.Add(txtTenLoai);
            tabCapNhat.Controls.Add(lblGhiChu);
            tabCapNhat.Controls.Add(txtGhiChu);
            tabCapNhat.Controls.Add(btnThem);
            tabCapNhat.Controls.Add(btnSua);
            tabCapNhat.Controls.Add(btnXoa);
            tabCapNhat.Controls.Add(btnMoi);
            tabCapNhat.Location = new Point(4, 37);
            tabCapNhat.Name = "tabCapNhat";
            tabCapNhat.Size = new Size(1295, 653);
            tabCapNhat.TabIndex = 0;
            tabCapNhat.Text = "CẬP NHẬT";
            tabCapNhat.UseVisualStyleBackColor = true;
            // 
            // lblMaLoai
            // 
            lblMaLoai.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMaLoai.Location = new Point(43, 45);
            lblMaLoai.Location = new Point(294, 69);
            lblMaLoai.Name = "lblMaLoai";
            lblMaLoai.Size = new Size(122, 32);
            lblMaLoai.TabIndex = 0;
            lblMaLoai.Text = "Mã loại:";
            // 
            // txtMaLoai
            // 

            txtMaLoai.Location = new Point(529, 144);
            txtMaLoai.Name = "txtMaLoai";
            txtMaLoai.Size = new Size(400, 34);
            txtMaLoai.TabIndex = 1;
            // 
            // lblTenLoai
            // 
            lblTenLoai.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTenLoai.Location = new Point(43, 123);
            lblTenLoai.Location = new Point(294, 147);
            lblTenLoai.Name = "lblTenLoai";
            lblTenLoai.Size = new Size(122, 35);
            lblTenLoai.TabIndex = 2;
            lblTenLoai.Text = "Tên loại:";
            // 
            // txtTenLoai
            // 

            txtTenLoai.Location = new Point(529, 66);
            txtTenLoai.Name = "txtTenLoai";
            txtTenLoai.Size = new Size(400, 34);
            txtTenLoai.TabIndex = 3;
            // 
            // lblGhiChu
            // 
            lblGhiChu.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGhiChu.Location = new Point(294, 227);
            lblGhiChu.Name = "lblGhiChu";
            lblGhiChu.Size = new Size(124, 26);
            lblGhiChu.TabIndex = 4;
            lblGhiChu.Text = "Ghi chú:";
            // 
            // txtGhiChu
            // 
            txtGhiChu.Location = new Point(529, 224);
            txtGhiChu.Multiline = true;
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.Size = new Size(400, 80);
            txtGhiChu.TabIndex = 5;
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Segoe UI", 10F);
            btnThem.Location = new Point(479, 358);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(129, 50);
            btnThem.TabIndex = 6;
            btnThem.Text = "Thêm";
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Enabled = false;
            btnSua.Font = new Font("Segoe UI", 10F);
            btnSua.Location = new Point(635, 358);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(129, 50);
            btnSua.TabIndex = 7;
            btnSua.Text = "Sửa";
            btnSua.Click += btnSua_Click;
           // 
            // btnXoa
            // 
            btnXoa.Enabled = false;
            btnXoa.Font = new Font("Segoe UI", 10F);
            btnXoa.Location = new Point(787, 358);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(129, 50);
            btnXoa.TabIndex = 8;
            btnXoa.Text = "Xóa";
            btnXoa.Click += btnXoa_Click;
            // 
            // btnMoi
            // 
            btnMoi.Font = new Font("Segoe UI", 10F);
            btnMoi.Location = new Point(329, 358);
            btnMoi.Name = "btnMoi";
            btnMoi.Size = new Size(129, 50);
            btnMoi.TabIndex = 9;
            btnMoi.Text = "Mới";
            btnMoi.Click += btnMoi_Click;
            // 
            // tabDanhSach
            // 
            tabDanhSach.Controls.Add(dgvLoaiSanPham);
            tabDanhSach.Location = new Point(4, 37);
            tabDanhSach.Name = "tabDanhSach";
            tabDanhSach.Size = new Size(1295, 798);
            tabDanhSach.TabIndex = 1;
            tabDanhSach.Text = "DANH SÁCH";
            tabDanhSach.UseVisualStyleBackColor = true;
            // 
            // dgvLoaiSanPham
            // 
            dgvLoaiSanPham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLoaiSanPham.Dock = DockStyle.Fill;
            dgvLoaiSanPham.Location = new Point(0, 0);
            dgvLoaiSanPham.Name = "dgvLoaiSanPham";
            dgvLoaiSanPham.RowHeadersWidth = 62;
            dgvLoaiSanPham.Size = new Size(1295, 798);
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
    }
}
