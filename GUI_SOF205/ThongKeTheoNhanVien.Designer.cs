namespace GUI_SOF205
{
    partial class ThongKeTheoNhanVien
    {
        private System.ComponentModel.IContainer components = null;

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
            label1 = new Label();
            panel1 = new Panel();
            btnThongKe = new Button();
            dtpDenNgay = new DateTimePicker();
            dtpTuNgay = new DateTimePicker();
            label4 = new Label();
            label3 = new Label();
            cbxNhanVien = new ComboBox();
            label2 = new Label();
            dgvThongKe = new DataGridView();
            MaNhanVien = new DataGridViewTextBoxColumn();
            HoTen = new DataGridViewTextBoxColumn();
            TongTien = new DataGridViewTextBoxColumn();
            SoLy = new DataGridViewTextBoxColumn();
            SoLuongPhieu = new DataGridViewTextBoxColumn();
            NgayBan = new DataGridViewTextBoxColumn();
            DaThanhToan = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvThongKe).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(1, 1);
            label1.Name = "label1";
            label1.Size = new Size(459, 30);
            label1.TabIndex = 0;
            label1.Text = "THỐNG KÊ DOANH THU THEO NHÂN VIÊN";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnThongKe);
            panel1.Controls.Add(dtpDenNgay);
            panel1.Controls.Add(dtpTuNgay);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(cbxNhanVien);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(12, 34);
            panel1.Name = "panel1";
            panel1.Size = new Size(1294, 55);
            panel1.TabIndex = 1;
            // 
            // btnThongKe
            // 
            btnThongKe.Font = new Font("Segoe UI", 10F);
            btnThongKe.Location = new Point(1143, 6);
            btnThongKe.Name = "btnThongKe";
            btnThongKe.Size = new Size(109, 40);
            btnThongKe.TabIndex = 6;
            btnThongKe.Text = "Thống kê";
            btnThongKe.UseVisualStyleBackColor = true;
            btnThongKe.Click += btnThongKe_Click;
            // 
            // dtpDenNgay
            // 
            dtpDenNgay.Font = new Font("Segoe UI", 10F);
            dtpDenNgay.Format = DateTimePickerFormat.Short;
            dtpDenNgay.Location = new Point(891, 12);
            dtpDenNgay.MinDate = new DateTime(2000, 1, 1, 0, 0, 0, 0);
            dtpDenNgay.Name = "dtpDenNgay";
            dtpDenNgay.Size = new Size(200, 25);
            dtpDenNgay.TabIndex = 5;
            // 
            // dtpTuNgay
            // 
            dtpTuNgay.CalendarFont = new Font("Segoe UI", 10F);
            dtpTuNgay.Format = DateTimePickerFormat.Short;
            dtpTuNgay.Location = new Point(543, 14);
            dtpTuNgay.MinDate = new DateTime(2000, 1, 1, 0, 0, 0, 0);
            dtpTuNgay.Name = "dtpTuNgay";
            dtpTuNgay.Size = new Size(219, 23);
            dtpTuNgay.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(817, 15);
            label4.Name = "label4";
            label4.Size = new Size(68, 19);
            label4.TabIndex = 3;
            label4.Text = "Đến ngày";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(479, 15);
            label3.Name = "label3";
            label3.Size = new Size(58, 19);
            label3.TabIndex = 2;
            label3.Text = "Từ ngày";
            // 
            // cbxNhanVien
            // 
            cbxNhanVien.Font = new Font("Segoe UI", 10F);
            cbxNhanVien.FormattingEnabled = true;
            cbxNhanVien.Location = new Point(137, 12);
            cbxNhanVien.Name = "cbxNhanVien";
            cbxNhanVien.Size = new Size(292, 25);
            cbxNhanVien.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(33, 18);
            label2.Name = "label2";
            label2.Size = new Size(71, 19);
            label2.TabIndex = 0;
            label2.Text = "Nhân viên";
            // 
            // dgvThongKe
            // 
            dgvThongKe.AllowUserToAddRows = false;
            dgvThongKe.AllowUserToDeleteRows = false;
            dgvThongKe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvThongKe.Columns.AddRange(new DataGridViewColumn[] { MaNhanVien, HoTen, TongTien, SoLy, SoLuongPhieu, NgayBan, DaThanhToan });
            dgvThongKe.Location = new Point(12, 95);
            dgvThongKe.Name = "dgvThongKe";
            dgvThongKe.ReadOnly = true;
            dgvThongKe.Size = new Size(1294, 587);
            dgvThongKe.TabIndex = 2;
            // 
            // MaNhanVien
            // 
            MaNhanVien.HeaderText = "Mã Nhân Viên";
            MaNhanVien.Name = "MaNhanVien";
            MaNhanVien.ReadOnly = true;
            MaNhanVien.Width = 150;
            // 
            // HoTen
            // 
            HoTen.HeaderText = "Họ Tên";
            HoTen.Name = "HoTen";
            HoTen.ReadOnly = true;
            HoTen.Width = 300;
            // 
            // TongTien
            // 
            TongTien.HeaderText = "Tổng Tiền";
            TongTien.Name = "TongTien";
            TongTien.ReadOnly = true;
            // 
            // SoLy
            // 
            SoLy.HeaderText = "Số Lượng Ly";
            SoLy.Name = "SoLy";
            SoLy.ReadOnly = true;
            // 
            // SoLuongPhieu
            // 
            SoLuongPhieu.HeaderText = "Số Lượng Phiếu";
            SoLuongPhieu.Name = "SoLuongPhieu";
            SoLuongPhieu.ReadOnly = true;
            SoLuongPhieu.Width = 200;
            // 
            // NgayBan
            // 
            NgayBan.HeaderText = "Ngày Lập Phiếu";
            NgayBan.Name = "NgayBan";
            NgayBan.ReadOnly = true;
            NgayBan.Width = 300;
            // 
            // DaThanhToan
            // 
            DaThanhToan.HeaderText = "Trạng Thái";
            DaThanhToan.Name = "DaThanhToan";
            DaThanhToan.ReadOnly = true;
            // 
            // ThongKeTheoNhanVien
            // 
            ClientSize = new Size(1318, 694);
            Controls.Add(dgvThongKe);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "ThongKeTheoNhanVien";
            Text = "Thống kê doanh thu theo nhân viên";
            Load += ThongKeTheoLoaiSP_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvThongKe).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label1;
        private Panel panel1;
        private Label label2;
        private ComboBox cbxNhanVien;
        private Label label4;
        private Label label3;
        private DateTimePicker dtpDenNgay;
        private DateTimePicker dtpTuNgay;
        private Button btnThongKe;
        private DataGridView dgvThongKe;
        private DataGridViewTextBoxColumn MaNhanVien;
        private DataGridViewTextBoxColumn HoTen;
        private DataGridViewTextBoxColumn TongTien;
        private DataGridViewTextBoxColumn SoLy;
        private DataGridViewTextBoxColumn SoLuongPhieu;
        private DataGridViewTextBoxColumn NgayBan;
        private DataGridViewTextBoxColumn DaThanhToan;
    }
}
