namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
            INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'3f5d16dc-e82f-48f0-8393-f6db869cabad', N'guest@vidly.com', 0, N'AJdgWrZaGkTBPFpDWWcDcvv4aY9vIib19WzamPN5Xg9VKEQto6RnUcAFoz188dMp0g==', N'89f262a4-c0e7-4d38-abf3-c1985258db66', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
            INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'a8ab1f44-1850-4ef2-ada9-2305275956a1', N'admin@vidly.com', 0, N'ALU9bjV5d4Ms14jojbiHPtV2kUBtmJxJqLRPBP33fvFyBp88JiE4UfH04+NUznaqsw==', N'86aa034c-fbd9-4912-9b65-0b62301c7cef', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
            
            INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'05c7584d-46c2-41c5-9076-5aa6014dd282', N'CanManageMovies')
            
            INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'a8ab1f44-1850-4ef2-ada9-2305275956a1', N'05c7584d-46c2-41c5-9076-5aa6014dd282')

            ");
        }
        
        public override void Down()
        {
        }
    }
}
