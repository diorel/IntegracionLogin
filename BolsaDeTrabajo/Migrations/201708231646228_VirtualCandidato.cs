namespace BolsaDeTrabajo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class VirtualCandidato : DbMigration
    {
        public override void Up()
        {
            AddColumn("Sist.Candidatos", "TipoLicenciaId", c => c.Byte());
            AddColumn("Sist.Candidatos", "TipoDiscapacidadId", c => c.Int(nullable: false));
            //AddColumn("Sist.Direcciones", "Candidato_Id", c => c.Int());
            //AddColumn("Sist.Emails", "Candidato_Id", c => c.Int());
            //AddColumn("Sist.Telefonos", "Candidato_Id", c => c.Int());
            CreateIndex("Sist.Direcciones", "PersonaFisicaMoralId");
            CreateIndex("Sist.Emails", "PersonaFisicaMoralId");
            CreateIndex("Sist.Telefonos", "PersonaFisicaMoralId");
            CreateIndex("Sist.Candidatos", "TipoLicenciaId");
            CreateIndex("Sist.Candidatos", "TipoDiscapacidadId");
            AddForeignKey("Sist.Direcciones", "PersonaFisicaMoralId", "Sist.Candidatos", "Id");
            AddForeignKey("Sist.Emails", "PersonaFisicaMoralId", "Sist.Candidatos", "Id");
            AddForeignKey("Sist.Telefonos", "PersonaFisicaMoralId", "Sist.Candidatos", "Id");
            AddForeignKey("Sist.Candidatos", "TipoLicenciaId", "Sist.TiposLicencias", "Id");
            //AddForeignKey("Sist.Candidatos", "TipoDiscapacidadId", "Sist.TiposDiscapacidades", "Id");
            
            DropColumn("Sist.Candidatos", "tipoLicenciaConducir");
        }
        
        public override void Down()
        {
            AddColumn("Sist.Candidatos", "tipoLicenciaConducir", c => c.String());
            DropForeignKey("Sist.Candidatos", "TipoDiscapacidadId", "Sist.TiposDiscapacidades");
            DropForeignKey("Sist.Candidatos", "TipoLicencia_Id", "Sist.TiposLicencias");
            DropForeignKey("Sist.Telefonos", "Candidato_Id", "Sist.Candidatos");
            DropForeignKey("Sist.Emails", "Candidato_Id", "Sist.Candidatos");
            DropForeignKey("Sist.Direcciones", "Candidato_Id", "Sist.Candidatos");
            DropIndex("Sist.Candidatos", new[] { "TipoDiscapacidadId" });
            DropIndex("Sist.Candidatos", new[] { "TipoLicencia_Id" });
            DropIndex("Sist.Telefonos", new[] { "Candidato_Id" });
            DropIndex("Sist.Emails", new[] { "Candidato_Id" });
            DropIndex("Sist.Direcciones", new[] { "Candidato_Id" });
            DropColumn("Sist.Telefonos", "Candidato_Id");
            DropColumn("Sist.Emails", "Candidato_Id");
            DropColumn("Sist.Direcciones", "Candidato_Id");
            DropColumn("Sist.Candidatos", "TipoLicenciaId");
            DropColumn("Sist.Candidatos", "TipoDiscapacidadId");
            DropColumn("Sist.Candidatos", "TipoLicencia_Id");
        }
    }
}
