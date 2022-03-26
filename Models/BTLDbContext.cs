using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace PTLChi.BTL._226.Models
{
    public partial class BTLDbContext : DbContext
    {
        public BTLDbContext()
            : base("name=BTLDbContext")
        {
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }

        public System.Data.Entity.DbSet<QLBHDTDD.Models.SanPham> SanPhams { get; set; }

        public System.Data.Entity.DbSet<QLBHDTDD.Models.Danhmuc_sp> Danhmuc_sp { get; set; }

        public System.Data.Entity.DbSet<QLBHDTDD.Models.Nguoi_dung> Nguoi_dung { get; set; }

        public System.Data.Entity.DbSet<QLBHDTDD.Models.Khach_hang> Khach_hang { get; set; }

        public System.Data.Entity.DbSet<QLBHDTDD.Models.Nhanvien_GH> Nhanvien_GH { get; set; }

        public System.Data.Entity.DbSet<QLBHDTDD.Models.Sp_Ban> Sp_Ban { get; set; }

        public System.Data.Entity.DbSet<QLBHDTDD.Models.Chitiet_dh> Chitiet_DH { get; set; }

        public System.Data.Entity.DbSet<QLBHDTDD.Models.Don_dh> Don_DH { get; set; }

        public System.Data.Entity.DbSet<QLBHDTDD.Models.TinhTrang_dh> TinhTrang_Dh { get; set; }

        public System.Data.Entity.DbSet<QLBHDTDD.Models.DanhGia> DanhGias { get; set; }
    }
}
