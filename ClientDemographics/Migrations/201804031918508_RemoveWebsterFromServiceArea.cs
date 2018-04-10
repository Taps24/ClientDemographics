namespace ClientDemographics.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveWebsterFromServiceArea : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Counties SET InServiceArea = 0 WHERE CountyName = 'Webster'");
        }
        
        public override void Down()
        {
        }
    }
}
