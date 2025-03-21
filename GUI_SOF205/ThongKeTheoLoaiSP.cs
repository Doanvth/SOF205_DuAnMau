using DAL_SOF205;
using DTO_SOF205;
using UTIL_SOF205;

namespace GUI_SOF205
{
    public partial class ThongKeTheoLoaiSP : Form
    {
        LoaiSanPhamDAL loaiSanPhamDAL = new LoaiSanPhamDAL();
        ThongKeDAL thongKeDAL = new ThongKeDAL();
        public ThongKeTheoLoaiSP()
        {
            InitializeComponent();
        }

        private void ThongKeTheoLoaiSP_Load(object sender, EventArgs e)
        {
            List<LoaiSanPham> loaiSanPhams = loaiSanPhamDAL.selectAll();
            cbxLoaiSanPham.Items.Clear();
            cbxLoaiSanPham.DataSource = loaiSanPhams;
            cbxLoaiSanPham.DisplayMember = "TenLoai";
            cbxLoaiSanPham.ValueMember = "MaLoai";
            dtpTuNgay.Value = DateUtil.ToDateTime("2024/01/01", "yyyy/MM/dd");
            dtpDenNgay.Value = DateUtil.ToDateTime("2024/11/01", "yyyy/MM/dd");
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            String loaiSP = (string)cbxLoaiSanPham.SelectedValue;
            String tuNgay = dtpTuNgay.Text;
            String denNgay = dtpDenNgay.Text;
            List<TKDoanhThuTheoLoaiSP> ketqua =  thongKeDAL.DoanhThuTheoLoaiSP(
                loaiSP,
                DateUtil.ToDateTime(tuNgay, "dd/MM/yyyy"),
                DateUtil.ToDateTime(denNgay, "dd/MM/yyyy"));
            dgvThongKe.AutoGenerateColumns = false;
            dgvThongKe.Rows.Clear();
            foreach (var item in ketqua)
            {
                dgvThongKe.Rows.Add(
                    item.MaSanPham,
                    item.TenSanPham,
                    item.TongTien.ToString("#,0"),
                    item.SoLy,
                    item.SoLuongPhieu,
                    DateUtil.ToString(item.NgayBan, "dd/MM/yyyy"),
                    item.DaThanhToan ? "Đã thanh toán" : "Chưa thanh toán"
                );
            }
        }
    }
}
