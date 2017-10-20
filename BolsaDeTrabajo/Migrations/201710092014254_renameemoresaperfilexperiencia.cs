namespace BolsaDeTrabajo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class renameemoresaperfilexperiencia : DbMigration
    {
        public override void Up()
        {
            DropIndex("Sist.ExperienciasProfesionales", new[] { "PerfilCandidatoId" });
            DropForeignKey("Sist.ExperienciasProfesionales", "PerfilCandidatoId", "Sist.PerfilCandidato");
            CreateIndex("Sist.ExperienciasProfesionales", "PerfilCandidatoId");
            AddForeignKey("Sist.ExperienciasProfesionales", "PerfilCandidatoId", "Sist.PerfilCandidato", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
        }
    }
}
