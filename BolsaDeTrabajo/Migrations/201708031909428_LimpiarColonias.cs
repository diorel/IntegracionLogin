namespace BolsaDeTrabajo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class LimpiarColonias : DbMigration
    {
        public override void Up()
        {
            Sql("DELETE FROM Sist.Colonias ");
            Sql("DBCC CHECKIDENT('Sist.Colonias', RESEED, 0)");
        }
        
        public override void Down()
        {
        }
    }
}
