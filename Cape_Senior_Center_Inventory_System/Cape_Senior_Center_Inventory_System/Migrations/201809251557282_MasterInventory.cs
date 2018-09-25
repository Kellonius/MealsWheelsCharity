namespace Cape_Senior_Center_Inventory_System.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MasterInventory : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MasterInventories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ItemType = c.String(),
                        Brand = c.String(),
                        SKU = c.String(),
                        UnitsOnHand = c.String(),
                        ItemName = c.String(),
                        PriceUnit = c.Double(nullable: false),
                        UnitPrice = c.Double(nullable: false),
                        ExtendedPrice = c.Double(nullable: false),
                        Created_TS = c.DateTime(nullable: false),
                        Updated_TS = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.MasterInventories");
        }
    }
}
