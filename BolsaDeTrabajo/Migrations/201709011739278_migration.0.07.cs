namespace BolsaDeTrabajo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migration007 : DbMigration
    {
        public override void Up()
        {
            AddColumn("Sist.Candidatos", "TipoLicenciaId", c => c.Byte());
            CreateIndex("Sist.Candidatos", "TipoLicenciaId");
            AddForeignKey("Sist.Candidatos", "TipoLicenciaId", "Sist.TiposLicencias", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("Sist.Candidatos", "TipoLicenciaId", "Sist.TiposLicencias");
            DropIndex("Sist.Candidatos", new[] { "TipoLicenciaId" });
            DropColumn("Sist.Candidatos", "TipoLicenciaId");
        }
    }
}
