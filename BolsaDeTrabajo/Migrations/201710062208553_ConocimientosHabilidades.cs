namespace BolsaDeTrabajo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ConocimientosHabilidades : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "Sist.ConocimientosHabilidades",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Conocimiento = c.String(),
                        Herramienta = c.String(),
                        InstitucionEducativaId = c.Int(),
                        NivelId = c.Byte(),
                        PerfilCandidatoId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("Sist.InstitucionesEducativas", t => t.InstitucionEducativaId)
                .ForeignKey("Sist.Niveles", t => t.NivelId)
                .ForeignKey("Sist.PerfilCandidato", t => t.PerfilCandidatoId)
                .Index(t => t.InstitucionEducativaId)
                .Index(t => t.NivelId)
                .Index(t => t.PerfilCandidatoId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("Sist.ConocimientosHabilidades", "PerfilCandidatoId", "Sist.PerfilCandidato");
            DropForeignKey("Sist.ConocimientosHabilidades", "NivelId", "Sist.Niveles");
            DropForeignKey("Sist.ConocimientosHabilidades", "InstitucionEducativaId", "Sist.InstitucionesEducativas");
            DropIndex("Sist.ConocimientosHabilidades", new[] { "PerfilCandidatoId" });
            DropIndex("Sist.ConocimientosHabilidades", new[] { "NivelId" });
            DropIndex("Sist.ConocimientosHabilidades", new[] { "InstitucionEducativaId" });
            DropTable("Sist.ConocimientosHabilidades");
        }
    }
}
