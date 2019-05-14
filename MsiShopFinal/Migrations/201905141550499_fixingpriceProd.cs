namespace MsiShopFinal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fixingpriceProd : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Prods", "Price", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Prods", "Price", c => c.Int(nullable: false));
        }
    }
}
