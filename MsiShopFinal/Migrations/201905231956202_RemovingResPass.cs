namespace MsiShopFinal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemovingResPass : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Resellers", "Password");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Resellers", "Password", c => c.String(nullable: false));
        }
    }
}
