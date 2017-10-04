namespace BolsaDeTrabajo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migration004 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("Sist.Candidatos", "TipoLicencia_Id", "Sist.TiposLicencias");
            DropIndex("Sist.Candidatos", new[] { "TipoLicencia_Id" });
            //DropColumn("Sist.Candidatos", "TipoLicencia_Id");
            DropForeignKey("Sist.Candidatos", "TipoLicenciaId", "Sist.TiposLicencias");
            DropIndex("Sist.Candidatos", new[] { "TipoLicenciaId" });
            DropColumn("Sist.Candidatos", "TipoLicenciaId");
        }
        
        public override void Down()
        {
            AddColumn("Sist.Candidatos", "TipoLicenciaId", c => c.Int(nullable: false));
            AddColumn("Sist.Candidatos", "TipoLicencia_Id", c => c.Byte());
            CreateIndex("Sist.Candidatos", "TipoLicencia_Id");
            AddForeignKey("Sist.Candidatos", "TipoLicencia_Id", "Sist.TiposLicencias", "Id");
        }
    }
}
