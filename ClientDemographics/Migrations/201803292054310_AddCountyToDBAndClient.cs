namespace ClientDemographics.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCountyToDBAndClient : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Counties",
                c => new
                    {
                        CountyId = c.Int(nullable: false, identity: true),
                        CountyName = c.Int(nullable: false),
                        InServiceArea = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.CountyId);
            
            AddColumn("dbo.Clients", "CountyOfResidence", c => c.Int(nullable: false));
            AddColumn("dbo.Clients", "CountyOfIncident", c => c.Int(nullable: false));
            AddColumn("dbo.Clients", "County_CountyId", c => c.Int());
            CreateIndex("dbo.Clients", "County_CountyId");
            AddForeignKey("dbo.Clients", "County_CountyId", "dbo.Counties", "CountyId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Clients", "County_CountyId", "dbo.Counties");
            DropIndex("dbo.Clients", new[] { "County_CountyId" });
            DropColumn("dbo.Clients", "County_CountyId");
            DropColumn("dbo.Clients", "CountyOfIncident");
            DropColumn("dbo.Clients", "CountyOfResidence");
            DropTable("dbo.Counties");
        }
    }
}
