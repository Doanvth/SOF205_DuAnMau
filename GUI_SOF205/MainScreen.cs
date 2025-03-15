namespace GUI_SOF205
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
        }

        private void LoadForm(Form form)
        {
            form.TopLevel = false;
            pnlFormContainer.Controls.Add(form);
            form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            form.Show();
        }

        private void ShowFormInPanel(Form form)
        {
            // Xóa form cũ trong panel
            pnlFormContainer.Controls.Clear();

            // Thiết lập form con
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            // Thêm form vào panel
            pnlFormContainer.Controls.Add(form);
            form.Show();
        }

        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new QuanLyNhanVien());
        }

        private void quảnLýLoạiSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new QuanLyLoaiSanPham());
        }

        private void quảnLýSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new QuanLySanPham());
        }

        private void quảnLýPhiếuBánHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new PhieuBanHang());
        }
    }
}
