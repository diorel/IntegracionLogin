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
            Sql("INSERT INTO [Sist].[InstitucionesEducativas] VALUES('Instituto Polit�cnico Nacional')");
            Sql("INSERT INTO [Sist].[InstitucionesEducativas] VALUES('Tecnol�gico de Monterrey')");
            Sql("INSERT INTO [Sist].[InstitucionesEducativas] VALUES('Universidad Nacional Aut�noma de M�xico')");
            Sql("INSERT INTO [Sist].[InstitucionesEducativas] VALUES('Otro')");
        }
        
        public override void Down()
        {
        }
    }
}
