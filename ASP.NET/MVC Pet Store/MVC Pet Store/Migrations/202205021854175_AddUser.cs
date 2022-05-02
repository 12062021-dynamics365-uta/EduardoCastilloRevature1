namespace MVC_Pet_Store.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUser : DbMigration
    {
        public override void Up()
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
                        DesiredAge = c.Int(nullable: false),
                        DesiredColor = c.String(),
                        DesiredGender = c.String(),
                        DesiredPetType = c.String(),
                        OtherPreferences = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Pets", "PetType", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Pets", "PetType");
            DropTable("dbo.Users");
        }
    }
}
