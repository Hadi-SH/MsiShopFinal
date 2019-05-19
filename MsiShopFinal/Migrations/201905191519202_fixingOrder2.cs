namespace MsiShopFinal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fixingOrder2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Orders", "ProdId", c => c.Int(nullable: false));
            AddColumn("dbo.Orders", "Prods_SerialNumber", c => c.String(maxLength: 128));
            CreateIndex("dbo.Orders", "Prods_SerialNumber");
            AddForeignKey("dbo.Orders", "Prods_SerialNumber", "dbo.Prods", "SerialNumber");
            DropColumn("dbo.Orders", "ProdcutId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Orders", "ProdcutId", c => c.Int(nullable: false));
            DropForeignKey("dbo.Orders", "Prods_SerialNumber", "dbo.Prods");
            DropIndex("dbo.Orders", new[] { "Prods_SerialNumber" });
            DropColumn("dbo.Orders", "Prods_SerialNumber");
            DropColumn("dbo.Orders", "ProdId");
        }
    }
}
