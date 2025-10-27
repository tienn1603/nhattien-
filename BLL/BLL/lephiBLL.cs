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
    public class lephiBLL
    {
        //CUD không cần thêm vì đã được xử lý TransactionScope trong hoadonBLL

        // R - READ (ALL): Lấy tất cả Lệ phí
        public List<lephi> LayTatCaLePhi()
        {
            using (var dbContext = new ContextDB())
            {
                return dbContext.lephis.ToList();
            }
        }

        // R - READ (BY ID): Lấy Lệ phí theo ID
        public lephi LayLePhiTheoId(string id)
        {
            using (var dbContext = new ContextDB())
            {
                // Find() hoạt động hiệu quả khi tìm kiếm theo khóa chính
                return dbContext.lephis.Find(id);
            }
        }

        //R - READ (BY ID): Lấy Lệ phí theo ID của hóa đơn



        public List<lephiViewModel> LayBanGhiLePhiTheoHoaDonId(string id_chutro)
        {
            using (var dbContext = new ContextDB())
            {
                var list = (from lp in dbContext.lephis
                            from hd in lp.hoadons   
                            join pt in dbContext.phongtroes on hd.id_phong equals pt.id_phong
                            where pt.id_chutro == id_chutro   
                            select new lephiViewModel
                            {
                                id_lephi = lp.id_lephi,
                                ngay_tao = lp.ngay_tao,
                                tien_phong = lp.tien_phong,
                                tien_dv = lp.tien_dv,
                                thanh_tien_lephi = lp.thanh_tien_lephi,
                                ten_phong = pt.tenphong
                            }).ToList();

                return list;
            }
        }

        public List<lephiViewModel> LayTatCaLePhiTheoKeyword(string id_chutro, string keyword)
        {
            using (var dbContext = new ContextDB())
            {
                string searchKeyword = (keyword ?? string.Empty).ToLower();

                var query = from lp in dbContext.lephis
                            from hd in lp.hoadons
                            join pt in dbContext.phongtroes on hd.id_phong equals pt.id_phong
                            where pt.id_chutro == id_chutro
                            select new lephiViewModel
                            {
                                id_lephi = lp.id_lephi,
                                ngay_tao = lp.ngay_tao,
                                tien_phong = lp.tien_phong,
                                tien_dv = lp.tien_dv,
                                thanh_tien_lephi = lp.thanh_tien_lephi,
                                ten_phong = pt.tenphong
                            };

                // Nếu có từ khóa thì lọc thêm
                if (!string.IsNullOrEmpty(searchKeyword))
                {
                    query = query.Where(lp =>
                        lp.id_lephi.ToLower().Contains(searchKeyword) ||
                        lp.ten_phong.ToLower().Contains(searchKeyword)
                    );
                }

                return query.ToList();
            }
        }




    }

}

