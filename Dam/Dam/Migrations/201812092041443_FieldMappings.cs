namespace Dam.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FieldMappings : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO[dbo].[Field_Mappings] " +
                "( [Field] , [doc_ID]) " +
                "VALUES( N'Name', N'1')");
            Sql(" INSERT INTO[dbo].[Field_Mappings]" +
                "( [Field] , [doc_ID]) " +
                "VALUES( N'Surname', N'1')");
            Sql("INSERT INTO[dbo].[Field_Mappings] " +
                "( [Field] , [doc_ID]) " +
                "VALUES( N'DOB', N'1')");
            Sql(" INSERT INTO[dbo].[Field_Mappings]" +
                "( [Field] , [doc_ID]) " +
                "VALUES( N'Name', N'1')");
            Sql(" INSERT INTO[dbo].[Field_Mappings]" +
               "( [Field] , [doc_ID]) " +
               "VALUES( N'Name', N'2')");
            Sql(" INSERT INTO[dbo].[Field_Mappings]" +
               "( [Field] , [doc_ID]) " +
               "VALUES( N'Surname', N'2')");
            Sql(" INSERT INTO[dbo].[Field_Mappings]" +
               "( [Field] , [doc_ID]) " +
               "VALUES( N'DOB', N'2')");
            Sql(" INSERT INTO[dbo].[Field_Mappings]" +
               "( [Field] , [doc_ID]) " +
               "VALUES( N'Name', N'3')");
            Sql(" INSERT INTO[dbo].[Field_Mappings]" +
               "( [Field] , [doc_ID]) " +
               "VALUES( N'Surname', N'3')");
            Sql(" INSERT INTO[dbo].[Field_Mappings]" +
               "( [Field] , [doc_ID]) " +
               "VALUES( N'DOB', N'3')");
            Sql(" INSERT INTO[dbo].[Field_Mappings]" +
               "( [Field] , [doc_ID]) " +
               "VALUES( N'Date Of Intake', N'1')");
            Sql(" INSERT INTO[dbo].[Field_Mappings]" +
               "( [Field] , [doc_ID]) " +
               "VALUES( N'DOB', N'2')");
            Sql(" INSERT INTO[dbo].[Field_Mappings]" +
               "( [Field] , [doc_ID]) " +
               "VALUES( N'License Number', N'4')");
            Sql(" INSERT INTO[dbo].[Field_Mappings]" +
               "( [Field] , [doc_ID]) " +
               "VALUES( N'DOB', N'4')");
            Sql(" INSERT INTO[dbo].[Field_Mappings]" +
               "( [Field] , [doc_ID]) " +
               "VALUES( N'Name', N'4')");
            Sql(" INSERT INTO[dbo].[Field_Mappings]" +
               "( [Field] , [doc_ID]) " +
               "VALUES( N'Surname', N'4')");



        }

        public override void Down()
        {
            Sql(" DELETE FROM  [dbo].[Field_Mappings] WHERE 1=1 ");
            Sql(" DBCC CHECKIDENT ('dbo.Field_Mappings', RESEED, 1) ");
        }
    }
}
