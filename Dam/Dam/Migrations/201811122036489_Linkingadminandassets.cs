namespace Dam.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Linkingadminandassets : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Assets", "CapturedBy_ID", c => c.Int());
            CreateIndex("dbo.Assets", "CapturedBy_ID");
            AddForeignKey("dbo.Assets", "CapturedBy_ID", "dbo.Admins", "ID");
            DropColumn("dbo.Assets", "CapturedBy");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Assets", "CapturedBy", c => c.Int(nullable: false));
            DropForeignKey("dbo.Assets", "CapturedBy_ID", "dbo.Admins");
            DropIndex("dbo.Assets", new[] { "CapturedBy_ID" });
            DropColumn("dbo.Assets", "CapturedBy_ID");
        }
    }
}
