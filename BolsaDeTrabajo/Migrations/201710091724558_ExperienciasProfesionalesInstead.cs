namespace BolsaDeTrabajo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ExperienciasProfesionalesInstead : DbMigration
    {
        public override void Up()
        {
           // RenameTable(name: "Sist.FormacionesProfesionales", newName: "ExperienciasProfesionales");
        }
        
        public override void Down()
        {
            RenameTable(name: "Sist.ExperienciasProfesionales", newName: "FormacionesProfesionales");
        }
    }
}
