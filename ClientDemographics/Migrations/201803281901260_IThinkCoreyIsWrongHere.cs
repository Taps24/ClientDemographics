namespace ClientDemographics.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IThinkCoreyIsWrongHere : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Clients", "Ethnicity_EthnicityId", "dbo.Ethnicities");
            DropIndex("dbo.Clients", new[] { "Ethnicity_EthnicityId" });
            RenameColumn(table: "dbo.Clients", name: "Ethnicity_EthnicityId", newName: "EthnicityId");
            AlterColumn("dbo.Clients", "EthnicityId", c => c.Int(nullable: false));
            CreateIndex("dbo.Clients", "EthnicityId");
            AddForeignKey("dbo.Clients", "EthnicityId", "dbo.Ethnicities", "EthnicityId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Clients", "EthnicityId", "dbo.Ethnicities");
            DropIndex("dbo.Clients", new[] { "EthnicityId" });
            AlterColumn("dbo.Clients", "EthnicityId", c => c.Int());
            RenameColumn(table: "dbo.Clients", name: "EthnicityId", newName: "Ethnicity_EthnicityId");
            CreateIndex("dbo.Clients", "Ethnicity_EthnicityId");
            AddForeignKey("dbo.Clients", "Ethnicity_EthnicityId", "dbo.Ethnicities", "EthnicityId");
        }
    }
}
