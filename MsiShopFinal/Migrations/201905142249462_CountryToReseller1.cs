namespace MsiShopFinal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CountryToReseller1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Resellers", "StoreCountry", c => c.String(nullable: false));
            DropColumn("dbo.Resellers", "Country");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Resellers", "Country", c => c.String(nullable: false));
            DropColumn("dbo.Resellers", "StoreCountry");
        }
    }
}
