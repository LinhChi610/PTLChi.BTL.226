﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace QLBHDTDD.Models
{
    public class Don_dh
    {
        [Key]
        [DisplayName("ID Hoá đơn")]
        public int ID_hd { get; set; }
        [Required, DisplayName("ID Khách hàng")]
        public int ID_kh { get; set; }
        [Required, DisplayName("ID tình trạng đơn đặt hàng ")]
        public int ID_tinhtrang { get; set; }
        [Required, DisplayName("ID Nhân viên giao hàng")]
        public int Id_nvgh { get; set; }
        [Required, DisplayName("Ngày lập đơn đặt hàng")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Ngay_lap { get; set; }
        [Required, DisplayName("Thời gian bảo hành")]
        public string Bao_hanh { get; set; }
        [Required, DisplayName("Giá khuyến mãi")]
        public string Gia_khuyen_mai{ get; set; }
        [Required, DisplayName("Tổng giá trị đơn hàng")]
        public int Tong_gia { get; set; }
        [Required, DisplayName("Địa điểm nhận đơn hàng")]
        public string Noi_nhan { get; set; }
        [Required, DisplayName("Ghi chú")]
        public string Chi_chu { get; set; }
        public ICollection<Chitiet_dh> Chitiet_DHs { get; set; }
        public TinhTrang_dh TinhTrang_dhs { get; set; }
        public Nhanvien_GH nhanvien_GHs { get; set; }
        public Khach_hang Khach_hangs { get; set; }
    }
}