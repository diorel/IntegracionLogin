namespace BolsaDeTrabajo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migration014 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "Sist.PalabrasExcluidas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Palabra = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("Sist.PalabrasExcluidas");
        }
    }
}
