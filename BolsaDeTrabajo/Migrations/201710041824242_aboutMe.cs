namespace BolsaDeTrabajo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class aboutMe : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "Sist.AcercaDeMi",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AcercaDeMi = c.String(),
                        PuestoDeseado = c.String(),
                        SalarioAceptable = c.Decimal(nullable: false, precision: 18, scale: 2),
                        SalarioDeseado = c.Decimal(nullable: false, precision: 18, scale: 2),
                        AreaExperienciaId = c.Int(nullable: false),
                        AreaInteresId = c.Int(nullable: false),
                        PerfilExperienciaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("Sist.AreasExperiencia", t => t.AreaExperienciaId, cascadeDelete: true)
                .ForeignKey("Sist.AreasInteres", t => t.AreaInteresId, cascadeDelete: true)
                .ForeignKey("Sist.PerfilExperiencia", t => t.PerfilExperienciaId, cascadeDelete: true)
                .Index(t => t.AreaExperienciaId)
                .Index(t => t.AreaInteresId)
                .Index(t => t.PerfilExperienciaId);
            
            CreateTable(
                "Sist.AreasExperiencia",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        areaExperiencia = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "Sist.AreasInteres",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        areaInteres = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "Sist.PerfilExperiencia",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        perfilExperiencia = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("Sist.PerfilCandidato", "AboutMeId", c => c.Int(nullable: false));
            CreateIndex("Sist.PerfilCandidato", "AboutMeId");
            AddForeignKey("Sist.PerfilCandidato", "AboutMeId", "Sist.AcercaDeMi", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("Sist.PerfilCandidato", "AboutMeId", "Sist.AcercaDeMi");
            DropForeignKey("Sist.AcercaDeMi", "PerfilExperienciaId", "Sist.PerfilExperiencia");
            DropForeignKey("Sist.AcercaDeMi", "AreaInteresId", "Sist.AreasInteres");
            DropForeignKey("Sist.AcercaDeMi", "AreaExperienciaId", "Sist.AreasExperiencia");
            DropIndex("Sist.PerfilCandidato", new[] { "AboutMeId" });
            DropIndex("Sist.AcercaDeMi", new[] { "PerfilExperienciaId" });
            DropIndex("Sist.AcercaDeMi", new[] { "AreaInteresId" });
            DropIndex("Sist.AcercaDeMi", new[] { "AreaExperienciaId" });
            DropColumn("Sist.PerfilCandidato", "AboutMeId");
            DropTable("Sist.PerfilExperiencia");
            DropTable("Sist.AreasInteres");
            DropTable("Sist.AreasExperiencia");
            DropTable("Sist.AcercaDeMi");
        }
    }
}
