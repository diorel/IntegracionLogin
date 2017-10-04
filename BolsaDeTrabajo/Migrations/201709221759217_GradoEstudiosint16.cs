namespace BolsaDeTrabajo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class GradoEstudiosint16 : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("Sist.GradosEstudios");
            AlterColumn("Sist.GradosEstudios", "Id", c => c.Short(nullable: false, identity: true));
            AddPrimaryKey("Sist.GradosEstudios", "Id");
        }
        
        public override void Down()
        {
            DropPrimaryKey("Sist.GradosEstudios");
            AlterColumn("Sist.GradosEstudios", "Id", c => c.Byte(nullable: false, identity: true));
            AddPrimaryKey("Sist.GradosEstudios", "Id");
        }
    }
}
