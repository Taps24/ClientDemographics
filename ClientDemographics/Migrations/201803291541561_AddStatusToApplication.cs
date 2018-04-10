namespace ClientDemographics.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddStatusToApplication : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Status",
                c => new
                    {
                        StatusId = c.Int(nullable: false, identity: true),
                        StatusName = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.StatusId);
            
            AddColumn("dbo.Clients", "ClientMiddleInitial", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Clients", "ClientMiddleInitial");
            DropTable("dbo.Status");
        }
    }
}
