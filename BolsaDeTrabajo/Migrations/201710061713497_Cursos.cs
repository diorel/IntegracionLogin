namespace BolsaDeTrabajo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Cursos : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "Sist.Cursos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        curso = c.String(),
                        InstitucionEducativaId = c.Int(nullable: false),
                        YearInicioId = c.Int(),
                        MonthInicioId = c.Int(),
                        YearTerminoId = c.Int(),
                        MonthTerminoId = c.Int(),
                        PerfilCandidatoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("Sist.InstitucionesEducativas", t => t.InstitucionEducativaId, cascadeDelete: true)
                .ForeignKey("Sist.Months", t => t.MonthInicioId)
                .ForeignKey("Sist.Months", t => t.MonthTerminoId)
                .ForeignKey("Sist.PerfilCandidato", t => t.PerfilCandidatoId, cascadeDelete: true)
                .ForeignKey("Sist.Years", t => t.YearInicioId)
                .ForeignKey("Sist.Years", t => t.YearTerminoId)
                .Index(t => t.InstitucionEducativaId)
                .Index(t => t.YearInicioId)
                .Index(t => t.MonthInicioId)
                .Index(t => t.YearTerminoId)
                .Index(t => t.MonthTerminoId)
                .Index(t => t.PerfilCandidatoId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("Sist.Cursos", "YearTerminoId", "Sist.Years");
            DropForeignKey("Sist.Cursos", "YearInicioId", "Sist.Years");
            DropForeignKey("Sist.Cursos", "PerfilCandidatoId", "Sist.PerfilCandidato");
            DropForeignKey("Sist.Cursos", "MonthTerminoId", "Sist.Months");
            DropForeignKey("Sist.Cursos", "MonthInicioId", "Sist.Months");
            DropForeignKey("Sist.Cursos", "InstitucionEducativaId", "Sist.InstitucionesEducativas");
            DropIndex("Sist.Cursos", new[] { "PerfilCandidatoId" });
            DropIndex("Sist.Cursos", new[] { "MonthTerminoId" });
            DropIndex("Sist.Cursos", new[] { "YearTerminoId" });
            DropIndex("Sist.Cursos", new[] { "MonthInicioId" });
            DropIndex("Sist.Cursos", new[] { "YearInicioId" });
            DropIndex("Sist.Cursos", new[] { "InstitucionEducativaId" });
            DropTable("Sist.Cursos");
        }
    }
}
