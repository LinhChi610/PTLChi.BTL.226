namespace PTLChi.BTL._226.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deletetable2 : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.Nguoi_dung");
        }
        
        public override void Down()
        {
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
    }
}
