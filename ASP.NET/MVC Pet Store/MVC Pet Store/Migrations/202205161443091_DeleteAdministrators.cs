namespace MVC_Pet_Store.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteAdministrators : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.Administrators");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Administrators",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
    }
}
