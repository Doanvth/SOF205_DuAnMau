using DAL_SOF205;
using DTO_SOF205;
using UTIL_SOF205;

namespace GUI_SOF205
{
    public partial class ThongKeTheoNhanVien : Form
    {
        NhanVienDAL nhanVienDAL = new NhanVienDAL();
        ThongKeDAL thongKeDAL = new ThongKeDAL();
        public ThongKeTheoNhanVien()
        {
            InitializeComponent();
        }

        private void ThongKeTheoLoaiSP_Load(object sender, EventArgs e)
        {
            List<NhanVien> nhanViens = nhanVienDAL.selectAll();
            cbxNhanVien.Items.Clear();
            cbxNhanVien.DataSource = nhanViens;
            cbxNhanVien.DisplayMember = "HoTen";
            cbxNhanVien.ValueMember = "MaNhanVien";
            dtpTuNgay.Value = DateUtil.ToDateTime("2024/01/01", "yyyy/MM/dd");
            dtpDenNgay.Value = DateUtil.ToDateTime("2024/11/01", "yyyy/MM/dd");
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            String nhanVien = (string)cbxNhanVien.SelectedValue;
            String tuNgay = dtpTuNgay.Text;
            String denNgay = dtpDenNgay.Text;
            List<TKDoanhThuTheoNhanVien> ketqua =  thongKeDAL.DoanhThuTheoNhanVien(
                nhanVien,
                DateUtil.ToDateTime(tuNgay, "dd/MM/yyyy"),
                DateUtil.ToDateTime(denNgay, "dd/MM/yyyy"));
            dgvThongKe.AutoGenerateColumns = false;
            dgvThongKe.Rows.Clear();
            foreach (var item in ketqua)
            {
                dgvThongKe.Rows.Add(
                    item.MaNhanVien,
                    item.HoTen,
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
