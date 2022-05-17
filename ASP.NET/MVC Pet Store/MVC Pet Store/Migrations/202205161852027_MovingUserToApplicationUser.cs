namespace MVC_Pet_Store.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MovingUserToApplicationUser : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Users", "DesiredColor_Id", "dbo.Colors");
            DropForeignKey("dbo.Users", "DesiredGender_Id", "dbo.Genders");
            DropForeignKey("dbo.Users", "DesiredPetType_Id", "dbo.PetTypes");
            DropIndex("dbo.Users", new[] { "DesiredColor_Id" });
            DropIndex("dbo.Users", new[] { "DesiredGender_Id" });
            DropIndex("dbo.Users", new[] { "DesiredPetType_Id" });
            AddColumn("dbo.AspNetUsers", "FirstName", c => c.String());
            AddColumn("dbo.AspNetUsers", "LastName", c => c.String());
            AddColumn("dbo.AspNetUsers", "DesiredAge", c => c.Int());
            AddColumn("dbo.AspNetUsers", "DesiredColorId", c => c.Byte(nullable: false));
            AddColumn("dbo.AspNetUsers", "DesiredGenderId", c => c.Byte(nullable: false));
            AddColumn("dbo.AspNetUsers", "DesiredPetTypeId", c => c.Byte(nullable: false));
            AddColumn("dbo.AspNetUsers", "OtherPreferences", c => c.String());
            AddColumn("dbo.AspNetUsers", "DesiredColor_Id", c => c.Int());
            AddColumn("dbo.AspNetUsers", "DesiredGender_Id", c => c.Int());
            AddColumn("dbo.AspNetUsers", "DesiredPetType_Id", c => c.Int());
            CreateIndex("dbo.AspNetUsers", "DesiredColor_Id");
            CreateIndex("dbo.AspNetUsers", "DesiredGender_Id");
            CreateIndex("dbo.AspNetUsers", "DesiredPetType_Id");
            AddForeignKey("dbo.AspNetUsers", "DesiredColor_Id", "dbo.Colors", "Id");
            AddForeignKey("dbo.AspNetUsers", "DesiredGender_Id", "dbo.Genders", "Id");
            AddForeignKey("dbo.AspNetUsers", "DesiredPetType_Id", "dbo.PetTypes", "Id");
            DropTable("dbo.Users");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Email = c.String(),
                        PhoneNumber = c.String(),
                        DesiredAge = c.Int(),
                        DesiredColorId = c.Byte(nullable: false),
                        DesiredGenderId = c.Byte(nullable: false),
                        DesiredPetTypeId = c.Byte(nullable: false),
                        OtherPreferences = c.String(),
                        DesiredColor_Id = c.Int(),
                        DesiredGender_Id = c.Int(),
                        DesiredPetType_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            DropForeignKey("dbo.AspNetUsers", "DesiredPetType_Id", "dbo.PetTypes");
            DropForeignKey("dbo.AspNetUsers", "DesiredGender_Id", "dbo.Genders");
            DropForeignKey("dbo.AspNetUsers", "DesiredColor_Id", "dbo.Colors");
            DropIndex("dbo.AspNetUsers", new[] { "DesiredPetType_Id" });
            DropIndex("dbo.AspNetUsers", new[] { "DesiredGender_Id" });
            DropIndex("dbo.AspNetUsers", new[] { "DesiredColor_Id" });
            DropColumn("dbo.AspNetUsers", "DesiredPetType_Id");
            DropColumn("dbo.AspNetUsers", "DesiredGender_Id");
            DropColumn("dbo.AspNetUsers", "DesiredColor_Id");
            DropColumn("dbo.AspNetUsers", "OtherPreferences");
            DropColumn("dbo.AspNetUsers", "DesiredPetTypeId");
            DropColumn("dbo.AspNetUsers", "DesiredGenderId");
            DropColumn("dbo.AspNetUsers", "DesiredColorId");
            DropColumn("dbo.AspNetUsers", "DesiredAge");
            DropColumn("dbo.AspNetUsers", "LastName");
            DropColumn("dbo.AspNetUsers", "FirstName");
            CreateIndex("dbo.Users", "DesiredPetType_Id");
            CreateIndex("dbo.Users", "DesiredGender_Id");
            CreateIndex("dbo.Users", "DesiredColor_Id");
            AddForeignKey("dbo.Users", "DesiredPetType_Id", "dbo.PetTypes", "Id");
            AddForeignKey("dbo.Users", "DesiredGender_Id", "dbo.Genders", "Id");
            AddForeignKey("dbo.Users", "DesiredColor_Id", "dbo.Colors", "Id");
        }
    }
}
