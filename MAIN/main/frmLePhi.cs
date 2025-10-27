using BLL.Services;
using DAL.ViewModel;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MAIN.main
{
    public partial class frmLePhi : Form
    {
        private hoadonService hoadonService = new hoadonService();
        private string id_chutrohientai;

        public frmLePhi()
        {
            InitializeComponent();
            this.id_chutrohientai = MAIN.main.LOGIN.id_chutrohientai;
            LoadDGVLePhi();
        }

        private void LoadDGVLePhi()
        {
            try
            {
                List<lephiViewModel> listLePhi = hoadonService.LayBanGhiLePhiTheoHoaDonId(id_chutrohientai);
                dgvLePhi.DataSource = listLePhi;
                EditDGVLePhi();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi load DGV: " + ex.Message);
            }
        }

        private void EditDGVLePhi()
        {
            dgvLePhi.Columns["id_lephi"].HeaderText = "Mã Lệ Phí";
            dgvLePhi.Columns["ten_phong"].HeaderText = "Tên Phòng";
            dgvLePhi.Columns["thanh_tien_lephi"].HeaderText = "Thành tiền";
            dgvLePhi.Columns["tien_dv"].HeaderText = "Tiền Dịch Vụ";
            dgvLePhi.Columns["tien_phong"].HeaderText = "Tiền Phòng";
            dgvLePhi.Columns["ngay_tao"].HeaderText = "Ngày Tạo";
            dgvLePhi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
           
        }

        private void dgvLePhi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvLePhi.Rows[e.RowIndex];
                txtTenPhong.Text = row.Cells["ten_phong"].Value?.ToString() ?? "";
                txtIDLePhi.Text = row.Cells["id_lephi"].Value?.ToString() ?? "";
                txtDichVu.Text = row.Cells["tien_dv"].Value?.ToString() ?? "";
                txtTienPhong.Text = row.Cells["tien_phong"].Value?.ToString() ?? "";

                decimal tienDV = Convert.ToDecimal(row.Cells["tien_dv"].Value ?? 0);
                decimal tienPhong = Convert.ToDecimal(row.Cells["tien_phong"].Value ?? 0);
                txtThanhTien.Text = (tienDV + tienPhong).ToString();

                if (row.Cells["ngay_tao"].Value != null)
                    dtpNgayTao.Value = Convert.ToDateTime(row.Cells["ngay_tao"].Value);
            }
        }

        private void btnTimLePhi_Click(object sender, EventArgs e)
        {
            string keyword = txtTimLePhi.Text.Trim();
            if (string.IsNullOrEmpty(keyword))
            {
                MessageBox.Show("Vui lòng nhập từ khóa để tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                List<lephiViewModel> searchLePhi = hoadonService.LayTatCaLePhiTheoKeyword(id_chutrohientai, keyword);
                if (searchLePhi == null || searchLePhi.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy le phi nào phù hợp với từ khóa: " + keyword, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                dgvLePhi.DataSource = searchLePhi;
                EditDGVLePhi();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi tìm kiếm: " + ex.Message);
            }
        }

        private void lblPhong_Click(object sender, EventArgs e)
        {

        }
    }
}
