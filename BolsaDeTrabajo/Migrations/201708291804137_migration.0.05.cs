namespace BolsaDeTrabajo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migration005 : DbMigration
    {
        public override void Up()
        {
           // RenameTable(name: "Sist.TipoTelefonoes", newName: "TiposTelefonos");
        }
        
        public override void Down()
        {
            RenameTable(name: "Sist.TiposTelefonos", newName: "TipoTelefonoes");
        }
    }
}
