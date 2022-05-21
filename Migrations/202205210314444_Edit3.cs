namespace PTLChi.BTL._226.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Edit3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Chitiet_dh", "Ten_Sanpham", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Chitiet_dh", "Ten_Sanpham");
        }
    }
}
