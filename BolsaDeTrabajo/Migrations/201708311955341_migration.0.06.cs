namespace BolsaDeTrabajo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migration006 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "Sist.FormasContacto",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CandidatoId = c.Int(nullable: false),
                        CorreoElectronico = c.Boolean(nullable: false),
                        Celular = c.Boolean(nullable: false),
                        Whatsapp = c.Boolean(nullable: false),
                        telLocal = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("Sist.Candidatos", t => t.CandidatoId)
                .Index(t => t.CandidatoId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("Sist.FormasContacto", "CandidatoId", "Sist.Candidatos");
            DropIndex("Sist.FormasContacto", new[] { "CandidatoId" });
            DropTable("Sist.FormasContacto");
        }
    }
}
