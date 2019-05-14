namespace MsiShopFinal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test2 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.CategoryFormViewModels", newName: "Categorys");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Categorys", newName: "CategoryFormViewModels");
        }
    }
}
