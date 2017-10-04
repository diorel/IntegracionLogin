namespace BolsaDeTrabajo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class catalogoEstadosEstudios : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO [Sist].[EstadosEstudios] VALUES('Cursando')");
            Sql("INSERT INTO [Sist].[EstadosEstudios] VALUES('Trunco')");
            Sql("INSERT INTO [Sist].[EstadosEstudios] VALUES('Pasante')");
            Sql("INSERT INTO [Sist].[EstadosEstudios] VALUES('Culminado ')");
            Sql("INSERT INTO [Sist].[EstadosEstudios] VALUES('Otro')");
        }
        
        public override void Down()
        {
        }
    }
}
