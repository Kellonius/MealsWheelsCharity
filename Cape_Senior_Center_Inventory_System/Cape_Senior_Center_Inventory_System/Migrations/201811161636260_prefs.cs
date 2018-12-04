namespace Cape_Senior_Center_Inventory_System.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class prefs : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Preferences",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NumCurrentGrids = c.Int(nullable: false),
                        CurrentColumnOne = c.String(),
                        CurrentColumnTwo = c.String(),
                        CurrentColumnThree = c.String(),
                        CurrentColumnFour = c.String(),
                        NumMasterGrids = c.Int(nullable: false),
                        MasterColumnOne = c.String(),
                        MasterColumnTwo = c.String(),
                        MasterColumnThree = c.String(),
                        MasterColumnFour = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Preferences");
        }
    }
}
