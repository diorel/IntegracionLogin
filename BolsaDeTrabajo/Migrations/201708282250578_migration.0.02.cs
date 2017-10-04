namespace BolsaDeTrabajo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migration002 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("Sist.Direcciones", "DireccionTipo_Id", "sist.DireccionTipo");
            DropIndex("Sist.Direcciones", new[] { "DireccionTipo_Id" });
            RenameColumn(table: "Sist.Direcciones", name: "DireccionTipo_Id", newName: "DireccionTipoId");
            //AddColumn("Sist.Candidatos", "TipoLicencia_Id", c => c.Byte());
            //AddColumn("Sist.Candidatos", "TipoLicenciaId", c => c.Int(nullable: false));
            AlterColumn("Sist.Direcciones", "DireccionTipoId", c => c.Int(nullable: false));
            CreateIndex("Sist.Direcciones", "DireccionTipoId");
            //CreateIndex("Sist.Candidatos", "TipoLicencia_Id");
            AlterColumn("Sist.Direcciones", "Activo", c => c.Boolean(nullable: false, defaultValue: true));
            //AddForeignKey("Sist.Candidatos", "TipoLicencia_Id", "Sist.TiposLicencias", "Id");
            AddForeignKey("Sist.Direcciones", "DireccionTipoId", "sist.DireccionTipo", "Id", cascadeDelete: true);
            DropColumn("Sist.Direcciones", "DirecciónTipoId");
        }
        
        public override void Down()
        {
            AddColumn("Sist.Direcciones", "DirecciónTipoId", c => c.Int(nullable: false));
            DropForeignKey("Sist.Direcciones", "DireccionTipoId", "sist.DireccionTipo");
            DropForeignKey("Sist.Candidatos", "TipoLicencia_Id", "Sist.TiposLicencias");
            DropIndex("Sist.Candidatos", new[] { "TipoLicencia_Id" });
            DropIndex("Sist.Direcciones", new[] { "DireccionTipoId" });
            AlterColumn("Sist.Direcciones", "DireccionTipoId", c => c.Int());
            DropColumn("Sist.Candidatos", "TipoLicenciaId");
            DropColumn("Sist.Candidatos", "TipoLicencia_Id");
            RenameColumn(table: "Sist.Direcciones", name: "DireccionTipoId", newName: "DireccionTipo_Id");
            CreateIndex("Sist.Direcciones", "DireccionTipo_Id");
            AddForeignKey("Sist.Direcciones", "DireccionTipo_Id", "sist.DireccionTipo", "Id");
        }
    }
}
