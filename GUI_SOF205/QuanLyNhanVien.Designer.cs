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
            // 
            // tabCapNhat
            // 
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
            // lblMaNhanVien
            // 
            lblMaNhanVien.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMaNhanVien.Location = new Point(220, 57);
            lblMaNhanVien.Name = "lblMaNhanVien";
            lblMaNhanVien.Size = new Size(194, 35);
            lblMaNhanVien.TabIndex = 0;
            lblMaNhanVien.Text = "Mã nhân viên:";
            // 
            // txtMaNhanVien
            // 
            txtMaNhanVien.Location = new Point(599, 54);
            txtMaNhanVien.Name = "txtMaNhanVien";
            txtMaNhanVien.Size = new Size(400, 34);
            txtMaNhanVien.TabIndex = 1;
            // 
            // lblMatKhau
            // 
            lblMatKhau.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMatKhau.Location = new Point(220, 220);
            lblMatKhau.Name = "lblMatKhau";
            lblMatKhau.Size = new Size(129, 37);
            lblMatKhau.TabIndex = 2;
            lblMatKhau.Text = "Mật khẩu:";
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(599, 217);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(400, 34);
            txtMatKhau.TabIndex = 3;
            // 
            // lblXacNhan
            // 
            lblXacNhan.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblXacNhan.Location = new Point(220, 303);
            lblXacNhan.Name = "lblXacNhan";
            lblXacNhan.Size = new Size(242, 33);
            lblXacNhan.TabIndex = 4;
            lblXacNhan.Text = "Xác nhận mật khẩu:";
            // 
            // txtXacNhanMatKhau
            // 
            txtXacNhanMatKhau.Location = new Point(599, 300);
            txtXacNhanMatKhau.Name = "txtXacNhanMatKhau";
            txtXacNhanMatKhau.Size = new Size(400, 34);
            txtXacNhanMatKhau.TabIndex = 5;
            // 
            // lblHoTen
            // 
            lblHoTen.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHoTen.Location = new Point(220, 140);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(159, 32);
            lblHoTen.TabIndex = 6;
            lblHoTen.Text = "Họ và tên:";
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(599, 137);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(400, 34);
            txtHoTen.TabIndex = 7;
            // 
            // lblVaiTro
            // 
            lblVaiTro.Font = new Font("Segoe UI", 10F);
            lblVaiTro.Location = new Point(224, 391);
            lblVaiTro.Name = "lblVaiTro";
            lblVaiTro.Size = new Size(100, 23);
            lblVaiTro.TabIndex = 8;
            lblVaiTro.Text = "Vai trò:";
            // 
            // rdoQuanly
            // 
            rdoQuanly.Font = new Font("Segoe UI", 10F);
            rdoQuanly.Location = new Point(795, 387);
            rdoQuanly.Name = "rdoQuanly";
            rdoQuanly.Size = new Size(154, 37);
            rdoQuanly.TabIndex = 9;
            rdoQuanly.Text = "Quản lý";
            // 
            // rdoNhanVien
            // 
            rdoNhanVien.Checked = true;
            rdoNhanVien.Font = new Font("Segoe UI", 10F);
            rdoNhanVien.Location = new Point(599, 380);
            rdoNhanVien.Name = "rdoNhanVien";
            rdoNhanVien.Size = new Size(182, 51);
            rdoNhanVien.TabIndex = 10;
            rdoNhanVien.TabStop = true;
            rdoNhanVien.Text = "Nhân viên";
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Segoe UI", 10F);
            btnThem.Location = new Point(457, 490);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(129, 50);
            btnThem.TabIndex = 11;
            btnThem.Text = "Thêm";
            // 
            // btnSua
            // 
            btnSua.Enabled = false;
            btnSua.Font = new Font("Segoe UI", 10F);
            btnSua.Location = new Point(637, 490);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(129, 50);
            btnSua.TabIndex = 12;
            btnSua.Text = "Sửa";
            // 
            // btnXoa
            // 
            btnXoa.Enabled = false;
            btnXoa.Font = new Font("Segoe UI", 10F);
            btnXoa.Location = new Point(820, 490);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(129, 50);
            btnXoa.TabIndex = 13;
            btnXoa.Text = "Xóa";
            // 
            // btnMoi
            // 
            btnMoi.Font = new Font("Segoe UI", 10F);
            btnMoi.Location = new Point(276, 490);
            btnMoi.Name = "btnMoi";
            btnMoi.Size = new Size(129, 50);
            btnMoi.TabIndex = 14;
            btnMoi.Text = "Mới";
            // 
            // tabDanhSach
            // 
            tabDanhSach.Controls.Add(dgvNhanVien);
            tabDanhSach.Location = new Point(4, 37);
            tabDanhSach.Name = "tabDanhSach";
            tabDanhSach.Size = new Size(1295, 798);
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
            dgvNhanVien.Size = new Size(1295, 798);
            dgvNhanVien.TabIndex = 0;
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
    }
}
