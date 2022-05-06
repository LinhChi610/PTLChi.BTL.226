using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace PTLChi.BTL._226.Models
{
    public class Nhanvien_GH
    {
        [Key]
        [DisplayName("ID Nhân viên giao hàng")]
        public int ID_NhanvienGH { get; set; }
        [Required, DisplayName("Tên Nhân viên GH")]
        public string Ten_NhanvienGH { get; set; }
        [Required, DisplayName("SĐT1 Nhân viên GH")]
        public string Sdt_1 { get; set; }
        [Required, DisplayName("SĐT2 nhân viên GH")]
        public string Sdt_2 { get; set; }
        public ICollection<Don_dh> Don_dhs { get; set; }
    }
}