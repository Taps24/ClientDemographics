namespace ClientDemographics.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class WhatCoreySays : DbMigration
    {
        public override void Up()
        {
            //DropForeignKey("dbo.Clients", "EthnicityId", "dbo.Ethnicities");
            //DropIndex("dbo.Clients", new[] { "EthnicityId" });
            RenameColumn(table: "dbo.Clients", name: "EthnicityId", newName: "Ethnicity_EthnicityId");
            AlterColumn("dbo.Clients", "Ethnicity_EthnicityId", c => c.Int());
            CreateIndex("dbo.Clients", "Ethnicity_EthnicityId");
            AddForeignKey("dbo.Clients", "Ethnicity_EthnicityId", "dbo.Ethnicities", "EthnicityId");
        }
        
        public override void Down()
        {
           // DropForeignKey("dbo.Clients", "Ethnicity_EthnicityId", "dbo.Ethnicities");
            //DropIndex("dbo.Clients", new[] { "Ethnicity_EthnicityId" });
            AlterColumn("dbo.Clients", "Ethnicity_EthnicityId", c => c.Int(nullable: false));
            RenameColumn(table: "dbo.Clients", name: "Ethnicity_EthnicityId", newName: "EthnicityId");
            CreateIndex("dbo.Clients", "EthnicityId");
            AddForeignKey("dbo.Clients", "EthnicityId", "dbo.Ethnicities", "EthnicityId", cascadeDelete: true);
        }
    }
}
