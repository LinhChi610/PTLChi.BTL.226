using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace QLBHDTDD.Models
{
    public class DanhGia
    {
        [Key]
        [DisplayName("ID Đánh giá")]
        public int ID_DanhGia { get; set; }
        [Required, DisplayName("ID Sản phẩm")]
        public int ID_SanPham { get; set; }
        [Required, DisplayName("Họ tên người đánh giá")]
        public string HoTen { get; set; }
        [Required, DisplayName("Ngày giờ đánh giá")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Ngay_Gio { get; set; }
        [Required, DisplayName("Nội dung đánh giá")]
        public string Noi_dung { get; set; }
        [Required, DisplayName("Điện thoại người đánh giá")]
        public string Dien_thoai { get; set; }
        public virtual SanPham SanPhams { get; set; }
    }
}