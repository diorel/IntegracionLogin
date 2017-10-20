namespace BolsaDeTrabajo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class girosempresascatalogonuevo : DbMigration
    {
        public override void Up()
        {
        }
        
        public override void Down()
        {
            Sql("INSERT INTO [Sist].[GirosEmpresas] VALUES ('Industrial')");
            Sql("INSERT INTO [Sist].[GirosEmpresas] VALUES ('Comercial')");
            Sql("INSERT INTO [Sist].[GirosEmpresas] VALUES ('Servicios')");
        }
    }
}
