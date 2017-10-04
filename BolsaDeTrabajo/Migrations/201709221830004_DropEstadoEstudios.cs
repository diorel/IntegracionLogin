namespace BolsaDeTrabajo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DropEstadoEstudios : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("Sist.Formaciones", "EstadoEstudioId", "Sist.EstadosEstudios");
            DropIndex("Sist.Formaciones", new[] { "EstadoEstudioId" });
            DropColumn("Sist.Formaciones", "EstadoEstudioId");
            DropTable("Sist.EstadosEstudios");
        }
        
        public override void Down()
        {
            CreateTable(
                "Sist.EstadosEstudios",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        EstadoEstuio = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("Sist.Formaciones", "EstadoEstudioId", c => c.Byte(nullable: false));
            CreateIndex("Sist.Formaciones", "EstadoEstudioId");
            AddForeignKey("Sist.Formaciones", "EstadoEstudioId", "Sist.EstadosEstudios", "Id", cascadeDelete: true);
        }
    }
}
