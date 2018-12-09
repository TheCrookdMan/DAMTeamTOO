namespace Dam.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateDocumentsTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO[dbo].[Documents] " +
                "( [Docname] ) " +
                "VALUES( N'Intake Form')");
            Sql(" INSERT INTO[dbo].[Documents]" +
                " ([Docname])" +
                " VALUES(N'Birth Certificate')");
            Sql("INSERT INTO[dbo].[Documents] " +
                "( [Docname] ) " +
                "VALUES( N'Medical Form')");
            Sql(" INSERT INTO[dbo].[Documents]" +
                " ([Docname])" +
                " VALUES(N'Driving License')");
        }

        public override void Down()
        {
            Sql(" DELETE FROM  [dbo].[Documents] WHERE 1=1 ");
            Sql(" DBCC CHECKIDENT ('dbo.Documents', RESEED, 1) ");
        }
    }
}
