namespace BolsaDeTrabajo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CandidatosRelaciones : DbMigration
    {
        public override void Up()
        {
            //AddColumn("Sist.Direcciones", "Candidato_Id", c => c.Int());
            //AddColumn("Sist.Emails", "Candidato_Id", c => c.Int());
            //AddColumn("Sist.Telefonos", "Candidato_Id", c => c.Int());
            //CreateIndex("Sist.Direcciones", "PersonaFisicaMoralId");
            //CreateIndex("Sist.Emails", "PersonaFisicaMoralId");
            //CreateIndex("Sist.Telefonos", "PersonaFisicaMoralId");
            //AddForeignKey("Sist.Direcciones", "PersonaFisicaMoralId", "Sist.Candidatos", "Id");
            //AddForeignKey("Sist.Emails", "PersonaFisicaMoralId", "Sist.Candidatos", "Id");
            //AddForeignKey("Sist.Telefonos", "PersonaFisicaMoralId", "Sist.Candidatos", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("Sist.Telefonos", "Candidato_Id", "Sist.Candidatos");
            DropForeignKey("Sist.Emails", "Candidato_Id", "Sist.Candidatos");
            DropForeignKey("Sist.Direcciones", "Candidato_Id", "Sist.Candidatos");
            DropIndex("Sist.Telefonos", new[] { "Candidato_Id" });
            DropIndex("Sist.Emails", new[] { "Candidato_Id" });
            DropIndex("Sist.Direcciones", new[] { "Candidato_Id" });
            DropColumn("Sist.Telefonos", "Candidato_Id");
            DropColumn("Sist.Emails", "Candidato_Id");
            DropColumn("Sist.Direcciones", "Candidato_Id");
        }
    }
}
