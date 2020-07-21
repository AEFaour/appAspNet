namespace WebApplicationmonPremierApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Indicateurs : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Indicateurs",
                c => new
                    {
                        IdIndicateur = c.Int(nullable: false, identity: true),
                        Libelle = c.String(),
                        Valeur = c.Int(nullable: false),
                        DateEvaluation = c.DateTime(nullable: false),
                        Module_id = c.Int(),
                    })
                .PrimaryKey(t => t.IdIndicateur)
                .ForeignKey("dbo.Modules", t => t.Module_id)
                .Index(t => t.Module_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Indicateurs", "Module_id", "dbo.Modules");
            DropIndex("dbo.Indicateurs", new[] { "Module_id" });
            DropTable("dbo.Indicateurs");
        }
    }
}
