namespace BolsaDeTrabajo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class monthsnews : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "Sist.Months",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        month = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("Sist.Months");
        }
    }
}
