namespace ClientDemographics.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateDB : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.DemographicClients", "Client_ClientId", "dbo.Clients");
            DropForeignKey("dbo.DemographicClients", "Demographic_DemographicId", "dbo.Demographics");
            DropPrimaryKey("dbo.Clients");
            DropPrimaryKey("dbo.Demographics");
            AlterColumn("dbo.Clients", "ClientId", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Demographics", "DemographicId", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Clients", "ClientId");
            AddPrimaryKey("dbo.Demographics", "DemographicId");
            AddForeignKey("dbo.DemographicClients", "Client_ClientId", "dbo.Clients", "ClientId", cascadeDelete: true);
            AddForeignKey("dbo.DemographicClients", "Demographic_DemographicId", "dbo.Demographics", "DemographicId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DemographicClients", "Demographic_DemographicId", "dbo.Demographics");
            DropForeignKey("dbo.DemographicClients", "Client_ClientId", "dbo.Clients");
            DropPrimaryKey("dbo.Demographics");
            DropPrimaryKey("dbo.Clients");
            AlterColumn("dbo.Demographics", "DemographicId", c => c.Int(nullable: false));
            AlterColumn("dbo.Clients", "ClientId", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Demographics", "DemographicId");
            AddPrimaryKey("dbo.Clients", "ClientId");
            AddForeignKey("dbo.DemographicClients", "Demographic_DemographicId", "dbo.Demographics", "DemographicId", cascadeDelete: true);
            AddForeignKey("dbo.DemographicClients", "Client_ClientId", "dbo.Clients", "ClientId", cascadeDelete: true);
        }
    }
}
