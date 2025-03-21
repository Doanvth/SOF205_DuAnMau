namespace DTO_SOF205
{
    public class LoaiSanPham
    {
        public String? MaLoai {  get; set; }
        public String? TenLoai { get; set; }
        public String? GhiChu { get; set; }

        public override string ToString()
        {
            return TenLoai; // Hiển thị tên trong ComboBox
        }
    }
}
