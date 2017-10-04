namespace BolsaDeTrabajo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class monthsdroped : DbMigration
    {
        public override void Up()
        {
            DropTable("Sist.Months");
        }
        
        public override void Down()
        {
            CreateTable(
                "Sist.Months",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
    }
}
