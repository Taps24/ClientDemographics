namespace ClientDemographics.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateDemographics : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Demographics (DemographicId, DemographicName) VALUES (0, 'Minority')");
            Sql("INSERT INTO Demographics (DemographicId, DemographicName) VALUES (1, 'Elderly')");
            Sql("INSERT INTO Demographics (DemographicId, DemographicName) VALUES (2, 'Child')");
            Sql("INSERT INTO Demographics (DemographicId, DemographicName) VALUES (3, 'Disability (Physical/Mental/Educational)')");
            Sql("INSERT INTO Demographics (DemographicId, DemographicName) VALUES (4, 'Limited English')");
            Sql("INSERT INTO Demographics (DemographicId, DemographicName) VALUES (5, 'Immigrant')");
            Sql("INSERT INTO Demographics (DemographicId, DemographicName) VALUES (6, 'Refugee/Asylum Seeker')");
            Sql("INSERT INTO Demographics (DemographicId, DemographicName) VALUES (7, 'Stalking')");
            Sql("INSERT INTO Demographics (DemographicId, DemographicName) VALUES (8, 'Deaf/Hard of Hearing')");
            Sql("INSERT INTO Demographics (DemographicId, DemographicName) VALUES (9, 'Homeless')");
            Sql("INSERT INTO Demographics (DemographicId, DemographicName) VALUES (10, 'LGBTQ')");
            Sql("INSERT INTO Demographics (DemographicId, DemographicName) VALUES (11, 'Veteran')");
        }
        
        public override void Down()
        {
        }
    }
}
