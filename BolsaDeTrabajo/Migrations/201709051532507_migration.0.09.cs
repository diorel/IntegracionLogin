namespace BolsaDeTrabajo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migration009 : DbMigration
    {
        public override void Up()
        {
            AddColumn("Sist.Candidatos", "CodigoPostal", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("Sist.Candidatos", "CodigoPostal");
        }
    }
}
