namespace BolsaDeTrabajo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigracionGradoEstidios : DbMigration
    {
        public override void Up()
        {
            AlterColumn("[Sist].[GradosEstudios]", "Id", c => c.Byte(nullable: false, identity: true));
        }
        
        public override void Down()
        {
        }
    }
}
