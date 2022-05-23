namespace MVC_Pet_Store.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAdoptionApplication : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AdoptionApplications",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Pet_Id = c.Int(),
                        User_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Pets", t => t.Pet_Id)
                .ForeignKey("dbo.AspNetUsers", t => t.User_Id)
                .Index(t => t.Pet_Id)
                .Index(t => t.User_Id);
            
            DropTable("dbo.Stores");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Stores",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Address = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            DropForeignKey("dbo.AdoptionApplications", "User_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.AdoptionApplications", "Pet_Id", "dbo.Pets");
            DropIndex("dbo.AdoptionApplications", new[] { "User_Id" });
            DropIndex("dbo.AdoptionApplications", new[] { "Pet_Id" });
            DropTable("dbo.AdoptionApplications");
        }
    }
}
