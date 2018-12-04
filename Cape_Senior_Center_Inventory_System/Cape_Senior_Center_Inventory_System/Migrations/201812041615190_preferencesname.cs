namespace Cape_Senior_Center_Inventory_System.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class preferencesname : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Preferences", "PreferencesName", c => c.String());
            AddColumn("dbo.Preferences", "isDefault", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Preferences", "isDefault");
            DropColumn("dbo.Preferences", "PreferencesName");
        }
    }
}
