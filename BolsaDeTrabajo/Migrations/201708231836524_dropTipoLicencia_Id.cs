namespace BolsaDeTrabajo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dropTipoLicencia_Id : DbMigration
    {
        public override void Up()
        {
            //DropColumn("Sist.Candidatos" ,"TipoLicencia_Id");
            DropForeignKey("Sist.Candidatos", "TipoLicencia_Id", "Sist.TiposLicencias");
        }
        
        public override void Down()
        {
        }
    }
}
