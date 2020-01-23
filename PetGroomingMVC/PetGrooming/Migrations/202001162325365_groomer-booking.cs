namespace PetGrooming.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class groomerbooking : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.GroomBookings",
                c => new
                    {
                        GroomBookingID = c.Int(nullable: false, identity: true),
                        GroomBookingDate = c.DateTime(nullable: false),
                        GroomBookingPrice = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.GroomBookingID);
            
            CreateTable(
                "dbo.GroomServices",
                c => new
                    {
                        GroomServiceID = c.Int(nullable: false, identity: true),
                        GroomServiceName = c.String(),
                        GroomServiceCost = c.Double(nullable: false),
                        GroomServiceDuration = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.GroomServiceID);
            
            CreateTable(
                "dbo.Owners",
                c => new
                    {
                        OwnerID = c.Int(nullable: false, identity: true),
                        OwnerFirstName = c.String(),
                        OwnerLastName = c.String(),
                        OwnerAddress = c.String(),
                        OwnerWPhone = c.Int(nullable: false),
                        OwnerHPhone = c.Int(nullable: false),
                        OwnerEmail = c.String(),
                    })
                .PrimaryKey(t => t.OwnerID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Owners");
            DropTable("dbo.GroomServices");
            DropTable("dbo.GroomBookings");
        }
    }
}
