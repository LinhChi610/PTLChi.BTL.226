using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PTLChi.BTL._226.Models
{
    public class Khach_hang
    {
        [Key]
        [DisplayName("ID Khách hàng")]
        public int ID_KhachHang { get; set; }
        [Required, DisplayName("Tên khách hàng")]
        public string Ten_KhachHang { get; set; }
        [Required, DisplayName("SĐT khách Hàng")]
        public string Sdt { get; set; }
        [Required, DisplayName("E-mail khách Hàng")]
        public string Email { get; set; }
        public ICollection<Don_dh> Don_dhs { get; set; }
    }
}