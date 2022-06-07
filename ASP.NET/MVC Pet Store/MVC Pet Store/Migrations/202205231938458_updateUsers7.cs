namespace MVC_Pet_Store.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateUsers7 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.AspNetUsers", name: "DesiredColor_Id", newName: "Color_Id");
            RenameColumn(table: "dbo.AspNetUsers", name: "DesiredGender_Id", newName: "Gender_Id");
            RenameColumn(table: "dbo.AspNetUsers", name: "DesiredPetType_Id", newName: "PetType_Id");
            RenameIndex(table: "dbo.AspNetUsers", name: "IX_DesiredColor_Id", newName: "IX_Color_Id");
            RenameIndex(table: "dbo.AspNetUsers", name: "IX_DesiredGender_Id", newName: "IX_Gender_Id");
            RenameIndex(table: "dbo.AspNetUsers", name: "IX_DesiredPetType_Id", newName: "IX_PetType_Id");
            AddColumn("dbo.AspNetUsers", "ColorId", c => c.Byte(nullable: false));
            AddColumn("dbo.AspNetUsers", "GenderId", c => c.Byte(nullable: false));
            AddColumn("dbo.AspNetUsers", "PetTypeId", c => c.Byte(nullable: false));
            DropColumn("dbo.AspNetUsers", "DesiredColorId");
            DropColumn("dbo.AspNetUsers", "DesiredGenderId");
            DropColumn("dbo.AspNetUsers", "DesiredPetTypeId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AspNetUsers", "DesiredPetTypeId", c => c.Byte(nullable: false));
            AddColumn("dbo.AspNetUsers", "DesiredGenderId", c => c.Byte(nullable: false));
            AddColumn("dbo.AspNetUsers", "DesiredColorId", c => c.Byte(nullable: false));
            DropColumn("dbo.AspNetUsers", "PetTypeId");
            DropColumn("dbo.AspNetUsers", "GenderId");
            DropColumn("dbo.AspNetUsers", "ColorId");
            RenameIndex(table: "dbo.AspNetUsers", name: "IX_PetType_Id", newName: "IX_DesiredPetType_Id");
            RenameIndex(table: "dbo.AspNetUsers", name: "IX_Gender_Id", newName: "IX_DesiredGender_Id");
            RenameIndex(table: "dbo.AspNetUsers", name: "IX_Color_Id", newName: "IX_DesiredColor_Id");
            RenameColumn(table: "dbo.AspNetUsers", name: "PetType_Id", newName: "DesiredPetType_Id");
            RenameColumn(table: "dbo.AspNetUsers", name: "Gender_Id", newName: "DesiredGender_Id");
            RenameColumn(table: "dbo.AspNetUsers", name: "Color_Id", newName: "DesiredColor_Id");
        }
    }
}
