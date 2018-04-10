namespace ClientDemographics.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateType : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Types (TypeName) VALUES ('Primary Victim')");
            Sql("INSERT INTO Types (TypeName) VALUES ('Secondary Victim')");
        }
        
        public override void Down()
        {
        }
    }
}
