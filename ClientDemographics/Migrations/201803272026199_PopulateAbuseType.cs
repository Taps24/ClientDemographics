namespace ClientDemographics.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateAbuseType : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO AbuseTypes (AbuseTypeName) VALUES ('Physical')");
            Sql("INSERT INTO AbuseTypes (AbuseTypeName) VALUES ('Mental')");
            Sql("INSERT INTO AbuseTypes (AbuseTypeName) VALUES ('Financial')");
            Sql("INSERT INTO AbuseTypes (AbuseTypeName) VALUES ('Sexual')");
            Sql("INSERT INTO AbuseTypes (AbuseTypeName) VALUES ('Strangulation')");
            Sql("INSERT INTO AbuseTypes (AbuseTypeName) VALUES ('Rape')");
            Sql("INSERT INTO AbuseTypes (AbuseTypeName) VALUES ('Head Trauma')");
            Sql("INSERT INTO AbuseTypes (AbuseTypeName) VALUES ('Childhood DV')");
            Sql("INSERT INTO AbuseTypes (AbuseTypeName) VALUES ('Childhood SA')");
            Sql("INSERT INTO AbuseTypes (AbuseTypeName) VALUES ('Molestation')");
            Sql("INSERT INTO AbuseTypes (AbuseTypeName) VALUES ('Stalking')");
        }
        
        public override void Down()
        {
        }
    }
}
