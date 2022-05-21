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
        public virtual DbSet<SanPham> SanPhams { get; set; }
        public virtual DbSet<Chitiet_dh> Chitiet_dhs { get; set; }
        public virtual DbSet<Danhmuc_sp> Danhmuc_sps { get; set; }
        public virtual DbSet<Khach_hang> Khach_Hangs { get; set; }       
        public virtual DbSet<Nhanvien_GH>  Nhanvien_GHs  { get; set; }
        public virtual DbSet<Don_dh> Don_Dhs { get; set; }
        public virtual DbSet<AccountModel> AccountModels { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }

        
    }
}
