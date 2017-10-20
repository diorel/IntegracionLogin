namespace BolsaDeTrabajo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class herramientahabilidadnonulleable : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("Sist.ConocimientosHabilidades", "PerfilCandidatoId", "Sist.PerfilCandidato");
            DropIndex("Sist.ConocimientosHabilidades", new[] { "PerfilCandidatoId" });
            AlterColumn("Sist.ConocimientosHabilidades", "PerfilCandidatoId", c => c.Int(nullable: false));
            CreateIndex("Sist.ConocimientosHabilidades", "PerfilCandidatoId");
            AddForeignKey("Sist.ConocimientosHabilidades", "PerfilCandidatoId", "Sist.PerfilCandidato", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("Sist.ConocimientosHabilidades", "PerfilCandidatoId", "Sist.PerfilCandidato");
            DropIndex("Sist.ConocimientosHabilidades", new[] { "PerfilCandidatoId" });
            AlterColumn("Sist.ConocimientosHabilidades", "PerfilCandidatoId", c => c.Int());
            CreateIndex("Sist.ConocimientosHabilidades", "PerfilCandidatoId");
            AddForeignKey("Sist.ConocimientosHabilidades", "PerfilCandidatoId", "Sist.PerfilCandidato", "Id");
        }
    }
}
