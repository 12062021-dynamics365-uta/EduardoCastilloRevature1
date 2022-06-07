namespace MVC_Pet_Store.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPet2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Pets", "Color_Id", "dbo.Colors");
            DropForeignKey("dbo.Pets", "Gender_Id", "dbo.Genders");
            DropForeignKey("dbo.Pets", "PetType_Id", "dbo.PetTypes");
            DropForeignKey("dbo.AdoptionApplications", "Pet_Id", "dbo.Pets");
            DropIndex("dbo.AdoptionApplications", new[] { "Pet_Id" });
            DropIndex("dbo.Pets", new[] { "Color_Id" });
            DropIndex("dbo.Pets", new[] { "Gender_Id" });
            DropIndex("dbo.Pets", new[] { "PetType_Id" });
            DropColumn("dbo.AdoptionApplications", "Pet_Id");
            DropTable("dbo.Pets");
        }
        
        public override void Down()
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
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.AdoptionApplications", "Pet_Id", c => c.Int());
            CreateIndex("dbo.Pets", "PetType_Id");
            CreateIndex("dbo.Pets", "Gender_Id");
            CreateIndex("dbo.Pets", "Color_Id");
            CreateIndex("dbo.AdoptionApplications", "Pet_Id");
            AddForeignKey("dbo.AdoptionApplications", "Pet_Id", "dbo.Pets", "Id");
            AddForeignKey("dbo.Pets", "PetType_Id", "dbo.PetTypes", "Id");
            AddForeignKey("dbo.Pets", "Gender_Id", "dbo.Genders", "Id");
            AddForeignKey("dbo.Pets", "Color_Id", "dbo.Colors", "Id");
        }
    }
}
