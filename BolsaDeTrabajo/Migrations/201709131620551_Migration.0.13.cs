namespace BolsaDeTrabajo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migration013 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "Sist.PalabrasInconvenientes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Palabra = c.String(),
                        Sustituto = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("Sist.PalabrasInconvenientes");
        }
    }
}
