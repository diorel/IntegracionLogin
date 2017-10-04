namespace BolsaDeTrabajo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class acentoTipoLicencia : DbMigration
    {
        public override void Up()
        {
            AddColumn("Sist.TiposLicencias", "Descripcion", c => c.String());
            DropColumn("Sist.TiposLicencias", "Descripción");
        }
        
        public override void Down()
        {
            AddColumn("Sist.TipoLicencias", "Descripción", c => c.String());
            DropColumn("Sist.TipoLicencias", "Descripcion");
        }
    }
}
