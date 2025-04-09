namespace GUI_SOF205
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
            //Cấu hình kiểu cho thanh progress bar
            progressBar.Style = ProgressBarStyle.Marquee;
            progressBar.MarqueeAnimationSpeed = 30;
            //Thực hiện thao tác load chờ 3 giây
            Task.Delay(3000).ContinueWith(t =>
            {
                Invoke(new Action(() =>
                {
                    this.Dispose();
                }));
            });
        }

        private void Welcome_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Ngăn chặn người dùng ngắt ứng dụng
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
            }
        }
    }
}
