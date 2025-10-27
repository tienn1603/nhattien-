using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.ViewModel
{
    public class lephiViewModel
    {
        public string id_lephi { get; set; }

        public DateTime ngay_tao { get; set; }
        public decimal tien_dv { get; set; }
        public decimal tien_phong { get; set; }

        public decimal thanh_tien_lephi { get; set; }
        public string ten_phong { get; set; }
    }

}
