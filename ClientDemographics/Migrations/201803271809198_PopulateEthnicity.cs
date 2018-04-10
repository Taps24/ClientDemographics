namespace ClientDemographics.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateEthnicity : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Ethnicities (EthnicityName) VALUES ('African-American')");
            Sql("INSERT INTO Ethnicities (EthnicityName) VALUES ('Asian/Asian-American')");
            Sql("INSERT INTO Ethnicities (EthnicityName) VALUES ('Caucasian')");
            Sql("INSERT INTO Ethnicities (EthnicityName) VALUES ('Latino/Hispanic')");
            Sql("INSERT INTO Ethnicities (EthnicityName) VALUES ('Multi-Racial/Bi-Racial')");
            Sql("INSERT INTO Ethnicities (EthnicityName) VALUES ('Native American')");
            Sql("INSERT INTO Ethnicities (EthnicityName) VALUES ('Pacific Islander')");
            Sql("INSERT INTO Ethnicities (EthnicityName) VALUES ('Unknown')");
            Sql("INSERT INTO Ethnicities (EthnicityName) VALUES ('Not-Disclosed')");
            Sql("INSERT INTO Ethnicities (EthnicityName) VALUES ('Other')");
        }
        
        public override void Down()
        {
        }
    }
}
