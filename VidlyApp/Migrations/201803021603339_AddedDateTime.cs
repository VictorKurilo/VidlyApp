namespace VidlyApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedDateTime : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "Date", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "Date");
        }
    }
}
