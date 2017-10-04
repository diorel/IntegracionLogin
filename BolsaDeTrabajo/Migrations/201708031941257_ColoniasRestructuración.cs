namespace BolsaDeTrabajo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ColoniasRestructuración : DbMigration
    {
        public override void Up()
        {
            AddColumn("Sist.Colonias", "EstadoId", c => c.Int(nullable: false));
            AddColumn("Sist.Colonias", "PaisId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("Sist.Colonias", "PaisId");
            DropColumn("Sist.Colonias", "EstadoId");
        }
    }
}
