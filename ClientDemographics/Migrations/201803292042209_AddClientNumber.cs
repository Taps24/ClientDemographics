namespace ClientDemographics.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddClientNumber : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Clients", "ClientNumber", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Clients", "ClientNumber");
        }
    }
}
