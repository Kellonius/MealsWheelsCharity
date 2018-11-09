namespace Cape_Senior_Center_Inventory_System.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class uom : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MasterInventories", "SubType", c => c.String());
            AddColumn("dbo.MasterInventories", "UnitOfMeasure", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.MasterInventories", "UnitOfMeasure");
            DropColumn("dbo.MasterInventories", "SubType");
        }
    }
}
