namespace BolsaDeTrabajo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PerfilCandidatoPrueba : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("Sist.PerfilIdiomas", "CandidatoId", "Sist.Candidatos");
            DropIndex("Sist.PerfilIdiomas", new[] { "CandidatoId" });
            DropColumn("Sist.Formaciones", "CandidatoId");
            DropColumn("Sist.PerfilIdiomas", "CandidatoId");
        }
        
        public override void Down()
        {
            AddColumn("Sist.PerfilIdiomas", "CandidatoId", c => c.Int(nullable: false));
            AddColumn("Sist.Formaciones", "CandidatoId", c => c.Int(nullable: false));
            CreateIndex("Sist.PerfilIdiomas", "CandidatoId");
            AddForeignKey("Sist.PerfilIdiomas", "CandidatoId", "Sist.Candidatos", "Id");
        }
    }
}
