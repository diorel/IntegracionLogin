namespace BolsaDeTrabajo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class renamenombreempresa : DbMigration
    {
        public override void Up()
        {
            AddColumn("Sist.ExperienciasProfesionales", "Empresa", c => c.String());
            DropColumn("Sist.ExperienciasProfesionales", "NombreEmpresa");
        }
        
        public override void Down()
        {
            AddColumn("Sist.ExperienciasProfesionales", "NombreEmpresa", c => c.String());
            DropColumn("Sist.ExperienciasProfesionales", "Empresa");
        }
    }
}
