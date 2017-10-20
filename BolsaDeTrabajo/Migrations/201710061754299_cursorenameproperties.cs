namespace BolsaDeTrabajo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class cursorenameproperties : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "Sist.Cursos", name: "InstitucionEducativaId", newName: "InstitutionEducativaId");
            RenameColumn(table: "Sist.Cursos", name: "MonthInicioId", newName: "MonthEndId");
            RenameColumn(table: "Sist.Cursos", name: "MonthTerminoId", newName: "MonthStartId");
            RenameColumn(table: "Sist.Cursos", name: "YearInicioId", newName: "YearEndId");
            RenameColumn(table: "Sist.Cursos", name: "YearTerminoId", newName: "YearStartId");
            RenameIndex(table: "Sist.Cursos", name: "IX_InstitucionEducativaId", newName: "IX_InstitutionEducativaId");
            RenameIndex(table: "Sist.Cursos", name: "IX_YearTerminoId", newName: "IX_YearStartId");
            RenameIndex(table: "Sist.Cursos", name: "IX_MonthTerminoId", newName: "IX_MonthStartId");
            RenameIndex(table: "Sist.Cursos", name: "IX_YearInicioId", newName: "IX_YearEndId");
            RenameIndex(table: "Sist.Cursos", name: "IX_MonthInicioId", newName: "IX_MonthEndId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "Sist.Cursos", name: "IX_MonthEndId", newName: "IX_MonthInicioId");
            RenameIndex(table: "Sist.Cursos", name: "IX_YearEndId", newName: "IX_YearInicioId");
            RenameIndex(table: "Sist.Cursos", name: "IX_MonthStartId", newName: "IX_MonthTerminoId");
            RenameIndex(table: "Sist.Cursos", name: "IX_YearStartId", newName: "IX_YearTerminoId");
            RenameIndex(table: "Sist.Cursos", name: "IX_InstitutionEducativaId", newName: "IX_InstitucionEducativaId");
            RenameColumn(table: "Sist.Cursos", name: "YearStartId", newName: "YearTerminoId");
            RenameColumn(table: "Sist.Cursos", name: "YearEndId", newName: "YearInicioId");
            RenameColumn(table: "Sist.Cursos", name: "MonthStartId", newName: "MonthTerminoId");
            RenameColumn(table: "Sist.Cursos", name: "MonthEndId", newName: "MonthInicioId");
            RenameColumn(table: "Sist.Cursos", name: "InstitutionEducativaId", newName: "InstitucionEducativaId");
        }
    }
}
