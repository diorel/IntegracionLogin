namespace BolsaDeTrabajo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class gradosEstudiodown : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("Sist.Formaciones", "GradoEstudiosId", "Sist.GradosEstudios");
            DropIndex("Sist.Formaciones", new[] { "GradoEstudiosId" });
            DropColumn("Sist.Formaciones", "GradoEstudiosId");
        }
        
        public override void Down()
        {
            AddColumn("Sist.Formaciones", "GradoEstudiosId", c => c.Byte(nullable: false));
            CreateIndex("Sist.Formaciones", "GradoEstudiosId");
            AddForeignKey("Sist.Formaciones", "GradoEstudiosId", "Sist.GradosEstudios", "Id", cascadeDelete: true);
        }
    }
}
