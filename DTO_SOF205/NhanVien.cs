namespace DTO_SOF205
{
    public class NhanVien
    {
        public String? MaNhanVien { get; set; }
        public String? HoTen { get; set; }
        public String? Email { get; set; }
        public String? MatKhau { get; set; }
        public Boolean VaiTro { get; set; } = true;
        public Boolean TrangThai { get; set; } = true;
        public override string ToString()
        {
            return HoTen; // Hiển thị tên trong ComboBox
        }
    }
}
