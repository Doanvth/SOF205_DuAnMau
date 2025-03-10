namespace UTIL_SOF205
{
    public class ImageUtil
    {
        /// <summary>
        /// Kiểm tra file được chọn có phải là ảnh không
        /// </summary>
        /// <param name="openFileDialog">Đối tượng đọc file được chọn</param>
        public static Boolean IsImage(OpenFileDialog openFileDialog)
        {
            string sourceFilePath = openFileDialog.FileName;
            string fileExtension = Path.GetExtension(sourceFilePath).ToLower();
            string[] imageExtensions = { ".jpg", ".jpeg", ".png", ".gif", ".bmp", ".tiff", ".webp" };
            return imageExtensions.Contains(fileExtension);
        }

        /// <summary>
        /// Sao chép ảnh được chọn vào thư mục Images
        /// </summary>
        /// <param name="openFileDialog">Đối tượng đọc file được chọn</param>
        /// <returns>Tên file theo mốc thời gian lưu</returns>
        public string save(OpenFileDialog openFileDialog)
        {
            string sourceFilePath = openFileDialog.FileName;

            string projectFolder = Path.Combine(Application.StartupPath, "Images");

            if (!Directory.Exists(projectFolder))
            {
                Directory.CreateDirectory(projectFolder);
            }
            //Lấy ngày tháng và thời gian hiện tại sử dụng cho tên ảnh
            string fileExtension = Path.GetExtension(sourceFilePath);
            string fileName = DateTime.Now.ToString("yyyyMMddHHmmss") + fileExtension;
            string destinationFilePath = Path.Combine(projectFolder, fileName);

            //Trả kết quả là tên file đã lưu
            try
            {
                File.Copy(sourceFilePath, destinationFilePath, true);
                return fileName;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Đọc ảnh được chọn từ thư mục Images
        /// </summary>
        /// <param name="fileName">Tên file cần đọc</param>
        /// <returns>Bitmap file ảnh đã đọc được</returns>
        public Bitmap load(string fileName) {
            string projectFolder = Path.Combine(Application.StartupPath, "Images");
            return new Bitmap(Path.Combine(projectFolder, fileName));
        }
    }
}
