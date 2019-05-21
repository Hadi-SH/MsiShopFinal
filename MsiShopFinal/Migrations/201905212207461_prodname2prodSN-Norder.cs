namespace MsiShopFinal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class prodname2prodSNNorder : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.NOrders", "ProdSerialNumber", c => c.String());
            DropColumn("dbo.NOrders", "ProdName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.NOrders", "ProdName", c => c.String());
            DropColumn("dbo.NOrders", "ProdSerialNumber");
        }
    }
}
