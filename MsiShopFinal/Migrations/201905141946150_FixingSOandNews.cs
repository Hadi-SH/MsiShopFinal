namespace MsiShopFinal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixingSOandNews : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.News", "NTitle", c => c.String(nullable: false));
            AddColumn("dbo.News", "Date", c => c.DateTime(nullable: false));
            AddColumn("dbo.SpecialOffers", "Date", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.SpecialOffers", "Date");
            DropColumn("dbo.News", "Date");
            DropColumn("dbo.News", "NTitle");
        }
    }
}
