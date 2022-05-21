namespace PTLChi.BTL._226.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatetable4 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Don_dh", "Khach_hangs_ID_KhachHang", "dbo.Khach_hang");
            DropForeignKey("dbo.Don_dh", "ID_KhachHang", "dbo.Khach_hang");
            DropForeignKey("dbo.Don_dh", "Khach_hang_ID_KhachHang", "dbo.Khach_hang");
            DropIndex("dbo.Don_dh", new[] { "ID_KhachHang" });
            DropIndex("dbo.Don_dh", new[] { "Khach_hang_ID_KhachHang" });
            DropIndex("dbo.Don_dh", new[] { "Khach_hangs_ID_KhachHang" });
            DropColumn("dbo.Don_dh", "ID_KhachHang");
            RenameColumn(table: "dbo.Don_dh", name: "Khach_hang_ID_KhachHang", newName: "ID_KhachHang");
            AlterColumn("dbo.Don_dh", "ID_KhachHang", c => c.Int(nullable: false));
            CreateIndex("dbo.Don_dh", "ID_KhachHang");
            AddForeignKey("dbo.Don_dh", "ID_KhachHang", "dbo.Khach_hang", "ID_KhachHang", cascadeDelete: true);
            DropColumn("dbo.Don_dh", "Khach_hangs_ID_KhachHang");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Don_dh", "Khach_hangs_ID_KhachHang", c => c.Int());
            DropForeignKey("dbo.Don_dh", "ID_KhachHang", "dbo.Khach_hang");
            DropIndex("dbo.Don_dh", new[] { "ID_KhachHang" });
            AlterColumn("dbo.Don_dh", "ID_KhachHang", c => c.Int());
            RenameColumn(table: "dbo.Don_dh", name: "ID_KhachHang", newName: "Khach_hang_ID_KhachHang");
            AddColumn("dbo.Don_dh", "ID_KhachHang", c => c.Int(nullable: false));
            CreateIndex("dbo.Don_dh", "Khach_hangs_ID_KhachHang");
            CreateIndex("dbo.Don_dh", "Khach_hang_ID_KhachHang");
            CreateIndex("dbo.Don_dh", "ID_KhachHang");
            AddForeignKey("dbo.Don_dh", "Khach_hang_ID_KhachHang", "dbo.Khach_hang", "ID_KhachHang");
            AddForeignKey("dbo.Don_dh", "ID_KhachHang", "dbo.Khach_hang", "ID_KhachHang", cascadeDelete: true);
            AddForeignKey("dbo.Don_dh", "Khach_hangs_ID_KhachHang", "dbo.Khach_hang", "ID_KhachHang");
        }
    }
}
