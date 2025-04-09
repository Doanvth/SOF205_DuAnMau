namespace GUI_SOF205
{
    partial class DoiMatKhau
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoiMatKhau));
            lblMaNhanVien = new Label();
            txtMaNhanVien = new TextBox();
            lblMatKhau = new Label();
            txtMatKhauMoi = new TextBox();
            lblHoTen = new Label();
            txtMatKhauCu = new TextBox();
            btnDoiMatKhau = new Button();
            label1 = new Label();
            label2 = new Label();
            txtXacNhanMatKhau = new TextBox();
            label3 = new Label();
            txtHoTen = new TextBox();
            chkMatKhauCu = new CheckBox();
            chkMatKhauMoi = new CheckBox();
            chkXacNhanMatKhau = new CheckBox();
            SuspendLayout();
            // 
            // lblMaNhanVien
            // 
            lblMaNhanVien.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMaNhanVien.Location = new Point(169, 89);
            lblMaNhanVien.Name = "lblMaNhanVien";
            lblMaNhanVien.Size = new Size(194, 35);
            lblMaNhanVien.TabIndex = 8;
            lblMaNhanVien.Text = "Mã nhân viên:";
            // 
            // txtMaNhanVien
            // 
            txtMaNhanVien.Location = new Point(386, 85);
            txtMaNhanVien.Name = "txtMaNhanVien";
            txtMaNhanVien.ReadOnly = true;
            txtMaNhanVien.Size = new Size(444, 23);
            txtMaNhanVien.TabIndex = 9;
            // 
            // lblMatKhau
            // 
            lblMatKhau.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMatKhau.Location = new Point(169, 319);
            lblMatKhau.Name = "lblMatKhau";
            lblMatKhau.Size = new Size(129, 37);
            lblMatKhau.TabIndex = 10;
            lblMatKhau.Text = "Mật khẩu mới:";
            // 
            // txtMatKhauMoi
            // 
            txtMatKhauMoi.Location = new Point(386, 315);
            txtMatKhauMoi.Name = "txtMatKhauMoi";
            txtMatKhauMoi.PasswordChar = '*';
            txtMatKhauMoi.Size = new Size(381, 23);
            txtMatKhauMoi.TabIndex = 11;
            // 
            // lblHoTen
            // 
            lblHoTen.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHoTen.Location = new Point(169, 239);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(159, 32);
            lblHoTen.TabIndex = 12;
            lblHoTen.Text = "Mật khẩu cũ:";
            // 
            // txtMatKhauCu
            // 
            txtMatKhauCu.Location = new Point(386, 235);
            txtMatKhauCu.Name = "txtMatKhauCu";
            txtMatKhauCu.PasswordChar = '*';
            txtMatKhauCu.Size = new Size(381, 23);
            txtMatKhauCu.TabIndex = 13;
            // 
            // btnDoiMatKhau
            // 
            btnDoiMatKhau.Font = new Font("Segoe UI", 10F);
            btnDoiMatKhau.Image = Properties.Resources.arrows1;
            btnDoiMatKhau.ImageAlign = ContentAlignment.TopCenter;
            btnDoiMatKhau.Location = new Point(408, 470);
            btnDoiMatKhau.Name = "btnDoiMatKhau";
            btnDoiMatKhau.Size = new Size(129, 50);
            btnDoiMatKhau.TabIndex = 15;
            btnDoiMatKhau.Text = "Đổi mật khẩu";
            btnDoiMatKhau.TextAlign = ContentAlignment.BottomCenter;
            btnDoiMatKhau.Click += btnDoiMatKhau_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(2, 3);
            label1.Name = "label1";
            label1.Size = new Size(176, 30);
            label1.TabIndex = 16;
            label1.Text = "ĐỔI MẬT KHẨU";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(169, 390);
            label2.Name = "label2";
            label2.Size = new Size(129, 37);
            label2.TabIndex = 17;
            label2.Text = "Xác nhận mật khẩu:";
            // 
            // txtXacNhanMatKhau
            // 
            txtXacNhanMatKhau.Location = new Point(386, 389);
            txtXacNhanMatKhau.Name = "txtXacNhanMatKhau";
            txtXacNhanMatKhau.PasswordChar = '*';
            txtXacNhanMatKhau.Size = new Size(381, 23);
            txtXacNhanMatKhau.TabIndex = 18;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(169, 168);
            label3.Name = "label3";
            label3.Size = new Size(194, 35);
            label3.TabIndex = 19;
            label3.Text = "Tên nhân viên:";
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(386, 164);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.ReadOnly = true;
            txtHoTen.Size = new Size(444, 23);
            txtHoTen.TabIndex = 20;
            // 
            // chkMatKhauCu
            // 
            chkMatKhauCu.AutoSize = true;
            chkMatKhauCu.Location = new Point(773, 237);
            chkMatKhauCu.Name = "chkMatKhauCu";
            chkMatKhauCu.Size = new Size(68, 19);
            chkMatKhauCu.TabIndex = 21;
            chkMatKhauCu.Text = "Hiển thị";
            chkMatKhauCu.UseVisualStyleBackColor = true;
            chkMatKhauCu.CheckedChanged += chkMatKhauCu_CheckedChanged;
            // 
            // chkMatKhauMoi
            // 
            chkMatKhauMoi.AutoSize = true;
            chkMatKhauMoi.Location = new Point(773, 319);
            chkMatKhauMoi.Name = "chkMatKhauMoi";
            chkMatKhauMoi.Size = new Size(68, 19);
            chkMatKhauMoi.TabIndex = 22;
            chkMatKhauMoi.Text = "Hiển thị";
            chkMatKhauMoi.UseVisualStyleBackColor = true;
            chkMatKhauMoi.CheckedChanged += chkMatKhauMoi_CheckedChanged;
            // 
            // chkXacNhanMatKhau
            // 
            chkXacNhanMatKhau.AutoSize = true;
            chkXacNhanMatKhau.Location = new Point(773, 391);
            chkXacNhanMatKhau.Name = "chkXacNhanMatKhau";
            chkXacNhanMatKhau.Size = new Size(68, 19);
            chkXacNhanMatKhau.TabIndex = 23;
            chkXacNhanMatKhau.Text = "Hiển thị";
            chkXacNhanMatKhau.UseVisualStyleBackColor = true;
            chkXacNhanMatKhau.CheckedChanged += chkXacNhanMatKhau_CheckedChanged;
            // 
            // DoiMatKhau
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(963, 562);
            Controls.Add(chkXacNhanMatKhau);
            Controls.Add(chkMatKhauMoi);
            Controls.Add(chkMatKhauCu);
            Controls.Add(label3);
            Controls.Add(txtHoTen);
            Controls.Add(label2);
            Controls.Add(txtXacNhanMatKhau);
            Controls.Add(label1);
            Controls.Add(btnDoiMatKhau);
            Controls.Add(lblMaNhanVien);
            Controls.Add(txtMaNhanVien);
            Controls.Add(lblMatKhau);
            Controls.Add(txtMatKhauMoi);
            Controls.Add(lblHoTen);
            Controls.Add(txtMatKhauCu);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "DoiMatKhau";
            Text = "DoiMatKhau";
            Load += DoiMatKhau_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMaNhanVien;
        private TextBox txtMaNhanVien;
        private Label lblMatKhau;
        private TextBox txtMatKhauMoi;
        private Label lblHoTen;
        private TextBox txtMatKhauCu;
        private Button btnDoiMatKhau;
        private Label label1;
        private Label label2;
        private TextBox txtXacNhanMatKhau;
        private Label label3;
        private TextBox txtHoTen;
        private CheckBox chkMatKhauCu;
        private CheckBox chkMatKhauMoi;
        private CheckBox chkXacNhanMatKhau;
    }
}