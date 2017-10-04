namespace BolsaDeTrabajo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PersonaRelationsCandidatos : DbMigration
    {
        public override void Up()
        {
            DropIndex("Sist.Telefonos", new[] { "PersonaFisicaMoralId" });
            DropIndex("Sist.Emails", new[] { "PersonaFisicaMoralId" });
            DropIndex("Sist.Direcciones", new[] { "PersonaFisicaMoralId" });
            CreateIndex("Sist.Direcciones", "PersonaFisicaMoralId");
            CreateIndex("Sist.Emails", "PersonaFisicaMoralId");
            CreateIndex("Sist.Telefonos", "PersonaFisicaMoralId");
            AddForeignKey("Sist.Direcciones", "PersonaFisicaMoralId", "Sist.Personas", "Id", cascadeDelete: true);
            AddForeignKey("Sist.Emails", "PersonaFisicaMoralId", "Sist.Personas", "Id", cascadeDelete: true);
            AddForeignKey("Sist.Telefonos", "PersonaFisicaMoralId", "Sist.Personas", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("Sist.Telefonos", "PersonaFisicaMoralId", "Sist.Personas");
            DropForeignKey("Sist.Emails", "PersonaFisicaMoralId", "Sist.Personas");
            DropForeignKey("Sist.Direcciones", "PersonaFisicaMoralId", "Sist.Personas");
          
        }
    }
}
