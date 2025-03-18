namespace GUI_SOF205
{
    partial class MainScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
            menuStrip1 = new MenuStrip();
            tàiKhoảnToolStripMenuItem = new ToolStripMenuItem();
            itmDoiMatKhau = new ToolStripMenuItem();
            itmDangXuat = new ToolStripMenuItem();
            quảnLýToolStripMenuItem = new ToolStripMenuItem();
            itmQLNhanVien = new ToolStripMenuItem();
            itmQLTheLuuDong = new ToolStripMenuItem();
            itmQLLoaiSanPham = new ToolStripMenuItem();
            itmQLSanPham = new ToolStripMenuItem();
            itmQLPhieuBanHang = new ToolStripMenuItem();
            itmStatisticByPT = new ToolStripMenuItem();
            itmTKTheoLoaiSP = new ToolStripMenuItem();
            itmTKTheoNV = new ToolStripMenuItem();
            hỗTrợToolStripMenuItem = new ToolStripMenuItem();
            itmTroGiup = new ToolStripMenuItem();
            itmGioiThieu = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            toolStripStatusLabel3 = new ToolStripStatusLabel();
            toolStripStatusLabel2 = new ToolStripStatusLabel();
            toolStrip1 = new ToolStrip();
            btnDangXuat = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btnQLNhanVien = new ToolStripButton();
            btnQLPhieuBanHang = new ToolStripButton();
            btnQLSanPham = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            btnGioiThieu = new ToolStripButton();
            lblAccount = new ToolStripLabel();
            pnlFormContainer = new Panel();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { tàiKhoảnToolStripMenuItem, quảnLýToolStripMenuItem, itmStatisticByPT, hỗTrợToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(923, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // tàiKhoảnToolStripMenuItem
            // 
            tàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { itmDoiMatKhau, itmDangXuat });
            tàiKhoảnToolStripMenuItem.Name = "tàiKhoảnToolStripMenuItem";
            tàiKhoảnToolStripMenuItem.Size = new Size(70, 20);
            tàiKhoảnToolStripMenuItem.Text = "Tài khoản";
            // 
            // itmDoiMatKhau
            // 
            itmDoiMatKhau.Image = Properties.Resources.arrows1;
            itmDoiMatKhau.Name = "itmDoiMatKhau";
            itmDoiMatKhau.Size = new Size(145, 22);
            itmDoiMatKhau.Text = "Đổi mật khẩu";
            // 
            // itmDangXuat
            // 
            itmDangXuat.Image = Properties.Resources.exit;
            itmDangXuat.Name = "itmDangXuat";
            itmDangXuat.Size = new Size(145, 22);
            itmDangXuat.Text = "Đăng xuất";
            // 
            // quảnLýToolStripMenuItem
            // 
            quảnLýToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { itmQLNhanVien, itmQLTheLuuDong, itmQLLoaiSanPham, itmQLSanPham, itmQLPhieuBanHang });
            quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            quảnLýToolStripMenuItem.Size = new Size(60, 20);
            quảnLýToolStripMenuItem.Text = "Quản lý";
            // 
            // itmQLNhanVien
            // 
            itmQLNhanVien.Image = Properties.Resources.Couple;
            itmQLNhanVien.Name = "itmQLNhanVien";
            itmQLNhanVien.Size = new Size(209, 30);
            itmQLNhanVien.Text = "Quản lý nhân viên";
            itmQLNhanVien.Click += quảnLýNhânViênToolStripMenuItem_Click;
            // 
            // itmQLTheLuuDong
            // 
            itmQLTheLuuDong.Image = Properties.Resources.webpage;
            itmQLTheLuuDong.Name = "itmQLTheLuuDong";
            itmQLTheLuuDong.Size = new Size(209, 30);
            itmQLTheLuuDong.Text = "Quản lý thẻ lưu động";
            // 
            // itmQLLoaiSanPham
            // 
            itmQLLoaiSanPham.Image = Properties.Resources.Packing1;
            itmQLLoaiSanPham.Name = "itmQLLoaiSanPham";
            itmQLLoaiSanPham.Size = new Size(209, 30);
            itmQLLoaiSanPham.Text = "Quản lý loại sản phẩm";
            itmQLLoaiSanPham.Click += quảnLýLoạiSảnPhẩmToolStripMenuItem_Click;
            // 
            // itmQLSanPham
            // 
            itmQLSanPham.Image = Properties.Resources.coffee;
            itmQLSanPham.Name = "itmQLSanPham";
            itmQLSanPham.Size = new Size(209, 30);
            itmQLSanPham.Text = "Quản lý sản phẩm";
            itmQLSanPham.Click += quảnLýSảnPhẩmToolStripMenuItem_Click;
            // 
            // itmQLPhieuBanHang
            // 
            itmQLPhieuBanHang.Image = Properties.Resources.Order_history;
            itmQLPhieuBanHang.Name = "itmQLPhieuBanHang";
            itmQLPhieuBanHang.Size = new Size(209, 30);
            itmQLPhieuBanHang.Text = "Quản lý phiếu bán hàng";
            itmQLPhieuBanHang.Click += quảnLýPhiếuBánHàngToolStripMenuItem_Click;
            // 
            // itmStatisticByPT
            // 
            itmStatisticByPT.DropDownItems.AddRange(new ToolStripItem[] { itmTKTheoLoaiSP, itmTKTheoNV });
            itmStatisticByPT.Name = "itmStatisticByPT";
            itmStatisticByPT.Size = new Size(69, 20);
            itmStatisticByPT.Text = "Thống kê";
            // 
            // itmTKTheoLoaiSP
            // 
            itmTKTheoLoaiSP.Image = Properties.Resources.Product_sale_report;
            itmTKTheoLoaiSP.Name = "itmTKTheoLoaiSP";
            itmTKTheoLoaiSP.Size = new Size(234, 22);
            itmTKTheoLoaiSP.Text = "Doanh thu theo loại sản phẩm";
            // 
            // itmTKTheoNV
            // 
            itmTKTheoNV.Image = Properties.Resources.Distributor_report;
            itmTKTheoNV.Name = "itmTKTheoNV";
            itmTKTheoNV.Size = new Size(234, 22);
            itmTKTheoNV.Text = "Doanh thu theo nhân viên";
            // 
            // hỗTrợToolStripMenuItem
            // 
            hỗTrợToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { itmTroGiup, itmGioiThieu });
            hỗTrợToolStripMenuItem.Name = "hỗTrợToolStripMenuItem";
            hỗTrợToolStripMenuItem.Size = new Size(53, 20);
            hỗTrợToolStripMenuItem.Text = "Hỗ trợ";
            // 
            // itmTroGiup
            // 
            itmTroGiup.Image = Properties.Resources.application;
            itmTroGiup.Name = "itmTroGiup";
            itmTroGiup.Size = new Size(125, 22);
            itmTroGiup.Text = "Trợ giúp";
            // 
            // itmGioiThieu
            // 
            itmGioiThieu.Image = Properties.Resources.information;
            itmGioiThieu.Name = "itmGioiThieu";
            itmGioiThieu.Size = new Size(125, 22);
            itmGioiThieu.Text = "Giới thiệu";
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(24, 24);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, toolStripStatusLabel3, toolStripStatusLabel2 });
            statusStrip1.Location = new Point(0, 487);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(923, 29);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Image = Properties.Resources.fpt1;
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(173, 24);
            toolStripStatusLabel1.Text = "Hệ thống quản lý PolyCafe";
            // 
            // toolStripStatusLabel3
            // 
            toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            toolStripStatusLabel3.Size = new Size(640, 24);
            toolStripStatusLabel3.Spring = true;
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.Image = Properties.Resources.Alarm_clock;
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.RightToLeft = RightToLeft.No;
            toolStripStatusLabel2.Size = new Size(95, 24);
            toolStripStatusLabel2.Text = "10:25:30 AM";
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(32, 32);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnDangXuat, toolStripSeparator1, btnQLNhanVien, btnQLPhieuBanHang, btnQLSanPham, toolStripSeparator2, btnGioiThieu, lblAccount });
            toolStrip1.Location = new Point(0, 24);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Padding = new Padding(0, 0, 2, 0);
            toolStrip1.Size = new Size(923, 39);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnDangXuat
            // 
            btnDangXuat.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnDangXuat.Image = Properties.Resources.exit;
            btnDangXuat.ImageTransparentColor = Color.Magenta;
            btnDangXuat.Margin = new Padding(2, 1, 2, 2);
            btnDangXuat.Name = "btnDangXuat";
            btnDangXuat.Size = new Size(36, 36);
            btnDangXuat.Text = "Đăng xuất";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 39);
            // 
            // btnQLNhanVien
            // 
            btnQLNhanVien.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnQLNhanVien.Image = Properties.Resources.users;
            btnQLNhanVien.ImageTransparentColor = Color.Magenta;
            btnQLNhanVien.Margin = new Padding(2, 1, 2, 2);
            btnQLNhanVien.Name = "btnQLNhanVien";
            btnQLNhanVien.Size = new Size(36, 36);
            btnQLNhanVien.Text = "Khách hàng";
            // 
            // btnQLPhieuBanHang
            // 
            btnQLPhieuBanHang.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnQLPhieuBanHang.Image = Properties.Resources.Order_history;
            btnQLPhieuBanHang.ImageTransparentColor = Color.Magenta;
            btnQLPhieuBanHang.Margin = new Padding(2, 1, 2, 2);
            btnQLPhieuBanHang.Name = "btnQLPhieuBanHang";
            btnQLPhieuBanHang.Size = new Size(36, 36);
            btnQLPhieuBanHang.Text = "Phiếu bán hàng";
            // 
            // btnQLSanPham
            // 
            btnQLSanPham.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnQLSanPham.Image = Properties.Resources.coffee;
            btnQLSanPham.ImageTransparentColor = Color.Magenta;
            btnQLSanPham.Margin = new Padding(2, 1, 2, 2);
            btnQLSanPham.Name = "btnQLSanPham";
            btnQLSanPham.Size = new Size(36, 36);
            btnQLSanPham.Text = "Sản phẩm";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 39);
            // 
            // btnGioiThieu
            // 
            btnGioiThieu.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnGioiThieu.Image = Properties.Resources.information;
            btnGioiThieu.ImageTransparentColor = Color.Magenta;
            btnGioiThieu.Margin = new Padding(2, 1, 2, 2);
            btnGioiThieu.Name = "btnGioiThieu";
            btnGioiThieu.Size = new Size(36, 36);
            btnGioiThieu.Text = "Hỗ trợ";
            // 
            // lblAccount
            // 
            lblAccount.Alignment = ToolStripItemAlignment.Right;
            lblAccount.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblAccount.Margin = new Padding(0, 1, 5, 2);
            lblAccount.Name = "lblAccount";
            lblAccount.Size = new Size(53, 36);
            lblAccount.Text = "Admin";
            // 
            // pnlFormContainer
            // 
            pnlFormContainer.AutoSize = true;
            pnlFormContainer.Location = new Point(0, 66);
            pnlFormContainer.Name = "pnlFormContainer";
            pnlFormContainer.Size = new Size(924, 420);
            pnlFormContainer.TabIndex = 3;
            // 
            // MainScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(923, 516);
            Controls.Add(pnlFormContainer);
            Controls.Add(toolStrip1);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "MainScreen";
            Text = "Trang chủ";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem tàiKhoảnToolStripMenuItem;
        private ToolStripMenuItem quảnLýToolStripMenuItem;
        private ToolStripMenuItem itmStatisticByPT;
        private ToolStripMenuItem hỗTrợToolStripMenuItem;
        private ToolStripMenuItem itmDoiMatKhau;
        private ToolStripMenuItem itmDangXuat;
        private ToolStripMenuItem itmQLNhanVien;
        private ToolStripMenuItem itmQLTheLuuDong;
        private ToolStripMenuItem itmQLLoaiSanPham;
        private ToolStripMenuItem itmQLSanPham;
        private ToolStripMenuItem itmQLPhieuBanHang;
        private ToolStripMenuItem itmTKTheoLoaiSP;
        private ToolStripMenuItem itmTKTheoNV;
        private ToolStripMenuItem itmTroGiup;
        private ToolStripMenuItem itmGioiThieu;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel toolStripStatusLabel3;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private ToolStrip toolStrip1;
        private ToolStripButton btnQLNhanVien;
        private ToolStripButton btnQLPhieuBanHang;
        private ToolStripButton btnDangXuat;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btnQLSanPham;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton btnGioiThieu;
        private ToolStripLabel lblAccount;
        private Panel pnlFormContainer;
    }
}