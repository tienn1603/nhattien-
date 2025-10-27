using BLL.Services;
using DAL.Model;
using DAL.ViewModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace MAIN.main
{
    public partial class frmNuoc : Form
    {
        private hoadonService hoadonService = new hoadonService();

       

        private string id_chutrohientai;

        public frmNuoc()
        {
            InitializeComponent();
            this.id_chutrohientai = MAIN.main.LOGIN.id_chutrohientai;
            LoadDGVNuoc();
          
        }

        

        private void LoadDGVNuoc()
        {
            try
            {
                List<nuocViewModel> listNuoc = hoadonService.LayTatCaBanGhiNuoc(id_chutrohientai);
                dgvNuoc.DataSource = listNuoc;
                EditDGVNguoiThue();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        private void EditDGVNguoiThue()
        {
            dgvNuoc.Columns["ten_phong"].HeaderText = "Tên phòng";
            dgvNuoc.Columns["id_nuoc"].HeaderText = "Mã Nước";
            dgvNuoc.Columns["chi_so_dau"].HeaderText = "Chỉ Số Cũ";
            dgvNuoc.Columns["chi_so_cuoi"].HeaderText = "Chỉ Số Mới";
            dgvNuoc.Columns["thanh_tien_nuoc"].HeaderText = "Tiền Nước";
            dgvNuoc.Columns["ngay_tao"].HeaderText = "Ngay tao";


            dgvNuoc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            


        }





        // 🔹 Khi chọn dòng trong DataGridView
        private void dgvNuoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; // chỉ bỏ qua khi click tiêu đề

            DataGridViewRow row = dgvNuoc.Rows[e.RowIndex];
            txtTenPhong.Text = row.Cells["ten_phong"].Value?.ToString();
            txtMaNuoc.Text = row.Cells["id_nuoc"].Value?.ToString();
            txtChiSoCu.Text = row.Cells["chi_so_dau"].Value?.ToString();
            txtChiSoMoi.Text = row.Cells["chi_so_cuoi"].Value?.ToString();
            txtTienNuoc.Text = row.Cells["thanh_tien_nuoc"].Value?.ToString();


            // Nếu có cột NgayTao hoặc Thang thì load vào DateTimePicker
            if (row.Cells["ngay_tao"].Value is DateTime thang)
            {
                dtpThang.Value = thang;
            }

        }

        private void frmNuoc_Load(object sender, EventArgs e)
        {

        }

        private void btnTimNuoc_Click(object sender, EventArgs e)
        {
            string keyword = txtTimNuoc.Text.Trim();
            if (string.IsNullOrEmpty(keyword))
            {
                MessageBox.Show("Vui lòng nhập từ khóa  để tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                
               List<nuocViewModel> seacrhNuoc =hoadonService.LayTatCaBanGhiNuocTheoKeyword(id_chutrohientai, keyword);

                if (seacrhNuoc == null || seacrhNuoc.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy hoa don nuoc nào phù hợp với từ khóa: " + keyword, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                dgvNuoc.DataSource = seacrhNuoc;
                 EditDGVNguoiThue();

            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
