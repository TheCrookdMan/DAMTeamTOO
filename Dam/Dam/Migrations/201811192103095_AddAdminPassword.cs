namespace Dam.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAdminPassword : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Admins", "AdminPassword", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Admins", "AdminPassword");
        }
    }
}
