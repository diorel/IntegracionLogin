namespace BolsaDeTrabajo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ColoniasRestructuración2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("Sist.Colonias", "MunicipioId", "Sist.Municipios");
            //DropColumn("Sist.Colonias", "MunicipioId");
            //AddColumn("Sist.Colonias", "MunicipioId", c => c.Int());
            CreateIndex("Sist.Colonias", "EstadoId");
            CreateIndex("Sist.Colonias", "PaisId");
            //CreateIndex("Sist.Colonias", "MunicipioId");
            AddForeignKey("Sist.Colonias", "EstadoId", "Sist.Estados", "Id", cascadeDelete: false);
            AddForeignKey("Sist.Colonias", "MunicipioId", "Sist.Municipios", "Id", cascadeDelete: false);
            AddForeignKey("Sist.Colonias", "PaisId", "Sist.Paises", "Id", cascadeDelete: false);
            //AddForeignKey("Sist.Colonias", "MunicipioId", "Sist.Municipios", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("Sist.Colonias", "Muncipios_Id", "Sist.Municipios");
            DropForeignKey("Sist.Colonias", "PaisId", "Sist.Paises");
            DropForeignKey("Sist.Colonias", "MunicipioId", "Sist.Municipios");
            DropForeignKey("Sist.Colonias", "EstadoId", "Sist.Estados");
            DropIndex("Sist.Colonias", new[] { "Muncipios_Id" });
            DropIndex("Sist.Colonias", new[] { "PaisId" });
            DropIndex("Sist.Colonias", new[] { "EstadoId" });
            DropColumn("Sist.Colonias", "Muncipios_Id");
            AddForeignKey("Sist.Colonias", "MunicipioId", "Sist.Municipios", "Id", cascadeDelete: true);
        }
    }
}
