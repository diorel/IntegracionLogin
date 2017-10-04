namespace BolsaDeTrabajo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Cambielainstitucioneducativa : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "Sist.Formaciones", name: "InstitucionId", newName: "InstitucionEducativaId");
            RenameIndex(table: "Sist.Formaciones", name: "IX_InstitucionId", newName: "IX_InstitucionEducativaId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "Sist.Formaciones", name: "IX_InstitucionEducativaId", newName: "IX_InstitucionId");
            RenameColumn(table: "Sist.Formaciones", name: "InstitucionEducativaId", newName: "InstitucionId");
        }
    }
}
