namespace BolsaDeTrabajo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingColoniaModel : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("Sist.Direcciones", "EstadoId", "Sist.Estados");
            DropForeignKey("Sist.Direcciones", "MunicipioId", "Sist.Municipios");
            DropIndex("Sist.Direcciones", new[] { "EstadoId" });
            DropIndex("Sist.Direcciones", new[] { "MunicipioId" });
            CreateTable(
                "Sist.Colonias",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        colonia = c.String(),
                        CP = c.String(),
                        TipoColonia = c.String(),
                        MunicipioId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("Sist.Municipios", t => t.MunicipioId, cascadeDelete: true)
                .Index(t => t.MunicipioId);
            
            AddColumn("Sist.Direcciones", "ColoniaId", c => c.Int());
            AlterColumn("Sist.Direcciones", "Calle", c => c.String());
            AlterColumn("Sist.Direcciones", "NumeroInterior", c => c.String());
            AlterColumn("Sist.Direcciones", "NumeroExterior", c => c.String());
            AlterColumn("Sist.Direcciones", "EstadoId", c => c.Int());
            AlterColumn("Sist.Direcciones", "MunicipioId", c => c.Int());
            AlterColumn("Sist.Direcciones", "CP", c => c.String());
            CreateIndex("Sist.Direcciones", "EstadoId");
            CreateIndex("Sist.Direcciones", "MunicipioId");
            CreateIndex("Sist.Direcciones", "ColoniaId");
            AddForeignKey("Sist.Direcciones", "ColoniaId", "Sist.Colonias", "Id");
            AddForeignKey("Sist.Direcciones", "EstadoId", "Sist.Estados", "Id");
            AddForeignKey("Sist.Direcciones", "MunicipioId", "Sist.Municipios", "Id");
            DropColumn("Sist.Direcciones", "Colonia");
        }
        
        public override void Down()
        {
            AddColumn("Sist.Direcciones", "Colonia", c => c.String(maxLength: 255));
            DropForeignKey("Sist.Direcciones", "MunicipioId", "Sist.Municipios");
            DropForeignKey("Sist.Direcciones", "EstadoId", "Sist.Estados");
            DropForeignKey("Sist.Direcciones", "ColoniaId", "Sist.Colonias");
            DropForeignKey("Sist.Colonias", "MunicipioId", "Sist.Municipios");
            DropIndex("Sist.Colonias", new[] { "MunicipioId" });
            DropIndex("Sist.Direcciones", new[] { "ColoniaId" });
            DropIndex("Sist.Direcciones", new[] { "MunicipioId" });
            DropIndex("Sist.Direcciones", new[] { "EstadoId" });
            AlterColumn("Sist.Direcciones", "CP", c => c.String(maxLength: 15));
            AlterColumn("Sist.Direcciones", "MunicipioId", c => c.Int(nullable: false));
            AlterColumn("Sist.Direcciones", "EstadoId", c => c.Int(nullable: false));
            AlterColumn("Sist.Direcciones", "NumeroExterior", c => c.String(maxLength: 10));
            AlterColumn("Sist.Direcciones", "NumeroInterior", c => c.String(maxLength: 10));
            AlterColumn("Sist.Direcciones", "Calle", c => c.String(maxLength: 100));
            DropColumn("Sist.Direcciones", "ColoniaId");
            DropTable("Sist.Colonias");
            CreateIndex("Sist.Direcciones", "MunicipioId");
            CreateIndex("Sist.Direcciones", "EstadoId");
            AddForeignKey("Sist.Direcciones", "MunicipioId", "Sist.Municipios", "Id", cascadeDelete: true);
            AddForeignKey("Sist.Direcciones", "EstadoId", "Sist.Estados", "Id", cascadeDelete: true);
        }
    }
}
