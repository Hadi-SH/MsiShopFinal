namespace MsiShopFinal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fixingOrder : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Orders", "ProdcutId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Orders", "ProdcutId");
        }
    }
}
