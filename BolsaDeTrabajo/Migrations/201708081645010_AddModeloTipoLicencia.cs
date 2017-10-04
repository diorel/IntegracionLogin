namespace BolsaDeTrabajo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddModeloTipoLicencia : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "Sist.TiposLicencias",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        tipoLicencia = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("Sist.TipoLicencias");
        }
    }
}
