namespace BolsaDeTrabajo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class catalogomeses : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO [Sist].[Months] VALUES ('Enero')");
            Sql("INSERT INTO [Sist].[Months] VALUES ('Febrero')");
            Sql("INSERT INTO [Sist].[Months] VALUES ('Marzo')");
            Sql("INSERT INTO [Sist].[Months] VALUES ('Abril')");
            Sql("INSERT INTO [Sist].[Months] VALUES ('Mayo')");
            Sql("INSERT INTO [Sist].[Months] VALUES ('Junio')");
            Sql("INSERT INTO [Sist].[Months] VALUES ('Julio')");
            Sql("INSERT INTO [Sist].[Months] VALUES ('Agosto')");
            Sql("INSERT INTO [Sist].[Months] VALUES ('Septiembre')");
            Sql("INSERT INTO [Sist].[Months] VALUES ('Octubre')");
            Sql("INSERT INTO [Sist].[Months] VALUES ('Noviembre')");
            Sql("INSERT INTO [Sist].[Months] VALUES ('Diciembre')");

        }

        public override void Down()
        {
        }
    }
}
