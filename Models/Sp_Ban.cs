using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace QLBHDTDD.Models
{
    public class Sp_Ban
    {
        [Key]
        [DisplayName("ID Sản phẩm bán")]
        public int ID_Sp_Ban { get; set; }
        [Required, DisplayName("ID Sản phẩm")]
        public int ID_Sanpham { get; set; }
        [Required, DisplayName("Số lượng bán")]
        public int So_luong_ban { get; set; }
        public virtual SanPham SanPhams { get; set; }
    }
}