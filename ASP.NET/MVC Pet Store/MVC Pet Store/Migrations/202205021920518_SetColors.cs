namespace MVC_Pet_Store.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SetColors : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Colors (ColorName) VALUES ('White')");
            Sql("INSERT INTO Colors (ColorName) VALUES ('Black')");
            Sql("INSERT INTO Colors (ColorName) VALUES ('Brown')");
            Sql("INSERT INTO Colors (ColorName) VALUES ('Gold')");
            Sql("INSERT INTO Colors (ColorName) VALUES ('Gray')");
            Sql("INSERT INTO Colors (ColorName) VALUES ('Orange')");
            Sql("INSERT INTO Colors (ColorName) VALUES ('Blue')");
            Sql("INSERT INTO Colors (ColorName) VALUES ('Red')");
            Sql("INSERT INTO Colors (ColorName) VALUES ('Green')");
            Sql("INSERT INTO Colors (ColorName) VALUES ('Yellow')");
        }
        
        public override void Down()
        {
        }
    }
}
