namespace PTLChi.BTL._226.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Edit2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Chitiet_dh", "Ten_KhachHang", c => c.String(nullable: false));
            AddColumn("dbo.Chitiet_dh", "Ten_NhanvienGH", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Chitiet_dh", "Ten_NhanvienGH");
            DropColumn("dbo.Chitiet_dh", "Ten_KhachHang");
        }
    }
}
