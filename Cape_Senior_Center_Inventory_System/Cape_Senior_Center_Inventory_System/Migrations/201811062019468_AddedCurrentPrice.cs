namespace Cape_Senior_Center_Inventory_System.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedCurrentPrice : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.InventoryHistories", "CurrentPrice", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.InventoryHistories", "CurrentPrice");
        }
    }
}
