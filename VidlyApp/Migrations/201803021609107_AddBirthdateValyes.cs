namespace VidlyApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBirthdateValyes : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET Date = '01.01.1980' WHERE Id = 1");
        }
        
        public override void Down()
        {
        }
    }
}
