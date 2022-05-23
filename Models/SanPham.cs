using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace PTLChi.BTL._226.Models
{
    public class SanPham
    {
        [Key]
        
        [DisplayName("ID Sản phẩm")]
        public int ID_Sanpham { get; set; }
        [Required, DisplayName("Tên sản phẩm")]
        public string Ten_Sanpham { get; set; }
        [Required, DisplayName("Ảnh sản phẩm")]
        public string Anh_Sanpham { get; set; }
        [Required, DisplayName("Giá sản phẩm")]
        public int Gia_Sanpham { get; set; }
        [Required, DisplayName("Số lượng")]
        public int So_luong { get; set; }
        [Required, DisplayName("Kích thước")]
        public string Kich_thuoc { get; set; }
        [Required, DisplayName("Màu sắc")]
        public string Mau_sac { get; set; }
        [Required, DisplayName("Bộ nhớ")]
        public string Bo_nho { get; set; }
        [Required, DisplayName("Bảo hành")]
        public string Bao_hanh { get; set; }
        [Required, DisplayName("Giá khuyến mãi")]
        public string Gia_khuyen_mai { get; set; }
        [Required, DisplayName("Ngày bắt đầu khuyến mãi")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Batdau_km { get; set; }
        [Required, DisplayName("Ngày kết thúc khuyến mãi")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Ketthuc_km { get; set; }
        public ICollection<Chitiet_dh> Chitiet_dhs { get; set; }        
        public virtual Danhmuc_sp Danhmuc_sps { get; set; }
    }
}