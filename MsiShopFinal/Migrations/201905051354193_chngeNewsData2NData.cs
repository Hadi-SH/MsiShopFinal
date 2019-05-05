namespace MsiShopFinal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class chngeNewsData2NData : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.News", "NData", c => c.String(nullable: false));
            DropColumn("dbo.News", "Data");
        }
        
        public override void Down()
        {
            AddColumn("dbo.News", "Data", c => c.String(nullable: false));
            DropColumn("dbo.News", "NData");
        }
    }
}
