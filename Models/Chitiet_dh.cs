using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace  PTLChi.BTL._226.Models
{
    public class Chitiet_dh
    {
        //internal object ID_SanPham;

        [Key]
        [DisplayName("ID chi tiết hoá đơn")]
        public int ID_ChitietHoaDon { get; set; }
        [Required, DisplayName("ID Hoá đơn")]
        public int ID_HoaDon { get; set; }
        [ForeignKey("ID_HoaDon")]
        public virtual Don_dh Don_dhs { get; set; }
        [Required, DisplayName("ID Khách hàng")]
        public int ID_KhachHang { get; set; }
        [Required, DisplayName("Tên Khách Hàng")]
        public string Ten_KhachHang { get; set; }
        [Required, DisplayName("ID Sản phẩm")]
        public int ID_Sanpham { get; set; }
        [ForeignKey("ID_Sanpham")]
        public virtual SanPham Sanphams { get; set; }
        [Required, DisplayName("Tên Sản Phẩm")]
        public string Ten_Sanpham { get; set; }
        [Required, DisplayName("Số lượng")]
        public int So_luong_mua { get; set; }
        [Required, DisplayName("Bảo hành")]
        public string Bao_hanh { get; set; }
        [Required, DisplayName("Giá khuyến mãi")]
        public string Gia_khuyen_mai { get; set; }
        [Required, DisplayName("Địa chỉ nhận hàng")]
        public string Dia_Chi_Nhan { get; set; }
        [Required, DisplayName("Ghi chú")]
        public string Chi_chu { get; set; }
        [Required, DisplayName("Ngày lập đơn")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Ngay_lap { get; set; }
        [Required, DisplayName("ID Nhân viên giao hàng")]
        public int Id_NhanvienGH { get; set; }
        [Required, DisplayName("Tên Nhân Viên GH")]
        public string Ten_NhanvienGH { get; set; }

        [Required, DisplayName("Tổng Hóa Đơn")]
        public int Don_gia { get; set; }

    }
}