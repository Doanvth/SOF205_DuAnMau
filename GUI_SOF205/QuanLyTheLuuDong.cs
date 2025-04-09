using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DAL_SOF205;
using DTO_SOF205;

namespace GUI_SOF205
{
    public partial class QuanLyTheLuuDong : Form
    {
        private TheLuuDongDAL theLuuDongDAL;

        public QuanLyTheLuuDong()
        {
            InitializeComponent();
            theLuuDongDAL = new TheLuuDongDAL();
        }

        private void QuanLyTheLuuDong_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                List<TheLuuDong> list = theLuuDongDAL.selectAll();
                dgvDSTheLuuDong.DataSource = list;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
            }
        }

        private void btnThemThe_Click(object sender, EventArgs e)
        {
            try
            {
                // Sinh mã tự động
                string maThe = theLuuDongDAL.generateAutoMaThe();

                if (string.IsNullOrWhiteSpace(txtChuSoHuu.Text))
                {
                    MessageBox.Show("Vui lòng nhập chủ sở hữu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                TheLuuDong the = new TheLuuDong
                {
                    MaThe = maThe,
                    ChuSoHuu = txtChuSoHuu.Text.Trim(),
                    TrangThai = chkTrangThai.Checked,
                };

                theLuuDongDAL.insert(the);
                MessageBox.Show($"Thêm thẻ thành công! Mã thẻ: {maThe}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadData();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm thẻ: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSuaThe_Click(object sender, EventArgs e)
        {
            try
            {
                TheLuuDong entity = new TheLuuDong()
                {
                    MaThe = txtMaThe.Text,
                    ChuSoHuu = txtChuSoHuu.Text,
                    TrangThai = chkTrangThai.Checked
                };

                theLuuDongDAL.update(entity);
                LoadData();
                MessageBox.Show("Cập nhật thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật: " + ex.Message);
            }
        }

        private void btnXoaThe_Click(object sender, EventArgs e)
        {
            try
            {
                string maThe = txtMaThe.Text;
                theLuuDongDAL.delete(maThe);
                LoadData();
                MessageBox.Show("Xóa thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa: " + ex.Message);
            }
        }

        private void dgvDSTheLuuDong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvDSTheLuuDong.Rows[e.RowIndex];
                txtMaThe.Text = row.Cells["MaThe"].Value.ToString();
                txtChuSoHuu.Text = row.Cells["ChuSoHuu"].Value.ToString();
                chkTrangThai.Checked = Convert.ToBoolean(row.Cells["TrangThai"].Value);
            }
        }

        private void ClearForm()
        {
            txtMaThe.Clear();
            txtChuSoHuu.Clear();
            chkTrangThai.Checked = false;
        }

        private void btnMoiThe_Click(object sender, EventArgs e)
        {
            txtMaThe.Clear();
            txtChuSoHuu.Clear();
            chkTrangThai.Checked = false;
        }

        private void dgvDSTheLuuDong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
