namespace PTLChi.BTL._226.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test : DbMigration
    {
        public override void Up()
        {
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
                .PrimaryKey(t => t.ID_DanhGia)
                .ForeignKey("dbo.SanPhams", t => t.ID_Sanpham, cascadeDelete: true)
                .Index(t => t.ID_Sanpham);
            
            CreateTable(
                "dbo.SanPhams",
                c => new
                    {
                        ID_Sanpham = c.Int(nullable: false, identity: true),
                        ID_Danhmuc = c.String(nullable: false),
                        Ten_Sanpham = c.String(nullable: false),
                        Anh_Sanpham = c.String(nullable: false),
                        Gia_Sanpham = c.Int(nullable: false),
                        So_luong = c.Int(nullable: false),
                        Kich_thuoc = c.String(nullable: false),
                        Mau_sac = c.String(nullable: false),
                        Bo_nho = c.String(nullable: false),
                        Bao_hanh = c.String(nullable: false),
                        Gia_khuyen_mai = c.String(nullable: false),
                        Batdau_km = c.DateTime(nullable: false),
                        Ketthuc_km = c.DateTime(nullable: false),
                        Danhmuc_sps_ID_Danhmuc = c.Int(),
                    })
                .PrimaryKey(t => t.ID_Sanpham)
                .ForeignKey("dbo.Danhmuc_sp", t => t.Danhmuc_sps_ID_Danhmuc)
                .Index(t => t.Danhmuc_sps_ID_Danhmuc);
            
            CreateTable(
                "dbo.Chitiet_dh",
                c => new
                    {
                        ID_ChitietHoaDon = c.Int(nullable: false, identity: true),
                        ID_HoaDon = c.Int(nullable: false),
                        ID_Sanpham = c.Int(nullable: false),
                        So_luong_mua = c.Int(nullable: false),
                        Don_gia = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID_ChitietHoaDon)
                .ForeignKey("dbo.Don_dh", t => t.ID_HoaDon, cascadeDelete: true)
                .ForeignKey("dbo.SanPhams", t => t.ID_Sanpham, cascadeDelete: true)
                .Index(t => t.ID_HoaDon)
                .Index(t => t.ID_Sanpham);
            
            CreateTable(
                "dbo.Don_dh",
                c => new
                    {
                        ID_HoaDon = c.Int(nullable: false, identity: true),
                        ID_KhachHang = c.Int(nullable: false),
                        ID_tinhtrang = c.Int(nullable: false),
                        Id_NhanvienGH = c.Int(nullable: false),
                        Ngay_lap = c.DateTime(nullable: false),
                        Bao_hanh = c.String(nullable: false),
                        Gia_khuyen_mai = c.String(nullable: false),
                        Tong_Gia = c.Int(nullable: false),
                        Dia_Chi_Nhan = c.String(nullable: false),
                        Chi_chu = c.String(nullable: false),
                        TinhTrang_dhs_ID_tinh_trang = c.Int(),
                    })
                .PrimaryKey(t => t.ID_HoaDon)
                .ForeignKey("dbo.Khach_hang", t => t.ID_KhachHang, cascadeDelete: true)
                .ForeignKey("dbo.Nhanvien_GH", t => t.Id_NhanvienGH, cascadeDelete: true)
                .ForeignKey("dbo.TinhTrang_dh", t => t.TinhTrang_dhs_ID_tinh_trang)
                .Index(t => t.ID_KhachHang)
                .Index(t => t.Id_NhanvienGH)
                .Index(t => t.TinhTrang_dhs_ID_tinh_trang);
            
            CreateTable(
                "dbo.Khach_hang",
                c => new
                    {
                        ID_KhachHang = c.Int(nullable: false, identity: true),
                        Ten_KhachHang = c.String(nullable: false),
                        Sdt = c.String(nullable: false),
                        Email = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID_KhachHang);
            
            CreateTable(
                "dbo.Nhanvien_GH",
                c => new
                    {
                        ID_NhanvienGH = c.Int(nullable: false, identity: true),
                        Ten_NhanvienGH = c.String(nullable: false),
                        Sdt_1 = c.String(nullable: false),
                        Sdt_2 = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID_NhanvienGH);
            
            CreateTable(
                "dbo.TinhTrang_dh",
                c => new
                    {
                        ID_tinh_trang = c.Int(nullable: false, identity: true),
                        TinhTrangdh = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID_tinh_trang);
            
            CreateTable(
                "dbo.Danhmuc_sp",
                c => new
                    {
                        ID_Danhmuc = c.Int(nullable: false, identity: true),
                        Ten_Danhmuc = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID_Danhmuc);
            
            CreateTable(
                "dbo.Sp_Ban",
                c => new
                    {
                        ID_Sp_Ban = c.Int(nullable: false, identity: true),
                        ID_Sanpham = c.Int(nullable: false),
                        So_luong_ban = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID_Sp_Ban)
                .ForeignKey("dbo.SanPhams", t => t.ID_Sanpham, cascadeDelete: true)
                .Index(t => t.ID_Sanpham);
            
            CreateTable(
                "dbo.Nguoi_dung",
                c => new
                    {
                        ID_Nguoidung = c.Int(nullable: false, identity: true),
                        ID = c.String(nullable: false),
                        Pass = c.String(nullable: false),
                        Ten = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID_Nguoidung);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Sp_Ban", "ID_Sanpham", "dbo.SanPhams");
            DropForeignKey("dbo.SanPhams", "Danhmuc_sps_ID_Danhmuc", "dbo.Danhmuc_sp");
            DropForeignKey("dbo.DanhGias", "ID_Sanpham", "dbo.SanPhams");
            DropForeignKey("dbo.Chitiet_dh", "ID_Sanpham", "dbo.SanPhams");
            DropForeignKey("dbo.Don_dh", "TinhTrang_dhs_ID_tinh_trang", "dbo.TinhTrang_dh");
            DropForeignKey("dbo.Don_dh", "Id_NhanvienGH", "dbo.Nhanvien_GH");
            DropForeignKey("dbo.Don_dh", "ID_KhachHang", "dbo.Khach_hang");
            DropForeignKey("dbo.Chitiet_dh", "ID_HoaDon", "dbo.Don_dh");
            DropIndex("dbo.Sp_Ban", new[] { "ID_Sanpham" });
            DropIndex("dbo.Don_dh", new[] { "TinhTrang_dhs_ID_tinh_trang" });
            DropIndex("dbo.Don_dh", new[] { "Id_NhanvienGH" });
            DropIndex("dbo.Don_dh", new[] { "ID_KhachHang" });
            DropIndex("dbo.Chitiet_dh", new[] { "ID_Sanpham" });
            DropIndex("dbo.Chitiet_dh", new[] { "ID_HoaDon" });
            DropIndex("dbo.SanPhams", new[] { "Danhmuc_sps_ID_Danhmuc" });
            DropIndex("dbo.DanhGias", new[] { "ID_Sanpham" });
            DropTable("dbo.Nguoi_dung");
            DropTable("dbo.Sp_Ban");
            DropTable("dbo.Danhmuc_sp");
            DropTable("dbo.TinhTrang_dh");
            DropTable("dbo.Nhanvien_GH");
            DropTable("dbo.Khach_hang");
            DropTable("dbo.Don_dh");
            DropTable("dbo.Chitiet_dh");
            DropTable("dbo.SanPhams");
            DropTable("dbo.DanhGias");
        }
    }
}
