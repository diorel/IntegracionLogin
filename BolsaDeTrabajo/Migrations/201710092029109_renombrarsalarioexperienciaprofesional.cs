namespace BolsaDeTrabajo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class renombrarsalarioexperienciaprofesional : DbMigration
    {
        public override void Up()
        {
            AddColumn("Sist.ExperienciasProfesionales", "Salario", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            DropColumn("Sist.ExperienciasProfesionales", "Sueldo");
        }
        
        public override void Down()
        {
            AddColumn("Sist.ExperienciasProfesionales", "Sueldo", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            DropColumn("Sist.ExperienciasProfesionales", "Salario");
        }
    }
}
