namespace BolsaDeTrabajo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dropcandidatosrelaciones : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("Sist.Direcciones", "Candidato_Id", "Sist.Candidatos");
            DropForeignKey("Sist.Emails", "Candidato_Id", "Sist.Candidatos");
            DropForeignKey("Sist.Telefonos", "Candidato_Id", "Sist.Candidatos");
            DropIndex("Sist.Direcciones", new[] { "Candidato_Id" });
            DropIndex("Sist.Emails", new[] { "Candidato_Id" });
            DropIndex("Sist.Telefonos", new[] { "Candidato_Id" });
            //DropColumn("Sist.Direcciones", "Candidato_Id");
            //DropColumn("Sist.Emails", "Candidato_Id");
            //DropColumn("Sist.Telefonos", "Candidato_Id");
        }
        
        public override void Down()
        {
            AddColumn("Sist.Telefonos", "Candidato_Id", c => c.Int());
            AddColumn("Sist.Emails", "Candidato_Id", c => c.Int());
            AddColumn("Sist.Direcciones", "Candidato_Id", c => c.Int());
            CreateIndex("Sist.Telefonos", "Candidato_Id");
            CreateIndex("Sist.Emails", "Candidato_Id");
            CreateIndex("Sist.Direcciones", "Candidato_Id");
            AddForeignKey("Sist.Telefonos", "Candidato_Id", "Sist.Candidatos", "Id");
            AddForeignKey("Sist.Emails", "Candidato_Id", "Sist.Candidatos", "Id");
            AddForeignKey("Sist.Direcciones", "Candidato_Id", "Sist.Candidatos", "Id");
        }
    }
}
