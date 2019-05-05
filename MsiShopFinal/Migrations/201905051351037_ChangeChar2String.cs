namespace MsiShopFinal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeChar2String : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Products");
            AddColumn("dbo.Categorys", "Name", c => c.String());
            AddColumn("dbo.Customers", "Name", c => c.String(nullable: false));
            AddColumn("dbo.Customers", "Phone", c => c.String(nullable: false));
            AddColumn("dbo.Customers", "IntrestedIn", c => c.String());
            AddColumn("dbo.Customers", "BestBrand", c => c.String());
            AddColumn("dbo.Customers", "Email", c => c.String(nullable: false));
            AddColumn("dbo.Customers", "Country", c => c.String(nullable: false));
            AddColumn("dbo.Customers", "DetailedAddress", c => c.String(nullable: false));
            AddColumn("dbo.Customers", "TitleName", c => c.String());
            AddColumn("dbo.Titles", "Name", c => c.String());
            AddColumn("dbo.News", "Data", c => c.String(nullable: false));
            AddColumn("dbo.Resellers", "Name", c => c.String(nullable: false));
            AddColumn("dbo.Resellers", "StoreName", c => c.String(nullable: false));
            AddColumn("dbo.Resellers", "StorePhone", c => c.String(nullable: false));
            AddColumn("dbo.Resellers", "StoreLocation", c => c.String(nullable: false));
            AddColumn("dbo.Resellers", "MostBuyableBrand", c => c.String(nullable: false));
            AddColumn("dbo.Resellers", "StoreEmail", c => c.String(nullable: false));
            AddColumn("dbo.Products", "SerialNumber", c => c.String(nullable: false, maxLength: 128));
            AddColumn("dbo.Products", "Name", c => c.String(nullable: false));
            AddColumn("dbo.Products", "Specifications", c => c.String(nullable: false));
            AddColumn("dbo.Products", "Image", c => c.String(nullable: false));
            AddColumn("dbo.Products", "CategoryName", c => c.String());
            AddColumn("dbo.SpecialOffers", "SOData", c => c.String(nullable: false));
            AddPrimaryKey("dbo.Products", "SerialNumber");
            DropColumn("dbo.Products", "Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "Id", c => c.Int(nullable: false, identity: true));
            DropPrimaryKey("dbo.Products");
            DropColumn("dbo.SpecialOffers", "SOData");
            DropColumn("dbo.Products", "CategoryName");
            DropColumn("dbo.Products", "Image");
            DropColumn("dbo.Products", "Specifications");
            DropColumn("dbo.Products", "Name");
            DropColumn("dbo.Products", "SerialNumber");
            DropColumn("dbo.Resellers", "StoreEmail");
            DropColumn("dbo.Resellers", "MostBuyableBrand");
            DropColumn("dbo.Resellers", "StoreLocation");
            DropColumn("dbo.Resellers", "StorePhone");
            DropColumn("dbo.Resellers", "StoreName");
            DropColumn("dbo.Resellers", "Name");
            DropColumn("dbo.News", "Data");
            DropColumn("dbo.Titles", "Name");
            DropColumn("dbo.Customers", "TitleName");
            DropColumn("dbo.Customers", "DetailedAddress");
            DropColumn("dbo.Customers", "Country");
            DropColumn("dbo.Customers", "Email");
            DropColumn("dbo.Customers", "BestBrand");
            DropColumn("dbo.Customers", "IntrestedIn");
            DropColumn("dbo.Customers", "Phone");
            DropColumn("dbo.Customers", "Name");
            DropColumn("dbo.Categorys", "Name");
            AddPrimaryKey("dbo.Products", "Id");
        }
    }
}
