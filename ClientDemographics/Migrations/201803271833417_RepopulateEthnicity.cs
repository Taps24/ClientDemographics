namespace ClientDemographics.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RepopulateEthnicity : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Ethnicities (EthnicityId, EthnicityName) VALUES (0, 'African-American')");
            Sql("INSERT INTO Ethnicities (EthnicityId, EthnicityName) VALUES (1, 'Asian/Asian-American')");
            Sql("INSERT INTO Ethnicities (EthnicityId, EthnicityName) VALUES (2, 'Caucasian')");
            Sql("INSERT INTO Ethnicities (EthnicityId, EthnicityName) VALUES (3, 'Latino/Hispanic')");
            Sql("INSERT INTO Ethnicities (EthnicityId, EthnicityName) VALUES (4, 'Multi-Racial/Bi-Racial')");
            Sql("INSERT INTO Ethnicities (EthnicityId, EthnicityName) VALUES (5, 'Native American')");
            Sql("INSERT INTO Ethnicities (EthnicityId, EthnicityName) VALUES (6, 'Pacific Islander')");
            Sql("INSERT INTO Ethnicities (EthnicityId, EthnicityName) VALUES (7, 'Unknown')");
            Sql("INSERT INTO Ethnicities (EthnicityId, EthnicityName) VALUES (8, 'Not-Disclosed')");
            Sql("INSERT INTO Ethnicities (EthnicityId, EthnicityName) VALUES (9, 'Other')");
        }
        
        public override void Down()
        {
          
        }
    }
}
