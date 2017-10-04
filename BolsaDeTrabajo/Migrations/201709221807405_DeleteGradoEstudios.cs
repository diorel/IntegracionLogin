namespace BolsaDeTrabajo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteGradoEstudios : DbMigration
    {
        public override void Up()
        {
            DropTable("Sist.GradosEstudios");
        }
        
        public override void Down()
        {
            CreateTable(
                "Sist.GradosEstudios",
                c => new
                    {
                        Id = c.Short(nullable: false, identity: true),
                        GradoEstudio = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
    }
}
