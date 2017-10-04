namespace BolsaDeTrabajo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangueTipoLicenciaModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("Sist.TiposLicencias", "Descripción", c => c.String());
            //DropColumn("Sist.TipoLicencias", "tipoLicencia");
            //AddColumn("Sist.TipoLicencias", "tipoLicencia", c=> c.nchar);
        }
        
        public override void Down()
        {
            AddColumn("Sist.TipoLicencias", "tipoLicencia", c => c.String());
            DropColumn("Sist.TipoLicencias", "Descripción");
        }
    }
}
