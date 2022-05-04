namespace MVC_Pet_Store.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class modPets1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Pets", "PetTypeId", c => c.Byte(nullable: false));
            DropColumn("dbo.Pets", "PetId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Pets", "PetId", c => c.Byte(nullable: false));
            DropColumn("dbo.Pets", "PetTypeId");
        }
    }
}
