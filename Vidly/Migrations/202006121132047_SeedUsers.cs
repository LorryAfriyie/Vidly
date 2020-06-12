namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'466badc9-e58d-495f-a5e8-81eedca6a940', N'guest@vidly.com', 0, N'ACeL+v9ojagqXKSZZ0woi2MnmSHXK4Z9oZJqqSXuJaYQigBAKedledR4cLD6CQAdwg==', N'6c465caf-dc3b-4abb-be35-9bbc0ccdef5a', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'8a041ce1-92fa-43a2-97fc-adeb3f8f9856', N'admin@vidly.com', 0, N'AN5jp9jlBn3h7Kl2B0/lTTbcbuxAtkKhkZhtIG0iGY/WqJpp9+WonjaXPvCMf7Pd7Q==', N'0d751352-ce01-4650-b006-652a9c1c3c71', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'22b75c8e-7a30-471c-8b76-7491469c6914', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'8a041ce1-92fa-43a2-97fc-adeb3f8f9856', N'22b75c8e-7a30-471c-8b76-7491469c6914')
");
        }
        
        public override void Down()
        {
        }
    }
}
