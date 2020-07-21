namespace WebApplicationmonPremierApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Modules",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Nom = c.String(),
                        Parcours_Id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Parcours", t => t.Parcours_Id)
                .Index(t => t.Parcours_Id);
            
            CreateTable(
                "dbo.Parcours",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nom = c.String(nullable: false),
                        Slogan = c.String(),
                        Logo = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Modules", "Parcours_Id", "dbo.Parcours");
            DropIndex("dbo.Modules", new[] { "Parcours_Id" });
            DropTable("dbo.Parcours");
            DropTable("dbo.Modules");
        }
    }
}
