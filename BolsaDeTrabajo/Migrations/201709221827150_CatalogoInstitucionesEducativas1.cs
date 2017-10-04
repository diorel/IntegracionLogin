namespace BolsaDeTrabajo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CatalogoInstitucionesEducativas1 : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO [Sist].[institucionesEducativas] VALUES('Instituto Politécnico Nacional')");
            Sql("INSERT INTO [Sist].[institucionesEducativas] VALUES('Tecnológico de Monterrey')");
            Sql("INSERT INTO [Sist].[institucionesEducativas] VALUES('Universidad Nacional Autónoma de México')");
            Sql("INSERT INTO [Sist].[institucionesEducativas] VALUES('Otro')");
        }
        
        public override void Down()
        {
        }
    }
}
