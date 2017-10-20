namespace BolsaDeTrabajo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeAboutMeToArray : DbMigration
    {
        public override void Up()
        {
            DropIndex("Sist.PerfilCandidato", new[] { "AboutMeId" });
            DropForeignKey("Sist.PerfilCandidato", "AboutMeId", "Sist.AcercaDeMi");
            DropColumn("Sist.PerfilCandidato", "AboutMeId");            
            AddColumn("Sist.AcercaDeMi", "PerfilCandidatoId", c => c.Int(nullable: false));
            CreateIndex("Sist.AcercaDeMi", "PerfilCandidatoId");
            AddForeignKey("Sist.AcercaDeMi", "PerfilCandidatoId", "Sist.PerfilCandidato", "Id",  cascadeDelete: true);
        }

        public override void Down()
        {
            AddColumn("Sist.PerfilCandidato", "AboutMeId", c => c.Int(nullable: false));
            DropIndex("Sist.AcercaDeMi", new[] { "PerfilCandidatoId" });
            RenameColumn(table: "Sist.AcercaDeMi", name: "PerfilCandidatoId", newName: "AboutMeId");
            CreateIndex("Sist.PerfilCandidato", "AboutMeId");
        }
    }
}
