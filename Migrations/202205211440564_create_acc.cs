namespace PTLChi.BTL._226.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class create_acc : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Don_dh", "Khach_hangs_ID_KhachHang", "dbo.Khach_hang");
            DropForeignKey("dbo.Don_dh", "ID_KhachHang", "dbo.Khach_hang");
            DropIndex("dbo.Don_dh", new[] { "ID_KhachHang" });
            DropIndex("dbo.Don_dh", new[] { "Khach_hangs_ID_KhachHang" });
            RenameColumn(table: "dbo.Don_dh", name: "Khach_hangs_ID_KhachHang", newName: "__mig_tmp__0");
            RenameColumn(table: "dbo.Don_dh", name: "ID_KhachHang", newName: "Khach_hangs_ID_KhachHang");
            RenameColumn(table: "dbo.Don_dh", name: "__mig_tmp__0", newName: "ID_KhachHang");
            CreateTable(
                "dbo.AccountModels",
                c => new
                    {
                        Username = c.String(nullable: false, maxLength: 50),
                        Password = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Username);
            
            AlterColumn("dbo.Don_dh", "Khach_hangs_ID_KhachHang", c => c.Int());
            AlterColumn("dbo.Don_dh", "ID_KhachHang", c => c.Int(nullable: false));
            CreateIndex("dbo.Don_dh", "ID_KhachHang");
            CreateIndex("dbo.Don_dh", "Khach_hangs_ID_KhachHang");
            AddForeignKey("dbo.Don_dh", "ID_KhachHang", "dbo.Khach_hang", "ID_KhachHang", cascadeDelete: true);
            AddForeignKey("dbo.Don_dh", "Khach_hangs_ID_KhachHang", "dbo.Khach_hang", "ID_KhachHang");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Don_dh", "Khach_hangs_ID_KhachHang", "dbo.Khach_hang");
            DropForeignKey("dbo.Don_dh", "ID_KhachHang", "dbo.Khach_hang");
            DropIndex("dbo.Don_dh", new[] { "Khach_hangs_ID_KhachHang" });
            DropIndex("dbo.Don_dh", new[] { "ID_KhachHang" });
            AlterColumn("dbo.Don_dh", "ID_KhachHang", c => c.Int());
            AlterColumn("dbo.Don_dh", "Khach_hangs_ID_KhachHang", c => c.Int(nullable: false));
            DropTable("dbo.AccountModels");
            RenameColumn(table: "dbo.Don_dh", name: "ID_KhachHang", newName: "__mig_tmp__0");
            RenameColumn(table: "dbo.Don_dh", name: "Khach_hangs_ID_KhachHang", newName: "ID_KhachHang");
            RenameColumn(table: "dbo.Don_dh", name: "__mig_tmp__0", newName: "Khach_hangs_ID_KhachHang");
            CreateIndex("dbo.Don_dh", "Khach_hangs_ID_KhachHang");
            CreateIndex("dbo.Don_dh", "ID_KhachHang");
            AddForeignKey("dbo.Don_dh", "ID_KhachHang", "dbo.Khach_hang", "ID_KhachHang", cascadeDelete: true);
            AddForeignKey("dbo.Don_dh", "Khach_hangs_ID_KhachHang", "dbo.Khach_hang", "ID_KhachHang");
        }
    }
}
