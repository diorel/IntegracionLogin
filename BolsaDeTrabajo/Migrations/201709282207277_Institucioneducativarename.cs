namespace BolsaDeTrabajo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Institucioneducativarename : DbMigration
    {
        public override void Up()
        {
            RenameColumn("Sist.InstitucionesEducativas", "InstitucionEducativa", "institucionEducativa");
           
        }
        
        public override void Down()
        {
        }
    }
}
