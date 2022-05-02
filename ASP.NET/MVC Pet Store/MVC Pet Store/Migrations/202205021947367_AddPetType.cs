namespace MVC_Pet_Store.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPetType : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PetTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Type = c.String(nullable: false, maxLength: 255),
                    })
                .PrimaryKey(t => t.Id);
            
            AlterColumn("dbo.Genders", "GenderName", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Genders", "GenderName", c => c.String());
            DropTable("dbo.PetTypes");
        }
    }
}
