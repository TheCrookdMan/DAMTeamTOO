namespace Dam.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class LinkAssetandMeta : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Metadatas", "AssetMeta_ID", c => c.Int());
            CreateIndex("dbo.Metadatas", "AssetMeta_ID");
            AddForeignKey("dbo.Metadatas", "AssetMeta_ID", "dbo.Assets", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Metadatas", "AssetMeta_ID", "dbo.Assets");
            DropIndex("dbo.Metadatas", new[] { "AssetMeta_ID" });
            DropColumn("dbo.Metadatas", "AssetMeta_ID");
        }
    }
}
