namespace Cape_Senior_Center_Inventory_System.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InventoryHistory : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.InventoryHistories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ItemId = c.Int(nullable: false),
                        ItemName = c.String(),
                        PreviousUnitsOnHand = c.Int(nullable: false),
                        NewUnitsOnHand = c.Int(nullable: false),
                        Updated_TS = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.InventoryHistories");
        }
    }
}
