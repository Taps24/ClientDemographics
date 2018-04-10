namespace ClientDemographics.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddStatusToClients : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Status", "StatusName", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Status", "StatusName", c => c.Int(nullable: false));
        }
    }
}
