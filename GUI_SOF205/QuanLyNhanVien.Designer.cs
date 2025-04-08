namespace GUI_SOF205
{
    partial class QuanLyNhanVien
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabCapNhat;
        private System.Windows.Forms.TabPage tabDanhSach;
        private System.Windows.Forms.TextBox txtMaNhanVien;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.TextBox txtXacNhanMatKhau;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.RadioButton rdoQuanly;
        private System.Windows.Forms.RadioButton rdoNhanVien;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnMoi;
        private System.Windows.Forms.Label lblMaNhanVien, lblMatKhau, lblXacNhan, lblHoTen, lblVaiTro;
        private System.Windows.Forms.DataGridView dgvNhanVien;

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
            txtEmail = new TextBox();
            lblEmail = new Label();
            lblMaNhanVien = new Label();
            txtMaNhanVien = new TextBox();
            lblMatKhau = new Label();
            txtMatKhau = new TextBox();
            lblXacNhan = new Label();
            txtXacNhanMatKhau = new TextBox();
            lblHoTen = new Label();
            txtHoTen = new TextBox();
            lblVaiTro = new Label();
            rdoQuanly = new RadioButton();
            rdoNhanVien = new RadioButton();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnMoi = new Button();
            tabDanhSach = new TabPage();
            dgvNhanVien = new DataGridView();
            lblNhanVien = new Label();
            tabControl.SuspendLayout();
            tabCapNhat.SuspendLayout();
            tabDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).BeginInit();
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
            tabCapNhat.Controls.Add(lblNhanVien);
            tabCapNhat.Controls.Add(txtEmail);
            tabCapNhat.Controls.Add(lblEmail);
            tabCapNhat.Controls.Add(lblMaNhanVien);
            tabCapNhat.Controls.Add(txtMaNhanVien);
            tabCapNhat.Controls.Add(lblMatKhau);
            tabCapNhat.Controls.Add(txtMatKhau);
            tabCapNhat.Controls.Add(lblXacNhan);
            tabCapNhat.Controls.Add(txtXacNhanMatKhau);
            tabCapNhat.Controls.Add(lblHoTen);
            tabCapNhat.Controls.Add(txtHoTen);
            tabCapNhat.Controls.Add(lblVaiTro);
            tabCapNhat.Controls.Add(rdoQuanly);
            tabCapNhat.Controls.Add(rdoNhanVien);
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
            // txtEmail
            // 
            txtEmail.Location = new Point(559, 273);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(400, 34);
            txtEmail.TabIndex = 3;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(280, 276);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(63, 28);
            lblEmail.TabIndex = 1;
            lblEmail.Text = "Email:";
            // 
            // lblMaNhanVien
            // 
            lblMaNhanVien.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMaNhanVien.Location = new Point(280, 130);
            lblMaNhanVien.Name = "lblMaNhanVien";
            lblMaNhanVien.Size = new Size(159, 35);
            lblMaNhanVien.TabIndex = 0;
            lblMaNhanVien.Text = "Mã nhân viên:";
            // 
            // txtMaNhanVien
            // 
            txtMaNhanVien.Location = new Point(559, 131);
            txtMaNhanVien.Name = "txtMaNhanVien";
            txtMaNhanVien.Size = new Size(400, 34);
            txtMaNhanVien.TabIndex = 1;
            // 
            // lblMatKhau
            // 
            lblMatKhau.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMatKhau.Location = new Point(280, 351);
            lblMatKhau.Name = "lblMatKhau";
            lblMatKhau.Size = new Size(129, 37);
            lblMatKhau.TabIndex = 2;
            lblMatKhau.Text = "Mật khẩu:";
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(559, 348);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(400, 34);
            txtMatKhau.TabIndex = 4;
            // 
            // lblXacNhan
            // 
            lblXacNhan.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblXacNhan.Location = new Point(280, 428);
            lblXacNhan.Name = "lblXacNhan";
            lblXacNhan.Size = new Size(192, 33);
            lblXacNhan.TabIndex = 4;
            lblXacNhan.Text = "Xác nhận mật khẩu:";
            // 
            // txtXacNhanMatKhau
            // 
            txtXacNhanMatKhau.Location = new Point(559, 425);
            txtXacNhanMatKhau.Name = "txtXacNhanMatKhau";
            txtXacNhanMatKhau.Size = new Size(400, 34);
            txtXacNhanMatKhau.TabIndex = 5;
            // 
            // lblHoTen
            // 
            lblHoTen.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHoTen.Location = new Point(280, 209);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(159, 32);
            lblHoTen.TabIndex = 6;
            lblHoTen.Text = "Họ và tên:";
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(559, 206);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(400, 34);
            txtHoTen.TabIndex = 2;
            // 
            // lblVaiTro
            // 
            lblVaiTro.Font = new Font("Segoe UI", 10F);
            lblVaiTro.Location = new Point(280, 498);
            lblVaiTro.Name = "lblVaiTro";
            lblVaiTro.Size = new Size(100, 23);
            lblVaiTro.TabIndex = 8;
            lblVaiTro.Text = "Vai trò:";
            // 
            // rdoQuanly
            // 
            rdoQuanly.Font = new Font("Segoe UI", 10F);
            rdoQuanly.Location = new Point(760, 494);
            rdoQuanly.Name = "rdoQuanly";
            rdoQuanly.Size = new Size(154, 37);
            rdoQuanly.TabIndex = 7;
            rdoQuanly.Text = "Quản lý";
            // 
            // rdoNhanVien
            // 
            rdoNhanVien.Checked = true;
            rdoNhanVien.Font = new Font("Segoe UI", 10F);
            rdoNhanVien.Location = new Point(559, 487);
            rdoNhanVien.Name = "rdoNhanVien";
            rdoNhanVien.Size = new Size(182, 51);
            rdoNhanVien.TabIndex = 6;
            rdoNhanVien.TabStop = true;
            rdoNhanVien.Text = "Nhân viên";
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnThem.ForeColor = Color.Green;
            btnThem.Location = new Point(327, 565);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(129, 50);
            btnThem.TabIndex = 11;
            btnThem.Text = "Thêm";
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Enabled = false;
            btnSua.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSua.ForeColor = Color.DarkOrange;
            btnSua.Location = new Point(482, 565);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(129, 50);
            btnSua.TabIndex = 12;
            btnSua.Text = "Sửa";
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Enabled = false;
            btnXoa.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnXoa.ForeColor = Color.Red;
            btnXoa.Location = new Point(636, 565);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(129, 50);
            btnXoa.TabIndex = 13;
            btnXoa.Text = "Xóa";
            // 
            // btnMoi
            // 
            btnMoi.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnMoi.ForeColor = SystemColors.Highlight;
            btnMoi.Location = new Point(794, 565);
            btnMoi.Name = "btnMoi";
            btnMoi.Size = new Size(129, 50);
            btnMoi.TabIndex = 14;
            btnMoi.Text = "Làm Mới";
            btnMoi.Click += btnMoi_Click;
            // 
            // tabDanhSach
            // 
            tabDanhSach.Controls.Add(dgvNhanVien);
            tabDanhSach.Location = new Point(4, 37);
            tabDanhSach.Name = "tabDanhSach";
            tabDanhSach.Size = new Size(1295, 653);
            tabDanhSach.TabIndex = 1;
            tabDanhSach.Text = "DANH SÁCH";
            tabDanhSach.UseVisualStyleBackColor = true;
            // 
            // dgvNhanVien
            // 
            dgvNhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNhanVien.Dock = DockStyle.Fill;
            dgvNhanVien.Location = new Point(0, 0);
            dgvNhanVien.Name = "dgvNhanVien";
            dgvNhanVien.RowHeadersWidth = 62;
            dgvNhanVien.Size = new Size(1295, 653);
            dgvNhanVien.TabIndex = 0;
            dgvNhanVien.CellClick += dgvNhanVien_CellClick;
            // 
            // lblNhanVien
            // 
            lblNhanVien.AutoSize = true;
            lblNhanVien.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNhanVien.ForeColor = SystemColors.Highlight;
            lblNhanVien.Location = new Point(506, 44);
            lblNhanVien.Name = "lblNhanVien";
            lblNhanVien.Size = new Size(200, 45);
            lblNhanVien.TabIndex = 15;
            lblNhanVien.Text = "NHÂN VIÊN";
            // 
            // QuanLyNhanVien
            // 
            ClientSize = new Size(1303, 694);
            Controls.Add(tabControl);
            Name = "QuanLyNhanVien";
            Text = "Quản Lý Nhân Viên";
            tabControl.ResumeLayout(false);
            tabCapNhat.ResumeLayout(false);
            tabCapNhat.PerformLayout();
            tabDanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).EndInit();
            ResumeLayout(false);
        }

        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblNhanVien;
    }
}
