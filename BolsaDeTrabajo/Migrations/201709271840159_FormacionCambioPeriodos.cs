namespace BolsaDeTrabajo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FormacionCambioPeriodos : DbMigration
    {
        public override void Up()
        {
            AddColumn("Sist.Formaciones", "InstitucionId", c => c.Int(nullable: false));
            AddColumn("Sist.Formaciones", "DocumentoValidadorId", c => c.Int(nullable: false));
            AddColumn("Sist.Formaciones", "YearInicioId", c => c.Int(nullable: false));
            AddColumn("Sist.Formaciones", "MonthInicioId", c => c.Int(nullable: false));
            AddColumn("Sist.Formaciones", "YearTerminoId", c => c.Int(nullable: false));
            AddColumn("Sist.Formaciones", "MonthTerminoId", c => c.Int(nullable: false));
            CreateIndex("Sist.Formaciones", "InstitucionId");
            CreateIndex("Sist.Formaciones", "DocumentoValidadorId");
            CreateIndex("Sist.Formaciones", "YearInicioId");
            CreateIndex("Sist.Formaciones", "MonthInicioId");
            CreateIndex("Sist.Formaciones", "YearTerminoId");
            CreateIndex("Sist.Formaciones", "MonthTerminoId");
            AddForeignKey("Sist.Formaciones", "DocumentoValidadorId", "Sist.DocumentosValidadores", "Id", cascadeDelete: true);
            AddForeignKey("Sist.Formaciones", "InstitucionId", "Sist.InstitucionesEducativas", "Id", cascadeDelete: true);
            AddForeignKey("Sist.Formaciones", "MonthInicioId", "Sist.Months", "Id", cascadeDelete: false);
            AddForeignKey("Sist.Formaciones", "MonthTerminoId", "Sist.Months", "Id", cascadeDelete: false);
            AddForeignKey("Sist.Formaciones", "YearInicioId", "Sist.Years", "Id", cascadeDelete: false);
            AddForeignKey("Sist.Formaciones", "YearTerminoId", "Sist.Years", "Id", cascadeDelete: false);
            DropColumn("Sist.Formaciones", "Institucion");
            DropColumn("Sist.Formaciones", "PeriodoInicio");
            DropColumn("Sist.Formaciones", "PeriodoTermino");
        }
        
        public override void Down()
        {
            AddColumn("Sist.Formaciones", "PeriodoTermino", c => c.String());
            AddColumn("Sist.Formaciones", "PeriodoInicio", c => c.String());
            AddColumn("Sist.Formaciones", "Institucion", c => c.String());
            DropForeignKey("Sist.Formaciones", "YearTerminoId", "Sist.Years");
            DropForeignKey("Sist.Formaciones", "YearInicioId", "Sist.Years");
            DropForeignKey("Sist.Formaciones", "MonthTerminoId", "Sist.Months");
            DropForeignKey("Sist.Formaciones", "MonthInicioId", "Sist.Months");
            DropForeignKey("Sist.Formaciones", "InstitucionId", "Sist.InstitucionesEducativas");
            DropForeignKey("Sist.Formaciones", "DocumentoValidadorId", "Sist.DocumentosValidadores");
            DropIndex("Sist.Formaciones", new[] { "MonthTerminoId" });
            DropIndex("Sist.Formaciones", new[] { "YearTerminoId" });
            DropIndex("Sist.Formaciones", new[] { "MonthInicioId" });
            DropIndex("Sist.Formaciones", new[] { "YearInicioId" });
            DropIndex("Sist.Formaciones", new[] { "DocumentoValidadorId" });
            DropIndex("Sist.Formaciones", new[] { "InstitucionId" });
            DropColumn("Sist.Formaciones", "MonthTerminoId");
            DropColumn("Sist.Formaciones", "YearTerminoId");
            DropColumn("Sist.Formaciones", "MonthInicioId");
            DropColumn("Sist.Formaciones", "YearInicioId");
            DropColumn("Sist.Formaciones", "DocumentoValidadorId");
            DropColumn("Sist.Formaciones", "InstitucionId");
        }
    }
}
