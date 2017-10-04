namespace BolsaDeTrabajo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CatalogoDiscapacidades : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Sist.TiposDiscapacidades VALUES " +
                "('Auditiva')," +
                "('Visual')," +
                "('Intelectual')," +
                "('Lenguaje')," +
                "('Motora')"  );
        }
        
        public override void Down()
        {
        }
    }
}
