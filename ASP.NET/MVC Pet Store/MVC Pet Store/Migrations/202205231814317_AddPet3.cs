namespace MVC_Pet_Store.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPet3 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Pets",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Breed = c.String(),
                        Age = c.Int(nullable: false),
                        ColorId = c.Byte(nullable: false),
                        GenderId = c.Byte(nullable: false),
                        PetTypeId = c.Byte(nullable: false),
                        Biography = c.String(),
                        Color_Id = c.Int(),
                        Gender_Id = c.Int(),
                        PetType_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Colors", t => t.Color_Id)
                .ForeignKey("dbo.Genders", t => t.Gender_Id)
                .ForeignKey("dbo.PetTypes", t => t.PetType_Id)
                .Index(t => t.Color_Id)
                .Index(t => t.Gender_Id)
                .Index(t => t.PetType_Id);
            
            AddColumn("dbo.AdoptionApplications", "Pet_Id", c => c.Int());
            CreateIndex("dbo.AdoptionApplications", "Pet_Id");
            AddForeignKey("dbo.AdoptionApplications", "Pet_Id", "dbo.Pets", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AdoptionApplications", "Pet_Id", "dbo.Pets");
            DropForeignKey("dbo.Pets", "PetType_Id", "dbo.PetTypes");
            DropForeignKey("dbo.Pets", "Gender_Id", "dbo.Genders");
            DropForeignKey("dbo.Pets", "Color_Id", "dbo.Colors");
            DropIndex("dbo.Pets", new[] { "PetType_Id" });
            DropIndex("dbo.Pets", new[] { "Gender_Id" });
            DropIndex("dbo.Pets", new[] { "Color_Id" });
            DropIndex("dbo.AdoptionApplications", new[] { "Pet_Id" });
            DropColumn("dbo.AdoptionApplications", "Pet_Id");
            DropTable("dbo.Pets");
        }
    }
}
