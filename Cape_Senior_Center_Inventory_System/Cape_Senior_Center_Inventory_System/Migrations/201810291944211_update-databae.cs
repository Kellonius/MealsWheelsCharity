namespace Cape_Senior_Center_Inventory_System.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatedatabae : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ItemSubTypes",
                c => new
                    {
                        SubTypeId = c.Int(nullable: false, identity: true),
                        TypeId = c.Int(nullable: false),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.SubTypeId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ItemSubTypes");
        }
    }
}
