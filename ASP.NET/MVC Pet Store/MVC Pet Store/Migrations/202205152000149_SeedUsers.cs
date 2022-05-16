namespace MVC_Pet_Store.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'679126d0-63be-49ec-a1b9-f1f369fbe29c', N'eduardcf90@gmail.com', 0, N'AI2K3rezGHCQPMf2IlKpjMxzz57xjlRy9GhItYpl11K3z/KjI4SfXGq/WLpFJALuAw==', N'f5a5409b-663f-4fa1-a5bd-52f5730a36d0', NULL, 0, 0, NULL, 1, 0, N'eduardcf90@gmail.com');
                  INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'a40879a4-dce7-462f-9813-973b9c7eaefc', N'admin@petstore.com', 0, N'ACk1XKWQD9NxA3jrbhYKUZMcKS4vsCqsHf37PA8G1sm30ZbRAWSIQ2mYox3n2xA1DA==', N'e6d6ec56-520a-435b-b187-ad9edca46896', NULL, 0, 0, NULL, 1, 0, N'admin@petstore.com');
                  INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'09e47103-5471-4443-acd5-2275e363c2be', N'Manager');
                  INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'a40879a4-dce7-462f-9813-973b9c7eaefc', N'09e47103-5471-4443-acd5-2275e363c2be');
               ");
        }
        
        public override void Down()
        {
        }
    }
}
