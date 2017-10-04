namespace BolsaDeTrabajo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EstatusEstudio : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "Sist.EstadosEstudios",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        estadoEstudio = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("Sist.Formaciones", "EstadoEstudioId", c => c.Int(nullable: false));
            CreateIndex("Sist.Formaciones", "EstadoEstudioId");
            AddForeignKey("Sist.Formaciones", "EstadoEstudioId", "Sist.EstadosEstudios", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("Sist.Formaciones", "EstadoEstudioId", "Sist.EstadosEstudios");
            DropIndex("Sist.Formaciones", new[] { "EstadoEstudioId" });
            DropColumn("Sist.Formaciones", "EstadoEstudioId");
            DropTable("Sist.EstadosEstudios");
        }
    }
}
