namespace PTLChi.BTL._226.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Chitiet_dh",
                c => new
                    {
                        ID_ct_hd = c.Int(nullable: false, identity: true),
                        ID_hd = c.Int(nullable: false),
                        ID_sp = c.Int(nullable: false),
                        So_luong_mua = c.Int(nullable: false),
                        Don_gia = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID_ct_hd)
                .ForeignKey("dbo.SanPhams", t => t.ID_sp, cascadeDelete: true)
                .ForeignKey("dbo.Don_dh", t => t.ID_hd, cascadeDelete: true)
                .Index(t => t.ID_hd)
                .Index(t => t.ID_sp);
            
            CreateTable(
                "dbo.SanPhams",
                c => new
                    {
                        ID_sp = c.Int(nullable: false, identity: true),
                        ID_dm = c.String(nullable: false),
                        Ten_sp = c.String(nullable: false),
                        Anh_sp = c.String(nullable: false),
                        Gia_sp = c.Int(nullable: false),
                        So_luong = c.Int(nullable: false),
                        Kich_thuoc = c.String(nullable: false),
                        Mau_sac = c.String(nullable: false),
                        Bo_nho = c.String(nullable: false),
                        Bao_hanh = c.String(nullable: false),
                        Gia_km = c.String(nullable: false),
                        Batdau_km = c.DateTime(nullable: false),
                        Ketthuc_km = c.DateTime(nullable: false),
                        Danhmuc_sps_ID_dm = c.Int(),
                    })
                .PrimaryKey(t => t.ID_sp)
                .ForeignKey("dbo.Danhmuc_sp", t => t.Danhmuc_sps_ID_dm)
                .Index(t => t.Danhmuc_sps_ID_dm);
            
            CreateTable(
                "dbo.DanhGias",
                c => new
                    {
                        ID_dg = c.Int(nullable: false, identity: true),
                        ID_sp = c.Int(nullable: false),
                        Ho_ten = c.String(nullable: false),
                        Ngay_gio = c.DateTime(nullable: false),
                        Noi_dung = c.String(nullable: false),
                        Dien_thoai = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID_dg)
                .ForeignKey("dbo.SanPhams", t => t.ID_sp, cascadeDelete: true)
                .Index(t => t.ID_sp);
            
            CreateTable(
                "dbo.Danhmuc_sp",
                c => new
                    {
                        ID_dm = c.Int(nullable: false, identity: true),
                        Ten_danhmuc = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID_dm);
            
            CreateTable(
                "dbo.Sp_Ban",
                c => new
                    {
                        ID_sp_ban = c.Int(nullable: false, identity: true),
                        ID_sp = c.Int(nullable: false),
                        So_luong_ban = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID_sp_ban)
                .ForeignKey("dbo.SanPhams", t => t.ID_sp, cascadeDelete: true)
                .Index(t => t.ID_sp);
            
            CreateTable(
                "dbo.Don_dh",
                c => new
                    {
                        ID_hd = c.Int(nullable: false, identity: true),
                        ID_kh = c.Int(nullable: false),
                        ID_tinhtrang = c.Int(nullable: false),
                        Id_nvgh = c.Int(nullable: false),
                        Ngay_lap = c.DateTime(nullable: false),
                        Bao_hanh = c.String(nullable: false),
                        Gia_khuyen_mai = c.String(nullable: false),
                        Tong_gia = c.Int(nullable: false),
                        Noi_nhan = c.String(nullable: false),
                        Chi_chu = c.String(nullable: false),
                        TinhTrang_dhs_ID_tinh_trang = c.Int(),
                    })
                .PrimaryKey(t => t.ID_hd)
                .ForeignKey("dbo.Khach_hang", t => t.ID_kh, cascadeDelete: true)
                .ForeignKey("dbo.Nhanvien_GH", t => t.Id_nvgh, cascadeDelete: true)
                .ForeignKey("dbo.TinhTrang_dh", t => t.TinhTrang_dhs_ID_tinh_trang)
                .Index(t => t.ID_kh)
                .Index(t => t.Id_nvgh)
                .Index(t => t.TinhTrang_dhs_ID_tinh_trang);
            
            CreateTable(
                "dbo.Khach_hang",
                c => new
                    {
                        ID_kh = c.Int(nullable: false, identity: true),
                        Ten_kh = c.String(nullable: false),
                        Sdt = c.String(nullable: false),
                        Email = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID_kh);
            
            CreateTable(
                "dbo.Nhanvien_GH",
                c => new
                    {
                        ID_nvgh = c.Int(nullable: false, identity: true),
                        Ten_nvgh = c.String(nullable: false),
                        Sdt_1 = c.String(nullable: false),
                        Sdt_2 = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID_nvgh);
            
            CreateTable(
                "dbo.TinhTrang_dh",
                c => new
                    {
                        ID_tinh_trang = c.Int(nullable: false, identity: true),
                        TinhTrangdh = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID_tinh_trang);
            
            CreateTable(
                "dbo.Nguoi_dung",
                c => new
                    {
                        ID_nd = c.Int(nullable: false, identity: true),
                        ID = c.String(nullable: false),
                        Pass = c.String(nullable: false),
                        Ten = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID_nd);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Don_dh", "TinhTrang_dhs_ID_tinh_trang", "dbo.TinhTrang_dh");
            DropForeignKey("dbo.Don_dh", "Id_nvgh", "dbo.Nhanvien_GH");
            DropForeignKey("dbo.Don_dh", "ID_kh", "dbo.Khach_hang");
            DropForeignKey("dbo.Chitiet_dh", "ID_hd", "dbo.Don_dh");
            DropForeignKey("dbo.Sp_Ban", "ID_sp", "dbo.SanPhams");
            DropForeignKey("dbo.SanPhams", "Danhmuc_sps_ID_dm", "dbo.Danhmuc_sp");
            DropForeignKey("dbo.DanhGias", "ID_sp", "dbo.SanPhams");
            DropForeignKey("dbo.Chitiet_dh", "ID_sp", "dbo.SanPhams");
            DropIndex("dbo.Don_dh", new[] { "TinhTrang_dhs_ID_tinh_trang" });
            DropIndex("dbo.Don_dh", new[] { "Id_nvgh" });
            DropIndex("dbo.Don_dh", new[] { "ID_kh" });
            DropIndex("dbo.Sp_Ban", new[] { "ID_sp" });
            DropIndex("dbo.DanhGias", new[] { "ID_sp" });
            DropIndex("dbo.SanPhams", new[] { "Danhmuc_sps_ID_dm" });
            DropIndex("dbo.Chitiet_dh", new[] { "ID_sp" });
            DropIndex("dbo.Chitiet_dh", new[] { "ID_hd" });
            DropTable("dbo.Nguoi_dung");
            DropTable("dbo.TinhTrang_dh");
            DropTable("dbo.Nhanvien_GH");
            DropTable("dbo.Khach_hang");
            DropTable("dbo.Don_dh");
            DropTable("dbo.Sp_Ban");
            DropTable("dbo.Danhmuc_sp");
            DropTable("dbo.DanhGias");
            DropTable("dbo.SanPhams");
            DropTable("dbo.Chitiet_dh");
        }
    }
}
