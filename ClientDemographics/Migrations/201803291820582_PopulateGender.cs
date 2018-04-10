namespace ClientDemographics.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGender : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genders (GenderName) VALUES ('Male')");
            Sql("INSERT INTO Genders (GenderName) VALUES ('Female')");
            Sql("INSERT INTO Genders (GenderName) VALUES ('Other')");
        }
        
        public override void Down()
        {
        }
    }
}
