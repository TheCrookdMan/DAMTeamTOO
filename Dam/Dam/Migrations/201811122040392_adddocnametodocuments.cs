namespace Dam.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class adddocnametodocuments : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Documents", "Docname", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Documents", "Docname");
        }
    }
}
