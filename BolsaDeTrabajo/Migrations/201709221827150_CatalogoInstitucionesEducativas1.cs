namespace BolsaDeTrabajo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CatalogoInstitucionesEducativas1 : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO [Sist].[institucionesEducativas] VALUES('Instituto Polit�cnico Nacional')");
            Sql("INSERT INTO [Sist].[institucionesEducativas] VALUES('Tecnol�gico de Monterrey')");
            Sql("INSERT INTO [Sist].[institucionesEducativas] VALUES('Universidad Nacional Aut�noma de M�xico')");
            Sql("INSERT INTO [Sist].[institucionesEducativas] VALUES('Otro')");
        }
        
        public override void Down()
        {
        }
    }
}
