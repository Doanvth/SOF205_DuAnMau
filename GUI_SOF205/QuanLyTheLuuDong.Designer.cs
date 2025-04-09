namespace GUI_SOF205
{
    partial class QuanLyTheLuuDong
    {
        private void InitializeComponent()
        {
            tabTheLuuDong = new TabControl();
            tabPage1 = new TabPage();
            lblTheLuuDong = new Label();
            lblMaThe = new Label();
            txtMaThe = new TextBox();
            lblChuSoHuu = new Label();
            txtChuSoHuu = new TextBox();
            lblTrangThai = new Label();
            chkTrangThai = new CheckBox();
            btnThemThe = new Button();
            btnSuaThe = new Button();
            btnXoaThe = new Button();
            btnMoiThe = new Button();
            tabPage2 = new TabPage();
            dgvDSTheLuuDong = new DataGridView();
            tabTheLuuDong.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDSTheLuuDong).BeginInit();
            SuspendLayout();
            // 
            // tabTheLuuDong
            // 
            tabTheLuuDong.Controls.Add(tabPage1);
            tabTheLuuDong.Controls.Add(tabPage2);
            tabTheLuuDong.Location = new Point(4, 4);
            tabTheLuuDong.Name = "tabTheLuuDong";
            tabTheLuuDong.SelectedIndex = 0;
            tabTheLuuDong.Size = new Size(1287, 689);
            tabTheLuuDong.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(lblTheLuuDong);
            tabPage1.Controls.Add(lblMaThe);
            tabPage1.Controls.Add(txtMaThe);
            tabPage1.Controls.Add(lblChuSoHuu);
            tabPage1.Controls.Add(txtChuSoHuu);
            tabPage1.Controls.Add(lblTrangThai);
            tabPage1.Controls.Add(chkTrangThai);
            tabPage1.Controls.Add(btnThemThe);
            tabPage1.Controls.Add(btnSuaThe);
            tabPage1.Controls.Add(btnXoaThe);
            tabPage1.Controls.Add(btnMoiThe);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1279, 661);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "CẬP NHẬT";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblTheLuuDong
            // 
            lblTheLuuDong.AutoSize = true;
            lblTheLuuDong.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTheLuuDong.ForeColor = SystemColors.Highlight;
            lblTheLuuDong.Location = new Point(498, 44);
            lblTheLuuDong.Name = "lblTheLuuDong";
            lblTheLuuDong.Size = new Size(177, 30);
            lblTheLuuDong.TabIndex = 21;
            lblTheLuuDong.Text = "THẺ LƯU ĐỘNG";
            // 
            // lblMaThe
            // 
            lblMaThe.Location = new Point(365, 130);
            lblMaThe.Name = "lblMaThe";
            lblMaThe.Size = new Size(132, 34);
            lblMaThe.TabIndex = 11;
            lblMaThe.Text = "Mã Thẻ:";
            // 
            // txtMaThe
            // 
            txtMaThe.Location = new Point(577, 127);
            txtMaThe.Name = "txtMaThe";
            txtMaThe.ReadOnly = true;
            txtMaThe.Size = new Size(286, 23);
            txtMaThe.TabIndex = 12;
            // 
            // lblChuSoHuu
            // 
            lblChuSoHuu.Location = new Point(365, 197);
            lblChuSoHuu.Name = "lblChuSoHuu";
            lblChuSoHuu.Size = new Size(132, 29);
            lblChuSoHuu.TabIndex = 13;
            lblChuSoHuu.Text = "Chủ Sở Hữu:";
            // 
            // txtChuSoHuu
            // 
            txtChuSoHuu.Location = new Point(577, 194);
            txtChuSoHuu.Name = "txtChuSoHuu";
            txtChuSoHuu.Size = new Size(286, 23);
            txtChuSoHuu.TabIndex = 14;
            // 
            // lblTrangThai
            // 
            lblTrangThai.Location = new Point(365, 263);
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(108, 31);
            lblTrangThai.TabIndex = 15;
            lblTrangThai.Text = "Trạng Thái:";
            // 
            // chkTrangThai
            // 
            chkTrangThai.Location = new Point(577, 251);
            chkTrangThai.Name = "chkTrangThai";
            chkTrangThai.Size = new Size(135, 50);
            chkTrangThai.TabIndex = 16;
            chkTrangThai.Text = "Hoạt động";
            // 
            // btnThemThe
            // 
            btnThemThe.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnThemThe.ForeColor = Color.Green;
            btnThemThe.Location = new Point(290, 321);
            btnThemThe.Name = "btnThemThe";
            btnThemThe.Size = new Size(129, 50);
            btnThemThe.TabIndex = 17;
            btnThemThe.Text = "Thêm";
            btnThemThe.Click += btnThemThe_Click;
            // 
            // btnSuaThe
            // 
            btnSuaThe.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSuaThe.ForeColor = Color.DarkOrange;
            btnSuaThe.Location = new Point(487, 321);
            btnSuaThe.Name = "btnSuaThe";
            btnSuaThe.Size = new Size(129, 50);
            btnSuaThe.TabIndex = 18;
            btnSuaThe.Text = "Sửa";
            btnSuaThe.Click += btnSuaThe_Click;
            // 
            // btnXoaThe
            // 
            btnXoaThe.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnXoaThe.ForeColor = Color.Red;
            btnXoaThe.Location = new Point(685, 321);
            btnXoaThe.Name = "btnXoaThe";
            btnXoaThe.Size = new Size(129, 50);
            btnXoaThe.TabIndex = 19;
            btnXoaThe.Text = "Xóa";
            btnXoaThe.Click += btnXoaThe_Click;
            // 
            // btnMoiThe
            // 
            btnMoiThe.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnMoiThe.ForeColor = SystemColors.MenuHighlight;
            btnMoiThe.Location = new Point(872, 321);
            btnMoiThe.Name = "btnMoiThe";
            btnMoiThe.Size = new Size(129, 50);
            btnMoiThe.TabIndex = 20;
            btnMoiThe.Text = "Mới";
            btnMoiThe.Click += btnMoiThe_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dgvDSTheLuuDong);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1279, 661);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "DANH SÁCH";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvDSTheLuuDong
            // 
            dgvDSTheLuuDong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDSTheLuuDong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDSTheLuuDong.Location = new Point(4, 6);
            dgvDSTheLuuDong.Name = "dgvDSTheLuuDong";
            dgvDSTheLuuDong.RowHeadersWidth = 62;
            dgvDSTheLuuDong.Size = new Size(1269, 639);
            dgvDSTheLuuDong.TabIndex = 0;
            dgvDSTheLuuDong.CellClick += dgvDSTheLuuDong_CellClick;
            // 
            // QuanLyTheLuuDong
            // 
            ClientSize = new Size(1303, 694);
            Controls.Add(tabTheLuuDong);
            Name = "QuanLyTheLuuDong";
            Text = "Quản Lý Thẻ Lưu Động";
            Load += QuanLyTheLuuDong_Load;
            tabTheLuuDong.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDSTheLuuDong).EndInit();
            ResumeLayout(false);
        }

        private TabControl tabTheLuuDong;
        private TabPage tabPage1;
        private Label lblMaThe;
        private TextBox txtMaThe;
        private Label lblChuSoHuu;
        private TextBox txtChuSoHuu;
        private Label lblTrangThai;
        private CheckBox chkTrangThai;
        private Button btnThemThe;
        private Button btnSuaThe;
        private Button btnXoaThe;
        private Button btnMoiThe;
        private TabPage tabPage2;
        private DataGridView dgvDSTheLuuDong;
        private Label lblTheLuuDong;
        private object components;
    }
}