namespace ClientDemographics.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddStatusToClients1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Clients", "StatusId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Clients", "StatusId");
        }
    }
}
