namespace ClientDemographics.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddStatusToClients11 : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Clients", "StatusId");
            AddForeignKey("dbo.Clients", "StatusId", "dbo.Status", "StatusId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Clients", "StatusId", "dbo.Status");
            DropIndex("dbo.Clients", new[] { "StatusId" });
        }
    }
}
