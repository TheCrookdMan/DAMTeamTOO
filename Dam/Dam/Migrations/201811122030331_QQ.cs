namespace Dam.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class QQ : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Admins",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        AdminName = c.String(),
                        Position = c.String(),
                        DOB = c.DateTime(nullable: false),
                        PhoneNo = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Assets",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Location = c.String(),
                        CapturedBy = c.Int(nullable: false),
                        CapturedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Documents",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Field_Mappings",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Field = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Metadatas",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FieldValue = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Metadatas");
            DropTable("dbo.Field_Mappings");
            DropTable("dbo.Documents");
            DropTable("dbo.Assets");
            DropTable("dbo.Admins");
        }
    }
}
