namespace ClientDemographics.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateStatus : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Status (StatusName) VALUES ('Active')");
            Sql("INSERT INTO Status (StatusName) VALUES ('Inactive')");
        }
        
        public override void Down()
        {
        }
    }
}
