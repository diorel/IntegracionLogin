namespace BolsaDeTrabajo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OnetoMany : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "Sist.PerfilCandidato",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CandidatoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("Sist.Candidatos", t => t.CandidatoId)
                .Index(t => t.CandidatoId);
            
            AddColumn("Sist.Formaciones", "PerfilCandidatoId", c => c.Int(nullable: false));
            AddColumn("Sist.PerfilIdiomas", "PerfilCandidatoId", c => c.Int(nullable: false));
            CreateIndex("Sist.Formaciones", "PerfilCandidatoId");
            CreateIndex("Sist.PerfilIdiomas", "PerfilCandidatoId");
            AddForeignKey("Sist.Formaciones", "PerfilCandidatoId", "Sist.PerfilCandidato", "Id", cascadeDelete: true);
            AddForeignKey("Sist.PerfilIdiomas", "PerfilCandidatoId", "Sist.PerfilCandidato", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("Sist.PerfilIdiomas", "PerfilCandidatoId", "Sist.PerfilCandidato");
            DropForeignKey("Sist.Formaciones", "PerfilCandidatoId", "Sist.PerfilCandidato");
            DropForeignKey("Sist.PerfilCandidato", "CandidatoId", "Sist.Candidatos");
            DropIndex("Sist.PerfilIdiomas", new[] { "PerfilCandidatoId" });
            DropIndex("Sist.PerfilCandidato", new[] { "CandidatoId" });
            DropIndex("Sist.Formaciones", new[] { "PerfilCandidatoId" });
            DropColumn("Sist.PerfilIdiomas", "PerfilCandidatoId");
            DropColumn("Sist.Formaciones", "PerfilCandidatoId");
            DropTable("Sist.PerfilCandidato");
        }
    }
}
