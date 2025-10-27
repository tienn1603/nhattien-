using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.ViewModel
{
    public class nuocViewModel
    {
        public string id_nuoc { get; set; }
        public decimal chi_so_dau { get; set; }
        public decimal chi_so_cuoi { get; set; }
        public decimal thanh_tien_nuoc { get; set; }
        public DateTime ngay_tao { get; set; }
        public string ten_phong { get; set; }
    }
}
