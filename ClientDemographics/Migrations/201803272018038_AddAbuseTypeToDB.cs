namespace ClientDemographics.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAbuseTypeToDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AbuseTypes",
                c => new
                    {
                        AbuseTypeId = c.Int(nullable: false, identity: true),
                        AbuseTypeName = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.AbuseTypeId);
            
            CreateTable(
                "dbo.AbuseTypeClients",
                c => new
                    {
                        AbuseType_AbuseTypeId = c.Int(nullable: false),
                        Client_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.AbuseType_AbuseTypeId, t.Client_ID })
                .ForeignKey("dbo.AbuseTypes", t => t.AbuseType_AbuseTypeId, cascadeDelete: true)
                .ForeignKey("dbo.Clients", t => t.Client_ID, cascadeDelete: true)
                .Index(t => t.AbuseType_AbuseTypeId)
                .Index(t => t.Client_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AbuseTypeClients", "Client_ID", "dbo.Clients");
            DropForeignKey("dbo.AbuseTypeClients", "AbuseType_AbuseTypeId", "dbo.AbuseTypes");
            DropIndex("dbo.AbuseTypeClients", new[] { "Client_ID" });
            DropIndex("dbo.AbuseTypeClients", new[] { "AbuseType_AbuseTypeId" });
            DropTable("dbo.AbuseTypeClients");
            DropTable("dbo.AbuseTypes");
        }
    }
}
