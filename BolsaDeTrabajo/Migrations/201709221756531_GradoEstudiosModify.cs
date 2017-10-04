namespace BolsaDeTrabajo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class GradoEstudiosModify : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("Sist.GradosEstudios");
            AlterColumn("Sist.GradosEstudios", "Id", c => c.Byte(nullable: false, identity: true));
            AddPrimaryKey("Sist.GradosEstudios", "Id");
      
        }
        
        public override void Down()
        {
            DropPrimaryKey("Sist.GradosEstudios");
            AlterColumn("Sist.GradosEstudios", "Id", c => c.Byte(nullable: false));
            AddPrimaryKey("Sist.GradosEstudios", "Id");
        }
    }
}
