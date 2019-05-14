namespace MsiShopFinal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Categorys", newName: "CategoryFormViewModels");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.CategoryFormViewModels", newName: "Categorys");
        }
    }
}
