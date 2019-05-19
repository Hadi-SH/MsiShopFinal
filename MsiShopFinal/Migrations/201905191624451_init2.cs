namespace MsiShopFinal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Orders", "Customers_Id", "dbo.Customers");
            DropForeignKey("dbo.Orders", "Prods_SerialNumber", "dbo.Prods");
            DropForeignKey("dbo.Orders", "Resellers_Id", "dbo.Resellers");
            DropIndex("dbo.Orders", new[] { "Customers_Id" });
            DropIndex("dbo.Orders", new[] { "Prods_SerialNumber" });
            DropIndex("dbo.Orders", new[] { "Resellers_Id" });
            DropTable("dbo.Orders");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CustomerId = c.Int(nullable: false),
                        ResellerId = c.Int(nullable: false),
                        ProdSerialNumber = c.Int(nullable: false),
                        Customers_Id = c.Int(),
                        Prods_SerialNumber = c.String(maxLength: 128),
                        Resellers_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateIndex("dbo.Orders", "Resellers_Id");
            CreateIndex("dbo.Orders", "Prods_SerialNumber");
            CreateIndex("dbo.Orders", "Customers_Id");
            AddForeignKey("dbo.Orders", "Resellers_Id", "dbo.Resellers", "Id");
            AddForeignKey("dbo.Orders", "Prods_SerialNumber", "dbo.Prods", "SerialNumber");
            AddForeignKey("dbo.Orders", "Customers_Id", "dbo.Customers", "Id");
        }
    }
}
