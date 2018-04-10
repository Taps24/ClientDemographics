namespace ClientDemographics.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddStateToDBAndClient : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.States",
                c => new
                    {
                        StateId = c.Int(nullable: false, identity: true),
                        StateName = c.String(),
                    })
                .PrimaryKey(t => t.StateId);
            
            AddColumn("dbo.Clients", "StateId", c => c.Int(nullable: false));
            CreateIndex("dbo.Clients", "StateId");
            AddForeignKey("dbo.Clients", "StateId", "dbo.States", "StateId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Clients", "StateId", "dbo.States");
            DropIndex("dbo.Clients", new[] { "StateId" });
            DropColumn("dbo.Clients", "StateId");
            DropTable("dbo.States");
        }
    }
}
