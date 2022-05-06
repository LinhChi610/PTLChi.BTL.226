namespace PTLChi.BTL._226.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteTable3 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Don_dh", "ID_tinhtrang");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Don_dh", "ID_tinhtrang", c => c.Int(nullable: false));
        }
    }
}
