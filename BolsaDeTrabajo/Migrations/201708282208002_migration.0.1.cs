namespace BolsaDeTrabajo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migration01 : DbMigration
    {
        public override void Up()
        {
            AddColumn("Sist.Candidatos", "puedeRehubicarse", c => c.Boolean(nullable: false));
            DropColumn("Sist.Candidatos", "puedeReubicarse");
        }
        
        public override void Down()
        {
            AddColumn("Sist.Candidatos", "puedeReubicarse", c => c.Boolean(nullable: false));
            DropColumn("Sist.Candidatos", "puedeRehubicarse");
        }
    }
}
