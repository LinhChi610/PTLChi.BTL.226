﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace PTLChi.BTL._226.Models
{
    public class Danhmuc_sp
    {
        [Key]
        [DisplayName("ID Danh mục")]
        public int ID_Danhmuc { get; set; }
        [Required, DisplayName("Tên danh mục")]
        public string Ten_Danhmuc { get; set; }
        public ICollection<SanPham> SanPhams { get; set; }
    }
}