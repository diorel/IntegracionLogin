namespace BolsaDeTrabajo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class catalogoinstitucioneseducativasagain : DbMigration
    {
        public override void Up()
        {
            Sql("DELETE FROM Sist.InstitucionesEducativas ");
            Sql("DBCC CHECKIDENT('Sist.InstitucionesEducativas', RESEED, 0)");
            Sql("INSERT INTO [Sist].[InstitucionesEducativas] VALUES('Instituto Politécnico Nacional')");
            Sql("INSERT INTO [Sist].[InstitucionesEducativas] VALUES('Tecnológico de Monterrey')");
            Sql("INSERT INTO [Sist].[InstitucionesEducativas] VALUES('Universidad Nacional Autónoma de México')");
            Sql("INSERT INTO [Sist].[InstitucionesEducativas] VALUES('Otro')");
        }
        
        public override void Down()
        {
        }
    }
}
