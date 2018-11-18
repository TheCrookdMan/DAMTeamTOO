namespace Dam.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class LinkMetaAndField : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Metadatas", "FieldMeta_ID", c => c.Int());
            CreateIndex("dbo.Metadatas", "FieldMeta_ID");
            AddForeignKey("dbo.Metadatas", "FieldMeta_ID", "dbo.Field_Mappings", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Metadatas", "FieldMeta_ID", "dbo.Field_Mappings");
            DropIndex("dbo.Metadatas", new[] { "FieldMeta_ID" });
            DropColumn("dbo.Metadatas", "FieldMeta_ID");
        }
    }
}
