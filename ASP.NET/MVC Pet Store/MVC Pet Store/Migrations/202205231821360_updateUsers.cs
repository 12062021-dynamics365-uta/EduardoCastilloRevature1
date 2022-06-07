namespace MVC_Pet_Store.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateUsers : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.AspNetUsers", "DesiredColor_Id", "dbo.Colors");
            DropForeignKey("dbo.AspNetUsers", "DesiredGender_Id", "dbo.Genders");
            DropForeignKey("dbo.AspNetUsers", "DesiredPetType_Id", "dbo.PetTypes");
            DropIndex("dbo.AspNetUsers", new[] { "DesiredColor_Id" });
            DropIndex("dbo.AspNetUsers", new[] { "DesiredGender_Id" });
            DropIndex("dbo.AspNetUsers", new[] { "DesiredPetType_Id" });
            DropColumn("dbo.AspNetUsers", "DesiredAge");
            DropColumn("dbo.AspNetUsers", "DesiredColorId");
            DropColumn("dbo.AspNetUsers", "DesiredGenderId");
            DropColumn("dbo.AspNetUsers", "DesiredPetTypeId");
            DropColumn("dbo.AspNetUsers", "OtherPreferences");
            DropColumn("dbo.AspNetUsers", "DesiredColor_Id");
            DropColumn("dbo.AspNetUsers", "DesiredGender_Id");
            DropColumn("dbo.AspNetUsers", "DesiredPetType_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AspNetUsers", "DesiredPetType_Id", c => c.Int());
            AddColumn("dbo.AspNetUsers", "DesiredGender_Id", c => c.Int());
            AddColumn("dbo.AspNetUsers", "DesiredColor_Id", c => c.Int());
            AddColumn("dbo.AspNetUsers", "OtherPreferences", c => c.String());
            AddColumn("dbo.AspNetUsers", "DesiredPetTypeId", c => c.Byte(nullable: false));
            AddColumn("dbo.AspNetUsers", "DesiredGenderId", c => c.Byte(nullable: false));
            AddColumn("dbo.AspNetUsers", "DesiredColorId", c => c.Byte(nullable: false));
            AddColumn("dbo.AspNetUsers", "DesiredAge", c => c.Int());
            CreateIndex("dbo.AspNetUsers", "DesiredPetType_Id");
            CreateIndex("dbo.AspNetUsers", "DesiredGender_Id");
            CreateIndex("dbo.AspNetUsers", "DesiredColor_Id");
            AddForeignKey("dbo.AspNetUsers", "DesiredPetType_Id", "dbo.PetTypes", "Id");
            AddForeignKey("dbo.AspNetUsers", "DesiredGender_Id", "dbo.Genders", "Id");
            AddForeignKey("dbo.AspNetUsers", "DesiredColor_Id", "dbo.Colors", "Id");
        }
    }
}
