namespace BolsaDeTrabajo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migration012 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("Sist.Candidatos", "EstadoNacimientoId", "Sist.Estados");
            DropForeignKey("Sist.Candidatos", "MunicipioNacimientoId", "Sist.Municipios");
            DropIndex("Sist.Candidatos", new[] { "EstadoNacimientoId" });
            DropIndex("Sist.Candidatos", new[] { "MunicipioNacimientoId" });
            AddColumn("Sist.Direcciones", "CodigoPostal", c => c.String());
            AlterColumn("Sist.Candidatos", "EstadoNacimientoId", c => c.Int());
            AlterColumn("Sist.Candidatos", "MunicipioNacimientoId", c => c.Int());
            CreateIndex("Sist.Candidatos", "EstadoNacimientoId");
            CreateIndex("Sist.Candidatos", "MunicipioNacimientoId");
            AddForeignKey("Sist.Candidatos", "EstadoNacimientoId", "Sist.Estados", "Id");
            AddForeignKey("Sist.Candidatos", "MunicipioNacimientoId", "Sist.Municipios", "Id");
            DropColumn("Sist.Direcciones", "CP");
        }
        
        public override void Down()
        {
            AddColumn("Sist.Direcciones", "CP", c => c.String());
            DropForeignKey("Sist.Candidatos", "MunicipioNacimientoId", "Sist.Municipios");
            DropForeignKey("Sist.Candidatos", "EstadoNacimientoId", "Sist.Estados");
            DropIndex("Sist.Candidatos", new[] { "MunicipioNacimientoId" });
            DropIndex("Sist.Candidatos", new[] { "EstadoNacimientoId" });
            AlterColumn("Sist.Candidatos", "MunicipioNacimientoId", c => c.Int(nullable: false));
            AlterColumn("Sist.Candidatos", "EstadoNacimientoId", c => c.Int(nullable: false));
            DropColumn("Sist.Direcciones", "CodigoPostal");
            CreateIndex("Sist.Candidatos", "MunicipioNacimientoId");
            CreateIndex("Sist.Candidatos", "EstadoNacimientoId");
            AddForeignKey("Sist.Candidatos", "MunicipioNacimientoId", "Sist.Municipios", "Id", cascadeDelete: true);
            AddForeignKey("Sist.Candidatos", "EstadoNacimientoId", "Sist.Estados", "Id", cascadeDelete: true);
        }
    }
}
