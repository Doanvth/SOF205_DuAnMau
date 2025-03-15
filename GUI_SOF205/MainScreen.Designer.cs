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
            đổiMậtKhẩuToolStripMenuItem = new ToolStripMenuItem();
            đăngXuấtToolStripMenuItem = new ToolStripMenuItem();
            quảnLýToolStripMenuItem = new ToolStripMenuItem();
            quảnLýNhânViênToolStripMenuItem = new ToolStripMenuItem();
            quảnLýKháchHàngToolStripMenuItem = new ToolStripMenuItem();
            quảnLýLoạiSảnPhẩmToolStripMenuItem = new ToolStripMenuItem();
            quảnLýSảnPhẩmToolStripMenuItem = new ToolStripMenuItem();
            quảnLýPhiếuBánHàngToolStripMenuItem = new ToolStripMenuItem();
            thốngKêToolStripMenuItem = new ToolStripMenuItem();
            doanhThuTheoLoạiToolStripMenuItem = new ToolStripMenuItem();
            doanhThuTheoNhânViênToolStripMenuItem = new ToolStripMenuItem();
            hỗTrợToolStripMenuItem = new ToolStripMenuItem();
            trợGiúpToolStripMenuItem = new ToolStripMenuItem();
            giớiThiệuToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            toolStripStatusLabel3 = new ToolStripStatusLabel();
            toolStripStatusLabel2 = new ToolStripStatusLabel();
            toolStrip1 = new ToolStrip();
            toolStripButton3 = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripButton1 = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            toolStripButton4 = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            toolStripButton5 = new ToolStripButton();
            toolStripLabel2 = new ToolStripLabel();
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
            tàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { đổiMậtKhẩuToolStripMenuItem, đăngXuấtToolStripMenuItem });
            tàiKhoảnToolStripMenuItem.Name = "tàiKhoảnToolStripMenuItem";
            tàiKhoảnToolStripMenuItem.Size = new Size(102, 29);
            tàiKhoảnToolStripMenuItem.Text = "Tài khoản";
            // 
            // đổiMậtKhẩuToolStripMenuItem
            // 
            đổiMậtKhẩuToolStripMenuItem.Image = Properties.Resources.arrows1;
            đổiMậtKhẩuToolStripMenuItem.Name = "đổiMậtKhẩuToolStripMenuItem";
            đổiMậtKhẩuToolStripMenuItem.Size = new Size(221, 34);
            đổiMậtKhẩuToolStripMenuItem.Text = "Đổi mật khẩu";
            // 
            // đăngXuấtToolStripMenuItem
            // 
            đăngXuấtToolStripMenuItem.Image = Properties.Resources.exit;
            đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            đăngXuấtToolStripMenuItem.Size = new Size(221, 34);
            đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            // 
            // quảnLýToolStripMenuItem
            // 
            quảnLýToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { quảnLýNhânViênToolStripMenuItem, quảnLýKháchHàngToolStripMenuItem, quảnLýLoạiSảnPhẩmToolStripMenuItem, quảnLýSảnPhẩmToolStripMenuItem, quảnLýPhiếuBánHàngToolStripMenuItem });
            quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            quảnLýToolStripMenuItem.Size = new Size(89, 29);
            quảnLýToolStripMenuItem.Text = "Quản lý";
            // 
            // quảnLýNhânViênToolStripMenuItem
            // 
            quảnLýNhânViênToolStripMenuItem.Image = Properties.Resources.Couple;
            quảnLýNhânViênToolStripMenuItem.Name = "quảnLýNhânViênToolStripMenuItem";
            quảnLýNhânViênToolStripMenuItem.Size = new Size(304, 34);
            quảnLýNhânViênToolStripMenuItem.Text = "Quản lý nhân viên";
            quảnLýNhânViênToolStripMenuItem.Click += quảnLýNhânViênToolStripMenuItem_Click;
            // 
            // quảnLýKháchHàngToolStripMenuItem
            // 
            quảnLýKháchHàngToolStripMenuItem.Image = Properties.Resources.users;
            quảnLýKháchHàngToolStripMenuItem.Name = "quảnLýKháchHàngToolStripMenuItem";
            quảnLýKháchHàngToolStripMenuItem.Size = new Size(304, 34);
            quảnLýKháchHàngToolStripMenuItem.Text = "Quản lý khách hàng";
            // 
            // quảnLýLoạiSảnPhẩmToolStripMenuItem
            // 
            quảnLýLoạiSảnPhẩmToolStripMenuItem.Image = Properties.Resources.Packing1;
            quảnLýLoạiSảnPhẩmToolStripMenuItem.Name = "quảnLýLoạiSảnPhẩmToolStripMenuItem";
            quảnLýLoạiSảnPhẩmToolStripMenuItem.Size = new Size(304, 34);
            quảnLýLoạiSảnPhẩmToolStripMenuItem.Text = "Quản lý loại sản phẩm";
            quảnLýLoạiSảnPhẩmToolStripMenuItem.Click += quảnLýLoạiSảnPhẩmToolStripMenuItem_Click;
            // 
            // quảnLýSảnPhẩmToolStripMenuItem
            // 
            quảnLýSảnPhẩmToolStripMenuItem.Image = Properties.Resources.coffee;
            quảnLýSảnPhẩmToolStripMenuItem.Name = "quảnLýSảnPhẩmToolStripMenuItem";
            quảnLýSảnPhẩmToolStripMenuItem.Size = new Size(304, 34);
            quảnLýSảnPhẩmToolStripMenuItem.Text = "Quản lý sản phẩm";
            quảnLýSảnPhẩmToolStripMenuItem.Click += quảnLýSảnPhẩmToolStripMenuItem_Click;
            // 
            // quảnLýPhiếuBánHàngToolStripMenuItem
            // 
            quảnLýPhiếuBánHàngToolStripMenuItem.Image = Properties.Resources.Order_history;
            quảnLýPhiếuBánHàngToolStripMenuItem.Name = "quảnLýPhiếuBánHàngToolStripMenuItem";
            quảnLýPhiếuBánHàngToolStripMenuItem.Size = new Size(304, 34);
            quảnLýPhiếuBánHàngToolStripMenuItem.Text = "Quản lý phiếu bán hàng";
            quảnLýPhiếuBánHàngToolStripMenuItem.Click += quảnLýPhiếuBánHàngToolStripMenuItem_Click;
            // 
            // thốngKêToolStripMenuItem
            // 
            thốngKêToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { doanhThuTheoLoạiToolStripMenuItem, doanhThuTheoNhânViênToolStripMenuItem });
            thốngKêToolStripMenuItem.Name = "thốngKêToolStripMenuItem";
            thốngKêToolStripMenuItem.Size = new Size(102, 29);
            thốngKêToolStripMenuItem.Text = "Thống kê";
            // 
            // doanhThuTheoLoạiToolStripMenuItem
            // 
            doanhThuTheoLoạiToolStripMenuItem.Image = Properties.Resources.Product_sale_report;
            doanhThuTheoLoạiToolStripMenuItem.Name = "doanhThuTheoLoạiToolStripMenuItem";
            doanhThuTheoLoạiToolStripMenuItem.Size = new Size(355, 34);
            doanhThuTheoLoạiToolStripMenuItem.Text = "Doanh thu theo loại sản phẩm";
            // 
            // doanhThuTheoNhânViênToolStripMenuItem
            // 
            doanhThuTheoNhânViênToolStripMenuItem.Image = Properties.Resources.Distributor_report;
            doanhThuTheoNhânViênToolStripMenuItem.Name = "doanhThuTheoNhânViênToolStripMenuItem";
            doanhThuTheoNhânViênToolStripMenuItem.Size = new Size(355, 34);
            doanhThuTheoNhânViênToolStripMenuItem.Text = "Doanh thu theo nhân viên";
            // 
            // hỗTrợToolStripMenuItem
            // 
            hỗTrợToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { trợGiúpToolStripMenuItem, giớiThiệuToolStripMenuItem });
            hỗTrợToolStripMenuItem.Name = "hỗTrợToolStripMenuItem";
            hỗTrợToolStripMenuItem.Size = new Size(80, 29);
            hỗTrợToolStripMenuItem.Text = "Hỗ trợ";
            // 
            // trợGiúpToolStripMenuItem
            // 
            trợGiúpToolStripMenuItem.Image = Properties.Resources.application;
            trợGiúpToolStripMenuItem.Name = "trợGiúpToolStripMenuItem";
            trợGiúpToolStripMenuItem.Size = new Size(189, 34);
            trợGiúpToolStripMenuItem.Text = "Trợ giúp";
            // 
            // giớiThiệuToolStripMenuItem
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
            toolStripStatusLabel3.Spring = true;
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.Image = Properties.Resources.Alarm_clock;
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.RightToLeft = RightToLeft.No;
            toolStripStatusLabel2.Size = new Size(137, 25);
            toolStripStatusLabel2.Text = "10:25:30 AM";
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(32, 32);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton3, toolStripSeparator1, toolStripButton1, toolStripButton2, toolStripButton4, toolStripSeparator2, toolStripButton5, toolStripLabel2 });
            toolStrip1.Location = new Point(0, 35);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Padding = new Padding(0, 0, 3, 0);
            toolStrip1.Size = new Size(1318, 39);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton3
            // 
            toolStripButton3.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton3.Image = Properties.Resources.exit;
            toolStripButton3.ImageTransparentColor = Color.Magenta;
            toolStripButton3.Margin = new Padding(2, 1, 2, 2);
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new Size(36, 36);
            toolStripButton3.Text = "Đăng xuất";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 39);
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = Properties.Resources.users;
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Margin = new Padding(2, 1, 2, 2);
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(36, 36);
            toolStripButton1.Text = "Khách hàng";
            // 
            // toolStripButton2
            // 
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton2.Image = Properties.Resources.Order_history;
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Margin = new Padding(2, 1, 2, 2);
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(36, 36);
            toolStripButton2.Text = "Phiếu bán hàng";
            // 
            // toolStripButton4
            // 
            toolStripButton4.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton4.Image = Properties.Resources.coffee;
            toolStripButton4.ImageTransparentColor = Color.Magenta;
            toolStripButton4.Margin = new Padding(2, 1, 2, 2);
            toolStripButton4.Name = "toolStripButton4";
            toolStripButton4.Size = new Size(36, 36);
            toolStripButton4.Text = "Sản phẩm";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 39);
            // 
            // toolStripButton5
            // 
            toolStripButton5.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton5.Image = Properties.Resources.information;
            toolStripButton5.ImageTransparentColor = Color.Magenta;
            toolStripButton5.Margin = new Padding(2, 1, 2, 2);
            toolStripButton5.Name = "toolStripButton5";
            toolStripButton5.Size = new Size(36, 36);
            toolStripButton5.Text = "Hỗ trợ";
            // 
            // toolStripLabel2
            // 
            toolStripLabel2.Alignment = ToolStripItemAlignment.Right;
            toolStripLabel2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            toolStripLabel2.Margin = new Padding(0, 1, 5, 2);
            toolStripLabel2.Name = "toolStripLabel2";
            toolStripLabel2.Size = new Size(74, 36);
            toolStripLabel2.Text = "Admin";
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
        private ToolStripMenuItem đổiMậtKhẩuToolStripMenuItem;
        private ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private ToolStripMenuItem quảnLýNhânViênToolStripMenuItem;
        private ToolStripMenuItem quảnLýKháchHàngToolStripMenuItem;
        private ToolStripMenuItem quảnLýLoạiSảnPhẩmToolStripMenuItem;
        private ToolStripMenuItem quảnLýSảnPhẩmToolStripMenuItem;
        private ToolStripMenuItem quảnLýPhiếuBánHàngToolStripMenuItem;
        private ToolStripMenuItem doanhThuTheoLoạiToolStripMenuItem;
        private ToolStripMenuItem doanhThuTheoNhânViênToolStripMenuItem;
        private ToolStripMenuItem trợGiúpToolStripMenuItem;
        private ToolStripMenuItem giớiThiệuToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel toolStripStatusLabel3;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private ToolStripButton toolStripButton3;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton toolStripButton4;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton toolStripButton5;
        private ToolStripLabel toolStripLabel2;
        private Panel pnlFormContainer;
    }
}