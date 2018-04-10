namespace ClientDemographics.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingLocalColumnsToClients : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Clients", "ClientFirstName", c => c.String(nullable: false));
            AddColumn("dbo.Clients", "ClientLastName", c => c.String(nullable: false));
            AddColumn("dbo.Clients", "DateofBirth", c => c.DateTime(nullable: false));
            AddColumn("dbo.Clients", "DateofFirstContact", c => c.DateTime(nullable: false));
            AddColumn("dbo.Clients", "Address1", c => c.String());
            AddColumn("dbo.Clients", "Address2", c => c.String());
            AddColumn("dbo.Clients", "City", c => c.String());
            AddColumn("dbo.Clients", "Phone", c => c.String());
            AddColumn("dbo.Clients", "ZipCode", c => c.String());
            AddColumn("dbo.Clients", "EmergencyContactName", c => c.String());
            AddColumn("dbo.Clients", "EmergencyContactPhone", c => c.String());
            DropColumn("dbo.Clients", "ClientName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Clients", "ClientName", c => c.String(nullable: false));
            DropColumn("dbo.Clients", "EmergencyContactPhone");
            DropColumn("dbo.Clients", "EmergencyContactName");
            DropColumn("dbo.Clients", "ZipCode");
            DropColumn("dbo.Clients", "Phone");
            DropColumn("dbo.Clients", "City");
            DropColumn("dbo.Clients", "Address2");
            DropColumn("dbo.Clients", "Address1");
            DropColumn("dbo.Clients", "DateofFirstContact");
            DropColumn("dbo.Clients", "DateofBirth");
            DropColumn("dbo.Clients", "ClientLastName");
            DropColumn("dbo.Clients", "ClientFirstName");
        }
    }
}
