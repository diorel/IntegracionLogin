namespace BolsaDeTrabajo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Recovery1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("Sist.Colonias", "Muncipios_Id", "Sist.Municipios");
            DropIndex("Sist.Colonias", new[] { "Muncipios_Id" });
            //DropColumn("Sist.Colonias", "Muncipios_Id");
        }
        
        public override void Down()
        {
            AddColumn("Sist.Colonias", "Muncipios_Id", c => c.Int());
            CreateIndex("Sist.Colonias", "Muncipios_Id");
            AddForeignKey("Sist.Colonias", "Muncipios_Id", "Sist.Municipios", "Id");
        }
    }
}
