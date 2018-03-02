namespace VidlyApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedCustomerBirthDate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "BirthDate", c => c.DateTime());
            DropColumn("dbo.Customers", "Date");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "Date", c => c.DateTime());
            DropColumn("dbo.Customers", "BirthDate");
        }
    }
}
