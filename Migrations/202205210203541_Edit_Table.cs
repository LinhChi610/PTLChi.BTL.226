namespace PTLChi.BTL._226.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Edit_Table : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Don_dh", "Id_NhanvienGH", "dbo.Nhanvien_GH");
            DropIndex("dbo.Don_dh", new[] { "Id_NhanvienGH" });
            RenameColumn(table: "dbo.Don_dh", name: "Id_NhanvienGH", newName: "Nhanvien_GHs_ID_NhanvienGH");
            AddColumn("dbo.Chitiet_dh", "ID_KhachHang", c => c.Int(nullable: false));
            AddColumn("dbo.Chitiet_dh", "Bao_hanh", c => c.String(nullable: false));
            AddColumn("dbo.Chitiet_dh", "Gia_khuyen_mai", c => c.String(nullable: false));
            AddColumn("dbo.Chitiet_dh", "Dia_Chi_Nhan", c => c.String(nullable: false));
            AddColumn("dbo.Chitiet_dh", "Chi_chu", c => c.String(nullable: false));
            AddColumn("dbo.Chitiet_dh", "Ngay_lap", c => c.DateTime(nullable: false));
            AddColumn("dbo.Chitiet_dh", "Id_NhanvienGH", c => c.Int(nullable: false));
            AlterColumn("dbo.Don_dh", "Nhanvien_GHs_ID_NhanvienGH", c => c.Int());
            CreateIndex("dbo.Don_dh", "Nhanvien_GHs_ID_NhanvienGH");
            AddForeignKey("dbo.Don_dh", "Nhanvien_GHs_ID_NhanvienGH", "dbo.Nhanvien_GH", "ID_NhanvienGH");
            DropColumn("dbo.Don_dh", "Bao_hanh");
            DropColumn("dbo.Don_dh", "Gia_khuyen_mai");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Don_dh", "Gia_khuyen_mai", c => c.String(nullable: false));
            AddColumn("dbo.Don_dh", "Bao_hanh", c => c.String(nullable: false));
            DropForeignKey("dbo.Don_dh", "Nhanvien_GHs_ID_NhanvienGH", "dbo.Nhanvien_GH");
            DropIndex("dbo.Don_dh", new[] { "Nhanvien_GHs_ID_NhanvienGH" });
            AlterColumn("dbo.Don_dh", "Nhanvien_GHs_ID_NhanvienGH", c => c.Int(nullable: false));
            DropColumn("dbo.Chitiet_dh", "Id_NhanvienGH");
            DropColumn("dbo.Chitiet_dh", "Ngay_lap");
            DropColumn("dbo.Chitiet_dh", "Chi_chu");
            DropColumn("dbo.Chitiet_dh", "Dia_Chi_Nhan");
            DropColumn("dbo.Chitiet_dh", "Gia_khuyen_mai");
            DropColumn("dbo.Chitiet_dh", "Bao_hanh");
            DropColumn("dbo.Chitiet_dh", "ID_KhachHang");
            RenameColumn(table: "dbo.Don_dh", name: "Nhanvien_GHs_ID_NhanvienGH", newName: "Id_NhanvienGH");
            CreateIndex("dbo.Don_dh", "Id_NhanvienGH");
            AddForeignKey("dbo.Don_dh", "Id_NhanvienGH", "dbo.Nhanvien_GH", "ID_NhanvienGH", cascadeDelete: true);
        }
    }
}
