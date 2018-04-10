namespace ClientDemographics.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddGenderToDBAndClient : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Genders",
                c => new
                    {
                        GenderId = c.Int(nullable: false, identity: true),
                        GenderName = c.String(),
                    })
                .PrimaryKey(t => t.GenderId);
            
            AddColumn("dbo.Clients", "GenderId", c => c.Int(nullable: false));
            CreateIndex("dbo.Clients", "GenderId");
            AddForeignKey("dbo.Clients", "GenderId", "dbo.Genders", "GenderId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Clients", "GenderId", "dbo.Genders");
            DropIndex("dbo.Clients", new[] { "GenderId" });
            DropColumn("dbo.Clients", "GenderId");
            DropTable("dbo.Genders");
        }
    }
}
