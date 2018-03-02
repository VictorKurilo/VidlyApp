namespace VidlyApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNullBirthDayToCustomer2 : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET BirthDate = '01.01.1980' WHERE Id = 1");
        }
        
        public override void Down()
        {
        }
    }
}
