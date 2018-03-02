namespace VidlyApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDatatoMembershipType : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MembershipTypes SET Name = 'Pay as You go' WHERE Id = 1");
            Sql("UPDATE MembershipTypes SET Name = 'Monthly' WHERE Id = 2");
            Sql("UPDATE MembershipTypes SET Name = 'Monthly' WHERE Id = 3");
            Sql("UPDATE MembershipTypes SET Name = 'Monthly' WHERE Id = 4");
        }
        
        public override void Down()
        {
        }
    }
}
