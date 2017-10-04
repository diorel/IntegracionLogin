namespace BolsaDeTrabajo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class formacionperfil : DbMigration
    {
        public override void Up()
        {
            //AddColumn("Sist.Formaciones", "PerfilCandidatoId", c => c.Int(nullable: false));
            //AddColumn("Sist.PerfilIdiomas", "PerfilCandidatoId", c => c.Int(nullable: false));
            //CreateIndex("Sist.Formaciones", "PerfilCandidatoId");
            //CreateIndex("Sist.PerfilIdiomas", "PerfilCandidatoId");
            //AddForeignKey("Sist.Formaciones", "PerfilCandidatoId", "Sist.PerfilCandidato", "Id", cascadeDelete: true);
            //AddForeignKey("Sist.PerfilIdiomas", "PerfilCandidatoId", "Sist.PerfilCandidato", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
        }
    }
}
