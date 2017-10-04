namespace BolsaDeTrabajo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CatalogoInstitucionesEducativas : DbMigration
    {
        public override void Up()
        {
            AddColumn("Sist.Formaciones", "GradoEstudiosId", c => c.Int(nullable: false));
            AddColumn("Sist.Formaciones", "GradosEstudio_Id", c => c.Int());
            CreateIndex("Sist.Formaciones", "GradosEstudio_Id");
            AddForeignKey("Sist.Formaciones", "GradosEstudio_Id", "Sist.GradosEstudio", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("Sist.Formaciones", "GradosEstudio_Id", "Sist.GradosEstudio");
            DropIndex("Sist.Formaciones", new[] { "GradosEstudio_Id" });
            DropColumn("Sist.Formaciones", "GradosEstudio_Id");
            DropColumn("Sist.Formaciones", "GradoEstudiosId");
        }
    }
}
