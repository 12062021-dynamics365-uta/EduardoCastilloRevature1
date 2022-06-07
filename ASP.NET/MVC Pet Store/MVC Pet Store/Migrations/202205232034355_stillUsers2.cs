namespace MVC_Pet_Store.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class stillUsers2 : DbMigration
    {
        public override void Up()
        {

            DropColumn("dbo.AspNetUsers", "PetType_Id");
            DropColumn("dbo.AspNetUsers", "Gender_Id");
            DropColumn("dbo.AspNetUsers", "Color_Id");

        }
        
        public override void Down()
        {
            
        }
    }
}
