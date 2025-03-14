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
            MenuDoiMatKhau = new ToolStripMenuItem();
            MenuDangXuat = new ToolStripMenuItem();
            quảnLýToolStripMenuItem = new ToolStripMenuItem();
            MenuQLNhanVien = new ToolStripMenuItem();
            MenuQLTheLuuDong = new ToolStripMenuItem();
            MenuQLLoaiSanPham = new ToolStripMenuItem();
            MenuQLSanPham = new ToolStripMenuItem();
            MenuQLPhieuBanHang = new ToolStripMenuItem();
            thốngKêToolStripMenuItem = new ToolStripMenuItem();
            MenuTKTheoLoaiSP = new ToolStripMenuItem();
            MenuTKTheoNhanVien = new ToolStripMenuItem();
            hỗTrợToolStripMenuItem = new ToolStripMenuItem();
            MenuTroGiup = new ToolStripMenuItem();
            MenuGioiThieu = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            toolStripStatusLabel3 = new ToolStripStatusLabel();
            lblDongHo = new ToolStripStatusLabel();
            toolStrip1 = new ToolStrip();
            btnDangXuat = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btnQLTheLuuDong = new ToolStripButton();
            btnTKTheoNhanVien = new ToolStripButton();
            btnQLSanPham = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            btnGioiThieu = new ToolStripButton();
            lblTaiKhoan = new ToolStripLabel();
            pnlFormContainer = new Panel();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { tàiKhoảnToolStripMenuItem, quảnLýToolStripMenuItem, thốngKêToolStripMenuItem, hỗTrợToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(941, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // tàiKhoảnToolStripMenuItem
            // 
            tàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { MenuDoiMatKhau, MenuDangXuat });
            tàiKhoảnToolStripMenuItem.Name = "tàiKhoảnToolStripMenuItem";
            tàiKhoảnToolStripMenuItem.Size = new Size(70, 20);
            tàiKhoảnToolStripMenuItem.Text = "Tài khoản";
            // 
            // MenuDoiMatKhau
            // 
            MenuDoiMatKhau.Image = Properties.Resources.arrows1;
            MenuDoiMatKhau.Name = "MenuDoiMatKhau";
            MenuDoiMatKhau.Size = new Size(180, 22);
            MenuDoiMatKhau.Text = "Đổi mật khẩu";
            // 
            // MenuDangXuat
            // 
            MenuDangXuat.Image = Properties.Resources.exit;
            MenuDangXuat.Name = "MenuDangXuat";
            MenuDangXuat.Size = new Size(180, 22);
            MenuDangXuat.Text = "Đăng xuất";
            MenuDangXuat.Click += MenuDangXuat_Click;
            // 
            // quảnLýToolStripMenuItem
            // 
            quảnLýToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { MenuQLNhanVien, MenuQLTheLuuDong, MenuQLLoaiSanPham, MenuQLSanPham, MenuQLPhieuBanHang });
            quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            quảnLýToolStripMenuItem.Size = new Size(60, 20);
            quảnLýToolStripMenuItem.Text = "Quản lý";
            // 
            // MenuQLNhanVien
            // 
            MenuQLNhanVien.Image = Properties.Resources.Couple;
            MenuQLNhanVien.Name = "MenuQLNhanVien";
            MenuQLNhanVien.Size = new Size(201, 22);
            MenuQLNhanVien.Text = "Quản lý nhân viên";
            // 
            // MenuQLTheLuuDong
            // 
            MenuQLTheLuuDong.Image = Properties.Resources.webpage;
            MenuQLTheLuuDong.Name = "MenuQLTheLuuDong";
            MenuQLTheLuuDong.Size = new Size(201, 22);
            MenuQLTheLuuDong.Text = "Quản lý thẻ lưu động";
            // 
            // MenuQLLoaiSanPham
            // 
            MenuQLLoaiSanPham.Image = Properties.Resources.Packing1;
            MenuQLLoaiSanPham.Name = "MenuQLLoaiSanPham";
            MenuQLLoaiSanPham.Size = new Size(201, 22);
            MenuQLLoaiSanPham.Text = "Quản lý loại sản phẩm";
            // 
            // MenuQLSanPham
            // 
            MenuQLSanPham.Image = Properties.Resources.coffee;
            MenuQLSanPham.Name = "MenuQLSanPham";
            MenuQLSanPham.Size = new Size(201, 22);
            MenuQLSanPham.Text = "Quản lý sản phẩm";
            // 
            // MenuQLPhieuBanHang
            // 
            MenuQLPhieuBanHang.Image = Properties.Resources.Order_history;
            MenuQLPhieuBanHang.Name = "MenuQLPhieuBanHang";
            MenuQLPhieuBanHang.Size = new Size(201, 22);
            MenuQLPhieuBanHang.Text = "Quản lý phiếu bán hàng";
            // 
            // thốngKêToolStripMenuItem
            // 
            thốngKêToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { MenuTKTheoLoaiSP, MenuTKTheoNhanVien });
            thốngKêToolStripMenuItem.Name = "thốngKêToolStripMenuItem";
            thốngKêToolStripMenuItem.Size = new Size(69, 20);
            thốngKêToolStripMenuItem.Text = "Thống kê";
            // 
            // MenuTKTheoLoaiSP
            // 
            MenuTKTheoLoaiSP.Image = Properties.Resources.Product_sale_report;
            MenuTKTheoLoaiSP.Name = "MenuTKTheoLoaiSP";
            MenuTKTheoLoaiSP.Size = new Size(234, 22);
            MenuTKTheoLoaiSP.Text = "Doanh thu theo loại sản phẩm";
            // 
            // MenuTKTheoNhanVien
            // 
            MenuTKTheoNhanVien.Image = Properties.Resources.Distributor_report;
            MenuTKTheoNhanVien.Name = "MenuTKTheoNhanVien";
            MenuTKTheoNhanVien.Size = new Size(234, 22);
            MenuTKTheoNhanVien.Text = "Doanh thu theo nhân viên";
            // 
            // hỗTrợToolStripMenuItem
            // 
            hỗTrợToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { MenuTroGiup, MenuGioiThieu });
            hỗTrợToolStripMenuItem.Name = "hỗTrợToolStripMenuItem";
            hỗTrợToolStripMenuItem.Size = new Size(53, 20);
            hỗTrợToolStripMenuItem.Text = "Hỗ trợ";
            // 
            // MenuTroGiup
            // 
            MenuTroGiup.Image = Properties.Resources.application;
            MenuTroGiup.Name = "MenuTroGiup";
            MenuTroGiup.Size = new Size(125, 22);
            MenuTroGiup.Text = "Trợ giúp";
            // 
            // MenuGioiThieu
            // 
            MenuGioiThieu.Image = Properties.Resources.information;
            MenuGioiThieu.Name = "MenuGioiThieu";
            MenuGioiThieu.Size = new Size(125, 22);
            MenuGioiThieu.Text = "Giới thiệu";
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, toolStripStatusLabel3, lblDongHo });
            statusStrip1.Location = new Point(0, 483);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(941, 22);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Image = Properties.Resources.fpt1;
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(165, 17);
            toolStripStatusLabel1.Text = "Hệ thống quản lý PolyCafe";
            // 
            // toolStripStatusLabel3
            // 
            toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            toolStripStatusLabel3.Size = new Size(674, 17);
            toolStripStatusLabel3.Spring = true;
            // 
            // lblDongHo
            // 
            lblDongHo.Image = Properties.Resources.Alarm_clock;
            lblDongHo.Name = "lblDongHo";
            lblDongHo.RightToLeft = RightToLeft.No;
            lblDongHo.Size = new Size(87, 17);
            lblDongHo.Text = "10:25:30 AM";
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(32, 32);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnDangXuat, toolStripSeparator1, btnQLTheLuuDong, btnTKTheoNhanVien, btnQLSanPham, toolStripSeparator2, btnGioiThieu, lblTaiKhoan });
            toolStrip1.Location = new Point(0, 24);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(941, 39);
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
            btnDangXuat.Click += btnDangXuat_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 39);
            // 
            // btnQLTheLuuDong
            // 
            btnQLTheLuuDong.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnQLTheLuuDong.Image = Properties.Resources.webpage;
            btnQLTheLuuDong.ImageTransparentColor = Color.Magenta;
            btnQLTheLuuDong.Margin = new Padding(2, 1, 2, 2);
            btnQLTheLuuDong.Name = "btnQLTheLuuDong";
            btnQLTheLuuDong.Size = new Size(36, 36);
            btnQLTheLuuDong.Text = "Thẻ lưu động";
            // 
            // btnTKTheoNhanVien
            // 
            btnTKTheoNhanVien.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnTKTheoNhanVien.Image = Properties.Resources.Order_history;
            btnTKTheoNhanVien.ImageTransparentColor = Color.Magenta;
            btnTKTheoNhanVien.Margin = new Padding(2, 1, 2, 2);
            btnTKTheoNhanVien.Name = "btnTKTheoNhanVien";
            btnTKTheoNhanVien.Size = new Size(36, 36);
            btnTKTheoNhanVien.Text = "Phiếu bán hàng";
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
            // lblTaiKhoan
            // 
            lblTaiKhoan.Alignment = ToolStripItemAlignment.Right;
            lblTaiKhoan.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTaiKhoan.Margin = new Padding(0, 1, 5, 2);
            lblTaiKhoan.Name = "lblTaiKhoan";
            lblTaiKhoan.Size = new Size(53, 36);
            lblTaiKhoan.Text = "Admin";
            // 
            // pnlFormContainer
            // 
            pnlFormContainer.AutoSize = true;
            pnlFormContainer.Location = new Point(0, 66);
            pnlFormContainer.Name = "pnlFormContainer";
            pnlFormContainer.Size = new Size(941, 414);
            pnlFormContainer.TabIndex = 3;
            // 
            // MainScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(941, 505);
            Controls.Add(pnlFormContainer);
            Controls.Add(toolStrip1);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "MainScreen";
            StartPosition = FormStartPosition.CenterScreen;
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
        private ToolStripMenuItem thốngKêToolStripMenuItem;
        private ToolStripMenuItem hỗTrợToolStripMenuItem;
        private ToolStripMenuItem MenuDoiMatKhau;
        private ToolStripMenuItem MenuDangXuat;
        private ToolStripMenuItem MenuQLNhanVien;
        private ToolStripMenuItem MenuQLTheLuuDong;
        private ToolStripMenuItem MenuQLLoaiSanPham;
        private ToolStripMenuItem MenuQLSanPham;
        private ToolStripMenuItem MenuQLPhieuBanHang;
        private ToolStripMenuItem MenuTKTheoLoaiSP;
        private ToolStripMenuItem MenuTKTheoNhanVien;
        private ToolStripMenuItem MenuTroGiup;
        private ToolStripMenuItem MenuGioiThieu;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel toolStripStatusLabel3;
        private ToolStripStatusLabel lblDongHo;
        private ToolStrip toolStrip1;
        private ToolStripButton btnQLTheLuuDong;
        private ToolStripButton btnTKTheoNhanVien;
        private ToolStripButton btnDangXuat;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btnQLSanPham;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton btnGioiThieu;
        private ToolStripLabel lblTaiKhoan;
        private Panel pnlFormContainer;
    }
}