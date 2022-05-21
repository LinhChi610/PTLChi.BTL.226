﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;


namespace PTLChi.BTL._226.Models
{
    public class Don_dh
    {
        [Key]
        [DisplayName("ID Hoá đơn")]
        public int ID_HoaDon { get; set; }
        [Required, DisplayName("ID Khách hàng")]
        public int ID_KhachHang { get; set; }
        [Required, DisplayName("Tên khách hàng")]
        public string Ten_KhachHang { get; set; }

        [Required, DisplayName("Ngày lập đơn")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Ngay_lap { get; set; }
        
        [Required, DisplayName("Tổng giá đơn hàng")]
        public int Tong_Gia { get; set; }
        [Required, DisplayName("Địa chỉ nhận hàng")]
        public string Dia_Chi_Nhan { get; set; }
        [Required, DisplayName("Ghi chú")]
        public string Chi_chu { get; set; }
        public ICollection<Chitiet_dh> Chitiet_DHs { get; set; }       
    }
}