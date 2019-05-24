namespace MsiShopFinal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeCustomerKey : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.NOrders", "Customers_Id", "dbo.Customers");
            DropIndex("dbo.NOrders", new[] { "Customers_Id" });
            RenameColumn(table: "dbo.NOrders", name: "Customers_Id", newName: "Customers_CustomerId");
            DropPrimaryKey("dbo.Customers");
            AddColumn("dbo.Customers", "CustomerId", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.NOrders", "Customers_CustomerId", c => c.String(maxLength: 128));
            AddPrimaryKey("dbo.Customers", "CustomerId");
            CreateIndex("dbo.NOrders", "Customers_CustomerId");
            AddForeignKey("dbo.NOrders", "Customers_CustomerId", "dbo.Customers", "CustomerId");
            DropColumn("dbo.Customers", "Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "Id", c => c.Int(nullable: false, identity: true));
            DropForeignKey("dbo.NOrders", "Customers_CustomerId", "dbo.Customers");
            DropIndex("dbo.NOrders", new[] { "Customers_CustomerId" });
            DropPrimaryKey("dbo.Customers");
            AlterColumn("dbo.NOrders", "Customers_CustomerId", c => c.Int());
            DropColumn("dbo.Customers", "CustomerId");
            AddPrimaryKey("dbo.Customers", "Id");
            RenameColumn(table: "dbo.NOrders", name: "Customers_CustomerId", newName: "Customers_Id");
            CreateIndex("dbo.NOrders", "Customers_Id");
            AddForeignKey("dbo.NOrders", "Customers_Id", "dbo.Customers", "Id");
        }
    }
}
