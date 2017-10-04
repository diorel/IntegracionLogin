namespace BolsaDeTrabajo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CatalogosPerfilCandidato : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "Sist.Carreras",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        carrera = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("Sist.Formaciones", "CarreraId", c => c.Int(nullable: false));
            CreateIndex("Sist.Formaciones", "CarreraId");
            AddForeignKey("Sist.Formaciones", "CarreraId", "Sist.Carreras", "Id", cascadeDelete: true);
            DropColumn("Sist.Formaciones", "Carrera");
        }
        
        public override void Down()
        {
            AddColumn("Sist.Formaciones", "Carrera", c => c.String());
            DropForeignKey("Sist.Formaciones", "CarreraId", "Sist.Carreras");
            DropIndex("Sist.Formaciones", new[] { "CarreraId" });
            DropColumn("Sist.Formaciones", "CarreraId");
            DropTable("Sist.Carreras");
        }
    }
}
