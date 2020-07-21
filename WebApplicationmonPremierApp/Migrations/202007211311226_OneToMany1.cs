namespace WebApplicationmonPremierApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OneToMany1 : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Modules", new[] { "parcours_Id" });
            CreateIndex("dbo.Modules", "Parcours_Id");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Modules", new[] { "Parcours_Id" });
            CreateIndex("dbo.Modules", "parcours_Id");
        }
    }
}
