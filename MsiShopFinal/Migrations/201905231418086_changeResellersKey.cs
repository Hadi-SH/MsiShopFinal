namespace MsiShopFinal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changeResellersKey : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.NOrders", "Resellers_Id", "dbo.Resellers");
            DropIndex("dbo.NOrders", new[] { "Resellers_Id" });
            RenameColumn(table: "dbo.NOrders", name: "Resellers_Id", newName: "Resellers_ResellerId");
            DropPrimaryKey("dbo.Resellers");
            AddColumn("dbo.Resellers", "ResellerId", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.NOrders", "Resellers_ResellerId", c => c.String(maxLength: 128));
            AddPrimaryKey("dbo.Resellers", "ResellerId");
            CreateIndex("dbo.NOrders", "Resellers_ResellerId");
            AddForeignKey("dbo.NOrders", "Resellers_ResellerId", "dbo.Resellers", "ResellerId");
            DropColumn("dbo.Resellers", "Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Resellers", "Id", c => c.Int(nullable: false, identity: true));
            DropForeignKey("dbo.NOrders", "Resellers_ResellerId", "dbo.Resellers");
            DropIndex("dbo.NOrders", new[] { "Resellers_ResellerId" });
            DropPrimaryKey("dbo.Resellers");
            AlterColumn("dbo.NOrders", "Resellers_ResellerId", c => c.Int());
            DropColumn("dbo.Resellers", "ResellerId");
            AddPrimaryKey("dbo.Resellers", "Id");
            RenameColumn(table: "dbo.NOrders", name: "Resellers_ResellerId", newName: "Resellers_Id");
            CreateIndex("dbo.NOrders", "Resellers_Id");
            AddForeignKey("dbo.NOrders", "Resellers_Id", "dbo.Resellers", "Id");
        }
    }
}
