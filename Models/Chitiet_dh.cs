﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace QLBHDTDD.Models
{
    public class Chitiet_dh
    {
        internal object ID_SanPham;

        [Key]
        [DisplayName("ID chi tiết hoá đơn")]
        public int ID_ChitietHoaDon { get; set; }
        [Required, DisplayName("ID Hoá đơn")]
        public int ID_HoaDon { get; set; }
        [Required, DisplayName("ID Sản phẩm")]
        public int ID_Sanpham { get; set; }
        [Required, DisplayName("Số lượng mỗi sản phẩm trong hoá đơn")]
        public int So_luong_mua { get; set; }
        [Required, DisplayName("Giá mỗi loại sản phẩm khi mua")]
        public int Don_gia { get; set; }
        public virtual SanPham Sanphams { get; set; }
        public virtual Don_dh Don_dhs { get; set; }
    }
}