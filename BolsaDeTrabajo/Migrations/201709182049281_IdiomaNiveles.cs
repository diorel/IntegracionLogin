namespace BolsaDeTrabajo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IdiomaNiveles : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "Sist.Niveles",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        nivel = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("Sist.PerfilIdiomas", "NivelId", c => c.Byte(nullable: false));
            CreateIndex("Sist.PerfilIdiomas", "NivelId");
            CreateIndex("Sist.PerfilIdiomas", "CandidatoId");
            AddForeignKey("Sist.PerfilIdiomas", "CandidatoId", "Sist.Candidatos", "Id");
            AddForeignKey("Sist.PerfilIdiomas", "NivelId", "Sist.Niveles", "Id", cascadeDelete: true);
            DropColumn("Sist.PerfilIdiomas", "PorcentageId");
        }
        
        public override void Down()
        {
            AddColumn("Sist.PerfilIdiomas", "PorcentageId", c => c.Byte(nullable: false));
            DropForeignKey("Sist.PerfilIdiomas", "NivelId", "Sist.Niveles");
            DropForeignKey("Sist.PerfilIdiomas", "CandidatoId", "Sist.Candidatos");
            DropIndex("Sist.PerfilIdiomas", new[] { "CandidatoId" });
            DropIndex("Sist.PerfilIdiomas", new[] { "NivelId" });
            DropColumn("Sist.PerfilIdiomas", "NivelId");
            DropTable("Sist.Niveles");
        }
    }
}
