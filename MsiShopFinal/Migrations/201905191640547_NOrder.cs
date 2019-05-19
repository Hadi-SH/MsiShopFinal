namespace MsiShopFinal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NOrder : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.NOrders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CustomerId = c.Int(nullable: false),
                        ResellerId = c.Int(nullable: false),
                        ProdName = c.String(),
                        Customers_Id = c.Int(),
                        Prods_SerialNumber = c.String(maxLength: 128),
                        Resellers_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customers", t => t.Customers_Id)
                .ForeignKey("dbo.Prods", t => t.Prods_SerialNumber)
                .ForeignKey("dbo.Resellers", t => t.Resellers_Id)
                .Index(t => t.Customers_Id)
                .Index(t => t.Prods_SerialNumber)
                .Index(t => t.Resellers_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.NOrders", "Resellers_Id", "dbo.Resellers");
            DropForeignKey("dbo.NOrders", "Prods_SerialNumber", "dbo.Prods");
            DropForeignKey("dbo.NOrders", "Customers_Id", "dbo.Customers");
            DropIndex("dbo.NOrders", new[] { "Resellers_Id" });
            DropIndex("dbo.NOrders", new[] { "Prods_SerialNumber" });
            DropIndex("dbo.NOrders", new[] { "Customers_Id" });
            DropTable("dbo.NOrders");
        }
    }
}
