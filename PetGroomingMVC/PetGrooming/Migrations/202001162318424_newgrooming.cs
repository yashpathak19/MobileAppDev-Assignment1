namespace PetGrooming.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newgrooming : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Groomers",
                c => new
                    {
                        GroomerID = c.Int(nullable: false, identity: true),
                        GroomerFirstName = c.String(),
                        GroomerLastName = c.String(),
                        GroomerDOB = c.DateTime(nullable: false),
                        GroomerPhone = c.Int(nullable: false),
                        GroomerRate = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.GroomerID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Groomers");
        }
    }
}
