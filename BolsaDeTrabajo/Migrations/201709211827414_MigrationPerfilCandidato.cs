namespace BolsaDeTrabajo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigrationPerfilCandidato : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "Sist.DocumentosValidadores",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        documentoValidador = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "Sist.InstitucionesEducativas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Institucion = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("Sist.Formaciones", "Carrera", c => c.String());
            AlterColumn("Sist.Formaciones", "Institucion", c => c.String());
            DropColumn("Sist.Formaciones", "Especialidad");
        }
        
        public override void Down()
        {
            AddColumn("Sist.Formaciones", "Especialidad", c => c.String(nullable: false));
            AlterColumn("Sist.Formaciones", "Institucion", c => c.String(nullable: false));
            DropColumn("Sist.Formaciones", "Carrera");
            DropTable("Sist.InstitucionesEducativas");
            DropTable("Sist.DocumentosValidadores");
        }
    }
}
