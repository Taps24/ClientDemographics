namespace ClientDemographics.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateState : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.States", "StateAbbreviation", c => c.String());
            AlterColumn("dbo.Counties", "CountyName", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Counties", "CountyName", c => c.Int(nullable: false));
            DropColumn("dbo.States", "StateAbbreviation");
        }
    }
}
