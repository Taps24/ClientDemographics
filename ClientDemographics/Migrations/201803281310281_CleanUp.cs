namespace ClientDemographics.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CleanUp : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.AbuseTypeClients", newName: "ClientAbuseTypes");
            DropPrimaryKey("dbo.ClientAbuseTypes");
            AddPrimaryKey("dbo.ClientAbuseTypes", new[] { "Client_ID", "AbuseType_AbuseTypeId" });
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.ClientAbuseTypes");
            AddPrimaryKey("dbo.ClientAbuseTypes", new[] { "AbuseType_AbuseTypeId", "Client_ID" });
            RenameTable(name: "dbo.ClientAbuseTypes", newName: "AbuseTypeClients");
        }
    }
}
