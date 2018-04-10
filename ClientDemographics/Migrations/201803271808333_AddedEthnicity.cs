namespace ClientDemographics.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedEthnicity : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Ethnicities",
                c => new
                    {
                        EthnicityId = c.Int(nullable: false, identity: true),
                        EthnicityName = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.EthnicityId);
            
            CreateTable(
                "dbo.EthnicityClients",
                c => new
                    {
                        Ethnicity_EthnicityId = c.Int(nullable: false),
                        Client_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Ethnicity_EthnicityId, t.Client_ID })
                .ForeignKey("dbo.Ethnicities", t => t.Ethnicity_EthnicityId, cascadeDelete: true)
                .ForeignKey("dbo.Clients", t => t.Client_ID, cascadeDelete: true)
                .Index(t => t.Ethnicity_EthnicityId)
                .Index(t => t.Client_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.EthnicityClients", "Client_ID", "dbo.Clients");
            DropForeignKey("dbo.EthnicityClients", "Ethnicity_EthnicityId", "dbo.Ethnicities");
            DropIndex("dbo.EthnicityClients", new[] { "Client_ID" });
            DropIndex("dbo.EthnicityClients", new[] { "Ethnicity_EthnicityId" });
            DropTable("dbo.EthnicityClients");
            DropTable("dbo.Ethnicities");
        }
    }
}
