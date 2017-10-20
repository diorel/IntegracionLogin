namespace BolsaDeTrabajo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class nuevocatlaogogirosempresas : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO [Sist].[GirosEmpresas] VALUES ('Industrial')");
            Sql("INSERT INTO [Sist].[GirosEmpresas] VALUES ('Comercial')");
            Sql("INSERT INTO [Sist].[GirosEmpresas] VALUES ('Servicios')");
        }
    
        
        public override void Down()
        {
        }
    }
}
