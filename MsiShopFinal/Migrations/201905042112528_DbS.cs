namespace MsiShopFinal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DbS : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categorys",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DOB = c.DateTime(nullable: false),
                        SpentTimeOnGaming = c.Int(nullable: false),
                        Titles_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Titles", t => t.Titles_Id)
                .Index(t => t.Titles_Id);
            
            CreateTable(
                "dbo.Titles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.News",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CustomerId = c.Int(nullable: false),
                        ResellerId = c.Int(nullable: false),
                        Customers_Id = c.Int(),
                        Resellers_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customers", t => t.Customers_Id)
                .ForeignKey("dbo.Resellers", t => t.Resellers_Id)
                .Index(t => t.Customers_Id)
                .Index(t => t.Resellers_Id);
            
            CreateTable(
                "dbo.Resellers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NetWorthPerMonth = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Price = c.Int(nullable: false),
                        Buyable = c.Boolean(nullable: false),
                        Categorys_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categorys", t => t.Categorys_Id)
                .Index(t => t.Categorys_Id);
            
            CreateTable(
                "dbo.SpecialOffers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "Categorys_Id", "dbo.Categorys");
            DropForeignKey("dbo.Orders", "Resellers_Id", "dbo.Resellers");
            DropForeignKey("dbo.Orders", "Customers_Id", "dbo.Customers");
            DropForeignKey("dbo.Customers", "Titles_Id", "dbo.Titles");
            DropIndex("dbo.Products", new[] { "Categorys_Id" });
            DropIndex("dbo.Orders", new[] { "Resellers_Id" });
            DropIndex("dbo.Orders", new[] { "Customers_Id" });
            DropIndex("dbo.Customers", new[] { "Titles_Id" });
            DropTable("dbo.SpecialOffers");
            DropTable("dbo.Products");
            DropTable("dbo.Resellers");
            DropTable("dbo.Orders");
            DropTable("dbo.News");
            DropTable("dbo.Titles");
            DropTable("dbo.Customers");
            DropTable("dbo.Categorys");
        }
    }
}
