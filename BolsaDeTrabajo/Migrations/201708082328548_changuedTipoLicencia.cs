namespace BolsaDeTrabajo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changuedTipoLicencia : DbMigration
    {
        public override void Up()
        {
            //AddColumn("Sist.TiposLicencias", "tipoLicencia", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("Sist.TiposLicencias", "tipoLicencia");
        }
    }
}
