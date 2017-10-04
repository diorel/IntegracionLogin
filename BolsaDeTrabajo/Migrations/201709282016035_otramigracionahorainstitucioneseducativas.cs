namespace BolsaDeTrabajo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class otramigracionahorainstitucioneseducativas : DbMigration
    {
        public override void Up()
        {
            AddColumn("Sist.InstitucionesEducativas", "InstitucionEducativa", c => c.String());
            DropColumn("Sist.InstitucionesEducativas", "Institucion");
        }
        
        public override void Down()
        {
            AddColumn("Sist.InstitucionesEducativas", "Institucion", c => c.String());
            DropColumn("Sist.InstitucionesEducativas", "institucionEducativa");
        }
    }
}
