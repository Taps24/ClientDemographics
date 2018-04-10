namespace ClientDemographics.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateStatesForRealThisTime : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO States (StateName, StateAbbreviation) VALUES ('Alabama', 'AL')");
            Sql("INSERT INTO States (StateName, StateAbbreviation) VALUES ('Alaska', 'AK')");
            Sql("INSERT INTO States (StateName, StateAbbreviation) VALUES ('Arizona', 'AZ')");
            Sql("INSERT INTO States (StateName, StateAbbreviation) VALUES ('Arkansas', 'AR')");
            Sql("INSERT INTO States (StateName, StateAbbreviation) VALUES ('California', 'CA')");
            Sql("INSERT INTO States (StateName, StateAbbreviation) VALUES ('Colorado', 'CO')");
            Sql("INSERT INTO States (StateName, StateAbbreviation) VALUES ('Connecticut', 'CT')");
            Sql("INSERT INTO States (StateName, StateAbbreviation) VALUES ('Delaware', 'DE')");
            Sql("INSERT INTO States (StateName, StateAbbreviation) VALUES ('Florida', 'FL')");
            Sql("INSERT INTO States (StateName, StateAbbreviation) VALUES ('Georgia', 'GA')");
            Sql("INSERT INTO States (StateName, StateAbbreviation) VALUES ('Hawaii', 'HI')");
            Sql("INSERT INTO States (StateName, StateAbbreviation) VALUES ('Idaho', 'ID')");
            Sql("INSERT INTO States (StateName, StateAbbreviation) VALUES ('Illinois', 'IL')");
            Sql("INSERT INTO States (StateName, StateAbbreviation) VALUES ('Indiana', 'IN')");
            Sql("INSERT INTO States (StateName, StateAbbreviation) VALUES ('Iowa', 'IA')");
            Sql("INSERT INTO States (StateName, StateAbbreviation) VALUES ('Kansas', 'KS')");
            Sql("INSERT INTO States (StateName, StateAbbreviation) VALUES ('Kentucky', 'KY')");
            Sql("INSERT INTO States (StateName, StateAbbreviation) VALUES ('Louisana', 'LA')");
            Sql("INSERT INTO States (StateName, StateAbbreviation) VALUES ('Maine', 'ME')");
            Sql("INSERT INTO States (StateName, StateAbbreviation) VALUES ('Maryland', 'MD')");
            Sql("INSERT INTO States (StateName, StateAbbreviation) VALUES ('Massachusets', 'MS')");
            Sql("INSERT INTO States (StateName, StateAbbreviation) VALUES ('Michigan', 'MI')");
            Sql("INSERT INTO States (StateName, StateAbbreviation) VALUES ('Minnesota', 'MN')");
            Sql("INSERT INTO States (StateName, StateAbbreviation) VALUES ('Mississippi', 'MS')");
            Sql("INSERT INTO States (StateName, StateAbbreviation) VALUES ('Missouri', 'MO')");
            Sql("INSERT INTO States (StateName, StateAbbreviation) VALUES ('Montana', 'MT')");
            Sql("INSERT INTO States (StateName, StateAbbreviation) VALUES ('Nebraska', 'NE')");
            Sql("INSERT INTO States (StateName, StateAbbreviation) VALUES ('Nevada', 'NV')");
            Sql("INSERT INTO States (StateName, StateAbbreviation) VALUES ('New Hampshire', 'NH')");
            Sql("INSERT INTO States (StateName, StateAbbreviation) VALUES ('New Jersey', 'NJ')");
            Sql("INSERT INTO States (StateName, StateAbbreviation) VALUES ('New Mexico', 'NM')");
            Sql("INSERT INTO States (StateName, StateAbbreviation) VALUES ('New York', 'NY')");
            Sql("INSERT INTO States (StateName, StateAbbreviation) VALUES ('North Carolina', 'NC')");
            Sql("INSERT INTO States (StateName, StateAbbreviation) VALUES ('North Dakota', 'ND')");
            Sql("INSERT INTO States (StateName, StateAbbreviation) VALUES ('Ohio', 'OH')");
            Sql("INSERT INTO States (StateName, StateAbbreviation) VALUES ('Oklahoma', 'OK')");
            Sql("INSERT INTO States (StateName, StateAbbreviation) VALUES ('Oregon', 'OR')");
            Sql("INSERT INTO States (StateName, StateAbbreviation) VALUES ('Pennsylvania', 'PA')");
            Sql("INSERT INTO States (StateName, StateAbbreviation) VALUES ('Rhode Island', 'RI')");
            Sql("INSERT INTO States (StateName, StateAbbreviation) VALUES ('South Carolina', 'SC')");
            Sql("INSERT INTO States (StateName, StateAbbreviation) VALUES ('South Dakota', 'SD')");
            Sql("INSERT INTO States (StateName, StateAbbreviation) VALUES ('Tennessee', 'TN')");
            Sql("INSERT INTO States (StateName, StateAbbreviation) VALUES ('Texas', 'TX')");
            Sql("INSERT INTO States (StateName, StateAbbreviation) VALUES ('Utah', 'UT')");
            Sql("INSERT INTO States (StateName, StateAbbreviation) VALUES ('Vermont', 'VT')");
            Sql("INSERT INTO States (StateName, StateAbbreviation) VALUES ('Virginia', 'VA')");
            Sql("INSERT INTO States (StateName, StateAbbreviation) VALUES ('Washington', 'WA')");
            Sql("INSERT INTO States (StateName, StateAbbreviation) VALUES ('West Virginia', 'WV')");
            Sql("INSERT INTO States (StateName, StateAbbreviation) VALUES ('Wisconsin', 'WI')");
            Sql("INSERT INTO States (StateName, StateAbbreviation) VALUES ('Wyoming', 'WY')");


        }
        
        public override void Down()
        {
        }
    }
}
