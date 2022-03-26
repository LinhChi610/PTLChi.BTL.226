using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace QLBHDTDD.Models
{
    public class TinhTrang_dh
    {
        [Key]
        [DisplayName("ID tình trạng đơn đặt hàng")]
        public int ID_tinh_trang { get; set; }
        [Required, DisplayName("Tình trạng đơn đặt hàng")]
        public string TinhTrangdh { get; set; }
        public ICollection<Don_dh> Don_dhs { get; set; }
    }
}