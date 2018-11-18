namespace Dam.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class LinkDocumentsAndFieldMappings : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Field_Mappings", "document_ID", c => c.Int());
            CreateIndex("dbo.Field_Mappings", "document_ID");
            AddForeignKey("dbo.Field_Mappings", "document_ID", "dbo.Documents", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Field_Mappings", "document_ID", "dbo.Documents");
            DropIndex("dbo.Field_Mappings", new[] { "document_ID" });
            DropColumn("dbo.Field_Mappings", "document_ID");
        }
    }
}
