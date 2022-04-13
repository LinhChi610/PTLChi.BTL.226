using PTLChi.BTL._226.Models;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace  PTLChi.BTL._226.Models
{
    public partial class BTLDbContext : DbContext
    {
        public BTLDbContext()
            : base("name=BTLDbContext")
        {
        }
        public DbSet<SanPham> SanPhams { get; set; }
        public DbSet<Don_dh> Don_dhs { get; set; }
        public DbSet<Chitiet_dh> Chitiet_dhs { get; set; }
        public DbSet<DanhGia> Danhgias { get; set; }
        public DbSet<Danhmuc_sp> Danhmuc_sps { get; set; }
        public DbSet<Khach_hang> Khach_Hangs { get; set; }
        public DbSet<Nguoi_dung> Nguoi_dungs { get; set; }
        public DbSet<Nhanvien_GH> Nhanvien_GHs { get; set; }
        public DbSet<TinhTrang_dh> TinhTrang_dhs { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
