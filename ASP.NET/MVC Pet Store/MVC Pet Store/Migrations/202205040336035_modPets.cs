namespace MVC_Pet_Store.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class modPets : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Pets", "ColorId", c => c.Byte(nullable: false));
            AddColumn("dbo.Pets", "GenderId", c => c.Byte(nullable: false));
            AddColumn("dbo.Pets", "PetId", c => c.Byte(nullable: false));
            AddColumn("dbo.Pets", "Color_Id", c => c.Int());
            AddColumn("dbo.Pets", "Gender_Id", c => c.Int());
            AddColumn("dbo.Pets", "PetType_Id", c => c.Int());
            CreateIndex("dbo.Pets", "Color_Id");
            CreateIndex("dbo.Pets", "Gender_Id");
            CreateIndex("dbo.Pets", "PetType_Id");
            AddForeignKey("dbo.Pets", "Color_Id", "dbo.Colors", "Id");
            AddForeignKey("dbo.Pets", "Gender_Id", "dbo.Genders", "Id");
            AddForeignKey("dbo.Pets", "PetType_Id", "dbo.PetTypes", "Id");
            DropColumn("dbo.Pets", "Color");
            DropColumn("dbo.Pets", "Gender");
            DropColumn("dbo.Pets", "PetType");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Pets", "PetType", c => c.String());
            AddColumn("dbo.Pets", "Gender", c => c.String());
            AddColumn("dbo.Pets", "Color", c => c.String());
            DropForeignKey("dbo.Pets", "PetType_Id", "dbo.PetTypes");
            DropForeignKey("dbo.Pets", "Gender_Id", "dbo.Genders");
            DropForeignKey("dbo.Pets", "Color_Id", "dbo.Colors");
            DropIndex("dbo.Pets", new[] { "PetType_Id" });
            DropIndex("dbo.Pets", new[] { "Gender_Id" });
            DropIndex("dbo.Pets", new[] { "Color_Id" });
            DropColumn("dbo.Pets", "PetType_Id");
            DropColumn("dbo.Pets", "Gender_Id");
            DropColumn("dbo.Pets", "Color_Id");
            DropColumn("dbo.Pets", "PetId");
            DropColumn("dbo.Pets", "GenderId");
            DropColumn("dbo.Pets", "ColorId");
        }
    }
}
