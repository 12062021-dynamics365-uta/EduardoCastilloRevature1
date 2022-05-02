namespace MVC_Pet_Store.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SetGenders : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genders (GenderName) VALUES ('Male')");
            Sql("INSERT INTO Genders (GenderName) VALUES ('Famele')");
        }
        
        public override void Down()
        {
        }
    }
}
