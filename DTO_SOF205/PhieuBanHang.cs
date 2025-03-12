namespace DTO_SOF205
{
    public class PhieuBanHang
    {
        public String? MaPhieu {  get; set; }
        public String? MaThe { get; set; }
        public String? MaNhanVien { get; set; }
        public DateTime NgayTao { get; set; } = new DateTime();
        public Boolean TrangThai { get; set; } = true;
    }
}
