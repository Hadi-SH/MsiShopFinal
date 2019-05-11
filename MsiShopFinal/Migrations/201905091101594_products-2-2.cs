namespace MsiShopFinal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class products22 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Prods",
                c => new
                    {
                        SerialNumber = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false),
                        Price = c.Int(nullable: false),
                        Specifications = c.String(nullable: false),
                        Image = c.String(nullable: false),
                        Buyable = c.Boolean(nullable: false),
                        CategoryName = c.String(),
                        Categorys_Id = c.Int(),
                    })
                .PrimaryKey(t => t.SerialNumber)
                .ForeignKey("dbo.Categorys", t => t.Categorys_Id)
                .Index(t => t.Categorys_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Prods", "Categorys_Id", "dbo.Categorys");
            DropIndex("dbo.Prods", new[] { "Categorys_Id" });
            DropTable("dbo.Prods");
        }
    }
}
