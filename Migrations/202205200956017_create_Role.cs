namespace PTLChi.BTL._226.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class create_Role : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        Roleid = c.String(nullable: false, maxLength: 128),
                        Rolename = c.String(),
                        Roles_Roleid = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Roleid)
                .ForeignKey("dbo.Roles", t => t.Roles_Roleid)
                .Index(t => t.Roles_Roleid);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Roles", "Roles_Roleid", "dbo.Roles");
            DropIndex("dbo.Roles", new[] { "Roles_Roleid" });
            DropTable("dbo.Roles");
        }
    }
}
