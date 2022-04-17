namespace PTLChi.BTL._226.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deletetable : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Don_dh", "TinhTrang_dhs_ID_tinh_trang", "dbo.TinhTrang_dh");
            DropForeignKey("dbo.DanhGias", "ID_Sanpham", "dbo.SanPhams");
            DropForeignKey("dbo.Sp_Ban", "ID_Sanpham", "dbo.SanPhams");
            DropIndex("dbo.Don_dh", new[] { "TinhTrang_dhs_ID_tinh_trang" });
            DropIndex("dbo.DanhGias", new[] { "ID_Sanpham" });
            DropIndex("dbo.Sp_Ban", new[] { "ID_Sanpham" });
            DropColumn("dbo.Don_dh", "TinhTrang_dhs_ID_tinh_trang");
            DropTable("dbo.TinhTrang_dh");
            DropTable("dbo.DanhGias");
            DropTable("dbo.Sp_Ban");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Sp_Ban",
                c => new
                    {
                        ID_Sp_Ban = c.Int(nullable: false, identity: true),
                        ID_Sanpham = c.Int(nullable: false),
                        So_luong_ban = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID_Sp_Ban);
            
            CreateTable(
                "dbo.DanhGias",
                c => new
                    {
                        ID_DanhGia = c.Int(nullable: false, identity: true),
                        ID_Sanpham = c.Int(nullable: false),
                        HoTen = c.String(nullable: false),
                        Ngay_Gio = c.DateTime(nullable: false),
                        Noi_dung = c.String(nullable: false),
                        Dien_thoai = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID_DanhGia);
            
            CreateTable(
                "dbo.TinhTrang_dh",
                c => new
                    {
                        ID_tinh_trang = c.Int(nullable: false, identity: true),
                        TinhTrangdh = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID_tinh_trang);
            
            AddColumn("dbo.Don_dh", "TinhTrang_dhs_ID_tinh_trang", c => c.Int());
            CreateIndex("dbo.Sp_Ban", "ID_Sanpham");
            CreateIndex("dbo.DanhGias", "ID_Sanpham");
            CreateIndex("dbo.Don_dh", "TinhTrang_dhs_ID_tinh_trang");
            AddForeignKey("dbo.Sp_Ban", "ID_Sanpham", "dbo.SanPhams", "ID_Sanpham", cascadeDelete: true);
            AddForeignKey("dbo.DanhGias", "ID_Sanpham", "dbo.SanPhams", "ID_Sanpham", cascadeDelete: true);
            AddForeignKey("dbo.Don_dh", "TinhTrang_dhs_ID_tinh_trang", "dbo.TinhTrang_dh", "ID_tinh_trang");
        }
    }
}
