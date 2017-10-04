namespace BolsaDeTrabajo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTipoDiscapacidadModelo : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "Sist.TiposDiscapacidades",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        tipoDiscapacidad = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("Sist.TiposDiscapacidades");
        }
    }
}
