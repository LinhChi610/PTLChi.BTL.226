namespace PTLChi.BTL._226.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Roles", "Roles_Roleid", "dbo.Roles");
            DropForeignKey("dbo.Don_dh", "ID_KhachHang", "dbo.Khach_hang");
            DropIndex("dbo.Roles", new[] { "Roles_Roleid" });
            RenameColumn(table: "dbo.Don_dh", name: "Nhanvien_GHs_ID_NhanvienGH", newName: "Nhanvien_GH_ID_NhanvienGH");
            RenameIndex(table: "dbo.Don_dh", name: "IX_Nhanvien_GHs_ID_NhanvienGH", newName: "IX_Nhanvien_GH_ID_NhanvienGH");
            AddColumn("dbo.Chitiet_dh", "Ten_KhachHang", c => c.String(nullable: false));
            AddColumn("dbo.Chitiet_dh", "Ten_Sanpham", c => c.String(nullable: false));
            AddColumn("dbo.Chitiet_dh", "Ten_NhanvienGH", c => c.String(nullable: false));
            AddColumn("dbo.Don_dh", "Khach_hang_ID_KhachHang", c => c.Int());
            AddColumn("dbo.Don_dh", "Khach_hangs_ID_KhachHang", c => c.Int());
            CreateIndex("dbo.Don_dh", "Khach_hang_ID_KhachHang");
            CreateIndex("dbo.Don_dh", "Khach_hangs_ID_KhachHang");
            AddForeignKey("dbo.Don_dh", "Khach_hangs_ID_KhachHang", "dbo.Khach_hang", "ID_KhachHang");
            AddForeignKey("dbo.Don_dh", "Khach_hang_ID_KhachHang", "dbo.Khach_hang", "ID_KhachHang");            
            DropTable("dbo.Roles");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        Roleid = c.String(nullable: false, maxLength: 128),
                        Rolename = c.String(),
                        Roles_Roleid = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Roleid);
            
            CreateTable(
                "dbo.AccountModels",
                c => new
                    {
                        Username = c.String(nullable: false, maxLength: 128),
                        Password = c.String(nullable: false),
                        Roleid = c.String(),
                    })
                .PrimaryKey(t => t.Username);
            
            DropForeignKey("dbo.Don_dh", "Khach_hang_ID_KhachHang", "dbo.Khach_hang");
            DropForeignKey("dbo.Don_dh", "Khach_hangs_ID_KhachHang", "dbo.Khach_hang");
            DropIndex("dbo.Don_dh", new[] { "Khach_hangs_ID_KhachHang" });
            DropIndex("dbo.Don_dh", new[] { "Khach_hang_ID_KhachHang" });
            DropColumn("dbo.Don_dh", "Khach_hangs_ID_KhachHang");
            DropColumn("dbo.Don_dh", "Khach_hang_ID_KhachHang");
            DropColumn("dbo.Chitiet_dh", "Ten_NhanvienGH");
            DropColumn("dbo.Chitiet_dh", "Ten_Sanpham");
            DropColumn("dbo.Chitiet_dh", "Ten_KhachHang");
            RenameIndex(table: "dbo.Don_dh", name: "IX_Nhanvien_GH_ID_NhanvienGH", newName: "IX_Nhanvien_GHs_ID_NhanvienGH");
            RenameColumn(table: "dbo.Don_dh", name: "Nhanvien_GH_ID_NhanvienGH", newName: "Nhanvien_GHs_ID_NhanvienGH");
            CreateIndex("dbo.Roles", "Roles_Roleid");
            AddForeignKey("dbo.Don_dh", "ID_KhachHang", "dbo.Khach_hang", "ID_KhachHang", cascadeDelete: true);
            AddForeignKey("dbo.Roles", "Roles_Roleid", "dbo.Roles", "Roleid");
        }
    }
}
