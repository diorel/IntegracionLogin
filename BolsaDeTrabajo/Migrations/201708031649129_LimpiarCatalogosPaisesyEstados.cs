namespace BolsaDeTrabajo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class LimpiarCatalogosPaisesyEstados : DbMigration
    {
        public override void Up()
        { 
            Sql("DELETE FROM Sist.Estados ");
            Sql("DBCC CHECKIDENT('Sist.Estados', RESEED, 0)");
            Sql("DELETE FROM Sist.Paises ");
            Sql("DBCC CHECKIDENT('Sist.Paises', RESEED, 0)");
        }
        
        public override void Down()
        {
        }
    }
}
