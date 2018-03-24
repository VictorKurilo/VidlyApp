namespace VidlyApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'ea29c182-97a2-4dcb-bb79-72862a89cd04', N'admin@vidly.com', 0, N'AO+OvC68H7/MV1rfy7R3/yzGn9pImNvcafCmPxik9a1s242zbaDvuy0erVKjdOXqqQ==', N'837917ea-3e36-42fc-87c7-625f84a7ec06', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'f6a5b061-4fdf-4476-b591-430d44b8b578', N'guest@vidly.com', 0, N'AIYY7lSqqVCNhFt3PZn91Zcwah9sfNqUZRpIo4t1T3wZXSQoWJKWawcwSdhQR64Dww==', N'809ab499-5812-493f-ba39-3a84f7eb017e', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'12bb084f-ac67-4d3e-8f66-5ccbe326fa46', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'ea29c182-97a2-4dcb-bb79-72862a89cd04', N'12bb084f-ac67-4d3e-8f66-5ccbe326fa46')
  ");
        }
        
        public override void Down()
        {
        }
    }
}
