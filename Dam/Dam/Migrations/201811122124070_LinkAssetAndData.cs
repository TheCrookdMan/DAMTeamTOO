namespace Dam.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class LinkAssetAndData : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Field_Mappings", name: "document_ID", newName: "doc_ID");
            RenameIndex(table: "dbo.Field_Mappings", name: "IX_document_ID", newName: "IX_doc_ID");
            AddColumn("dbo.Assets", "DocID_ID", c => c.Int());
            AddColumn("dbo.Metadatas", "document_ID", c => c.Int());
            CreateIndex("dbo.Assets", "DocID_ID");
            CreateIndex("dbo.Metadatas", "document_ID");
            AddForeignKey("dbo.Assets", "DocID_ID", "dbo.Documents", "ID");
            AddForeignKey("dbo.Metadatas", "document_ID", "dbo.Documents", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Metadatas", "document_ID", "dbo.Documents");
            DropForeignKey("dbo.Assets", "DocID_ID", "dbo.Documents");
            DropIndex("dbo.Metadatas", new[] { "document_ID" });
            DropIndex("dbo.Assets", new[] { "DocID_ID" });
            DropColumn("dbo.Metadatas", "document_ID");
            DropColumn("dbo.Assets", "DocID_ID");
            RenameIndex(table: "dbo.Field_Mappings", name: "IX_doc_ID", newName: "IX_document_ID");
            RenameColumn(table: "dbo.Field_Mappings", name: "doc_ID", newName: "document_ID");
        }
    }
}
