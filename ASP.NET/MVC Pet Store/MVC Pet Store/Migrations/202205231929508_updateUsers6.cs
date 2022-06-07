namespace MVC_Pet_Store.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateUsers6 : DbMigration
    {
        public override void Up()
        {
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
        }
        
        public override void Down()
        {
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
        }
    }
}
