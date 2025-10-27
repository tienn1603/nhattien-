using DAL.Model;
using DAL.ViewModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.BLL
{
    public class nuocBLL
    {

        //CUD không cần thêm vì đã được xử lý TransactionScope trong hoadonBLL

        // R - READ (ALL): Lấy tất cả chỉ số Nước
        /*    public List<nuoc> LayTatCaBanGhiNuoc(string id_chutro)
            {
                using (var dbContext = new ContextDB())
                {
                    return dbContext.nuocs.ToList();
                }
            }
        */
        public List<nuocViewModel> LayTatCaBanGhiNuoc(string id_chutro)
        {
            using (var dbContext = new ContextDB())
            {
                var list = dbContext.hoadons
                                    .Include(hd => hd.nuoc)
                                    .Include(hd => hd.phongtro)
                                    .Where(hd => hd.phongtro.id_chutro == id_chutro && hd.nuoc != null)
                                    .Select(hd => new nuocViewModel
                                    {
                                        ten_phong = hd.phongtro.tenphong,
                                        id_nuoc = hd.nuoc.id_nuoc,
                                        chi_so_dau = hd.nuoc.chi_so_dau,
                                        chi_so_cuoi = hd.nuoc.chi_so_cuoi,
                                        thanh_tien_nuoc = hd.nuoc.thanh_tien_nuoc,
                                        ngay_tao = hd.nuoc.ngay_tao
                                    })
                                    .ToList();

                return list;
            }
        }

        internal List<nuocViewModel> LayTatBanGhiNuocTheoKeyword(string id_chutro, string keyword)
        {
            using (var db = new ContextDB())
            {
                string searchKeyword = (keyword ?? string.Empty).Trim().ToLower();

                var query = db.nuocs
                    .Where(n => n.hoadons.Any(h => h.phongtro.id_chutro == id_chutro))
                    .Select(n => new nuocViewModel
                    {
                        id_nuoc = n.id_nuoc,
                        chi_so_dau = n.chi_so_dau,
                        chi_so_cuoi = n.chi_so_cuoi,
                        thanh_tien_nuoc = n.thanh_tien_nuoc,
                        ngay_tao = n.ngay_tao,
                        ten_phong = n.hoadons
                                     .Where(h => h.phongtro.id_chutro == id_chutro)
                                     .Select(h => h.phongtro.tenphong)
                                     .FirstOrDefault()
                    });

                if (!string.IsNullOrEmpty(searchKeyword))
                {
                    query = query.Where(n =>
                        n.id_nuoc.ToLower().Contains(searchKeyword)
                        || n.ten_phong.ToLower().Contains(searchKeyword)
                        || n.chi_so_dau.ToString().Contains(searchKeyword)
                        || n.chi_so_cuoi.ToString().Contains(searchKeyword)
                        || n.thanh_tien_nuoc.ToString().Contains(searchKeyword)
                    );
                }

                return query.ToList();
            }
        }




        // R - READ (BY ID): Lấy chỉ số Nước theo ID
        public nuoc LayBanGhiNuocTheoId(string id)
        {
            using (var dbContext = new ContextDB())
            {
                return dbContext.nuocs.Find(id);
            }
        }

        // R - READ (BY ID): Lấy chỉ số Nước theo ID của hóa đơn
        public nuoc LayBanGhiNuocTheoHoaDonId(string id_hoadon)
        {
            using (var dbContext = new ContextDB())
            {
                // Tìm Hóa đơn, sau đó truy xuất chi tiết Nước
                // Sử dụng Include(hd => hd.nuoc) để tải chi tiết Nước
                var hoadon = dbContext.hoadons
                                       .Include(hd => hd.nuoc)
                                       .FirstOrDefault(hd => hd.id_hoadon == id_hoadon);

                // Trả về chi tiết Nước từ Hóa đơn (có thể là null nếu không tìm thấy)
                return hoadon?.nuoc;
            }
        }

        
    }
}