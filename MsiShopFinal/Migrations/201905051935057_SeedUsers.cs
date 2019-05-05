namespace MsiShopFinal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'823270e7-15cd-4b74-99a1-c9568f0901e6', N'Admin@MsiShop.com', 0, N'AEiQz+iQ0Dye1AcTaK9/yByem4nkzy8rcidO72oS8tzpaCHfcOM1bbDwOzAR5Oebag==', N'07bcc3ff-b854-4af0-a987-2e1c4e423dd7', NULL, 0, 0, NULL, 1, 0, N'Admin@MsiShop.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'a379a995-d2c6-42f7-a536-6b8d3fa79ca9', N'hadishrara@gmail.com', 0, N'AJW41WMaVT/SFGIMMQCrzy5nSgqyzmxz5yek706bcKsQMnYyKA1AIVT53Y2DOu+UNA==', N'975a46ae-80b4-4c3a-82a4-784024bc57f5', NULL, 0, 0, NULL, 1, 0, N'hadishrara@gmail.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'76e3e9b3-1c08-4821-8fe1-a1e34ef078f3', N'CanManageProducts')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'823270e7-15cd-4b74-99a1-c9568f0901e6', N'76e3e9b3-1c08-4821-8fe1-a1e34ef078f3')
");
        }
        
        public override void Down()
        {
        }
    }
}
