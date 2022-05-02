namespace MVC_Pet_Store.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SetPetTypes : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO PetTypes (Type) VALUES ('Dog')");
            Sql("INSERT INTO PetTypes (Type) VALUES ('Cat')");
            Sql("INSERT INTO PetTypes (Type) VALUES ('Fish')");
            Sql("INSERT INTO PetTypes (Type) VALUES ('Turtle')");
            Sql("INSERT INTO PetTypes (Type) VALUES ('Hamster')");
        }
        
        public override void Down()
        {
        }
    }
}
