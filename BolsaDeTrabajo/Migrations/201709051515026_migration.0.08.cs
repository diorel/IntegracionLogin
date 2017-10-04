namespace BolsaDeTrabajo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migration008 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "Sist.Candidatos", name: "PaisId", newName: "PaisNacimientoId");
            RenameColumn(table: "Sist.Candidatos", name: "EstadoId", newName: "EstadoNacimientoId");
            RenameColumn(table: "Sist.Candidatos", name: "MunicipioId", newName: "MunicipioNacimientoId");
            RenameIndex(table: "Sist.Candidatos", name: "IX_PaisId", newName: "IX_PaisNacimientoId");
            RenameIndex(table: "Sist.Candidatos", name: "IX_EstadoId", newName: "IX_EstadoNacimientoId");
            RenameIndex(table: "Sist.Candidatos", name: "IX_MunicipioId", newName: "IX_MunicipioNacimientoId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "Sist.Candidatos", name: "IX_MunicipioNacimientoId", newName: "IX_MunicipioId");
            RenameIndex(table: "Sist.Candidatos", name: "IX_EstadoNacimientoId", newName: "IX_EstadoId");
            RenameIndex(table: "Sist.Candidatos", name: "IX_PaisNacimientoId", newName: "IX_PaisId");
            RenameColumn(table: "Sist.Candidatos", name: "MunicipioNacimientoId", newName: "MunicipioId");
            RenameColumn(table: "Sist.Candidatos", name: "EstadoNacimientoId", newName: "EstadoId");
            RenameColumn(table: "Sist.Candidatos", name: "PaisNacimientoId", newName: "PaisId");
        }
    }
}
