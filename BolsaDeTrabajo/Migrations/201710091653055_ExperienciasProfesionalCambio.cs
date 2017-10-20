namespace BolsaDeTrabajo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ExperienciasProfesionalCambio : DbMigration
    {
        public override void Up()
        {
           // RenameTable(name: "Sist.ExperienciasProfesionales", newName: "ExperienciasProfesionales");
            AddColumn("Sist.ExperienciasProfesionales", "YearInicioId", c => c.Int(nullable: false));
            AddColumn("Sist.ExperienciasProfesionales", "MonthInicioId", c => c.Int(nullable: false));
            AddColumn("Sist.ExperienciasProfesionales", "YearTerminoId", c => c.Int(nullable: false));
            AddColumn("Sist.ExperienciasProfesionales", "MonthTerminoId", c => c.Int(nullable: false));
            AddColumn("Sist.ExperienciasProfesionales", "TrabajoActual", c => c.Boolean(nullable: false));
            AddColumn("Sist.ExperienciasProfesionales", "PerfilCandidatoId", c => c.Int(nullable: false));
            CreateIndex("Sist.ExperienciasProfesionales", "YearInicioId");
            CreateIndex("Sist.ExperienciasProfesionales", "MonthInicioId");
            CreateIndex("Sist.ExperienciasProfesionales", "YearTerminoId");
            CreateIndex("Sist.ExperienciasProfesionales", "MonthTerminoId");
            CreateIndex("Sist.ExperienciasProfesionales", "PerfilCandidatoId");
            AddForeignKey("Sist.ExperienciasProfesionales", "MonthInicioId", "Sist.Months", "Id", cascadeDelete: false);
            AddForeignKey("Sist.ExperienciasProfesionales", "MonthTerminoId", "Sist.Months", "Id", cascadeDelete: false);
            AddForeignKey("Sist.ExperienciasProfesionales", "PerfilCandidatoId", "Sist.PerfilCandidato", "Id", cascadeDelete: false);
            AddForeignKey("Sist.ExperienciasProfesionales", "YearInicioId", "Sist.Years", "Id", cascadeDelete: false);
            AddForeignKey("Sist.ExperienciasProfesionales", "YearTerminoId", "Sist.Years", "Id", cascadeDelete: false);
            DropColumn("Sist.ExperienciasProfesionales", "PeriodoInicio");
            DropColumn("Sist.ExperienciasProfesionales", "PeriodoFin");
            DropColumn("Sist.ExperienciasProfesionales", "CandidatoId");
        }
        
        public override void Down()
        {
            AddColumn("Sist.ExperienciasProfesionales", "CandidatoId", c => c.Int(nullable: false));
            AddColumn("Sist.ExperienciasProfesionales", "PeriodoFin", c => c.String());
            AddColumn("Sist.ExperienciasProfesionales", "PeriodoInicio", c => c.String());
            DropForeignKey("Sist.ExperienciasProfesionales", "YearTerminoId", "Sist.Years");
            DropForeignKey("Sist.ExperienciasProfesionales", "YearInicioId", "Sist.Years");
            DropForeignKey("Sist.ExperienciasProfesionales", "PerfilCandidatoId", "Sist.PerfilCandidato");
            DropForeignKey("Sist.ExperienciasProfesionales", "MonthTerminoId", "Sist.Months");
            DropForeignKey("Sist.ExperienciasProfesionales", "MonthInicioId", "Sist.Months");
            DropIndex("Sist.ExperienciasProfesionales", new[] { "PerfilCandidatoId" });
            DropIndex("Sist.ExperienciasProfesionales", new[] { "MonthTerminoId" });
            DropIndex("Sist.ExperienciasProfesionales", new[] { "YearTerminoId" });
            DropIndex("Sist.ExperienciasProfesionales", new[] { "MonthInicioId" });
            DropIndex("Sist.ExperienciasProfesionales", new[] { "YearInicioId" });
            DropColumn("Sist.ExperienciasProfesionales", "PerfilCandidatoId");
            DropColumn("Sist.ExperienciasProfesionales", "TrabajoActual");
            DropColumn("Sist.ExperienciasProfesionales", "MonthTerminoId");
            DropColumn("Sist.ExperienciasProfesionales", "YearTerminoId");
            DropColumn("Sist.ExperienciasProfesionales", "MonthInicioId");
            DropColumn("Sist.ExperienciasProfesionales", "YearInicioId");
            RenameTable(name: "Sist.ExperienciasProfesionales", newName: "ExperienciasProfesionales");
        }
    }
}
