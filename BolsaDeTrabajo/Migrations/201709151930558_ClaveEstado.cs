namespace BolsaDeTrabajo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ClaveEstado : DbMigration
    {
        public override void Up()
        {
            AddColumn("Sist.Estados", "Clave", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("Sist.Estados", "Clave");
        }
    }
}
