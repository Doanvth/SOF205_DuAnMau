namespace DTO_SOF205
{
    public class SanPham
    {
        public String? MaSanPham { get; set; }
        public String? TenSanPham { get; set; }
        public Decimal DonGia { get; set; }
        public String? MaLoai { get; set; }
        public String? HinhAnh { get; set; }
        public Boolean TrangThai { get; set; } = true;
    }
}
