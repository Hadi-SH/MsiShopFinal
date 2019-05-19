namespace MsiShopFinal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CountryToReseller : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Resellers", "Country", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Resellers", "Country");
        }
    }
}
