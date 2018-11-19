namespace Dam.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateAdminsWithPW : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO[dbo].[Admins] " +
                "( [AdminName], [AdminPassword], [Position], [DOB], [PhoneNo]) " +
                "VALUES( N'Admin', N'Password1', N'Admin', N'1997-12-12 00:00:00', N'022682555')");
            Sql(" INSERT INTO[dbo].[Admins]" +
                " ([AdminName], [AdminPassword], [Position], [DOB], [PhoneNo])" +
                " VALUES(N'User', N'Password1', N'User', N'1997-12-12 00:00:00', N'5454854454')");
        }

        public override void Down()
        {
            Sql(" DELETE FROM  [dbo].[Admins] WHERE 1=1 ");
            Sql(" DBCC CHECKIDENT ('dbo.Admins', RESEED, 1) ");
        }
    }
}
