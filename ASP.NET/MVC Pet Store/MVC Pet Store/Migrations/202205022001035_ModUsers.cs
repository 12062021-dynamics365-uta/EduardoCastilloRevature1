namespace MVC_Pet_Store.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModUsers : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "DesiredColorId", c => c.Byte(nullable: false));
            AddColumn("dbo.Users", "DesiredGenderId", c => c.Byte(nullable: false));
            AddColumn("dbo.Users", "DesiredPetTypeId", c => c.Byte(nullable: false));
            AddColumn("dbo.Users", "DesiredColor_Id", c => c.Int());
            AddColumn("dbo.Users", "DesiredGender_Id", c => c.Int());
            AddColumn("dbo.Users", "DesiredPetType_Id", c => c.Int());
            AlterColumn("dbo.Users", "DesiredAge", c => c.Int());
            CreateIndex("dbo.Users", "DesiredColor_Id");
            CreateIndex("dbo.Users", "DesiredGender_Id");
            CreateIndex("dbo.Users", "DesiredPetType_Id");
            AddForeignKey("dbo.Users", "DesiredColor_Id", "dbo.Colors", "Id");
            AddForeignKey("dbo.Users", "DesiredGender_Id", "dbo.Genders", "Id");
            AddForeignKey("dbo.Users", "DesiredPetType_Id", "dbo.PetTypes", "Id");
            DropColumn("dbo.Users", "DesiredColor");
            DropColumn("dbo.Users", "DesiredGender");
            DropColumn("dbo.Users", "DesiredPetType");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "DesiredPetType", c => c.String());
            AddColumn("dbo.Users", "DesiredGender", c => c.String());
            AddColumn("dbo.Users", "DesiredColor", c => c.String());
            DropForeignKey("dbo.Users", "DesiredPetType_Id", "dbo.PetTypes");
            DropForeignKey("dbo.Users", "DesiredGender_Id", "dbo.Genders");
            DropForeignKey("dbo.Users", "DesiredColor_Id", "dbo.Colors");
            DropIndex("dbo.Users", new[] { "DesiredPetType_Id" });
            DropIndex("dbo.Users", new[] { "DesiredGender_Id" });
            DropIndex("dbo.Users", new[] { "DesiredColor_Id" });
            AlterColumn("dbo.Users", "DesiredAge", c => c.Int(nullable: false));
            DropColumn("dbo.Users", "DesiredPetType_Id");
            DropColumn("dbo.Users", "DesiredGender_Id");
            DropColumn("dbo.Users", "DesiredColor_Id");
            DropColumn("dbo.Users", "DesiredPetTypeId");
            DropColumn("dbo.Users", "DesiredGenderId");
            DropColumn("dbo.Users", "DesiredColorId");
        }
    }
}
