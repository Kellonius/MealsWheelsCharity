namespace Cape_Senior_Center_Inventory_System.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MasterInveroymk2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.MasterInventories", "UnitsOnHand", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.MasterInventories", "UnitsOnHand", c => c.String());
        }
    }
}
