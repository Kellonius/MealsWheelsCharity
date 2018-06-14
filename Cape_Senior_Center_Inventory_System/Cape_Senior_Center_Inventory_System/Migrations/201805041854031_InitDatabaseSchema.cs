namespace Cape_Senior_Center_Inventory_System.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitDatabaseSchema : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(),
                        Weight = c.Int(nullable: false),
                        Created_TS = c.DateTime(nullable: false),
                        Updated_TS = c.DateTime(nullable: true),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Inventories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ItemId = c.Int(nullable: false),
                        QuantityChange = c.Int(nullable: false),
                        Created_TS = c.DateTime(nullable: false),
                        Updated_TS = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Items", t => t.ItemId, cascadeDelete: true)
                .Index(t => t.ItemId);
            
            CreateTable(
                "dbo.Items",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Quantity = c.Int(nullable: false),
                        UomId = c.Int(nullable: false),
                        Created_TS = c.DateTime(nullable: false),
                        Updated_TS = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.UnitOfMeasures", t => t.UomId, cascadeDelete: true)
                .Index(t => t.UomId);
            
            CreateTable(
                "dbo.UnitOfMeasures",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Unit = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ItemCategories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ItemId = c.Int(nullable: false),
                        CategoryId = c.Int(nullable: false),
                        Created_TS = c.DateTime(nullable: false),
                        Updated_TS = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.CategoryId, cascadeDelete: true)
                .ForeignKey("dbo.Items", t => t.ItemId, cascadeDelete: true)
                .Index(t => t.ItemId)
                .Index(t => t.CategoryId);
            
            CreateTable(
                "dbo.Prices",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ItemId = c.Int(nullable: false),
                        Cost = c.Double(nullable: false),
                        EffectiveDate = c.DateTime(nullable: false),
                        Created_TS = c.DateTime(nullable: false),
                        Updated_TS = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Items", t => t.ItemId, cascadeDelete: true)
                .Index(t => t.ItemId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Prices", "ItemId", "dbo.Items");
            DropForeignKey("dbo.ItemCategories", "ItemId", "dbo.Items");
            DropForeignKey("dbo.ItemCategories", "CategoryId", "dbo.Categories");
            DropForeignKey("dbo.Inventories", "ItemId", "dbo.Items");
            DropForeignKey("dbo.Items", "UomId", "dbo.UnitOfMeasures");
            DropIndex("dbo.Prices", new[] { "ItemId" });
            DropIndex("dbo.ItemCategories", new[] { "CategoryId" });
            DropIndex("dbo.ItemCategories", new[] { "ItemId" });
            DropIndex("dbo.Items", new[] { "UomId" });
            DropIndex("dbo.Inventories", new[] { "ItemId" });
            DropTable("dbo.Prices");
            DropTable("dbo.ItemCategories");
            DropTable("dbo.UnitOfMeasures");
            DropTable("dbo.Items");
            DropTable("dbo.Inventories");
            DropTable("dbo.Categories");
        }
    }
}
