﻿namespace PTLChi.BTL._226.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class eeee : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.SanPhams", "ID_Danhmuc");
        }
        
        public override void Down()
        {
            AddColumn("dbo.SanPhams", "ID_Danhmuc", c => c.String(nullable: false));
        }
    }
}
