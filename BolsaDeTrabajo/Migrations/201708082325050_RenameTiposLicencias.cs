namespace BolsaDeTrabajo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenameTiposLicencias : DbMigration
    {
        public override void Up()
        {
            //RenameTable(name: "Sist.TipoLicencias", newName: "TiposLicencias");
        }
        
        public override void Down()
        {
            RenameTable(name: "Sist.TiposLicencias", newName: "TipoLicencias");
        }
    }
}
