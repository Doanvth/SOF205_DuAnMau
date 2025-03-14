namespace GUI_SOF205
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();

            progressBar.Style = ProgressBarStyle.Marquee;
            progressBar.MarqueeAnimationSpeed = 30;

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
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
            }
        }
    }
}
