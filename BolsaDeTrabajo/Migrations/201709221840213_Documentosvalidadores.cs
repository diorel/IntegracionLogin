namespace BolsaDeTrabajo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Documentosvalidadores : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO [Sist].[DocumentosValidadores] VALUES('Certificado')");
            Sql("INSERT INTO [Sist].[DocumentosValidadores] VALUES('Cedula Profesional')");
            Sql("INSERT INTO [Sist].[DocumentosValidadores] VALUES('Carta Pasante')");
            Sql("INSERT INTO [Sist].[DocumentosValidadores] VALUES('Otro')");
        }
        
        public override void Down()
        {
        }
    }
}
