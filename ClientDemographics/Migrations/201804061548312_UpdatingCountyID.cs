namespace ClientDemographics.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatingCountyID : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Clients", "CountyOfResidenceId", c => c.Int(nullable: false));
            AddColumn("dbo.Clients", "CountyOfIncidentId", c => c.Int(nullable: false));
            AddColumn("dbo.Clients", "CountyOfIncident_CountyId", c => c.Int());
            AddColumn("dbo.Clients", "CountyOfResidence_CountyId", c => c.Int());
            CreateIndex("dbo.Clients", "CountyOfIncident_CountyId");
            CreateIndex("dbo.Clients", "CountyOfResidence_CountyId");
            AddForeignKey("dbo.Clients", "CountyOfIncident_CountyId", "dbo.Counties", "CountyId");
            AddForeignKey("dbo.Clients", "CountyOfResidence_CountyId", "dbo.Counties", "CountyId");
            DropColumn("dbo.Clients", "CountyOfResidence");
            DropColumn("dbo.Clients", "CountyOfIncident");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Clients", "CountyOfIncident", c => c.Int(nullable: false));
            AddColumn("dbo.Clients", "CountyOfResidence", c => c.Int(nullable: false));
            DropForeignKey("dbo.Clients", "CountyOfResidence_CountyId", "dbo.Counties");
            DropForeignKey("dbo.Clients", "CountyOfIncident_CountyId", "dbo.Counties");
            DropIndex("dbo.Clients", new[] { "CountyOfResidence_CountyId" });
            DropIndex("dbo.Clients", new[] { "CountyOfIncident_CountyId" });
            DropColumn("dbo.Clients", "CountyOfResidence_CountyId");
            DropColumn("dbo.Clients", "CountyOfIncident_CountyId");
            DropColumn("dbo.Clients", "CountyOfIncidentId");
            DropColumn("dbo.Clients", "CountyOfResidenceId");
        }
    }
}
