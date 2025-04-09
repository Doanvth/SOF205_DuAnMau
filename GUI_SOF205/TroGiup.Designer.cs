namespace GUI_SOF205
{
    partial class TroGiup
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.poly;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(562, 202);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 217);
            label1.Name = "label1";
            label1.Size = new Size(283, 15);
            label1.TabIndex = 2;
            label1.Text = "Đây là hệ thống quản lý chuỗi quán cà phê PolyCafe";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 232);
            label2.Name = "label2";
            label2.Size = new Size(461, 15);
            label2.TabIndex = 3;
            label2.Text = "Khi hoàn thành dự án này các bạn sẽ nắm được trình tự và công đoạn thực hiện dự án";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 247);
            label3.Name = "label3";
            label3.Size = new Size(114, 15);
            label3.TabIndex = 4;
            label3.Text = "Yêu cầu môi trường:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 262);
            label4.Name = "label4";
            label4.Size = new Size(125, 15);
            label4.TabIndex = 5;
            label4.Text = "1. Hệ điều hành bất kỳ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 277);
            label5.Name = "label5";
            label5.Size = new Size(111, 15);
            label5.TabIndex = 6;
            label5.Text = "2. dotNet 8.0 trở lên";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 292);
            label6.Name = "label6";
            label6.Size = new Size(139, 15);
            label6.TabIndex = 7;
            label6.Text = "3. SQL Server 2022 trở lên";
            // 
            // TroGiup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(586, 318);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "TroGiup";
            Text = "TroGiup";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}