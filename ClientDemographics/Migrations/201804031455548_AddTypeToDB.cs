namespace ClientDemographics.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTypeToDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Types",
                c => new
                    {
                        TypeId = c.Int(nullable: false, identity: true),
                        TypeName = c.String(),
                    })
                .PrimaryKey(t => t.TypeId);
            
            AddColumn("dbo.Clients", "TypeId", c => c.Int(nullable: false));
            CreateIndex("dbo.Clients", "TypeId");
            AddForeignKey("dbo.Clients", "TypeId", "dbo.Types", "TypeId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Clients", "TypeId", "dbo.Types");
            DropIndex("dbo.Clients", new[] { "TypeId" });
            DropColumn("dbo.Clients", "TypeId");
            DropTable("dbo.Types");
        }
    }
}
