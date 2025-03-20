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
            đổiMậtKhẩuToolStripMenuItem = new ToolStripStatusLabel();
            đăngXuấtToolStripMenuItem = new ToolStripStatusLabel();
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
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { tàiKhoảnToolStripMenuItem, quảnLýToolStripMenuItem, thốngKêToolStripMenuItem, hỗTrợToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(9, 3, 0, 3);
            menuStrip1.Size = new Size(1318, 35);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // tàiKhoảnToolStripMenuItem
            // 
            tàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { MenuDoiMatKhau, MenuDangXuat });
            tàiKhoảnToolStripMenuItem.Name = "tàiKhoảnToolStripMenuItem";
            tàiKhoảnToolStripMenuItem.Size = new Size(102, 29);
            tàiKhoảnToolStripMenuItem.Text = "Tài khoản";
            // 
            // MenuDoiMatKhau
            // 
            đổiMậtKhẩuToolStripMenuItem.Image = Properties.Resources.arrows1;
            đổiMậtKhẩuToolStripMenuItem.Name = "đổiMậtKhẩuToolStripMenuItem";
            đổiMậtKhẩuToolStripMenuItem.Size = new Size(221, 34);
            đổiMậtKhẩuToolStripMenuItem.Text = "Đổi mật khẩu";
            // 
            // MenuDangXuat
            // 
            đăngXuấtToolStripMenuItem.Image = Properties.Resources.exit;
            đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            đăngXuấtToolStripMenuItem.Size = new Size(221, 34);
            đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            // 
            // quảnLýToolStripMenuItem
            // 
            quảnLýToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { MenuQLNhanVien, MenuQLTheLuuDong, MenuQLLoaiSanPham, MenuQLSanPham, MenuQLPhieuBanHang });
            quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            quảnLýToolStripMenuItem.Size = new Size(89, 29);
            quảnLýToolStripMenuItem.Text = "Quản lý";
            // 
            // MenuQLNhanVien
            // 
            //quảnLýNhânViênToolStripMenuItem.Image = Properties.Resources.Couple;
            //quảnLýNhânViênToolStripMenuItem.Name = "quảnLýNhânViênToolStripMenuItem";
            //quảnLýNhânViênToolStripMenuItem.Size = new Size(304, 34);
            //quảnLýNhânViênToolStripMenuItem.Text = "Quản lý nhân viên";
            //quảnLýNhânViênToolStripMenuItem.Click += quảnLýNhânViênToolStripMenuItem_Click;
            // 
            // MenuQLTheLuuDong
            // 
            quảnLýKháchHàngToolStripMenuItem.Image = Properties.Resources.users;
            quảnLýKháchHàngToolStripMenuItem.Name = "quảnLýKháchHàngToolStripMenuItem";
            quảnLýKháchHàngToolStripMenuItem.Size = new Size(304, 34);
            quảnLýKháchHàngToolStripMenuItem.Text = "Quản lý khách hàng";
            // 
            // MenuQLLoaiSanPham
            // 

            quảnLýLoạiSảnPhẩmToolStripMenuItem.Image = Properties.Resources.Packing1;
            quảnLýLoạiSảnPhẩmToolStripMenuItem.Name = "quảnLýLoạiSảnPhẩmToolStripMenuItem";
            quảnLýLoạiSảnPhẩmToolStripMenuItem.Size = new Size(304, 34);
            quảnLýLoạiSảnPhẩmToolStripMenuItem.Text = "Quản lý loại sản phẩm";
            quảnLýLoạiSảnPhẩmToolStripMenuItem.Click += quảnLýLoạiSảnPhẩmToolStripMenuItem_Click;
            // 
            // MenuQLSanPham
            // 
            quảnLýSảnPhẩmToolStripMenuItem.Image = Properties.Resources.coffee;
            quảnLýSảnPhẩmToolStripMenuItem.Name = "quảnLýSảnPhẩmToolStripMenuItem";
            quảnLýSảnPhẩmToolStripMenuItem.Size = new Size(304, 34);
            quảnLýSảnPhẩmToolStripMenuItem.Text = "Quản lý sản phẩm";
            quảnLýSảnPhẩmToolStripMenuItem.Click += quảnLýSảnPhẩmToolStripMenuItem_Click;
            // 

            quảnLýPhiếuBánHàngToolStripMenuItem.Image = Properties.Resources.Order_history;
            quảnLýPhiếuBánHàngToolStripMenuItem.Name = "quảnLýPhiếuBánHàngToolStripMenuItem";
            quảnLýPhiếuBánHàngToolStripMenuItem.Size = new Size(304, 34);
            quảnLýPhiếuBánHàngToolStripMenuItem.Text = "Quản lý phiếu bán hàng";
            quảnLýPhiếuBánHàngToolStripMenuItem.Click += quảnLýPhiếuBánHàngToolStripMenuItem_Click;
            // 
            // thốngKêToolStripMenuItem
            // 
            thốngKêToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { MenuTKTheoLoaiSP, MenuTKTheoNhanVien });
            thốngKêToolStripMenuItem.Name = "thốngKêToolStripMenuItem";
            thốngKêToolStripMenuItem.Size = new Size(102, 29);
            thốngKêToolStripMenuItem.Text = "Thống kê";
            // 
            // MenuTKTheoLoaiSP
            // 
            doanhThuTheoLoạiToolStripMenuItem.Image = Properties.Resources.Product_sale_report;
            doanhThuTheoLoạiToolStripMenuItem.Name = "doanhThuTheoLoạiToolStripMenuItem";
            doanhThuTheoLoạiToolStripMenuItem.Size = new Size(355, 34);
            doanhThuTheoLoạiToolStripMenuItem.Text = "Doanh thu theo loại sản phẩm";
            // 
            // MenuTKTheoNhanVien
            // 
            doanhThuTheoNhânViênToolStripMenuItem.Image = Properties.Resources.Distributor_report;
            doanhThuTheoNhânViênToolStripMenuItem.Name = "doanhThuTheoNhânViênToolStripMenuItem";
            doanhThuTheoNhânViênToolStripMenuItem.Size = new Size(355, 34);
            doanhThuTheoNhânViênToolStripMenuItem.Text = "Doanh thu theo nhân viên";
            // 
            // hỗTrợToolStripMenuItem
            // 
            hỗTrợToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { MenuTroGiup, MenuGioiThieu });
            hỗTrợToolStripMenuItem.Name = "hỗTrợToolStripMenuItem";
            hỗTrợToolStripMenuItem.Size = new Size(80, 29);
            hỗTrợToolStripMenuItem.Text = "Hỗ trợ";
            // 
            // MenuTroGiup
            // 
            trợGiúpToolStripMenuItem.Image = Properties.Resources.application;
            trợGiúpToolStripMenuItem.Name = "trợGiúpToolStripMenuItem";
            trợGiúpToolStripMenuItem.Size = new Size(189, 34);
            trợGiúpToolStripMenuItem.Text = "Trợ giúp";

            // 
            // MenuGioiThieu
            // 

            giớiThiệuToolStripMenuItem.Image = Properties.Resources.information;
            giớiThiệuToolStripMenuItem.Name = "giớiThiệuToolStripMenuItem";
            giớiThiệuToolStripMenuItem.Size = new Size(189, 34);
            giớiThiệuToolStripMenuItem.Text = "Giới thiệu";
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(24, 24);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, toolStripStatusLabel3, toolStripStatusLabel2 });
            statusStrip1.Location = new Point(0, 807);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 20, 0);
            statusStrip1.Size = new Size(1318, 32);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Image = Properties.Resources.fpt1;
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(247, 25);
            toolStripStatusLabel1.Text = "Hệ thống quản lý PolyCafe";
            // 
            // toolStripStatusLabel3
            // 
            toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            toolStripStatusLabel3.Size = new Size(913, 25);
           // toolStripStatusLabel3.Spring = true;
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
            toolStrip1.Padding = new Padding(0, 0, 3, 0);
            toolStrip1.Size = new Size(1318, 39);
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
            pnlFormContainer.Location = new Point(0, 110);
            pnlFormContainer.Margin = new Padding(4, 5, 4, 5);
            pnlFormContainer.Name = "pnlFormContainer";
            pnlFormContainer.Size = new Size(1320, 700);
            pnlFormContainer.TabIndex = 3;
            // 
            // MainScreen
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1318, 839);
            Controls.Add(pnlFormContainer);
            Controls.Add(toolStrip1);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 5, 4, 5);
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
        private ToolStripMenuItem quảnLýNhânViênToolStripMenuItem;
        private ToolStripMenuItem quảnLýKháchHàngToolStripMenuItem;
        private ToolStripMenuItem quảnLýLoạiSảnPhẩmToolStripMenuItem;
        private ToolStripMenuItem quảnLýSảnPhẩmToolStripMenuItem;
        private ToolStripMenuItem quảnLýPhiếuBánHàngToolStripMenuItem;
        private ToolStripMenuItem doanhThuTheoLoạiToolStripMenuItem;
        private ToolStripMenuItem doanhThuTheoNhânViênToolStripMenuItem;
        private ToolStripMenuItem trợGiúpToolStripMenuItem;
        private ToolStripMenuItem giớiThiệuToolStripMenuItem;
        private ToolStripMenuItem toolStripStatusLabel1;
        private ToolStripMenuItem toolStripStatusLabel2;
        private ToolStripMenuItem toolStripStatusLabel3;
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
        private ToolStripStatusLabel đổiMậtKhẩuToolStripMenuItem;
        private ToolStripStatusLabel đăngXuấtToolStripMenuItem;
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