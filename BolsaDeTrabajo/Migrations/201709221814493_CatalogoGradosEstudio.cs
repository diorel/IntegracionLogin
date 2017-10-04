namespace BolsaDeTrabajo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CatalogoGradosEstudio : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO [Sist].[GradosEstudio] VALUES('Primaria')");
            Sql("INSERT INTO [Sist].[GradosEstudio] VALUES('Secundaria')");
            Sql("INSERT INTO [Sist].[GradosEstudio] VALUES('Preparatoria')");
            Sql("INSERT INTO [Sist].[GradosEstudio] VALUES('Bachillerato')");
            Sql("INSERT INTO [Sist].[GradosEstudio] VALUES('Técnico')");
            Sql("INSERT INTO [Sist].[GradosEstudio] VALUES('Licenciatura')");
            Sql("INSERT INTO [Sist].[GradosEstudio] VALUES('Maestría')");
            Sql("INSERT INTO [Sist].[GradosEstudio] VALUES('Doctorado')");
            Sql("INSERT INTO [Sist].[GradosEstudio] VALUES('Otro')");
        }
        
        public override void Down()
        {
        }
    }
}
