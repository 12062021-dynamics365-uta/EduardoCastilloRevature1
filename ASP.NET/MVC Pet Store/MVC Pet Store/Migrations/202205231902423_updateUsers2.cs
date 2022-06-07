namespace MVC_Pet_Store.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateUsers2 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.AspNetUsers", "DesiredColorId");
            DropColumn("dbo.AspNetUsers", "DesiredGenderId");
            DropColumn("dbo.AspNetUsers", "DesiredPetTypeId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AspNetUsers", "DesiredPetTypeId", c => c.Byte(nullable: false));
            AddColumn("dbo.AspNetUsers", "DesiredGenderId", c => c.Byte(nullable: false));
            AddColumn("dbo.AspNetUsers", "DesiredColorId", c => c.Byte(nullable: false));
        }
    }
}
