namespace WebApplicationmonPremierApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Indicateurs2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Indicateurs", "IdModule", c => c.Int());
            AddColumn("dbo.Indicateurs", "Discriminator", c => c.String(nullable: false, maxLength: 128));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Indicateurs", "Discriminator");
            DropColumn("dbo.Indicateurs", "IdModule");
        }
    }
}
