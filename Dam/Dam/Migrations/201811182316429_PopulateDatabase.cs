namespace Dam.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class PopulateDatabase : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO[dbo].[Admins] " +
                "([ID], [AdminName], [Position], [DOB], [PhoneNo]) " +
                "VALUES(1, N'Admin', N'Admin', N'1997-12-12 00:00:00', N'022682555')");
            Sql(" INSERT INTO[dbo].[Admins]" +
        " ([ID], [AdminName], [Position], [DOB], [PhoneNo])" +
        " VALUES(2, N'User', N'User', N'1997-12-12 00:00:00', N'5454854454')");


        }

        public override void Down()
        {

            Sql(" TRUNCATE [dbo].[Admins] ");
        }
    }
}
